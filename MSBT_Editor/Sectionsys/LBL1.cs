using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Diagnostics;
using MSBT_Editor.FileSys;
using CS = MSBT_Editor.FileSys.Calculation_System;
using MSBT_Editor.MSBTsys;
using MSBT_Editor.Formsys;
namespace MSBT_Editor.Sectionsys
{
    public class LBL1:objects
    {
        //ヘッダー情報
        private static string magic;
        private static int sec_size;
        private static int unknown1;
        private static int unknown2;
        private static int entries;

        private static long offset;
        private static long offset2;

        public static List<long> unknownpos;

        public static List<int> unknown;
        public static List<int> name_offset;
        public static List<string> list_name;
        public List<int> list_no;

        public struct Hash_Data
        {
            public UInt32 hash;
            public long listindex;
            public Hash_Data(UInt32 arg1, long arg2)
            {
                this.hash = arg1;
                this.listindex = arg2;
            }

        }

        public struct LBL_1st_Item {
            public int HashSkipCounter;
            public string ListName;
            public UInt32 hash;
            public LBL_1st_Item(int arg1,string arg2 ,UInt32 arg3) {
                this.HashSkipCounter = arg1;
                this.ListName = arg2;
                this.hash = arg3;
                
            }
        
        }

        public List<LBL_1st_Item> Item_1st;

        public List<Hash_Data> HashData;

        public string Magic {
            set => magic = value;
            get => magic;
        }

        public int Sec_Size {
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
            set {
                if (value != 101 || value != 102)
                {
                    entries = 101;
                    
                }
                else {
                    entries = 101;
                }
            }
            get => entries;
        }

        public void Read(BinaryReader br , FileStream fs) {

            //リストボックスのアイテムをすべて削除
            list1.Items.Clear();

            //リスト初期化
            unknownpos = new List<long>();
            unknown     = new List<int>();
            name_offset = new List<int>();
            list_name = new List<string>();
            list_no = new List<int>();

            //ヘッダー部読み取り
            Magic    = CS.Byte2Char(br);
            Sec_Size = CS.Byte2Int(br);
            Unknown1 = CS.Byte2Int(br);
            Unknown2 = CS.Byte2Int(br);

            //LBL1のオフセット位置を記憶
            offset = fs.Position;

            //エントリーの数101、例外あり
            Entries  = CS.Byte2Int(br);
            txtb14.Text = Entries.ToString();

            for (int i = 0; i<entries; i++){
                unknownpos.Add(fs.Position);
                var unk = CS.Byte2Int(br);
                var n_set = CS.Byte2Int(br);
                unknown.Add(unk);
                name_offset.Add(n_set);
                if (i != 0)
                {
                    var counter = name_offset.Count();
                    if (name_offset[counter - 2] == name_offset[counter-1])
                    {
                        unknownpos.RemoveRange(unknownpos.Count() - 2, 1);
                        unknown.RemoveRange(unknown.Count()-2,1);
                        name_offset.RemoveRange(name_offset.Count() - 2, 1);
                        continue;
                    }
                }
            }

            offset2 = fs.Position;

            string[] test = new string[/*entries+1*/0xFF];
            int testcount = 0;
            Debugger.HashTxt("//////////ハッシュ値順//////////", true);
            for (long k = 0; k < (offset+sec_size)-offset2; k++) {

                var lblfspos = fs.Position;
                byte num = CS.Bytes2Byte(br);
                string list_item = CS.Byte2Char(br, num);
                var listNo = CS.Byte2Int(br);
                Debugger.HashTxt("ListName_ " + list_item);
                Debugger.HashTxt("ListNo_ " + listNo.ToString("X"));
                Debugger.HashTxt("");

                test[listNo] = list_item;

                Console.WriteLine((int)(lblfspos - offset));
                var nameoffindex = name_offset.IndexOf((int)(lblfspos-offset));
                if (-1 != nameoffindex)list_name.Add(list_item) ;

                //デバッグ用ハッシュ値を表示できます
                Console.WriteLine("ハッシュ値 " + CS.MSBT_Hash(list_item, entries).ToString("X8"));
                Debugger.HashTxt("ハッシュ値 " + CS.MSBT_Hash(list_item, entries).ToString("X8"));
                Debugger.HashTxt(list_item);
                Debugger.HashTxt("リスト番号" + listNo.ToString("X8")) ;
                Debugger.HashTxt("");
                list_no.Add(listNo);
                k += num;
                k += 4;
                testcount++;
            }

            Debugger.HashTxt("リストかうんと" + testcount.ToString("X"));
            Debugger.HashTxt("//////////リスト順//////////");

            //無意味かもしれない？(今後バグが発生しなければ削除予定)
            //if ((offset + sec_size) - offset2 < entries)
            //{
            //    var paddingpos = Entries - ((offset + sec_size) - offset2);
            //    for (int a = 0; a < paddingpos; a++) fs.Position += 8;
            //}
            var lino = list_no.ToList();
            IOrderedEnumerable<int> list_No_sorted = lino.OrderBy(x => x);
            var lino2 = list_No_sorted.ToArray();
            for (int l = 0; l < testcount; l++) {
                list1.Items.Add(test[l]);
                Debugger.HashTxt("リスト番号"+lino2[l].ToString("X8"));
                Debugger.HashTxt(test[l]);
                Debugger.HashTxt("ハッシュ値 " + CS.MSBT_Hash(test[l], entries).ToString("X8"));
                Debugger.HashTxt("");
            } 
            CS.Padding(br,fs.Position);
        }

        public void Write(BinaryWriter bw , FileStream fs) {
            int itemcount = 0;
            List<long> labelpos = new List<long>();
            //HashData = new List<Hash_Data>();
            //if(HashData == null)
            HashData = new List<Hash_Data>();

            //LBL1セクション
            bw.Write(Encoding.ASCII.GetBytes("LBL1"));

            //セクションサイズを後で追記するために位置を記憶させる
            offset = fs.Position;

            //セクションサイズをいったん0(4byte)
            CS.Null_Writer_Int32(bw, 3);

            //ラベルオフセットを記憶する
            offset2 = fs.Position;

            //エントリーサイズをバイナリに書き込む
            if (Entries<=101) Entries = 101;
            bw.Write(CS.StringToBytes((Entries).ToString("X8")));
            //CS.Null_Writer_Int32(bw);

            //ラベルindex(不明)とラベルオフセットを空白で埋める
            for (int i = 0; i < Entries; i++)
            {
                CS.Null_Writer_Int32(bw, 2);
            }

            //ラベルのエリアの値を書き込む
            
            foreach (var item in list1.Items)
            {
                var str = item.ToString();
                var strnum = (byte)str.Count();
                //ハッシュ値とリスト番号をリストへ
                HashData.Add(new Hash_Data(CS.MSBT_Hash(str, Entries), itemcount));
                Debugger.HashTxt(HashData[itemcount].hash.ToString("X")+"そーとまえ"+ HashData[itemcount].listindex.ToString("X"));
                itemcount++;
            }

            // ScenarioName_RedBlueExGalaxy3
            //ScenarioName_RedBlueExGalaxy3
            //ハッシュ値を並び替えリスト番号も順番変更
            IOrderedEnumerable<Hash_Data> sorted = HashData.OrderBy(x => x.hash);
            var hashdata = sorted.ToArray();

            //for (int i = 0; i < HashData.Count; i++)
            //{
            //    HashData[i] = new Hash_Data(hashdata2[i].hash, i);
            //    Console.WriteLine(HashData[i].hash + "___" + HashData[i].listindex);
            //}


            int hashcount = 0;
            foreach (var hashdatsorted in hashdata) {
                var index = hashdatsorted.listindex;
                list1.SelectedIndex = (int)index/*(int)HashData[hashcount].listindex*/;
                labelpos.Add(fs.Position);
                var str = list1.Text;
                var strnum = (byte)str.Count();

                bw.Write(CS.StringToBytes(strnum.ToString("X2")));
                bw.Write(Encoding.GetEncoding(932).GetBytes(str));
                bw.Write(CS.StringToBytes(hashdatsorted.listindex.ToString("X8")));
                //Console.WriteLine("リストインデックス");
                Debugger.HashTxt("_" + hashdatsorted.hash.ToString("X8") +"_"+hashdatsorted.listindex.ToString("X"));
                hashcount++;
            }

            var lblend = fs.Position;

            //パディングの書き込み
            CS.Padding_Writer(bw, fs.Position);
            var fspadend1 = fs.Position;

            

            //同じハッシュ値をチェックする数値
            var samecheck = 0;

            //ファイルストリームの位置を変更
            fs.Seek(offset2 + 4, SeekOrigin.Begin);

            

            var entry_hash_counter = 0;



            for (int i = 0; i < sorted.Count(); i++)
            {

                //初回のみの処理
                if (i == 0)
                {
                    for (int j = 0; j < (hashdata[i].hash)+1; j++)
                    {
                        if (j == (hashdata[i].hash))
                        {
                            bw.Write(CS.StringToInt32_byte((unknown[i]).ToString("X8")));
                        }
                        else
                        {
                            CS.Null_Writer_Int32(bw);
                        }
                        bw.Write(CS.StringToInt32_byte(((int)labelpos[i] - 0x30).ToString("X8")));
                        entry_hash_counter++;
                    }
                    
                    continue;
                }


                //同じハッシュ値の処理
                if ((hashdata[i].hash) - (hashdata[i - 1].hash) == 0)
                {
                    samecheck++;
                    entry_hash_counter++;
                    continue;
                }

                for (int j = 0; j < (hashdata[i].hash) - (hashdata[i - 1].hash ); j++)
                {

                    if (j == (hashdata[i].hash) - (hashdata[i - 1].hash)-1)
                    {
                        bw.Write(CS.StringToInt32_byte((unknown[i - samecheck]).ToString("X8")));
                        Debugger.HashTxt(unknown[i - samecheck].ToString());
                        //ScenarioName_RedBlueExGalaxy3
                    }
                    else
                    {
                        CS.Null_Writer_Int32(bw);
                    }
                    bw.Write(CS.StringToInt32_byte(((int)labelpos[i] - 0x30).ToString("X8")));
                    entry_hash_counter++;
                }
            }
            if (entry_hash_counter   < Entries) {
                var remaining_offset = Entries - entry_hash_counter;
                var padding_point = (int)(fs.Position + (remaining_offset*8) -0x30);

                for (int a = 0; a<remaining_offset; a++) {
                    bw.Write(BitConverter.GetBytes(0x00000000));
                    bw.Write(CS.StringToInt32_byte((lblend-0x30).ToString("X8")));
                }
            
            }
            
            var secsize = (int)(lblend - offset2);
            fs.Seek(offset, SeekOrigin.Begin);
            bw.Write(CS.StringToBytes(secsize.ToString("X8")));
            fs.Seek(fspadend1, SeekOrigin.Begin);
        }
       
    }

}
