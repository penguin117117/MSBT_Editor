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
        private static string s_magic;
        private static int s_sectionSize;
        private static int s_unknown1;
        private static int s_unknown2;
        private static int s_entrySize;
        private static long s_positionBaseAddress;
        private static long s_positionLastEntrySection;

        public static List<long> BeginEntryAdressList;
        public static List<int> HashSkipList;
        public static List<int> NameOffsetList;
        public static List<string> NameList;
        public List<int> MsbtListBoxIndexList;

        public struct Hash_Data
        {
            public UInt32 Hash;
            public long MsbtListBoxIndex;
            public Hash_Data(UInt32 hash, long msbtListBoxIndex)
            {
                this.Hash = hash;
                this.MsbtListBoxIndex = msbtListBoxIndex;
            }
        }

        public struct LBL_1st_Item {
            public int HashSkipCounter;
            public string ListName;
            public UInt32 Hash;
            public LBL_1st_Item(int hashSkipCounter,string listName ,UInt32 hash) {
                this.HashSkipCounter = hashSkipCounter;
                this.ListName = listName;
                this.Hash = hash;
            }
        }

        public List<LBL_1st_Item> Item_1st;
        public List<Hash_Data> HashData;

        public string Magic {
            set => s_magic = value;
            get => s_magic;
        }

        public int SectionSize {
            set => s_sectionSize = value;
            get => s_sectionSize;
        }

        public int Unknown1 {
            set => s_unknown1 = value;
            get => s_unknown1;
        }

        public int Unknown2 {
            set => s_unknown2 = value;
            get => s_unknown2;
        }

        public int EntrySize {
            set {
                if (value != 101 || value != 102){
                    s_entrySize = 101;
                }
                else {
                    s_entrySize = 101;
                }
            }
            get => s_entrySize;
        }

        /// <summary>
        /// <para>
        /// LBL1セクションのデータを読み込んで変数と構造体リストに保存します。<br/>
        /// Read the data in the LBL1 section and save it in variables and in the structure list.
        /// </para>
        /// </summary>
        /// <param name="br"></param>
        /// <param name="fs"></param>
        public void Read(BinaryReader br , FileStream fs) {

            MsbtListBox.Items.Clear();
            
            BeginEntryAdressList = new List<long>();
            HashSkipList         = new List<int>();
            NameOffsetList       = new List<int>();
            NameList             = new List<string>();
            MsbtListBoxIndexList = new List<int>();

            //ヘッダー部読み取り header section reading
            Magic       = CS.Byte2Char(br);
            SectionSize = CS.Byte2Int(br);
            Unknown1    = CS.Byte2Int(br);
            Unknown2    = CS.Byte2Int(br);
            EntrySize   = CS.Byte2Int(br);

            //LBL1のベースアドレスを記憶 Stores the base address of LBL1
            s_positionBaseAddress = fs.Position - 4;
            ReadEntrySection(fs,br);

            s_positionLastEntrySection = fs.Position;

            //配列を用意エントリー数を超える場合があるので最大値を0xFFにしています
            //The maximum value is set to 0xFF because the number of entries in the array may be exceeded.
            string[] NameArray = new string[0xFF];
            ReadLabelSection(fs,br,ref NameArray);

            var Tmp = MsbtListBoxIndexList;
            IOrderedEnumerable<int> MsbtListBoxIndexSorted = Tmp.OrderBy(x => x);

            for (int l = 0; l < MsbtListBoxIndexList.Count; l++) 
                MsbtListBox.Items.Add(NameArray[l]);

            CS.Padding(br,fs.Position);
        }

        /// <summary>
        /// LBLのスキップ数(数値が違っても修復します)とオフセット値を読み込む<br/>
        /// Read the number of skips in LBL (it will be repaired even if the numbers are different) and the offset value.
        /// </summary>
        /// <param name="fs"></param>
        /// <param name="br"></param>
        private void ReadEntrySection(FileStream fs , BinaryReader br) {
            
            for (int i = 0; i < EntrySize; i++)
            {

                BeginEntryAdressList.Add(fs.Position);

                var SkipIntNum = CS.Byte2Int(br);
                var NameOffsetIntNum = CS.Byte2Int(br);

                HashSkipList.Add(SkipIntNum);
                NameOffsetList.Add(NameOffsetIntNum);

                if (i == 0) continue;

                var BeforeNameOffsetIndex = NameOffsetList.Count() - 2;
                var NowNameOffsetIndex = NameOffsetList.Count() - 1;

                //同じオフセット値の場合ひとつ前のリストを削除する
                //If the offset value is the same, the previous list will be deleted.
                if (NameOffsetList[BeforeNameOffsetIndex] == NameOffsetList[NowNameOffsetIndex])
                {
                    BeginEntryAdressList.RemoveRange(BeforeNameOffsetIndex, 1);
                    HashSkipList.RemoveRange(BeforeNameOffsetIndex, 1);
                    NameOffsetList.RemoveRange(BeforeNameOffsetIndex, 1);
                    continue;
                }
            }
        }
        /// <summary>
        /// ラベルセクションを読み取ります。<br/>
        /// Read the label section
        /// </summary>
        /// <param name="fs"></param>
        /// <param name="br"></param>
        /// <param name="NameArray"></param>
        private void ReadLabelSection(FileStream fs , BinaryReader br , ref string[] NameArray) {

            var PositionNameSectionBytesSize = (s_positionBaseAddress + s_sectionSize) - s_positionLastEntrySection;

            //LBL1セクションのラベル名セクションの処理
            for (long k = 0; k < PositionNameSectionBytesSize; k++)
            {
                var PositionFirstLabelName = fs.Position;
                var LabelStringSize        = CS.Bytes2Byte(br);
                var LabelString            = CS.Byte2Char(br, LabelStringSize);
                var LabelMsbtListBoxIndex  = CS.Byte2Int(br);

                NameArray[LabelMsbtListBoxIndex] = LabelString;

                var NameOffset          = (int)(PositionFirstLabelName - s_positionBaseAddress);
                var FindNameOffsetIndex = NameOffsetList.IndexOf(NameOffset);

                if (-1 != FindNameOffsetIndex)
                    NameList.Add(LabelString);

                MsbtListBoxIndexList.Add(LabelMsbtListBoxIndex);

                //文字数のカウント分と末尾のInt32(4byte)分進める
                k += LabelStringSize;
                k += 4;
            }
        }
        /// <summary>
        /// LBL1セクションのデータを書き込みます
        /// </summary>
        /// <param name="bw"></param>
        /// <param name="fs"></param>
        public void Write(BinaryWriter bw , FileStream fs) {

            List<long> PositionIndividualLabelTop = new List<long>();
            HashData = new List<Hash_Data>();

            var PositionEntrySizeAddress = fs.Position + 4;

            if (EntrySize <= 101) EntrySize = 101;

            //ヘッダー情報の書き込み
            CS.String_Writer(bw ,"LBL1");
            CS.Null_Writer_Int32(bw, 3);
            CS.StringToBytesWriter(bw,(EntrySize).ToString("X8"));

            s_positionBaseAddress = fs.Position - 4;

            //データセクションを一時的に書き込み
            TemporarilyWriteNullData(bw);

            HashData = LabelHashAndListIndexGet();
            var HashDataArray = LabelHashAndListIndexSortToArray(HashData);

            //ラベルセクションを書き込む
            LabelSectionWriter(fs,bw,HashDataArray,ref PositionIndividualLabelTop);
            var PositionLabelLastAddress = fs.Position;

            CS.Padding_Writer(bw, fs.Position);
            var PositionLBL1LastAddress = fs.Position;

            //ファイルストリームの位置をデータセクションの開始位置へ変更
            fs.Seek(s_positionBaseAddress + 4, SeekOrigin.Begin);

            //データセクションに計算したデータを書き込む
            DataSectionAllWriter(bw,HashDataArray,PositionIndividualLabelTop, PositionLabelLastAddress);

            SectionSize = (int)(PositionLabelLastAddress - s_positionBaseAddress);
            fs.Seek(PositionEntrySizeAddress, SeekOrigin.Begin);
            CS.StringToBytesWriter(bw,SectionSize.ToString("X8"));
            fs.Seek(PositionLBL1LastAddress, SeekOrigin.Begin);
        }
        /// <summary>
        /// データセクションのデータを計算して全て書き込みます
        /// </summary>
        /// <param name="bw"></param>
        /// <param name="HashDataArray"></param>
        /// <param name="PositionIndividualLabelTop"></param>
        /// <param name="PositionLabelLastAddress"></param>
        private void DataSectionAllWriter(BinaryWriter bw , Hash_Data[] HashDataArray,List<long> PositionIndividualLabelTop,long PositionLabelLastAddress/*, ref int ActualDataCount*/) {
            var ActualDataCount = 0;
            for (int i = 0; i < HashData.Count(); i++)
            {
                var NowHash = HashDataArray[i].Hash;
                var SkipDataCount = HashDataArray.Where(a => a.Hash.Equals(NowHash)).Count();
                var LabelOffset = (int)PositionIndividualLabelTop[i] - 0x30;

                //初回のみの処理
                if (i == 0)
                {
                    DataSectionActualDataWriter(bw, NowHash, SkipDataCount, LabelOffset, ref ActualDataCount, true);
                    continue;
                }

                var BeforeHash = HashDataArray[i - 1].Hash;
                var SubtractNowFromBeforeHash = NowHash - BeforeHash;

                //同じハッシュ値の処理
                if (SubtractNowFromBeforeHash == 0)
                {
                    if ((HashData.Count() - 1) != i)
                    {
                        if (HashDataArray[i + 1].Hash - NowHash == 0)
                            continue;
                    }
                }

                //初回以外かつ同じハッシュ値以外
                DataSectionActualDataWriter(bw, SubtractNowFromBeforeHash, SkipDataCount, LabelOffset, ref ActualDataCount, false);
            }
            DataSectionInsufficientDataWriter(bw, PositionLabelLastAddress, ActualDataCount);
        }

        /// <summary>
        /// データセクションの不足データをパディングまでのオフセットで埋めます。
        /// </summary>
        /// <param name="bw"></param>
        /// <param name="PositionLabelLastAddress"></param>
        /// <param name="ActualDataCount"></param>
        private void DataSectionInsufficientDataWriter(BinaryWriter bw,long PositionLabelLastAddress,int ActualDataCount) {
            if (ActualDataCount < EntrySize)
            {

                var NumberOfInsufficientData = EntrySize - ActualDataCount;

                for (int a = 0; a < NumberOfInsufficientData; a++)
                {
                    bw.Write(BitConverter.GetBytes(0x00000000));
                    bw.Write(CS.StringToInt32_byte((PositionLabelLastAddress - 0x30).ToString("X8")));
                }
            }
        }
        /// <summary>
        /// 実際のデータをデータセクションに書き込みます。
        /// </summary>
        /// <param name="bw"></param>
        /// <param name="hash"></param>
        /// <param name="SkipDataCount"></param>
        /// <param name="LabelOffset"></param>
        /// <param name="ActualDataCount"></param>
        /// <param name="isTop"></param>
        private void DataSectionActualDataWriter(BinaryWriter bw , uint hash , int SkipDataCount , int LabelOffset ,ref int ActualDataCount , bool isTop) {
            var LoopCountChange = 0;
            var BranchDataChenge = -1;
            if (isTop) {
                LoopCountChange = 1;
                BranchDataChenge = 0;
            }
            for (int j = 0; j < (hash + LoopCountChange); j++)
            {

                if (j == hash + BranchDataChenge)
                {
                    CS.StringToBytesWriter(bw, (SkipDataCount).ToString("X8"));
                }
                else
                {
                    CS.Null_Writer_Int32(bw);
                }
                CS.StringToBytesWriter(bw, LabelOffset.ToString("X8"));
                ActualDataCount++;
            }
        }

        /// <summary>
        /// nullSetNumで指定した数値分のInt32NullデータをLBL1のEntriesの数値分繰り返し書き込みます。
        /// </summary>
        /// <param name="bw"></param>
        /// <param name="nullSetNum"></param>
        private void TemporarilyWriteNullData(BinaryWriter bw , int nullSetNum = 2) {
            //ラベルindex(不明)とラベルオフセットを空白で埋める
            for (int i = 0; i < EntrySize; i++)
                CS.Null_Writer_Int32(bw, nullSetNum);
        }

        /// <summary>
        /// ラベルとMSBTリストのインデックス値のリストデータを取得します
        /// </summary>
        /// <returns></returns>
        private List<Hash_Data> LabelHashAndListIndexGet() {
            //ラベルのエリアの値を書き込む
            List<Hash_Data> TemporarilyData = new List<Hash_Data>();
            int itemcount = 0;
            foreach (var item in MsbtListBox.Items)
            {

                var LabelName = item.ToString();
                //var strnum = (byte)str.Count();
                //ハッシュ値とリスト番号をリストへ
                var LabelHash = CS.MSBT_Hash(LabelName, EntrySize);
                TemporarilyData.Add(new Hash_Data(LabelHash, itemcount));
                itemcount++;
            }
            return TemporarilyData;
        }
        /// <summary>
        /// ハッシュデータとMSBTリストのインデックスのリストデータをハッシュ値順に並べ替えます。
        /// </summary>
        /// <param name="HashData"></param>
        /// <returns></returns>
        private Hash_Data[] LabelHashAndListIndexSortToArray(List<Hash_Data> HashData) {
            IOrderedEnumerable<Hash_Data> HashDataSorted
                    = HashData.OrderBy(x => x.Hash);
            return HashDataSorted.ToArray();
        }
        /// <summary>
        /// ラベルセクションをファイルに書き込みます
        /// </summary>
        /// <param name="fs"></param>
        /// <param name="bw"></param>
        /// <param name="HashDataArray"></param>
        /// <param name="PositionIndividualLabelTop"></param>
        private void LabelSectionWriter(FileStream fs , BinaryWriter bw , Hash_Data[] HashDataArray , ref List<long> PositionIndividualLabelTop) {
            int hashcount = 0;
            foreach (var hashdatsorted in HashDataArray)
            {
                var index = hashdatsorted.MsbtListBoxIndex;
                MsbtListBox.SelectedIndex = (int)index;
                PositionIndividualLabelTop.Add(fs.Position);
                var LabelName = MsbtListBox.Text;
                var LabelStringLength = (byte)LabelName.Count();

                CS.StringToBytesWriter(bw, LabelStringLength.ToString("X2"));
                CS.String_Writer(bw, LabelName, "Shift_JIS");
                CS.StringToBytesWriter(bw, hashdatsorted.MsbtListBoxIndex.ToString("X8"));
                hashcount++;
            }
        }
    }

}
