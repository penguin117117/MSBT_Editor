using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MSBT_Editor.FileSys;
using CS = MSBT_Editor.FileSys.Calculation_System;
using MSBT_Editor.MSBFsys;
using MSBT_Editor.Formsys;
using System.Windows.Forms;

namespace MSBT_Editor.Sectionsys
{
    public class FEN1:objects
    {
        private static string magic;
        private static int sec_size;
        private static int unknown1;
        private static int unknown2;
        private static int entry;

        
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

        public int Unknown2
        {
            set => unknown2 = value;
            get => unknown2;
        }

        public int Entry {
            set => entry = value;
            get => entry;
        }

        public struct Element
        {
            public int tagflag;
            public int unknown2;
            public Element(int arg1, int arg2)
            {
                this.tagflag = arg1;
                this.unknown2 = arg2;
            }
        }

        public struct ElementTag {
            public string tagname;
            public int tagnum;
            public ElementTag(string arg1 , int arg2) {
                this.tagname = arg1;
                this.tagnum  = arg2;
            }
        }

        private static List<Element> item1;
        private static List<ElementTag> item2;

        public List<Element> Item1 {
            set => item1 = value;
            get => item1;
        }

        public List<ElementTag> Item2 {
            set => item2 = value;
            get => item2;
        }

        public void Read(BinaryReader br, FileStream fs)
        {
            Item1 = new List<Element>();
            Item2 = new List<ElementTag>();
            Magic = CS.Byte2Char(br);
            Section_Size = CS.Byte2Int(br);
            Unknown1 = CS.Byte2Int(br);
            Unknown2 = CS.Byte2Int(br);

            var pos1 = fs.Position;

            Entry = CS.Byte2Int(br);

            Debugger.MSBF_Text(Magic.ToString());
            Debugger.MSBF_Text(Section_Size.ToString());
            Debugger.MSBF_Text(Unknown1.ToString());
            Debugger.MSBF_Text(Unknown2.ToString());
            Debugger.MSBF_Text(Entry.ToString());
            Debugger.MSBF_Text("");
            for (int i = 0; i < Entry; i++) {
                var unk1 = CS.Byte2Int(br);
                var unk2 = CS.Byte2Int(br);
                Item1.Add(new Element(unk1, unk2));
                //if (i!=0) {
                //    if (Item1[i - 1].tagflag == Item1[i].tagflag) 
                //        Item1.RemoveAt(i);
                        
                //}

                Debugger.MSBF_Text(unk1.ToString());
                Debugger.MSBF_Text(unk2.ToString());
                Debugger.MSBF_Text("");
            }
            Debugger.MSBF_Text(fs.Position.ToString()+"__"+pos1.ToString());
            txtb27.AppendText("unk1____"+item1.Count.ToString());
            //タグの数を抜き出す
            var array = Item1.ToArray();
            var array2 = array.Distinct().ToArray();
            //var array2 = array.Where(num => num.tagflag > 0).ToArray();
            //var array2 = array.Distinct(num => num).ToArray();
            //IEnumerable<Element> array2 = array.Distinct();
            var tag_flag_count = array2.Count();

            //タグ抜き出しデバッグ専用
            var tagcount = array2.Count().ToString();
            Debugger.MSBF_Text(tagcount);
            Debugger.MSBF_Text("");

            Item1 = new List<Element>(array2);

            Debugger.HashTxt("//////////FEN1//////////");
            for (int j = 0; j < tag_flag_count; j++) {
                Console.WriteLine(j);
                var txtnum = CS.Bytes2Byte(br);

                //パディングに当たった際にファイルストリームを1戻して処理を抜ける
                if (txtnum == 0xAB) {
                    fs.Position --;
                    break; }
                Console.WriteLine("ok");
                //Debugger.MSBF_Text(CS.Byte2Char(br,txtnum)) ;
                //Debugger.MSBF_Text(CS.Byte2Int(br).ToString());
                var targettagname = CS.Byte2Char(br, txtnum);
                var targettagnum = CS.Byte2Int(br);

                list3.Items.Add(targettagname);
                
                Item2.Add(new ElementTag(targettagname,targettagnum));

                Debugger.HashTxt(targettagname);
                Debugger.HashTxt(targettagnum.ToString("X8"));
            
            }
            CS.MSBF_Padding(br,fs.Position);
        }

        public static void FEN1_Item_Change(ListBox lb, TextBox tb) {
            //エラー対策
            if (lb.Items.Count == 0) return;
            if (tb.Text.Length != 4) return;

            //インデックス位置を保持
            var index = lb.SelectedIndex;

            //インデックス番号が-1の時0にする
            if (index == -1) index = 0;


        }
    }
}
