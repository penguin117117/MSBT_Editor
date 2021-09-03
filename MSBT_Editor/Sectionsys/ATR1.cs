using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MSBT_Editor.FileSys;
using CS = MSBT_Editor.FileSys.Calculation_System;
using EN = System.Environment;
using MSBT_Editor.MSBTsys;
using MSBT_Editor.Formsys;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;

namespace MSBT_Editor.Sectionsys
{
    public class ATR1 : objects
    {
        private static string s_magic;
        private static int s_sec_size;
        private static int s_unknown1;
        private static int s_unknown2;
        private static int s_entrySize;
        private static int s_entryBytesSize;

        public struct AttributeData
        {
            public byte SoundID;
            public byte SimpleCameraID;
            public byte DialogID;
            public byte WindowID;
            public short EventCameraID;
            public byte MessageAreaID;
            public byte unknown6;
            public int SpecialTextOffset;
            public AttributeData(byte soundID, byte simpleCamID, byte dialogID, byte windowID, short eventCamID, byte messageAreaID, byte unknown, int specialTextOffset)
            {
                this.SoundID = soundID;
                this.SimpleCameraID = simpleCamID;
                this.DialogID = dialogID;
                this.WindowID = windowID;
                this.EventCameraID = eventCamID;
                this.MessageAreaID = messageAreaID;
                this.unknown6 = unknown;
                this.SpecialTextOffset = specialTextOffset;
            }
        }

        public List<AttributeData> AttributeDataList;
        public static List<string> SpecialTextList;

        public string Magic
        {
            set => s_magic = value;
            get => s_magic;
        }

        public int SectionSize
        {
            set => s_sec_size = value;
            get => s_sec_size;
        }

        public int Unknown1
        {
            set => s_unknown1 = value;
            get => s_unknown1;
        }

        public int Unknown2
        {
            set => s_unknown2 = value;
            get => s_unknown2;
        }

        public int EntrySize
        {
            set
            {
                if (value != 101 || value != 102)
                {
                    s_entrySize = value;
                }
                else
                {
                    s_entrySize = 101;
                }
            }
            get => s_entrySize;
        }

        public int EntryBytesSize
        {
            set => s_entryBytesSize = value;
            get => s_entryBytesSize;
        }

        public void Read(BinaryReader br, FileStream fs)
        {

            AttributeDataList = new List<AttributeData>();
            SpecialTextList = new List<string>();

            //ヘッダー情報を取得
            Magic = CS.Byte2Char(br);
            SectionSize = CS.Byte2Int(br);
            Unknown1 = CS.Byte2Int(br);
            Unknown2 = CS.Byte2Int(br);
            EntrySize = CS.Byte2Int(br);
            EntryBytesSize = CS.Byte2Int(br);

            //エントリーサイズをテキストボックスに
            txtb15.Text = EntrySize.ToString();

            AttributeDataReader(br, ref AttributeDataList);

            SpecialTextReader(br, AttributeDataList, ref SpecialTextList);

            CS.Padding(br, fs.Position);
        }

        private void AttributeDataReader(BinaryReader br, ref List<AttributeData> AttributeDataList)
        {
            for (int i = 0; i < EntrySize; i++)
            {
                var arg1 = CS.Bytes2Byte(br);
                var arg2 = CS.Bytes2Byte(br);
                var arg3 = CS.Bytes2Byte(br);
                var arg4 = CS.Bytes2Byte(br);
                var arg5 = CS.Byte2Short(br);
                var arg6 = CS.Bytes2Byte(br);
                var arg7 = CS.Bytes2Byte(br);
                var arg8 = CS.Byte2Int(br);
                AttributeDataList.Add(new AttributeData(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
            }
        }

        private void SpecialTextReader(BinaryReader br, List<AttributeData> AttributeDataList, ref List<string> SpecialTextList)
        {
            for (int j = 0; j < AttributeDataList.Count; j++)
            {

                string SpecialText;
                if (AttributeDataList.Count - 1 == j)
                {
                    SpecialText = CS.Byte2Str_UTF16BE(br);
                }
                else
                {
                    var SpecialTextBytesSize
                        = AttributeDataList[j + 1].SpecialTextOffset - AttributeDataList[j].SpecialTextOffset;
                    SpecialText = CS.Byte2Str_UTF16BE(br, SpecialTextBytesSize);
                }
                SpecialTextList.Add(SpecialText);
            }
        }

        public static byte ATR1TextBoxChange(TextBox textBox,byte changeData)
        {
            var TextBoxByteData = changeData;
            
            if (textBox.Text.Length != 2) return TextBoxByteData;

            TextBoxByteData = byte.Parse(textBox.Text, NumberStyles.HexNumber);

            return TextBoxByteData;
        }

        public static void ATR1TextBoxChange(TextBox textBox, short changeData)
        {
            if (MsbtListBox.Items.Count < 1) return;
            var TextCount = textBox.Text.Length;
            if (TextCount != 4) return;
        }
        public static void ATR1_Change(TextBox textbox)
        {
            if (MsbtListBox.Items.Count < 1) return;
            byte bit = 0x01;
            short sh = 0x0000;
            var strnum = textbox.Text.Length;

            if (strnum == 2)
            {
                bit = byte.Parse(textbox.Text, System.Globalization.NumberStyles.HexNumber);
            }
            else if (strnum == 4)
            {
                sh = short.Parse(textbox.Text, System.Globalization.NumberStyles.HexNumber);
            }

            

            ATR1.AttributeData element = MSBT_Data.MSBT_All_Data.Item[MsbtListBox.SelectedIndex];

            switch (textbox.Name)
            {
                case "Atr1SoundID":
                    element.SoundID = bit;
                    break;
                case "Atr1SimpleCamID":
                    element.SimpleCameraID = bit;
                    break;
                case "Atr1DialogID":
                    element.DialogID = bit;
                    break;
                case "Atr1WindowID":
                    element.WindowID = bit;
                    break;
                case "Atr1EventCameraID":
                    element.EventCameraID = sh;
                    break;
                case "Atr1MessageAreaID":
                    element.MessageAreaID = bit;
                    break;
                case "Atr1Unknown6":
                    element.unknown6 = bit;
                    break;
            }
            MSBT_Data.MSBT_All_Data.Item[MsbtListBox.SelectedIndex] = element;

        }

        public void Write(BinaryWriter bw, FileStream fs)
        {

            var SectionSizePosition = fs.Position + 0x04;
            var BasePositionAddress = fs.Position + 0x10;

            //ヘッダー情報を書き込む
            CS.String_Writer(bw, "ATR1");
            CS.Null_Writer_Int32(bw, 3);

            CS.StringToBytesWriter(bw, (MsbtListBox.Items.Count).ToString("X8"));
            CS.StringToBytesWriter(bw, (12).ToString("X8"));


            //エントリーの各データを書き込む
            var MSBTAllDataCount = MSBT_Data.MSBT_All_Data.Item.Count();
            List<long> nulloffsetpos = new List<long>();
            for (int i = 0; i < MSBTAllDataCount; i++)
            {
                bw.Write(MSBT_Data.MSBT_All_Data.Item[i].SoundID);
                bw.Write(MSBT_Data.MSBT_All_Data.Item[i].SimpleCameraID);
                bw.Write(MSBT_Data.MSBT_All_Data.Item[i].DialogID);
                bw.Write(MSBT_Data.MSBT_All_Data.Item[i].WindowID);
                bw.Write(CS.StringToBytes(MSBT_Data.MSBT_All_Data.Item[i].EventCameraID.ToString("X4")));
                bw.Write(MSBT_Data.MSBT_All_Data.Item[i].MessageAreaID);
                bw.Write(MSBT_Data.MSBT_All_Data.Item[i].unknown6);
                nulloffsetpos.Add(fs.Position);
                CS.Null_Writer_Int32(bw);
            }

            //特殊テキストの書き込み
            List<long> sptextoffset = new List<long>();
            for (int j = 0; j < MsbtListBox.Items.Count; j++)
            {
                MsbtListBox.SelectedIndex = j;
                if (txtb11.Text == "")
                {
                    sptextoffset.Add(fs.Position - (BasePositionAddress));
                    bw.Write(CS.StringToBytes("0000"));
                }
                else
                {
                    sptextoffset.Add(fs.Position - (BasePositionAddress));
                    CS.UTF16BE_String_Writer(bw, txtb11.Text);
                    fs.Position += 2;
                }
            }

            //エントリーサイズが102の場合(星船など)
            //if (Entries == 102) bw.Write(CS.StringToBytes("0000"));
            var sptextend_pos = fs.Position;

            for (int k = 0; k < nulloffsetpos.Count(); k++)
            {
                fs.Seek(nulloffsetpos[k], SeekOrigin.Begin);
                bw.Write(CS.StringToBytes(((int)sptextoffset[k]).ToString("X8")));
            }


            fs.Seek(SectionSizePosition, SeekOrigin.Begin);
            bw.Write(CS.StringToBytes(((int)(sptextend_pos - BasePositionAddress)).ToString("X8")));

            fs.Position = sptextend_pos;
            CS.Padding_Writer(bw, fs.Position);
        }
    }
}
