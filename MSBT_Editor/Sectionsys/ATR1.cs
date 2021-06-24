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

namespace MSBT_Editor.Sectionsys
{
    public class ATR1:objects
    {
        private static string magic;
        private static int sec_size;
        private static int unknown1;
        private static int unknown2;
        private static int entries;
        private static int ent_size;

        public struct Item {
            public byte unknown1;
            public byte unknown2;
            public byte Dialog_Type;
            public byte unknown3;
            public short unknown4;
            public byte unknown5;
            public byte unknown6;
            public int null_offset;
            public Item(byte arg1 , byte arg2 , byte arg3 , byte arg4 , short arg5 , byte arg6 , byte arg7 , int arg8) {
                this.unknown1 = arg1;
                this.unknown2 = arg2;
                this.Dialog_Type = arg3;
                this.unknown3 = arg4;
                this.unknown4 = arg5;
                this.unknown5 = arg6;
                this.unknown6 = arg7;
                this.null_offset = arg8;
            }
        }

        public List<Item> Element;
        public static List<string> nulldata;

        public string Magic {
            set => magic = value;
            get => magic;
        }

        public int Section_Size {
            set => sec_size = value;
            get => sec_size;
        }

        public int Unknown1 {
            set => unknown1 = value;
            get => unknown1;
        }

        public int Unknown2 {
            set => unknown2 = value;
            get => unknown2;
        }

        public int Entries {
            set
            {
                if (value != 101 || value != 102)
                {
                    entries = value;

                }
                else
                {
                    entries = 101;
                }
            }
            get => entries;
        }

        public int Entry_Size {
            set => ent_size = value;
            get => ent_size;
        }

        public void Read(BinaryReader br , FileStream fs) {

            //初期化
            int notffcount = 0;
            Element = new List<Item>();
            nulldata = new List<string>();

            //ヘッダー情報
            Magic = CS.Byte2Char(br);
            Section_Size = CS.Byte2Int(br);
            Unknown1 = CS.Byte2Int(br);
            Unknown2 = CS.Byte2Int(br);
            Entries = CS.Byte2Int(br);
            Entry_Size = CS.Byte2Int(br);

            txtb15.Text = Entries.ToString();

            for (int i = 0; i < Entries; i++)
            {
                var arg1 = CS.Bytes2Byte(br);
                var arg2 = CS.Bytes2Byte(br);
                var arg3 = CS.Bytes2Byte(br);
                var arg4 = CS.Bytes2Byte(br);
                var arg5 = CS.Byte2Short(br);
                var arg6 = CS.Bytes2Byte(br);
                var arg7 = CS.Bytes2Byte(br);
                if (arg7 != 0xFF){ 
                    notffcount++;
                    Console.WriteLine(fs.Position.ToString("X"));
                }
                var arg8 = CS.Byte2Int(br);

                //星船マリオの対策
                //if (i != 0)
                //{
                //    var starship_Check = arg8 - Element[i - 1].null_offset;
                //    if (starship_Check > 2)
                //    {

                //    }
                //}
                Element.Add(new Item( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
            }

            for (int j = 0; j<Element.Count; j++) {
                
                string null_table = "";
                if (Element.Count - 1 == j){
                    null_table = CS.Byte2Str_UTF16BE(br);
                }
                else {
                    
                    var check = Element[j + 1].null_offset - Element[j].null_offset;
                    Console.WriteLine(check.ToString("X"));
                    Console.WriteLine("ATR1" + fs.Position.ToString("X"));
                    null_table = CS.Byte2Str_UTF16BE(br, check);
                    
                }
                nulldata.Add(null_table);
            }
            CS.Padding(br,fs.Position);
        }

        public static void ATR1_Change(TextBox textbox)
        {
            
            if (list1.Items.Count != 0)
            {
                byte bit = 0x01;
                short sh = 0x0000;
                var strnum = textbox.Text.Length;

                if (strnum == 2)
                {
                    bit = byte.Parse(textbox.Text, System.Globalization.NumberStyles.HexNumber);
                }
                else if(strnum == 4)
                {
                    sh = short.Parse(textbox.Text, System.Globalization.NumberStyles.HexNumber);
                }


                ATR1.Item element = MSBT_Data.MSBT_All_Data.Item[list1.SelectedIndex];
                switch (textbox.Name)
                {
                    case "textBox3":
                        element.unknown1 = bit;
                        break;
                    case "textBox4":
                        element.unknown2 = bit;
                        break;
                    case "textBox5":
                        element.Dialog_Type = bit;
                        break;
                    case "textBox6":
                        element.unknown3 = bit;
                        break;
                    case "textBox7":
                        element.unknown4 = sh;
                        break;
                    case "textBox8":
                        element.unknown5 = bit;
                        break;
                    case "textBox9":
                        element.unknown6 = bit;
                        break;
                }
                MSBT_Data.MSBT_All_Data.Item[list1.SelectedIndex] = element;
            }
        }

        public void Write(BinaryWriter bw , FileStream fs) {

            //マジックの書き込み
            bw.Write(Encoding.ASCII.GetBytes("ATR1"));

            //セクションサイズの位置を記憶
            var atr_sec_pos = fs.Position;

            //セクションサイズとその他二つを書き込む(12バイト)
            CS.Null_Writer_Int32(bw, 3);

            //ATR1オフセット位置を記憶
            var atr_offset_pos = fs.Position;

            //エントリー数と1エントリー当たりのバイト数を書き込む
            bw.Write(CS.StringToInt32_byte((list1.Items.Count).ToString("X8")));
            bw.Write(CS.StringToInt32_byte((12).ToString("X8")));

            //エントリーの各データを書き込む
            var msbtcount =MSBT_Data.MSBT_All_Data.Item.Count();
            List<long> nulloffsetpos = new List<long>();
            for (int i = 0; i < msbtcount; i++)
            {
                bw.Write(MSBT_Data.MSBT_All_Data.Item[i].unknown1);
                bw.Write(MSBT_Data.MSBT_All_Data.Item[i].unknown2);
                bw.Write(MSBT_Data.MSBT_All_Data.Item[i].Dialog_Type);
                bw.Write(MSBT_Data.MSBT_All_Data.Item[i].unknown3);
                bw.Write(CS.StringToBytes(MSBT_Data.MSBT_All_Data.Item[i].unknown4.ToString("X4")));
                bw.Write(MSBT_Data.MSBT_All_Data.Item[i].unknown5);
                bw.Write(MSBT_Data.MSBT_All_Data.Item[i].unknown6);
                nulloffsetpos.Add(fs.Position);
                CS.Null_Writer_Int32(bw);
            }

            //特殊テキストの書き込み
            List<long> sptextoffset = new List<long>();
            for (int j = 0; j < list1.Items.Count; j++)
            {
                list1.SelectedIndex = j;
                if (txtb11.Text == "")
                {
                    sptextoffset.Add(fs.Position - (atr_offset_pos));
                    bw.Write(CS.StringToBytes("0000"));
                }
                else
                {
                    sptextoffset.Add(fs.Position - (atr_offset_pos));
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


            fs.Seek(atr_sec_pos, SeekOrigin.Begin);
            bw.Write(CS.StringToBytes(((int)(sptextend_pos - atr_offset_pos)).ToString("X8")));

            fs.Position = sptextend_pos;
            CS.Padding_Writer(bw, fs.Position);
        }
    }
}
