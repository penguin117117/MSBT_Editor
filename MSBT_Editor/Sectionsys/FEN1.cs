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

namespace MSBT_Editor.Sectionsys
{
    public class FEN1
    {
        public string magic;
        public int sec_size;
        public int Unknown1;
        public int Unknown2;
        public int entry;

        public struct Element {
            public int tagflag;
            public int unknown2;
            public Element(int arg1 ,int arg2) 
            {
                this.tagflag = arg1;
                this.unknown2 = arg2;
            }
        }

        List<Element> element;

        public void Read(BinaryReader br, FileStream fs)
        {
            element = new List<Element>();
            magic = CS.Byte2Char(br);
            sec_size = CS.Byte2Int(br);
            Unknown1 = CS.Byte2Int(br);
            Unknown2 = CS.Byte2Int(br);

            var pos1 = fs.Position;

            entry = CS.Byte2Int(br);

            Debugger.MSBF_Text(magic.ToString());
            Debugger.MSBF_Text(sec_size.ToString());
            Debugger.MSBF_Text(Unknown1.ToString());
            Debugger.MSBF_Text(Unknown2.ToString());
            Debugger.MSBF_Text(entry.ToString());
            Debugger.MSBF_Text("");
            for (int i = 0; i < entry; i++) {
                var unk1 = CS.Byte2Int(br);
                var unk2 = CS.Byte2Int(br);
                element.Add(new Element(unk1,unk2));

                Debugger.MSBF_Text(unk1.ToString());
                Debugger.MSBF_Text(unk2.ToString());
                Debugger.MSBF_Text("");
            }
            Debugger.MSBF_Text(fs.Position.ToString()+"__"+pos1.ToString());
            
            //タグの数を抜き出す
            var array = element.ToArray();
            var array2 = array.Where(num  => num.tagflag ==1 ).ToArray();
            var tag_flag_count = array2.Count();

            //タグ抜き出しデバッグ専用
            var tagcount = array2.Count().ToString();
            Debugger.MSBF_Text(tagcount);
            Debugger.MSBF_Text("");

            Debugger.HashTxt("//////////FEN1//////////");
            for (int j = 0; j < tag_flag_count; j++) {
                var txtnum = CS.Bytes2Byte(br);
                //Debugger.MSBF_Text(CS.Byte2Char(br,txtnum)) ;
                //Debugger.MSBF_Text(CS.Byte2Int(br).ToString());
                
                Debugger.HashTxt(CS.Byte2Char(br, txtnum));
                Debugger.HashTxt(CS.Byte2Int(br).ToString("X8"));
            
            }
            CS.MSBF_Padding(br,fs.Position);
        }
    }
}
