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
    public class FLW2
    {
        public string magic;
        public int sec_size;
        public int Unknown1;
        public int Unknown2;
        public short entry;
        public short Unknown3;
        public int padding;

        public void Read(BinaryReader br, FileStream fs) {
            magic = CS.Byte2Char(br);
            sec_size = CS.Byte2Int(br);
            Unknown1 = CS.Byte2Int(br);
            Unknown2 = CS.Byte2Int(br);

            var pos1 = fs.Position;

            entry = CS.Byte2Short(br);
            Unknown3 = CS.Byte2Short(br);
            padding = CS.Byte2Int(br);

            Debugger.MSBF_Text(magic.ToString());
            Debugger.MSBF_Text(sec_size.ToString());
            Debugger.MSBF_Text(Unknown1.ToString());
            Debugger.MSBF_Text(Unknown2.ToString());
            Debugger.MSBF_Text(entry.ToString());
            Debugger.MSBF_Text(Unknown3.ToString());
            Debugger.MSBF_Text(padding.ToString());

            Debugger.MSBF_Text("");
            for (int i = 0; i< entry; i++) {
                for(int j = 0; j<6;j++)
                Debugger.MSBF_Text(CS.Byte2Short(br).ToString("X4"));
                Debugger.MSBF_Text("");
            }
            Debugger.MSBF_Text(fs.Position.ToString());

            for (int k = 0; k < (Unknown3); k++) {
                Debugger.MSBF_Text(CS.Byte2Short(br).ToString()); 
            }

            CS.MSBF_Padding(br,fs.Position);
        }

    }
}
