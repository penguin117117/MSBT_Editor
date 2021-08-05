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
    public class FEN1 : objects
    {
        private static string magic;
        private static int sec_size;
        private static int unknown1;
        private static int unknown2;
        private static int entry;

        private static List<Int16> EventNo;
        private static List<Int16> BranchNo;
        private static List<Int16> BranchNo2;
        private static List<List<Int16>> BranchNoItems;
        private static List<int> AllJumpAddres;

        public string Magic
        {
            set => magic = value;
            get => magic;
        }

        public int Section_Size
        {
            set => sec_size = value;
            get => sec_size;
        }

        public int Unknown1
        {
            set => unknown1 = value;
            get => unknown1;
        }

        public int Unknown2
        {
            set => unknown2 = value;
            get => unknown2;
        }

        public int Entry
        {
            set
            {
                //0x3Bは定数です。私の解析では変動なし。

                if (value == 0x3B)
                {
                    Console.WriteLine("FEN1エントリーサイズ0x3Bでした。");
                }
                else
                {
                    Console.WriteLine("FEN1エントリーサイズ0x3Bではありません。");
                }
                entry = value;

            }
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

        public struct ElementTag
        {
            public string tagname;
            public int tagnum;
            public ElementTag(string arg1, int arg2)
            {
                this.tagname = arg1;
                this.tagnum = arg2;
            }
        }

        public struct HashData_And_TagItem
        {
            public int tagflag;
            public string tagname;
            public int tagnum;
            public UInt32 Hash;
            public HashData_And_TagItem(string arg1, int arg2, UInt32 arg3, int arg4)
            {
                this.tagflag = arg4;
                this.tagname = arg1;
                this.tagnum = arg2;
                this.Hash = arg3;
            }
        }

        public struct Hash_And_Unknown
        {
            public int tagflag;
            public UInt32 Hash;
            public Hash_And_Unknown(int arg1, UInt32 arg2)
            {
                this.tagflag = arg1;
                this.Hash = arg2;
            }
        }

        private static List<Element> item1;
        private static List<ElementTag> item2;

        private static List<HashData_And_TagItem> HashData;
        private static List<Hash_And_Unknown> HashData_Read;



        public List<Element> Item1
        {
            set => item1 = value;
            get => item1;
        }

        public List<ElementTag> Item2
        {
            set => item2 = value;
            get => item2;
        }

        public List<Hash_And_Unknown> Hashes
        {
            set => HashData_Read = value;
            get => HashData_Read;
        }

        private static List<Element> EntryReader(BinaryReader br, int EntryNum)
        {
            List<Element> EntryReadItem = new List<Element>();
            int unk1, unk2;

            for (int i = 0; i < EntryNum; i++)
            {
                unk1 = CS.Byte2Int(br);
                unk2 = CS.Byte2Int(br);
                EntryReadItem.Add(new Element(unk1, unk2));
                //0以下のtagflagを排除
                var array = EntryReadItem.ToArray();
                var RemoveNullArray = array.Where((x, y) => x.tagflag > 0).ToArray();
                EntryReadItem = new List<Element>(RemoveNullArray);
            }

            return EntryReadItem;
        }

        private static List<ElementTag> EntryNameReader(FileStream fs ,BinaryReader br,int entry ,long pos_secEnd , List<Element> item1) {
            byte TargetNPCStringCount = 0;
            string TargetNPCName = "";
            int TargetNPCListIndex = 0;
            uint TargetNPCNameHash = 0;
            int tagcounter = 0;
            int tag_duplicate = 0;
            List<ElementTag> item2 = new List<ElementTag>();

            //エントリーネームを読み込む
            while (fs.Position < pos_secEnd)
            {
                TargetNPCStringCount = CS.Bytes2Byte(br);
                TargetNPCName = CS.Byte2Char(br, TargetNPCStringCount);
                TargetNPCListIndex = CS.Byte2Int(br);
                TargetNPCNameHash = CS.MSBT_Hash(TargetNPCName, entry);

                Hash_And_Unknown HAU = HashDataRead(item1, tagcounter, ref tag_duplicate, TargetNPCNameHash);
                HashData_Read.Add(HAU);
                list3.Items.Add(TargetNPCName);
                item2.Add(new ElementTag(TargetNPCName, TargetNPCListIndex));

                tagcounter++;

            }

            return item2;
        }

        private static Hash_And_Unknown HashDataRead(List<Element> Item, int tagcounter, ref int DuplicateCount, uint Hash)
        {
            int ItemIndex = 0;


            if (tagcounter == 0)
            {
                ItemIndex = tagcounter;
            }
            else if (HashData_Read[tagcounter - 1].Hash == Hash)
            {
                ItemIndex = tagcounter - (1 + DuplicateCount);
                DuplicateCount++;
            }
            else
            {
                ItemIndex = tagcounter - (DuplicateCount);
            }

            return new Hash_And_Unknown(Item[ItemIndex].tagflag, Hash);

        }

        public void Read(BinaryReader br, FileStream fs)
        {
            //宣言
            HashData_Read = new List<Hash_And_Unknown>();
            Item1 = new List<Element>();
            Item2 = new List<ElementTag>();

            //初期化
            long pos_SectionEnd       = 0;
            long pos_EntryOffset      = 0;
            

            //ヘッダー情報の読み取り
            Magic        = CS.Byte2Char(br);
            Section_Size = CS.Byte2Int(br);
            Unknown1     = CS.Byte2Int(br);
            Unknown2     = CS.Byte2Int(br);
            Entry        = CS.Byte2Int(br);

            //FEN1の位置系列の保持
            pos_EntryOffset = fs.Position - 4;
            pos_SectionEnd  = pos_EntryOffset + Section_Size;

            //エントリーの読み込み
            Item1 = EntryReader(br, Entry);

            //エントリーネームを読み込む
            Item2 = EntryNameReader(fs,br,Entry,pos_SectionEnd,Item1);

            //ツリーの読み込み
            if(chb1.Checked)TreeLoder(Item2);
            
            //パディング
            CS.MSBF_Padding(br, fs.Position);
        }

        public static void TreeLoder(List<ElementTag> Item2) {
            //インスタンス生成
            FLW2 flw2 = new FLW2();

            //ツリービューのアイテムを削除する。
            treeview1.Nodes.Clear();

            //ツリーの構成に必要なデータがあるか確認する
            if ((Item2.Count == 0) || (flw2.Item.Count == 0)) return;

            //ツリーを構成する
            foreach (var item in Item2.Select((Value, Index) => (Value, Index)))
            {
                BranchNoItems = new List<List<short>>();
                BranchNo = new List<short>();
                BranchNo2 = new List<short>();
                EventNo = new List<short>();
                AllJumpAddres = new List<int>();
                List<ElementTag> fen1newiteme = new List<ElementTag>(Item2);
                var flw2item = flw2.Item[item.Value.tagnum];

                //ツリービューのエントリーポイントを書き込む
                treeview1.Nodes.Add(item.Value.tagname);
                
                //エントリーポイントをサブノードに追加
                treeviewnodeadder(flw2item, treeview1.Nodes[item.Index]);
            }
        }


        public static void TreeView_Fllow_Type_Checker(short subfunc, short type, string subnodename, TreeNode tn)
        {
            FLW2 flw2 = new FLW2();
            var subnode_element = flw2.Item[subfunc];
            subnodename = Langage.FLW2_List_Langage(subnode_element.TypeCheck);

            switch (type)
            {
                case 1:
                    tn.Nodes.Add(subnodename);
                    var indexfllow1 = flw2.Item.IndexOf(flw2.Item[subfunc]);
                    tn.Nodes[0].Tag = flw2.Item[indexfllow1];

                    var AJA_Find = AllJumpAddres.IndexOf(flw2.Item[subfunc].Unknown4);
                    if (AJA_Find != -1) {
                        tn.Nodes[0].Text = subnodename + "  「重複/Dupe」";
                        break; 
                    }

                    if ((flw2.Item[subfunc].Unknown4 != indexfllow1) && (flw2.Item[subfunc].Unknown4.ToString("X4") != "FFFF")){
                        Treeview_Message_Node_Adder(flw2.Item[indexfllow1], tn.Nodes[0]);
                        AllJumpAddres.Add(flw2.Item[subfunc].Unknown4);
                    }
                    
                    break;
                case 2:
                    var subbranchfunc = flw2.Branch_No[flw2.Item[subfunc].Unknown5];
                    tn.Nodes.Add(subnodename + subbranchfunc.ToString("X"));
                    tn.Nodes[0].Tag = flw2.Item[subfunc];
                    var AJA_Find2 = AllJumpAddres.IndexOf(subbranchfunc);

                    if (AJA_Find2 != -1){
                        tn.Nodes[0].Text = subnodename + subbranchfunc.ToString("X") + "  「重複/Dupe」";
                        break;
                    }


                    BranchNo.Add(subbranchfunc);
                    Treeview_Branch_Node_Adder(flw2.Item[subfunc], tn.Nodes[0]);
                    AllJumpAddres.Add(subbranchfunc);

                    var subbranchfunc2 = flw2.Branch_No[flw2.Item[subfunc].Unknown5 + 1];
                    tn.Nodes.Add(subnodename + subbranchfunc2.ToString("X"));
                    tn.Nodes[1].Tag = flw2.Item[subfunc];
                    var AJA_Find3 = AllJumpAddres.IndexOf(subbranchfunc2);

                    if (AJA_Find3 != -1)
                    {
                        tn.Nodes[1].Text = subnodename + subbranchfunc2.ToString("X") + "  「重複/Dupe」";
                        break;
                    }

                    BranchNo.Add(subbranchfunc2);
                    Treeview_Branch_Node_Adder(flw2.Item[subfunc], tn.Nodes[1], 1);
                    AllJumpAddres.Add(subbranchfunc2);

                    break;
                case 3:
                    tn.Nodes.Add(subnodename);
                    var indexfllow3 = flw2.Item.IndexOf(flw2.Item[subfunc]);
                    tn.Nodes[0].Tag = flw2.Item[indexfllow3];
                    var AJA_Find4 = AllJumpAddres.IndexOf(flw2.Item[subfunc].Unknown3);

                    if (AJA_Find4 != -1){
                        tn.Nodes[0].Text = subnodename + "  「重複/Dupe」";
                        break;
                    }
                    if (EventNo.IndexOf(flw2.Item[indexfllow3].Unknown3) == -1){

                        if ((flw2.Item[subfunc].Unknown3 != indexfllow3) && (flw2.Item[subfunc].Unknown3.ToString("X4") != "FFFF")){
                            EventNo.Add(flw2.Item[indexfllow3].Unknown3);
                            Treeview_Event_Node_Adder(flw2.Item[indexfllow3], tn.Nodes[0]);
                            AllJumpAddres.Add(flw2.Item[indexfllow3].Unknown3);
                        }

                    }

                    
                    break;
            }

                
                
            
        }

        public static void treeviewnodeadder(FLW2.flw2_item flw2item, TreeNode tn, int brancno = 0)
        {
            tn.Tag = flw2item;
            //構文をサブノードに追加する
            Console.WriteLine("rootnode");
            FLW2 flw2 = new FLW2();
            var subfunc = flw2item.Unknown2;
            var subnode_element = flw2.Item[subfunc];
            var subnodename = Langage.FLW2_List_Langage(subnode_element.TypeCheck);
            TreeView_Fllow_Type_Checker(subfunc, subnode_element.TypeCheck, subnodename, tn);
            //return 0;

        }

        public static void Treeview_Message_Node_Adder(FLW2.flw2_item flw2item, TreeNode tn, int brancno = 0)
        {
            tn.Tag = flw2item;
            //構文をサブノードに追加する
            FLW2 flw2 = new FLW2();

            var subfunc = flw2item.Unknown4;
            var subnode_element = flw2.Item[subfunc];
            var subnodename = Langage.FLW2_List_Langage(subnode_element.TypeCheck);
            TreeView_Fllow_Type_Checker(subfunc, subnode_element.TypeCheck, subnodename, tn);
            
        }

        public static void Treeview_Branch_Node_Adder(FLW2.flw2_item flw2item, TreeNode tn, short brancno = 0)
        {
            tn.Tag = flw2item;
            //構文をサブノードに追加する
            FLW2 flw2 = new FLW2();
            short subfunc = flw2item.Unknown5;
            subfunc += brancno;
            var subbranchfunc = flw2.Branch_No[subfunc];
            var subnode_element = flw2.Item[subbranchfunc];
            var subnodename = Langage.FLW2_List_Langage(subnode_element.TypeCheck);
            TreeView_Fllow_Type_Checker(subbranchfunc, subnode_element.TypeCheck, subnodename, tn);
        }

        public static void Treeview_Event_Node_Adder(FLW2.flw2_item flw2item, TreeNode tn, int brancno = 0)
        {
            tn.Tag = flw2item;
            //構文をサブノードに追加する
            FLW2 flw2 = new FLW2();

            var subfunc = flw2item.Unknown3;
            //Console.WriteLine("" + subfunc.ToString("X"));
            var subnode_element = flw2.Item[subfunc];
            var subnodename = Langage.FLW2_List_Langage(subnode_element.TypeCheck);
            TreeView_Fllow_Type_Checker(subfunc, subnode_element.TypeCheck, subnodename, tn);
            
        }



        public int Write(BinaryWriter bw, FileStream fs)
        {
            var filesize = 0;

            HashData = new List<HashData_And_TagItem>();
            long pos_fen1_sec_size, pos_fen1_offset;
            FEN1 fen1 = new FEN1();

            //FEN1セクション
            bw.Write(Encoding.ASCII.GetBytes("FEN1"));

            //セクションサイズを後で追記するために位置を記憶させる
            pos_fen1_sec_size = fs.Position;

            //セクションサイズをいったん0(4byte)
            CS.Null_Writer_Int32(bw, 3);

            //FEN1オフセットを記憶する
            pos_fen1_offset = fs.Position;

            //エントリーサイズをバイナリに書き込む
            var entrysize = list3.Items.Count;
            bw.Write(CS.StringToBytes((0x3B).ToString("X8")));

            var offset01 = fs.Position;

            //一度0でファイルを埋める
            for (int i = 0; i < 0x3B; i++) {
                CS.Null_Writer_Int32(bw, 2);
            }

            var hash_duplicate_count = 0;

            foreach (var a in fen1.Item2.Select((Value, Index) => new { Value, Index }))
            {

                var hash = CS.MSBT_Hash(a.Value.tagname, 0x3B);

                if (a.Index == 0)
                {
                    HashData.Add(new HashData_And_TagItem(a.Value.tagname, a.Value.tagnum, hash, fen1.Hashes[a.Index].tagflag));
                    continue;
                }
                if (HashData[a.Index - (1 + hash_duplicate_count)].Hash == hash)
                {
                    HashData_And_TagItem newitem = new HashData_And_TagItem();
                    newitem = HashData[a.Index - (1 + hash_duplicate_count)];
                    newitem.tagflag = fen1.Hashes[a.Index - 1 + hash_duplicate_count].tagflag;
                    HashData[a.Index - (1 + hash_duplicate_count)] = newitem;

                    HashData.Add(new HashData_And_TagItem(a.Value.tagname, a.Value.tagnum, hash, fen1.Hashes[a.Index - (1 + hash_duplicate_count)].tagflag));

                    hash_duplicate_count++;
                    continue;
                }
                HashData.Add(new HashData_And_TagItem(a.Value.tagname, a.Value.tagnum, hash, fen1.Hashes[a.Index].tagflag));

            }

            //ハッシュ値を並び替えリスト番号も順番変更
            IOrderedEnumerable<HashData_And_TagItem> sorted = HashData.OrderBy(x => x.Hash);
            var hashdata = sorted.ToArray();

            var pos_unknown_and_offsetend = fs.Position;

            List<int> pos_fen1_offset_entry_name = new List<int>();

            foreach (var b in hashdata)
            {
                pos_fen1_offset_entry_name.Add((int)(fs.Position - pos_fen1_offset));
                bw.Write(CS.StringToBytes(((byte)(b.tagname.Length)).ToString("X2")));
                bw.Write(Encoding.GetEncoding(932).GetBytes((b.tagname)));
                bw.Write(CS.StringToBytes((b.tagnum).ToString("X8")));
            }

            var sectionend = fs.Position;
            fs.Seek(offset01, SeekOrigin.Begin);

            var hashcounter = 0;
            foreach (var c in hashdata.Select((Value, Index) => new { Value, Index }))
            {

                if (c.Index == 0)
                {
                    for (int k = 0; k < c.Value.Hash + 1; k++)
                    {
                        if (c.Value.Hash != k) bw.Write(CS.StringToBytes((0).ToString("X8")));
                        else bw.Write(CS.StringToBytes(c.Value.tagflag.ToString("X8")));

                        bw.Write(CS.StringToBytes(pos_fen1_offset_entry_name[c.Index].ToString("X8")));
                        hashcounter++;
                    }
                }
                else if (c.Value.Hash != hashdata[c.Index - 1].Hash)
                {
                    var taglpeet = (c.Value.Hash - hashdata[c.Index - 1].Hash);
                    for (int i = 0; i < taglpeet; i++)
                    {
                        if (taglpeet - 1 == i)
                        {
                            bw.Write(CS.StringToBytes(c.Value.tagflag.ToString("X8")));
                        }
                        else
                        {
                            bw.Write(CS.StringToBytes((0).ToString("X8")));
                        }

                        bw.Write(CS.StringToBytes(pos_fen1_offset_entry_name[c.Index].ToString("X8")));
                    }
                }
            }

            if (pos_unknown_and_offsetend > fs.Position)
            {
                var testfor = ((0x3B * 8 + (pos_fen1_offset + 4)) - (fs.Position)) / 8;
                for (long j = 0; j < testfor; j++)
                {
                    bw.Write(CS.StringToBytes((0).ToString("X8")));
                    bw.Write(CS.StringToBytes(((int)sectionend - pos_fen1_offset).ToString("X8")));
                }
            }

            //セクションサイズの書き込み
            fs.Seek(pos_fen1_sec_size, SeekOrigin.Begin);
            bw.Write(CS.StringToBytes(((int)sectionend - pos_fen1_offset).ToString("X8")));

            fs.Seek(sectionend, SeekOrigin.Begin);
            CS.Padding_Writer(bw, fs.Position);

            filesize = (int)(fs.Position);
            return filesize;
        }

        public static void FEN1_Item_Change(ListBox lb, TextBox tb)
        {
            //エラー対策
            if (lb.Items.Count == 0) return;
            if (tb.Text.Length != 8) return;

            //インデックス位置を保持
            var index = lb.SelectedIndex;

            //インデックス番号が-1の時0にする
            if (index == -1) index = 0;

            //インスタンス生成
            FEN1 fen1 = new FEN1();
            //FLW2.flw2_item item = flw2.Item[index];
            FEN1.Hash_And_Unknown item1 = fen1.Hashes[index];
            FEN1.ElementTag item2 = fen1.Item2[index];

            var numhex = Int32.Parse(tb.Text, System.Globalization.NumberStyles.HexNumber);

            switch (tb.Name.Substring(tb.Name.Length - 2, 2))
            {
                case "28":
                    item1.tagflag = numhex;
                    break;
                case "29":
                    item2.tagnum = numhex;
                    break;
            }
            fen1.Hashes[index] = item1;
            fen1.Item2[index] = item2;
        }
    }
}
