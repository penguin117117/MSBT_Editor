using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Windows.Forms;

using EN = System.Environment;
using MSBT_Editor.Sectionsys;
using MSBT_Editor.Formsys;

namespace MSBT_Editor.FileSys
{
    /// <summary>
    /// <para><br/></para>
    /// </summary>
    class Calculation_System
    {
        public static string Byte2Char(BinaryReader br, int readchers = 4)
        {
            return new string(br.ReadChars(readchers));
        }

        public static string Byte2Str_UTF16BE(BinaryReader br, int readchers = 2)
        {
            string strs = "";
            //ここで、発生するエラーは過去に既存のMSBTで編集したデータを使用している可能性が高い
            try
            {
                strs = Encoding.GetEncoding("unicodeFFFE").GetString(br.ReadBytes(readchers));
            }
            catch (Exception e)
            {
                    br.Close();
                    string[] errorJP01 = { "深刻なエラーが発生しました\n\r[" + e.Message + "]\n\r" + "ErrorNo 1", "エラー" };
                    string[] errorJP02 = { "「以前に他のMSBTエディタで編集していませんか？」\n\r", "ファイルフォーマット規則が一部破損しているので\n\r", "このエディタでは開くことが出来ません", "このエラーの原因で考えられること" };
                    string[] errorJP03 = { "ゲームから吸い出した壊れていないデータを使用してください\n\r", "または、正しい方法でバイナリを修正する必要があります。\n\r", "このメッセージの後アプリケーションを強制終了します", "この問題への提案" };
                    string[] errorEN01 = { "A serious error has occurred.\n\r[" + e.Message + "]\n\r" + "ErrorNo 1", "Error" };
                    string[] errorEN02 = { "「Have you edited with a different 'MSBT editor' before?」\n\r", "The file formatting rules are partially broken,\n\r", "so this editor cannot open the file.", "Possible causes for this error." };
                    string[] errorEN03 = { "Use the uncorrupted data sucked out of the game.\n\r", "Or you need to modify the binary in the right way.\n\r", "After this message, the application will be killed.", "Suggestions for this problem" };

                    string[] error01;
                    string[] error02;
                    string[] error03;

                    if (Properties.Settings.Default.言語 == "EN")
                    {
                        error01 = errorEN01;
                        error02 = errorEN02;
                        error03 = errorEN03;
                    }
                    else
                    {
                        error01 = errorJP01;
                        error02 = errorJP02;
                        error03 = errorJP03;
                    }

                    MessageBox.Show(error01[0], error01[1], MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(error02[0] + error02[1] + error02[2], error02[3], MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(error03[0] + error03[1] + error03[2], error03[3], MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(0);
                
            }
            
            return strs;
        }

        public static void UTF16BE(string str, List<byte> bits) {
            var ret = Encoding.GetEncoding("unicodeFFFE").GetBytes(str);
            foreach (byte bit in ret) bits.Add(bit);
        }

        public static string Byte2JIS(BinaryReader br, FileStream fs)
        {
            List<byte> bit_list = new List<byte>();
            byte bit1, bit2;
            byte bit3, bit4, bit5, bit6, bit7, bit8;
            bool checker = true;
            while (checker) {
                bit1 = br.ReadByte();
                bit2 = br.ReadByte();
                bit_list.Add(bit1);
                bit_list.Add(bit2);
                if (bit1 == 0x00 && bit2 == 0x0A) {
                    UTF16BE("</br>" + EN.NewLine, bit_list);
                    continue;
                }



                if (((bit_list[bit_list.Count - 2] == 0x00) && (bit_list[bit_list.Count - 1]) == 0x0E)) {
                    bit_list.RemoveRange(bit_list.Count() - 1, 1);
                    bit_list.RemoveRange(bit_list.Count() - 1, 1);
                    bit3 = br.ReadByte();
                    bit4 = br.ReadByte();
                    bit5 = br.ReadByte();
                    bit6 = br.ReadByte();
                    bit7 = br.ReadByte();
                    bit8 = br.ReadByte();


                    switch (bit4) {
                        case 0x00:
                            Tag00(br, fs, bit_list, bit5, bit6, bit7, bit8);
                            continue;
                        case 0x01:
                            Tag01(br, fs, bit_list, bit5, bit6, bit7, bit8);
                            continue;
                        case 0x02:
                            Tag02(br, fs, bit_list, bit5, bit6, bit7, bit8);
                            continue;
                        case 0x03:
                            Tag03(br, fs, bit_list, bit5, bit6, bit7, bit8);
                            continue;
                        case 0x04:
                            Tag04(br, fs, bit_list, bit5, bit6, bit7, bit8);
                            continue;
                        case 0x05:
                            Tag05(br, fs, bit_list, bit5, bit6, bit7, bit8);
                            break;
                        case 0x06:
                            Tag06(br, fs, bit_list, bit5, bit6, bit7, bit8);
                            break;
                        case 0x07:
                            Tag07(br, fs, bit_list, bit5, bit6, bit7, bit8);
                            break;
                        default:
                            break;
                    }

                    continue;
                }

                if ((bit_list[bit_list.Count - 2] == 0) && (bit_list[bit_list.Count - 1]) == 0) {
                    bit_list.RemoveRange(bit_list.Count() - 1, 1);
                    bit_list.RemoveRange(bit_list.Count() - 1, 1);
                    UTF16BE("</End>", bit_list);
                    checker = false;
                }

            }
            //Console.WriteLine(Encoding.GetEncoding("unicodeFFFE"/*1201*/).GetString(bit_list.ToArray()));
            //Debugger.Text("");
            return Encoding.GetEncoding("unicodeFFFE"/*1201*/).GetString(bit_list.ToArray());

        }


        public static bool Tag00(BinaryReader br, FileStream fs, List<byte> list, byte bit5, byte bit6, byte bit7, byte bit8)
        {
            var bit9 = Bytes2Byte(br);
            var bit10 = Bytes2Byte(br);
            string tagstrs = "<Unknown=\"Tag00\">";
            switch (bit6)
            {
                case 0x00:
                    var bit11 = Bytes2Byte(br);
                    var bit12 = Bytes2Byte(br);
                    var rubi = (bit12 >> 1);
                    var target = (bit10 >> 1);
                    tagstrs = "<Rubi=\"" + rubi.ToString() + "\" Target=\"" + target.ToString() + "\">";
                    
                    break;
                case 0x03:
                    tagstrs = Tag_Colors(bit10);
                    break;
            }

            UTF16BE(tagstrs, list);
            if (tagstrs.Substring(1,7)== "Unknown") Debugger.Unknowntagwriter(tagstrs);
            return true;
        }

        public static string Tag_Colors(byte bit10) {
            var tagname = "";
            switch (bit10)
            {
                case 0x00:
                    tagname = "<Color=\"Black\">";
                    break;
                case 0x01:
                    tagname = "<Color=\"Red\">";
                    break;
                case 0x02:
                    tagname = "<Color=\"Green\">";
                    break;
                case 0x03:
                    tagname = "<Color=\"Blue\">";
                    break;
                case 0x04:
                    tagname = "<Color=\"Yellow\">";
                    break;
                case 0x05:
                    tagname = "<Color=\"Purple\">";
                    break;
                case 0x06:
                    tagname = "<Color=\"Orange\">";
                    break;
                case 0x07:
                    tagname = "<Color=\"Gray\">";
                    break;
                case 0xFF:
                    tagname = "</Color>";
                    break;

            }
            return tagname;
        }


        public static bool Tag01(BinaryReader br, FileStream fs, List<byte> list, byte bit5, byte bit6, byte bit7, byte bit8) {

            string tagstrs = "< Unknown =\"Tag01\">";
            var bit9 = Bytes2Byte(br);
            var bit10 = Bytes2Byte(br);
            switch (bit6) {
                case 0x00:

                    if ((bit8 == 2))
                    {
                        var time = (bit9 << 8) + bit10;
                        tagstrs = "</Timer=\"" + time.ToString() + "\">";

                    }
                    break;
                case 0x01:

                    //10byte目が0x0Aではない場合の処理
                    tagstrs = "</NCenter>";

                    //新しいページ作成処理
                    if ((bit8 == 0) && (bit9 == 0x00) && (bit10 == 0x0A)) {
                        tagstrs = "</New_Page>" + EN.NewLine + EN.NewLine;
                        break;
                    }

                    //9,10bitを使用しない場合2bit分fsを戻す
                    fs.Position -= 2;

                    break;
                case 0x02:
                    tagstrs = "</YCenter>";

                    //9,10bitを使用しない場合2bit分fsを戻す
                    fs.Position -= 2;
                    break;
                case 0x03:
                    tagstrs = "</XCenter>";

                    //9,10bitを使用しない場合2bit分fsを戻す
                    fs.Position -= 2;
                    break;
            }

            UTF16BE(tagstrs, list);
            if (tagstrs.Substring(1, 7) == "Unknown") Debugger.Unknowntagwriter(tagstrs);
            return true;
        }


        public static bool Tag02(BinaryReader br, FileStream fs, List<byte> list, byte bit5, byte bit6, byte bit7, byte bit8)
        {
            var bit9 = Bytes2Byte(br);
            var bit10 = Bytes2Byte(br);

            string tagstrs = "<SE=\""+ "000E00020000"+ bit7.ToString("X2")+ bit8.ToString("X2")+ bit9.ToString("X2")+ bit10.ToString("X2") + "\">";
            var SEName = Byte2Str_UTF16BE(br , bit10);
            tagstrs = "<SE=\""+ SEName +"\">";
            //switch (bit6)
            //{
            //    case 0x00:
            //        var bit11 = Bytes2Byte(br);
            //        var bit12 = Bytes2Byte(br);
            //        var rubi = (bit12 >> 1);
            //        var target = (bit10 >> 1);
            //        tagstrs = "<Rubi=\"" + rubi.ToString() + "\" Target=\"" + target.ToString() + "\">";

            //        break;
            //    case 0x03:
            //        tagstrs = Tag_Colors(bit10);
            //        break;
            //}

            UTF16BE(tagstrs, list);
            //if (tagstrs.Substring(1, 7) == "Unknown") Debugger.Unknowntagwriter(tagstrs);
            Debugger.Unknowntagwriter(tagstrs + EN.NewLine);
            return true;
        }

        public static bool Tag03(BinaryReader br, FileStream fs, List<byte> list, byte bit5, byte bit6, byte bit7, byte bit8)
        {
            var bit9 = Bytes2Byte(br);
            var bit10 = Bytes2Byte(br);

            var icon_num = "0003" + bit5.ToString("X2") + bit6.ToString("X2") + bit7.ToString("X2") + bit8.ToString("X2") + bit9.ToString("X2") + bit10.ToString("X2");
            Console.WriteLine(icon_num);

            string tagstrs = "<UserIcon=\"" + "000E" + icon_num + "\">";
            switch (icon_num)
            {
                case "000300350002003A":
                    tagstrs = "<Icon=\"CometMedal\">";
                    break;
                case "000300360002003B":
                    tagstrs = "<Icon=\"SilverCrown\">";
                    break;
                case "0003002500020025":
                    tagstrs = "<Icon=\"PointerHand\">";
                    break;
                case "0003002800020028":
                    tagstrs = "<Icon=\"Peach\">";
                    break;
                case "0003003F00020044":
                    tagstrs = "<Icon=\"SilverCrownwJewel\">";
                    break;
                case "0003004100020046":
                    tagstrs = "<Icon=\"Begoman\">";
                    break;
                case "0003002300020023":
                    tagstrs = "<Icon=\"Koopa\">";
                    break;
                case "0003004300020048":
                    tagstrs = "<Icon=\"Coins\">";
                    break;
                case "0003002700020027":
                    tagstrs = "<Icon=\"Starbit\">";
                    break;
                case "0003003D00020042":
                    tagstrs = "<Icon=\"BronzeStar\">";
                    break;
                case "0003002D00020032":
                    tagstrs = "<Icon=\"LifeUpMushroom\">";
                    break;
                case "0003001500020015":
                    tagstrs = "<Icon=\"StarPiece\">";
                    break;
                case "0003000A0002000A":
                    tagstrs = "<Icon=\"Pointer\">";
                    break;
                case "0003001F0002001F":
                    tagstrs = "<Icon=\"GreenComet\">";
                    break;
                case "0003000300020003":
                    tagstrs = "<Icon=\"WiiMote\">";
                    break;
                case "000300470002004C":
                    tagstrs = "<Icon=\"Kinopio\">";
                    break;
                case "0003000B0002000B":
                    tagstrs = "<Icon=\"PurpleStarbit\">";
                    break;
                case "0003002900020029":
                    tagstrs = "<Icon=\"Letter\">";
                    break;
                case "0003004200020047":
                    tagstrs = "<Icon=\"Kuribo\">";
                    break;
                case "0003002B0002002B":
                    tagstrs = "<Icon=\"Mario\">";
                    break;
                case "0003001200020012":
                    tagstrs = "<Icon=\"Mario2\">";
                    break;
                case "0003001300020013":
                    tagstrs = "<Icon=\"DPad\">";
                    break;
                case "000300450002004A":
                    tagstrs = "<Icon=\"DPadDown\">";
                    break;
                case "0003000F0002000F":
                    tagstrs = "<Icon=\"JoyStick\">";
                    break;
                case "0003001700020017":
                    tagstrs = "<Icon=\"MButton\">";
                    break;
                case "0003004400020049":
                    tagstrs = "<Icon=\"DPadUp\">";
                    break;
                case "0003001B0002001B":
                    tagstrs = "<Icon=\"GrandStar\">";
                    break;
                case "0003000700020007":
                    tagstrs = "<Icon=\"Star\">";
                    break;
                case "0003002F00020034":
                    tagstrs = "<Icon=\"Tico\">";
                    break;
                case "0003002C00020031":
                    tagstrs = "<Icon=\"1UPMushroom\">";
                    break;
                case "0003000200020002":
                    tagstrs = "<Icon=\"CButton\">";
                    break;
                case "0003001800020018":
                    tagstrs = "<Icon=\"PButton\">";
                    break;
                case "0003000900020009":
                    tagstrs = "<Icon=\"BlueStar\">";
                    break;
                case "0003003400020039":
                    tagstrs = "<Icon=\"Yoshi\">";
                    break;
                case "0003001000020010":
                    tagstrs = "<Icon=\"XIcon\">";
                    break;
                case "0003001100020011":
                    tagstrs = "<Icon=\"Coin\">";
                    break;
                case "0003002000020020":
                    tagstrs = "<Icon=\"GoldCrown\">";
                    break;
                case "0003001900020019":
                    tagstrs = "<Icon=\"ZButton\">";
                    break;
                case "0003002E00020033":
                    tagstrs = "<Icon=\"HarapekoTico\">";
                    break;
                case "0003000D0002000D":
                    tagstrs = "<Icon=\"ArrowDown\">";
                    break;
                case "0003001C0002001C":
                    tagstrs = "<Icon=\"Luigi\">";
                    break;
                case "0003000800020008":
                    tagstrs = "<Icon=\"StarRing\">";
                    break;
                case "0003000000020000":
                    tagstrs = "<Icon=\"AButton\">";
                    break;
                case "0003001E0002001E":
                    tagstrs = "<Icon=\"PurpleCoin\">";
                    break;
                case "0003000100020001":
                    tagstrs = "<Icon=\"BButton\">";
                    break;
                case "0003002100020021":
                    tagstrs = "<Icon=\"Aim\">";
                    break;
                case "0003000400020004":
                    tagstrs = "<Icon=\"Nunchuck\">";
                    break;
                case "0003003300020038":
                    tagstrs = "<Icon=\"MasterTico\">";
                    break;
                case "0003003200020037":
                    tagstrs = "<Icon=\"StopWatch\">";
                    break;
                case "000300460002004B":
                    tagstrs = "<Icon=\"Columa\">";
                    break;
                case "0003001D0002001D":
                    tagstrs = "<Icon=\"PointerYellow\">";
                    break;
                case "000300370002003C":
                    tagstrs = "<Icon=\"Flower\">";
                    break;
                case "0003001A0002001A":
                    tagstrs = "<Icon=\"SilverStar\">";
                    break;
                case "000300480002004D":
                    tagstrs = "<Icon=\"BronzeComet\">";
                    break;
                case "0003000500020005":
                    tagstrs = "<Icon=\"1Button\">";
                    break;
                case "0003000600020006":
                    tagstrs = "<Icon=\"2Button\">";
                    break;
                case "0003000C0002000C":
                    tagstrs = "<Icon=\"Coconut\">";
                    break;
                case "0003000E0002000E":
                    tagstrs = "<Icon=\"StarBunny\">";
                    break;
                case "0003001400020014":
                    tagstrs = "<Icon=\"BlueStarPiece\">";
                    break;
                case "0003001600020016":
                    tagstrs = "<Icon=\"HomeButton\">";
                    break;
                case "0003002400020024":
                    tagstrs = "<Icon=\"StarPointerSeleced\">";
                    break;
                case "0003002600020026":
                    tagstrs = "<Icon=\"StarPointerSelecting\">";
                    break;
                case "0003002A0002002A":
                    tagstrs = "<Icon=\"QuestionMark\">";
                    break;
                case "0003003000020035":
                    tagstrs = "<Icon=\"CometStar\">";
                    break;
                case "0003003100020036":
                    tagstrs = "<Icon=\"QuestionMarkGreen\">";
                    break;
                case "000300380002003D":
                    tagstrs = "<Icon=\"CheckpointFlag\">";
                    break;
                case "000300390002003E":
                    tagstrs = "<Icon=\"EmptyStar\">";
                    break;
                case "00030003A002003F":
                    tagstrs = "<Icon=\"EmptyCometStar\">";
                    break;
                case "00030003B0020040":
                    tagstrs = "<Icon=\"EmptyCometMedal\">";
                    break;
                case "0003003C00020041":
                    tagstrs = "<Icon=\"EmptyHiddenStar\">";
                    break;
                case "0003003E00020043":
                    tagstrs = "<Icon=\"BlimpFruit\">";
                    break;
                case "0003004000020045":
                    tagstrs = "<Icon=\"BronzeGrandStar\">";
                    break;

            }

            UTF16BE(tagstrs, list);
            if (tagstrs.Substring(1, 7) == "Unknown") Debugger.Unknowntagwriter(tagstrs);
            return true;
        }

        public static bool Tag04(BinaryReader br, FileStream fs, List<byte> list, byte bit5, byte bit6, byte bit7, byte bit8)
        {

            string tagstrs = "<Unknown=\"Tag04\">";
            switch (bit6)
            {
                case 0x00:
                    tagstrs = "<Size=\"Small\">";
                    break;
                case 0x01:
                    tagstrs = "<Size=\"Normal\">";
                    break;
                case 0x02:
                    tagstrs = "<Size=\"Large\">";
                    break;

            }
            Console.WriteLine(tagstrs + "_てす");
            UTF16BE(tagstrs, list);
            if (tagstrs.Substring(1, 7) == "Unknown") Debugger.Unknowntagwriter(tagstrs);
            return true;
        }

        public static bool Tag05(BinaryReader br, FileStream fs, List<byte> list, byte bit5, byte bit6, byte bit7, byte bit8)
        {
            Bytes2Byte(br);
            Bytes2Byte(br);
            string tagstrs = "<Unknown=\"Tag05\">";
            switch (bit6)
            {
                case 0x00:
                    if (bit8 != 02) break;
                    tagstrs = "</PlayCharacter>";
                    break;
            }
            Console.WriteLine(tagstrs + "_てす");
            UTF16BE(tagstrs, list);
            if (tagstrs.Substring(1, 7) == "Unknown") Debugger.Unknowntagwriter(tagstrs);
            return true;
        }

        public static bool Tag06(BinaryReader br, FileStream fs, List<byte> list, byte bit5, byte bit6, byte bit7, byte bit8)
        {
            Bytes2Byte(br);
            Bytes2Byte(br);
            Bytes2Byte(br);
            Bytes2Byte(br);
            Bytes2Byte(br);
            Bytes2Byte(br);
            Bytes2Byte(br);
            var lastbit = Bytes2Byte(br);
            string tagstrs = "<Unknown=\"Tag06\">";
            switch (bit6)
            {
                case 0x00:
                    if (bit8 != 08) break;
                    tagstrs = "</WorldNo>";
                    break;
                case 0x01:
                    if (bit8 != 08) break;
                    tagstrs = "</StarShipTag>";
                    break;
                case 0x02:
                    if (bit8 != 08) break;
                    tagstrs = "</Year01>";
                    break;
                case 0x03:
                    if (bit8 != 08) break;
                    tagstrs = "</Year02>";
                    break;
                case 0x04:
                    if (bit8 != 08) break;
                   
                    switch (lastbit)
                    {
                        case 00:
                            tagstrs = "</Score01>";
                            break;
                        case 01:
                            //tagstrs = "</Score?>";
                            break;
                        case 02:
                            //tagstrs = "</Score??>";
                            break;
                        case 03:
                            //tagstrs = "</Score???>";
                            break;
                    }
                    break;
                case 0x05:
                    if (bit8 != 08) break;
                    switch (lastbit) {
                        case 00:
                            tagstrs = "</Hour>";
                            break;
                        case 01:
                            tagstrs = "</Minutes>";
                            break;
                        case 02:
                            tagstrs = "</Seconds>";
                            break;
                        case 03:
                            tagstrs = "</AfterTheDecimalPoint>";
                            break;
                    }
                    
                    break;
            }
            UTF16BE(tagstrs, list);
            if (tagstrs.Length > 8) {
                Console.WriteLine("tagname   " + tagstrs.Substring(1, 7));
                if (tagstrs.Substring(1, 7) == "Unknown" && tagstrs.Length > 8) Debugger.Unknowntagwriter(tagstrs);
            }
            
            return true;
        }
        public static bool Tag07(BinaryReader br, FileStream fs, List<byte> list, byte bit5, byte bit6, byte bit7, byte bit8)
        {
            Bytes2Byte(br);
            Bytes2Byte(br);
            Bytes2Byte(br);
            Bytes2Byte(br);
            Bytes2Byte(br);
            Bytes2Byte(br);
            Bytes2Byte(br);
            Bytes2Byte(br);
            string tagstrs = "<Unknown=\"Tag07\">";
            switch (bit6)
            {
                case 0x00:
                    if (bit8 != 08) break;
                    tagstrs = "</ResultGalaxyName>";
                    break;
                case 0x01:
                    if (bit8 != 08) break;
                    tagstrs = "</ResultScenarioName>";
                    break;
                case 0x02:
                    tagstrs = "</UnusedTags07_02>";
                    break;
                case 0x03:
                    tagstrs = "</UnusedTags07_03>";
                    break;
                case 0x04:
                    if (bit8 != 08) break;
                    tagstrs = "</UserName>";
                    break;
                case 0x05:
                    if (bit8 != 08) break;
                    tagstrs = "</TotalPlayTime>";
                    break;
            }
            UTF16BE(tagstrs, list);
            if (tagstrs.Substring(1, 7) == "Unknown") Debugger.Unknowntagwriter(tagstrs);
            return true;
        }

        

        public static byte Bytes2Byte(BinaryReader br) {
            return br.ReadByte();
        }

        public static int Byte2Int(BinaryReader br, int readbyte = 4)
        {
            return Int32.Parse(BitConverter.ToString(br.ReadBytes(readbyte), 0).Replace("-", "").PadLeft(readbyte, '0'), NumberStyles.HexNumber);
        }

        public static Int16 Byte2Short(BinaryReader br, int readbyte = 2)
        {
            return Int16.Parse(BitConverter.ToString(br.ReadBytes(readbyte), 0).Replace("-", "").PadLeft(readbyte, '0'), NumberStyles.HexNumber);
        }

        

        public static uint MSBT_Hash(string label, int num_slots) {
            uint hash = 0;
            foreach (char c in label) {
                hash *= 0x492;
                hash += c;
            }
            return (hash & 0xFFFFFFFF) % (uint)num_slots;
        }

        /// <summary>
        /// ファイルのパディング分バイナリリードを進めます<br/>
        /// <remarks>Padding(進めたいバイナリリード、ファイルストリームの位置(ling型))</remarks>
        /// </summary>
        /// 
        public static void Padding(BinaryReader br, long fs)
        {
            string ps = "";
            for (long k = fs; (k % 16f) != 0; k++)
            {
                ps += Byte2Char(br, 1);
            }
            Debugger.Text(ps);
        }

        /// <summary>
        /// ファイルのパディング分バイナリライトを進めます<br/>
        /// <remarks>Padding_Writer(進めたいバイナリライト、ファイルストリームの位置(ling型))</remarks>
        /// </summary>
        public static void Padding_Writer(BinaryWriter bw, long bw_pos)
        {
            int i = 0;
            byte[] pad = StringToBytes("ABABABABABABABABABABABABABABABAB");
            for (long k = bw_pos; (k % 16f) != 0; k++)
            {
                bw.Write(pad[i]);
                i++;
            }
        }

        public static void MSBF_Padding(BinaryReader br, long fs)
        {
            string ps = "";
            for (long k = fs; (k % 16f) != 0; k++)
            {
                ps += Byte2Char(br, 1);
            }
            Debugger.MSBF_Text(ps);
        }

        public static byte[] StringToBytes(string str)
        {
            var bs = new List<byte>();
            for (int i = 0; i < str.Length / 2; i++)
            {
                bs.Add(Convert.ToByte(str.Substring(i * 2, 2), 16));
            }
            return bs.ToArray();
        }

        public static void StringToBytesWriter(BinaryWriter bw , string str) {
            bw.Write(StringToBytes(str));
        }
        

        public static byte[] StringToInt32_byte(string str)
        {
            int sh;
            string str2;
            sh = Convert.ToInt32(str, 16);
            str2 = sh.ToString("X8");
            return StringToBytes(str2);

        }

        /// <summary>
        /// ファイルにint32型のNullデータを書き込みます<br/>
        /// <remarks>Null_Writer_Int32(進めたいバイナリライト、繰り返し回数(int型))</remarks>
        /// </summary>
        /// 
        public static void Null_Writer_Int32(BinaryWriter bw , int write_rep_num = 1) {

            //0以上または、int型の最大値までしか選択できないようにする。
            if (write_rep_num < 1) write_rep_num = 1;
            if (Int32.MaxValue < write_rep_num) write_rep_num = Int32.MaxValue;

            for(int i = 0; i<write_rep_num; i++)
            bw.Write(BitConverter.GetBytes(0x00000000));

            //↓旧計算式
            //bw.Write(BitConverter.GetBytes(0x00000000));
        }

        public static void UTF16BE_String_Writer(BinaryWriter bw , string str) {
            bw.Write(Encoding.GetEncoding("unicodeFFFE").GetBytes(str));
            
        }

        public static void String_Writer(BinaryWriter bw , string str , string EncodingName = "ASCII") {
            bw.Write(Encoding.GetEncoding(EncodingName).GetBytes(str));
        }

        

        public static string String2TagChecker(string str) {
            var oldstr = str.Replace(EN.NewLine, "");
            oldstr = oldstr.Replace("\n", "");
            oldstr = oldstr.Replace("\r", "");
            char[] ch = { '<', '>' };
            string[] oldstrarray = oldstr.Split(ch);
            
            for (int i = 0; i < oldstrarray.Count(); i++) {
                var roopstr = TagChecker(oldstrarray[i]);
                oldstrarray[i] = roopstr;
            }
            
            return string.Join("",oldstrarray);
        }

        public static string TagChecker(string str)
        {

            byte[] bits;
            switch (str)
            {
                case "/br":
                    bits = StringToBytes("000A");
                    break;
                case "/End":
                    bits = StringToBytes("0000");
                    break;
                case "Size=\"Small\"":
                    bits = StringToBytes("000E000400000000");
                    break;
                case "Size=\"Normal\"":
                    bits = StringToBytes("000E000400010000");
                    break;
                case "Size=\"Large\"":
                    bits = StringToBytes("000E000400020000");
                    break;
                case "/NCenter":
                    bits = StringToBytes("000E000100010000");
                    break;
                case "/YCenter":
                    bits = StringToBytes("000E000100020000");
                    break;
                case "/XCenter":
                    bits = StringToBytes("000E000100030000");
                    break;
                case "/PlayCharacter":
                    bits = StringToBytes("000E00050000000200CD");
                    break;
                case "/New_Page":
                    bits = StringToBytes("000E000100010000000A");
                    break;
                case "Color=\"Black\"":
                    bits = StringToBytes("000E0000000300020000");
                    break;
                case "Color=\"Red\"":
                    bits = StringToBytes("000E0000000300020001");
                    break;
                case "Color=\"Green\"":
                    bits = StringToBytes("000E0000000300020002");
                    break;
                case "Color=\"Blue\"":
                    bits = StringToBytes("000E0000000300020003");
                    break;
                case "Color=\"Yellow\"":
                    bits = StringToBytes("000E0000000300020004");
                    break;
                case "Color=\"Purple\"":
                    bits = StringToBytes("000E0000000300020005");
                    break;
                case "Color=\"Orange\"":
                    bits = StringToBytes("000E0000000300020006");
                    break;
                case "Color=\"Gray\"":
                    bits = StringToBytes("000E0000000300020007");
                    break;
                case "/Color":
                    bits = StringToBytes("000E000000030002FFFF");
                    break;
                case "Icon=\"CometMedal\"":
                case "Icon=\"Comet Medal\"":
                    bits = StringToBytes("000E000300350002003A");
                    break;
                case "Icon=\"SilverCrown\"":
                case "Icon=\"Silver Crown\"":
                    bits = StringToBytes("000E000300360002003B");
                    break;
                case "Icon=\"PointerHand\"":
                case "Icon=\"Wii Pointer Hand (Selected)\"":
                    bits = StringToBytes("000E0003002500020025");
                    break;
                case "Icon=\"Peach\"":
                case "Icon=\"Peach Icon\"":
                    bits = StringToBytes("000E0003002800020028");
                    break;
                case "Icon=\"SilverCrownwJewel\"":
                case "Icon=\"Large Silver Crown\"":
                    bits = StringToBytes("000E0003003F00020044");
                    break;
                case "Icon=\"Begoman\"":
                    bits = StringToBytes("000E0003004100020046");
                    break;
                case "Icon=\"Koopa\"":
                    bits = StringToBytes("000E0003002300020023");
                    break;
                case "Icon=\"Coins\"":
                    bits = StringToBytes("000E0003004300020048");
                    break;
                case "Icon=\"Starbit\"":
                case "Icon=\"Purple Starbit\"":
                    bits = StringToBytes("000E0003002700020027");
                    break;
                case "Icon=\"BronzeStar\"":
                case "Icon=\"Bronze Star\"":
                    bits = StringToBytes("000E0003003D00020042");
                    break;
                case "Icon=\"LifeUpMushroom\"":
                case "Icon=\"Life Up Mushroom\"":
                    bits = StringToBytes("000E0003002D00020032");
                    break;
                case "Icon=\"StarPiece\"":
                case "Icon=\"Star Chip\"":
                    bits = StringToBytes("000E0003001500020015");
                    break;
                case "Icon=\"Pointer\"":
                case "Icon=\"P1 Pointer\"":
                    bits = StringToBytes("000E0003000A0002000A");
                    break;

                case "Icon=\"GreenComet\"":
                case "Icon=\"Green Comet\"":
                    bits = StringToBytes("000E0003001F0002001F");
                    break;
                case "Icon=\"WiiMote\"":
                case "Icon=\"Wii Remote\"":
                    bits = StringToBytes("000E0003000300020003");
                    break;
                case "Icon=\"Kinopio\"":
                case "Icon=\"Toad\"":
                    bits = StringToBytes("000E000300470002004C");
                    break;
                case "Icon=\"PurpleStarbit\"":
                case "Icon=\"Purple Star Bit\"":
                    bits = StringToBytes("000E0003000B0002000B");
                    break;
                case "Icon=\"Letter\"":
                    bits = StringToBytes("000E0003002900020029");
                    break;
                case "Icon=\"Kuribo\"":
                case "Icon=\"Goomba\"":
                    bits = StringToBytes("000E0003004200020047");
                    break;
                case "Icon=\"Mario\"":
                case "Icon=\"Mario Icon\"":
                    bits = StringToBytes("000E0003002B0002002B");
                    break;
                case "Icon=\"Mario2\"":
                    bits = StringToBytes("000E0003001200020012");
                    break;
                case "Icon=\"DPad\"":
                case "Icon=\"D-Pad\"":
                    bits = StringToBytes("000E0003001300020013");
                    break;
                case "Icon=\"DPadDown\"":
                case "Icon=\"D-Pad Down\"":
                    bits = StringToBytes("000E000300450002004A");
                    break;

                case "Icon=\"JoyStick\"":
                case "Icon=\"Control Stick\"":
                    bits = StringToBytes("000E0003000F0002000F");
                    break;
                case "Icon=\"MButton\"":
                case "Icon=\"Minus Button\"":
                    bits = StringToBytes("000E0003001700020017");
                    break;
                case "Icon=\"DPadUp\"":
                case "Icon=\"D-Pad Up\"":
                    bits = StringToBytes("000E0003004400020049");
                    break;
                case "Icon=\"GrandStar\"":
                case "Icon=\"Grand Star\"":
                    bits = StringToBytes("000E0003001B0002001B");
                    break;
                case "Icon=\"Star\"":
                case "Icon=\"Power Star\"":
                    bits = StringToBytes("000E0003000700020007");
                    break;
                case "Icon=\"Tico\"":
                case "Icon=\"Luma\"":
                    bits = StringToBytes("000E0003002F00020034");
                    break;
                case "Icon=\"1UPMushroom\"":
                case "Icon=\"One Up Mushroom\"":
                    bits = StringToBytes("000E0003002C00020031");
                    break;
                case "Icon=\"CButton\"":
                case "Icon=\"C Button\"":
                    bits = StringToBytes("000E0003000200020002");
                    break;
                case "Icon=\"PButton\"":
                case "Icon=\"Plus Button\"":
                    bits = StringToBytes("000E0003001800020018");
                    break;
                case "Icon=\"BlueStar\"":
                case "Icon=\"Pull Star\"":
                    bits = StringToBytes("000E0003000900020009");
                    break;

                case "Icon=\"Yoshi\"":
                    bits = StringToBytes("000E0003003400020039");
                    break;
                case "Icon=\"XIcon\"":
                case "Icon=\"X Icon\"":
                    bits = StringToBytes("000E0003001000020010");
                    break;
                case "Icon=\"Coin\"":
                    bits = StringToBytes("000E0003001100020011");
                    break;
                case "Icon=\"GoldCrown\"":
                case "Icon=\"Golden Crown\"":
                    bits = StringToBytes("000E0003002000020020");
                    break;
                case "Icon=\"ZButton\"":
                case "Icon=\"Z Button\"":
                    bits = StringToBytes("000E0003001900020019");
                    break;
                case "Icon=\"HarapekoTico\"":
                case "Icon=\"Hungry Luma\"":
                    bits = StringToBytes("000E0003002E00020033");
                    break;
                case "Icon=\"ArrowDown\"":
                case "Icon=\"Arrow Down\"":
                    bits = StringToBytes("000E0003000D0002000D");
                    break;
                case "Icon=\"Luigi\"":
                case "Icon=\"Luigi Icon\"":
                    bits = StringToBytes("000E0003001C0002001C");
                    break;
                case "Icon=\"StarRing\"":
                case "Icon=\"Launch Star\"":
                    bits = StringToBytes("000E0003000800020008");
                    break;
                case "Icon=\"AButton\"":
                case "Icon=\"A Button\"":
                    bits = StringToBytes("000E0003000000020000");
                    break;

                case "Icon=\"PurpleCoin\"":
                case "Icon=\"Purple Coin\"":
                    bits = StringToBytes("000E0003001E0002001E");
                    break;
                case "Icon=\"BButton\"":
                case "Icon=\"B Button\"":
                    bits = StringToBytes("000E0003000100020001");
                    break;
                case "Icon=\"Aim\"":
                case "Icon=\"Aim Target\"":
                    bits = StringToBytes("000E0003002100020021");
                    break;
                case "Icon=\"Nunchuck\"":
                    bits = StringToBytes("000E0003000400020004");
                    break;
                case "Icon=\"MasterTico\"":
                case "Icon=\"Young Master Luma\"":
                    bits = StringToBytes("000E0003003300020038");
                    break;
                case "Icon=\"StopWatch\"":
                case "Icon=\"Timer Icon\"":
                    bits = StringToBytes("000E0003003200020037");
                    break;
                case "Icon=\"Columa\"":
                case "Icon=\"Co-Star Luma\"":
                    bits = StringToBytes("000E000300460002004B");
                    break;
                case "Icon=\"PointerYellow\"":
                case "Icon=\"P2 Pointer\"":
                    bits = StringToBytes("000E0003001D0002001D");
                    break;
                case "Icon=\"Flower\"":
                case "Icon=\"Yoshi Grapple\"":
                    bits = StringToBytes("000E000300370002003C");
                    break;
                case "Icon=\"SilverStar\"":
                case "Icon=\"Silver Star\"":
                    bits = StringToBytes("000E0003001A0002001A");
                    break;
                case "Icon=\"BronzeComet\"":
                case "Icon=\"Bronze Comet\"":
                    bits = StringToBytes("000E000300480002004D");
                    break;
                case "Icon=\"1 Button\"":
                    bits = StringToBytes("000E0003000500020005");
                    break;
                case "Icon=\"2 Button\"":
                    bits = StringToBytes("000E0003000600020006");
                    break;
                case "Icon=\"Coconut\"":
                    bits = StringToBytes("000E0003000C0002000C");
                    break;
                case "Icon=\"StarBunny\"":
                    bits = StringToBytes("000E0003000E0002000E");
                    break;
                case "Icon=\"BlueStarPiece\"":
                    bits = StringToBytes("000E0003001400020014");
                    break;
                case "Icon=\"HomeButton\"":
                    bits = StringToBytes("000E0003001600020016");
                    break;
                case "Icon=\"StarPointerSelected\"":
                    bits = StringToBytes("000E0003002400020024");
                    break;
                case "Icon=\"StarPointerSelecting\"":
                    bits = StringToBytes("000E0003000600020006");
                    break;
                case "Icon=\"QuestionMark\"":
                    bits = StringToBytes("000E0003002A0002002A");
                    break;
                case "Icon=\"CometStar\"":
                    bits = StringToBytes("000E0003003000020035");
                    break;
                case "Icon=\"QuestionMarkGreen\"":
                    bits = StringToBytes("000E0003003100020036");
                    break;
                case "Icon=\"CheckpointFlag\"":
                    bits = StringToBytes("000E000300380002003D");
                    break;
                case "Icon=\"EmptyStar\"":
                    bits = StringToBytes("000E000300390002003E");
                    break;
                case "Icon=\"EmptyCometMedal\"":
                    bits = StringToBytes("000E00030003A002003F");
                    break;
                case "Icon=\"EmptyCometStar\"":
                    bits = StringToBytes("000E00030003B0020040");
                    break;
                case "Icon=\"EmptyHiddenStar\"":
                    bits = StringToBytes("000E0003003C00020041");
                    break;
                case "Icon=\"BlimpFruit\"":
                    bits = StringToBytes("000E0003003E00020043");
                    break;
                case "Icon=\"BronzeGrandStar\"":
                    bits = StringToBytes("000E0003004000020045");
                    break;

                case "/World_No":
                    bits = StringToBytes("000E0006000000080000000000000000");
                    break;
                case "/StarShipTag":
                    bits = StringToBytes("000E0006000100080000000000000000");
                    break;
                case "/Year01":
                    bits = StringToBytes("000E0006000200080000000000000000");
                    break;
                case "/Year02":
                    bits = StringToBytes("000E0006000300080000000000000000");
                    break;
                case "/Hour":
                    bits = StringToBytes("000E0006000500080000000000000000");
                    break;
                case "/Minutes":
                    bits = StringToBytes("000E0006000500080000000000000001");
                    break;
                case "/Seconds":
                    bits = StringToBytes("000E0006000500080000000000000002");
                    break;
                case "/AfterTheDecimalPoint":
                    bits = StringToBytes("000E0006000500080000000000000003");
                    break;

                case "/ResultGalaxyName":
                    bits = StringToBytes("000E0007000000080000000000000000");
                    break;
                case "/ResultScenarioName":
                    bits = StringToBytes("000E0007000100080000000000000001");
                    break;
                case "/UserName":
                    bits = StringToBytes("000E0007000400080000000000000000");
                    break;
                case "/TotalPlayTime":
                    bits = StringToBytes("000E0007000500080000000000000001");
                    break;
                default:
                    if (str.Length > 2)
                    {
                        if (str.Substring(0, 3) == "SE=")
                        {
                            Console.WriteLine(str);
                            var strs = str.Split('\"');
                            var strslength = strs[1].Length;
                            var bit9to10 = strslength *2;
                            var bit7to8 = bit9to10 + 2;
                            //var se_no = Int32.Parse(strs[1]);
                            var setagand = "000E00020000"+bit7to8.ToString("X4")+bit9to10.ToString("X4");
                            var stringbytes = Encoding.GetEncoding("unicodeFFFE").GetBytes(strs[1]);
                            var bytestring = BitConverter.ToString(stringbytes).Replace("-", string.Empty);

                            Console.WriteLine(setagand + bytestring);
                            bits = StringToBytes(setagand + bytestring);
                            break;
                        }
                    }
                    if (str.Length > 3)
                    {
                        if (str.Substring(0, 4) == "Rubi")
                        {
                            var strs = str.Split('\"');
                            var rubi = Int32.Parse(strs[1]);
                            var target = Int32.Parse(strs[3]);
                            var total = ((target) << 1) + ((rubi) << 1) ;

                            switch (((target) << 1)) {
                                case 2:
                                    total += 2;
                                    break;
                                case 4:
                                    break;
                                case 6:
                                    total -= 2;
                                    break;
                                case 8:
                                    total -= 4;
                                    break;
                                case 10:
                                    total -= 6;
                                    break;
                                default:
                                    break;
                            
                            }
                            
                            var hexnum = ((long)(total) << 32) + ((long)(target) << 17) + ((long)(rubi) << 1);
                            
                            bits = StringToBytes("000E00000000" + hexnum.ToString("X12"));
                            break;
                        }
                    }
                    if (str.Length > 5) {
                        if (str.Substring(0, 6) == "/Timer")
                        {
                            var strs = str.Split('\"');
                            var time = UInt16.Parse(strs[1]);

                            bits = StringToBytes("000E000100000002" + time.ToString("X4"));
                            break;
                        }
                    }
                    if (str.Length > 8) {
                        if (str.Substring(0,9) == "UserIcon=") {
                            var strs = str.Split('\"');
                            bits = StringToBytes(strs[1]);
                            break;
                        }
                    }
                    return str;
            }

            return Encoding.GetEncoding("unicodeFFFE"/*1201*/).GetString(bits);
        }

        public static void TextBoxInsert(TextBox tb , string str) {
            if (str == string.Empty) return;
            tb.SelectedText = str;
        }

        public static void TextBoxTagAdder(ListBox lb , TextBox tb , ComboBox cb , string[] strs) {
            if (lb.Items.Count < 1) return;
            if (cb.Items.Count == -1) return;
            if (cb.SelectedIndex == -1) cb.SelectedIndex = 0;
            int index = cb.SelectedIndex;
            string tag = strs[index];
            TextBoxInsert(tb, tag);
        }

    }
}
