using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MSBT_Editor.FileSys;
using CS = MSBT_Editor.FileSys.Calculation_System;
using MSBT_Editor.MSBTsys;
using MSBT_Editor.Formsys;
namespace MSBT_Editor.Sectionsys
{
    class TXT2:objects
    {
        public string magic;
        public int sec_size;
        public int unknown1;
        public int unknown2;
        public static int entries;
        public List<long> txt_pos;
        public static List<string> Text_Data;
        

        public void Read(BinaryReader br,FileStream fs ) {
            txt_pos = new List<long>();
            Text_Data = new List<string>();

            magic = CS.Byte2Char(br);
            sec_size = CS.Byte2Int(br);
            unknown1 = CS.Byte2Int(br);
            unknown2 = CS.Byte2Int(br);
            entries = CS.Byte2Int(br);

            var offset = fs.Position;
            for (int i = 0; i < entries; i++){
                txt_pos.Add((int)offset + CS.Byte2Int(br));
            }

            var offset2 = fs.Position;
            for(int j = 0; j<entries; j++) {
                fs.Position = txt_pos[j]-4;
                Text_Data.Add(CS.Byte2JIS(br, fs));
            }
        }

        public void Write(BinaryWriter bw , FileStream fs, long fileend_pos) {
            bw.Write(Encoding.ASCII.GetBytes("TXT2"));
            var txt2_sec_pos = fs.Position;
            CS.Null_Writer_Int32(bw, 3);
            var txt2_offset = fs.Position;
            bw.Write(CS.StringToInt32_byte((list1.Items.Count).ToString("X8")));

            var txt2_txt_offset_pos = fs.Position;
            for (int i = 0; i < list1.Items.Count; i++)
                CS.Null_Writer_Int32(bw);

            List<int> txt2_offset_data = new List<int>();
            for (int j = 0; j < list1.Items.Count; j++)
            {
                list1.SelectedIndex = j;
                txt2_offset_data.Add((int)(fs.Position - txt2_offset));
                bw.Write(Encoding.GetEncoding("unicodeFFFE").GetBytes(CS.String2TagChecker(txtb1.Text)));
            }

            var txt2_txt_end = fs.Position;


            CS.Padding_Writer(bw, fs.Position);
            var msbt_end_pos = fs.Position;

            fs.Seek(txt2_sec_pos, SeekOrigin.Begin);
            bw.Write(CS.StringToInt32_byte(((int)(txt2_txt_end - txt2_offset)).ToString("X8")));

            fs.Seek(txt2_txt_offset_pos, SeekOrigin.Begin);
            for (int i = 0; i < list1.Items.Count; i++)
                bw.Write(CS.StringToInt32_byte(txt2_offset_data[i].ToString("X8")));

            fs.Seek(fileend_pos, SeekOrigin.Begin);
            bw.Write(CS.StringToInt32_byte(((int)msbt_end_pos).ToString("X8")));
        }
    }
}
