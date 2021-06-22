using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MSBT_Editor.FileSys;
using CS = MSBT_Editor.FileSys.Calculation_System;
using MSBT_Editor.Sectionsys;

namespace MSBT_Editor.MSBFsys
{
    public class MSBF_Header : MSBF_Data
    {
        public void Read(string path)
        {
            list2.Items.Clear();
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);


            //MSBTヘッダー情報
            Magic = CS.Byte2Char(br, 8);    //MsgFlwBn
            Endian = CS.Byte2Short(br);     //-257 = Big Endian
            Unknown1 = CS.Byte2Short(br);   //常に0
            Unknown2 = CS.Byte2Short(br);   //常に259
            Unknown3 = CS.Byte2Short(br);   //常に3
            Unknown4 = CS.Byte2Short(br);   //常に0
            File_Size = CS.Byte2Int(br);    //ファイルサイズ
            Unknown5 = CS.Byte2Short(br);   //以下10バイト常に0
            Unknown6 = CS.Byte2Short(br);
            Unknown7 = CS.Byte2Short(br);
            Unknown8 = CS.Byte2Short(br);
            Unknown9 = CS.Byte2Short(br);   //ここまで

            FLW2 flw2 = new FLW2();
            FEN1 fen1 = new FEN1();

            Debugger.MSBF_Text(Magic, true);
            Debugger.MSBF_Text(Endian.ToString());
            Debugger.MSBF_Text(Unknown1.ToString());
            Debugger.MSBF_Text(Unknown2.ToString());
            Debugger.MSBF_Text(Unknown3.ToString());
            Debugger.MSBF_Text(Unknown4.ToString());
            Debugger.MSBF_Text(File_Size.ToString());
            Debugger.MSBF_Text(Unknown5.ToString());
            Debugger.MSBF_Text(Unknown6.ToString());
            Debugger.MSBF_Text(Unknown7.ToString());
            Debugger.MSBF_Text(Unknown8.ToString());
            Debugger.MSBF_Text(Unknown9.ToString());

            flw2.Read(br,fs);
            fen1.Read(br,fs);

            fs.Close();
            br.Close();
        }
    }
}
