using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MSBT_Editor.FileSys;
using CS = MSBT_Editor.FileSys.Calculation_System;
using EN = System.Environment;
using MSBT_Editor.Sectionsys;


namespace MSBT_Editor.MSBTsys
{
    public class MSBT_Header : MSBT_Data
    {
        
        public void Read(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            //MSBTヘッダー情報
            Magic = CS.Byte2Char(br, 8);    //MsgStdBn
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

            //インスタンス生成
            LBL1 lbl1 = new LBL1();
            ATR1 atr1 = new ATR1();
            TXT2 txt2 = new TXT2();

            //各セクション読み取り
            lbl1.Read(br, fs);
            atr1.Read(br, fs);
            txt2.Read(br,fs);
            
            //データ記録
            MSBT_All_Data = new Data_List(new List<string>(TXT2.Text_Data) , new List<ATR1.AttributeData>(atr1.AttributeDataList));
            atr_nulldata = new List<string>();
            atr_nulldata = ATR1.SpecialTextList;

            if(MsbtListBox.Items.Count > 0)
            MsbtListBox.SelectedIndex = 0;

            //終了処理
            fs.Close();
            br.Close();
        }


        public void Write(string filepath) {
            Console.WriteLine("MSBT処理に入りました");

            FileStream fs = new FileStream(filepath, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            long MSBT_File_Size_pos;

            //MSBTヘッダー
            bw.Write(Encoding.ASCII.GetBytes("MsgStdBn"));
            bw.Write(CS.StringToBytes("FEFF"));
            bw.Write(CS.StringToBytes("0000"));
            bw.Write(CS.StringToBytes("0103"));
            bw.Write(CS.StringToBytes("0003"));
            bw.Write(CS.StringToBytes("0000"));

            //ファイルサイズを後で追記するために位置を記憶させる
            MSBT_File_Size_pos = fs.Position;

            //ファイルサイズ、最後に追記するのでいったんint型の0
            bw.Write(BitConverter.GetBytes(0x00000000));
            bw.Write(CS.StringToBytes("0000"));
            bw.Write(CS.StringToBytes("0000"));
            bw.Write(CS.StringToBytes("0000"));
            bw.Write(CS.StringToBytes("0000"));
            bw.Write(CS.StringToBytes("0000"));

            //インスタンス生成
            LBL1 lbl1 = new LBL1();
            ATR1 atr1 = new ATR1();
            TXT2 txt2 = new TXT2();

            //各セクションの書き込み
            lbl1.Write(bw,fs);
            atr1.Write(bw,fs);
            txt2.Write(bw,fs,MSBT_File_Size_pos);

            //終了処理
            fs.Close();
            bw.Close();
        }

    }
}
