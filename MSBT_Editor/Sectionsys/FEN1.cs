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

        public struct HashData_And_TagItem {
            public int tagflag;
            public string tagname;
            public int tagnum;
            public UInt32 Hash;
            public HashData_And_TagItem(string arg1, int arg2 , UInt32 arg3 ,int arg4)
            {
                this.tagflag = arg4;
                this.tagname = arg1;
                this.tagnum = arg2;
                this.Hash = arg3;
            }
        }

        public struct Hash_And_Unknown {
            public int tagflag;
            public UInt32 Hash;
            public Hash_And_Unknown(int arg1 , UInt32 arg2) {
                this.tagflag = arg1;
                this.Hash = arg2;
            }
        }

        private static List<Element> item1;
        private static List<ElementTag> item2;

        private static List<HashData_And_TagItem> HashData;
        private static List<Hash_And_Unknown> HashData_Read;

        public List<Element> Item1 {
            set => item1 = value;
            get => item1;
        }

        public List<ElementTag> Item2 {
            set => item2 = value;
            get => item2;
        }

        public List<Hash_And_Unknown> Hashes {
            set => HashData_Read = value;
            get => HashData_Read;
        }

        public void Read(BinaryReader br, FileStream fs)
        {
            HashData_Read = new List<Hash_And_Unknown>();


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

                Debugger.MSBF_Text(unk1.ToString());
                Debugger.MSBF_Text(unk2.ToString());
                Debugger.MSBF_Text("");
            }
            Debugger.MSBF_Text(fs.Position.ToString()+"__"+pos1.ToString());
            txtb27.AppendText("unk1____"+item1.Count.ToString());
            //タグの数を抜き出す
            var array = Item1.ToArray();
            var array2 = array.Distinct().ToArray();

            //0以下のtagflagを排除
            var testarray = array.Where((x , y ) => x.tagflag > 0).ToArray();


            //var array2 = array.Where(num => num.tagflag > 0).ToArray();
            //var array2 = array.Distinct(num => num).ToArray();
            //IEnumerable<Element> array2 = array.Distinct();
            var tag_flag_count = array2.Count();

            //タグ抜き出しデバッグ専用
            var tagcount = array2.Count().ToString();
            Debugger.MSBF_Text(tagcount);
            Debugger.MSBF_Text("");

            //Item1 = new List<Element>(array2);
            Item1 = new List<Element>(testarray);


            //debug
            //foreach (var items in testarray) Debugger.MSBF_Text(items.tagflag.ToString());

            foreach (var items in testarray) Debugger.MSBF_Text(items.unknown2.ToString("X"));

            //var testcounter = 0;
            //foreach (var tes in Item1) {
            //    Debugger.MSBF_Text(tes.tagflag.ToString() + "_item1_" + tes.unknown2.ToString("X"));
            //    if (tes.tagflag == 0) testcounter++;
            //}
            //Debugger.MSBF_Text("item nums" + (Item1.Count - testcounter).ToString());
            //debugend


            Debugger.HashTxt("//////////FEN1//////////");
            bool tagread = true;
            int tagcounter = 0;
            int tag_duplicate = 0;

            treeview1.Nodes.Clear();
            while (true) {
                var txtnum = CS.Bytes2Byte(br);

                //パディングに当たった際にファイルストリームを1戻して処理を抜ける
                if (txtnum == 0xAB)
                {
                    fs.Position--;
                    break;
                }
                var targettagname = CS.Byte2Char(br, txtnum);
                var targettagnum = CS.Byte2Int(br);

                var hash = CS.MSBT_Hash(targettagname , 0x3B);
                if (tagcounter == 0)
                {
                    HashData_Read.Add(new Hash_And_Unknown(Item1[tagcounter].tagflag, hash));

                }
                else if (HashData_Read[tagcounter - 1].Hash == hash)
                {
                    HashData_Read.Add(new Hash_And_Unknown(Item1[tagcounter - (1 + tag_duplicate)].tagflag, hash));
                    tag_duplicate++;
                }
                else {
                    HashData_Read.Add(new Hash_And_Unknown(Item1[tagcounter - ( tag_duplicate)].tagflag, hash));
                }


                list3.Items.Add(targettagname);

                treeview1.Nodes.Add(targettagname);
                
                //TreeNode NodeRoot = new TreeNode(targettagname);
                //NodeRoot.Nodes.Add();


                Item2.Add(new ElementTag(targettagname, targettagnum));

                Debugger.HashTxt(targettagname);
                Debugger.HashTxt(targettagnum.ToString("X8"));

                tagcounter++;
            }

           
            FLW2 flw2 = new FLW2();

            var rootnodecounter = 0;
            var branchcounter = 0;
            Console.WriteLine(flw2.Branch_No.Count);

            var nodecount = treeview1.Nodes.Count;
            for (var i = 0;  i< nodecount; i++) {
                List<ElementTag> fen1newiteme = new List<ElementTag>(Item2);

                var rootnode_element = fen1newiteme.FirstOrDefault(x => x.tagname == treeview1.Nodes[rootnodecounter].Text);
                Console.WriteLine(treeview1.Nodes[rootnodecounter].Text);
                var flw2item = flw2.Item[rootnode_element.tagnum];
                
                //エントリーポイントをサブノードに追加
                var entrypointnum = flw2item.TypeCheck;
                var entrynodename = Langage.FLW2_List_Langage(entrypointnum);
                //treeview1.Nodes[rootnodecounter].Nodes.Add(subnodename);
                Console.WriteLine("entrys" + fen1newiteme.Count());
                branchcounter = treeviewnodeadder(flw2item, treeview1.Nodes[rootnodecounter]/*, branchcounter*/);
                //Treeview_Branch_Node_Adder(flw2item, treeview1.Nodes[rootnodecounter], branchcounter);
                treeview1.Nodes[rootnodecounter].Tag = flw2item;



                ////サブノードを追加するっ構文
                //bool nodeendflag = true;
                //var subnodeaddercounter = 0;
                //var branchcounter = 0;
                //var eventcounter = 0;
                //var nodeendnum = 1;
                //var nodeendcounter = 0;
                //while (nodeendflag) {
                //    if (subnodeaddercounter == 0) ;


                //    subnodeaddercounter++;
                //}

                rootnodecounter++;
            }
            //for (int j = 0; j < tag_flag_count; j++) {
            //    Console.WriteLine(j);
            //    var txtnum = CS.Bytes2Byte(br);

            //    //パディングに当たった際にファイルストリームを1戻して処理を抜ける
            //    if (txtnum == 0xAB) {
            //        fs.Position --;
            //        break; 
            //    }
            //    var targettagname = CS.Byte2Char(br, txtnum);
            //    var targettagnum = CS.Byte2Int(br);

            //    list3.Items.Add(targettagname);

            //    Item2.Add(new ElementTag(targettagname,targettagnum));

            //    Debugger.HashTxt(targettagname);
            //    Debugger.HashTxt(targettagnum.ToString("X8"));

            //}
            CS.MSBF_Padding(br,fs.Position);
        }

        public static void TreeView_Fllow_Type_Checker(short subfunc ,short type , string subnodename, TreeNode tn) {
            FLW2 flw2 = new FLW2();
            var subnode_element = flw2.Item[subfunc];
            subnodename = Langage.FLW2_List_Langage(subnode_element.TypeCheck);


            switch (type)
            {
                case 1:
                    tn.Nodes.Add(subnodename);
                    var indexfllow1 = flw2.Item.IndexOf(flw2.Item[subfunc]);
                    if ((flw2.Item[subfunc].Unknown4 != indexfllow1) && (flw2.Item[subfunc].Unknown4.ToString("X4") != "FFFF"))
                    {
                        Treeview_Message_Node_Adder(flw2.Item[indexfllow1], tn.Nodes[0]);
                        
                    }
                    tn.Nodes[0].Tag = flw2.Item[indexfllow1];
                    break;
                case 2:
                    //分岐1
                    var subbranchfunc = flw2.Branch_No[flw2.Item[subfunc].Unknown5];
                    tn.Nodes.Add(subnodename + subbranchfunc.ToString("X"));
                    Treeview_Branch_Node_Adder(flw2.Item[subfunc], tn.Nodes[0]);
                    //tn.Nodes[0].Tag = flw2.Item[subfunc];
                    //分岐2
                    var subbranchfunc2 = flw2.Branch_No[flw2.Item[subfunc].Unknown5 + 1];
                    tn.Nodes.Add(subnodename + subbranchfunc2.ToString("X"));
                    Treeview_Branch_Node_Adder(flw2.Item[subfunc], tn.Nodes[1], 1);
                    //tn.Nodes[1].Tag = flw2.Item[subfunc];

                    break;
                case 3:
                    tn.Nodes.Add(subnodename);
                    var indexfllow3 = flw2.Item.IndexOf(flw2.Item[subfunc]);
                    if ((flw2.Item[subfunc].Unknown3 != indexfllow3) && (flw2.Item[subfunc].Unknown3.ToString("X4") != "FFFF"))
                    {
                        //treeviewnodeadder(flw2.Item[subfunc], tn.Nodes[0]);
                        Treeview_Event_Node_Adder(flw2.Item[indexfllow3], tn.Nodes[0]);
                    }
                    tn.Nodes[0].Tag = flw2.Item[indexfllow3];
                    break;
            }
        }

        public static int treeviewnodeadder(FLW2.flw2_item flw2item, TreeNode tn , int brancno =0) {
            //構文をサブノードに追加する
            //tn.Tag = flw2item;
            Console.WriteLine("rootnode");
            FLW2 flw2 = new FLW2();
            var subfunc = flw2item.Unknown2;
            var subnode_element = flw2.Item[subfunc];
            var subnodename = Langage.FLW2_List_Langage(subnode_element.TypeCheck);
            TreeView_Fllow_Type_Checker(subfunc,subnode_element.TypeCheck,subnodename,tn);
            //switch (subnode_element.TypeCheck) {
            //    case 1:
            //        tn.Nodes.Add(subnodename);
            //        var indexfllow1 = flw2.Item.IndexOf(flw2.Item[subfunc]);
            //        if ((flw2.Item[subfunc].Unknown4 != indexfllow1)|| (flw2.Item[subfunc].Unknown4 != -1)) {
            //            treeviewnodeadder(flw2.Item[subfunc], tn.Nodes[0]);
            //        }

            //        break;
            //    case 2:
            //        //分岐1
            //        var subbranchfunc = flw2.Branch_No[flw2.Item[subfunc].Unknown5];
            //        tn.Nodes.Add(subnodename + subbranchfunc.ToString("X"));
            //        Treeview_Branch_Node_Adder(flw2.Item[subfunc], tn.Nodes[0]);

            //        //分岐2
            //        var subbranchfunc2 = flw2.Branch_No[flw2.Item[subfunc].Unknown5 + 1];
            //        tn.Nodes.Add(subnodename + subbranchfunc2.ToString("X"));
            //        Treeview_Branch_Node_Adder(flw2.Item[subfunc], tn.Nodes[1],1);
            //        break;
            //    case 3:
            //        tn.Nodes.Add(subnodename);
            //        var indexfllow3 = flw2.Item.IndexOf(flw2.Item[subfunc]);
            //        if ((flw2.Item[subfunc].Unknown4 != indexfllow3) || (flw2.Item[subfunc].Unknown4 != -1))
            //        {
            //            treeviewnodeadder(flw2.Item[subfunc], tn.Nodes[0]);
            //        }
            //        break;
            //}




            //if (subnode_element.TypeCheck == 2)
            //{
            //    //分岐1
            //    var subbranchfunc = flw2.Branch_No[flw2.Item[subfunc].Unknown5];
            //    tn.Nodes.Add(subnodename + subbranchfunc.ToString("X"));
            //    //treeviewnodeadder(flw2.Item[subfunc],tn.Nodes[0]);

            //    //分岐2
            //    var subbranchfunc2 = flw2.Branch_No[flw2.Item[subfunc].Unknown5 +1];
            //    tn.Nodes.Add(subnodename + subbranchfunc2.ToString("X"));
            //    //treeviewnodeadder(flw2.Item[subfunc], tn.Nodes[1]);

            //}
            //else {

            //    //if (flw2item.) { tn.Nodes.Add(subnodename); }
            //    tn.Nodes.Add(subnodename);

            //}

            return 0;

        }

        public static void Treeview_Message_Node_Adder(FLW2.flw2_item flw2item, TreeNode tn, int brancno = 0)
        {
            //tn.Tag = flw2item;
            Console.WriteLine("messagenode");
            //構文をサブノードに追加する
            FLW2 flw2 = new FLW2();

            var subfunc = flw2item.Unknown4;
            Console.WriteLine("" + subfunc.ToString("X"));
            var subnode_element = flw2.Item[subfunc];
            var subnodename = Langage.FLW2_List_Langage(subnode_element.TypeCheck);
            TreeView_Fllow_Type_Checker(subfunc, subnode_element.TypeCheck, subnodename, tn);
            //if (subnode_element.TypeCheck == 2)
            //{
            //    tn.Nodes.Add(subnodename + "true");
            //    tn.Nodes.Add(subnodename + "false");

            //}
            //else
            //{
            //    tn.Nodes.Add(subnodename);

            //}

        }

        public static void Treeview_Branch_Node_Adder(FLW2.flw2_item flw2item, TreeNode tn, short brancno = 0)
        {
            tn.Tag = flw2item;
            Console.WriteLine("branchnode");
            //構文をサブノードに追加する
            FLW2 flw2 = new FLW2();

            short subfunc = flw2item.Unknown5;
           
            subfunc += brancno;
            var subbranchfunc = flw2.Branch_No[subfunc];
            //var subbranchfunc2 = flw2.Branch_No[flw2.Item[subfunc].Unknown5];
            Console.WriteLine("分岐番号リストインデックス"+subfunc.ToString("X"));
            var subnode_element = flw2.Item[subbranchfunc];
            var subnodename = Langage.FLW2_List_Langage(subnode_element.TypeCheck);
            TreeView_Fllow_Type_Checker(subbranchfunc, subnode_element.TypeCheck, subnodename, tn);
            //if (subnode_element.TypeCheck == 2)
            //{
            //    tn.Nodes.Add(subnodename + "true");
            //    tn.Nodes.Add(subnodename + "false");

            //}
            //else
            //{
            //    tn.Nodes.Add(subnodename);

        }

        public static void Treeview_Event_Node_Adder(FLW2.flw2_item flw2item, TreeNode tn, int brancno = 0)
        {
            tn.Tag = flw2item;
            Console.WriteLine("eventnode");
            //構文をサブノードに追加する
            FLW2 flw2 = new FLW2();

            var subfunc = flw2item.Unknown3;
            Console.WriteLine("" + subfunc.ToString("X"));
            var subnode_element = flw2.Item[subfunc];
            var subnodename = Langage.FLW2_List_Langage(subnode_element.TypeCheck);
            TreeView_Fllow_Type_Checker(subfunc, subnode_element.TypeCheck, subnodename, tn);
            //if (subnode_element.TypeCheck == 2)
            //{
            //    tn.Nodes.Add(subnodename + "true");
            //    tn.Nodes.Add(subnodename + "false");

            //}
            //else
            //{
            //    tn.Nodes.Add(subnodename);

            //}

        }



        //public static void treeviewnodeadder2(FLW2.flw2_item flw2item, TreeNode tn)
        //{
        //    //構文をサブノードに追加する
        //    FLW2 flw2 = new FLW2();
        //    var subfunc = flw2item.Unknown2;
        //    var subnode_element = flw2.Item[subfunc];
        //    Console.WriteLine(subnode_element.TypeCheck);
        //    var subnodename = Langage.FLW2_List_Langage(subnode_element.TypeCheck);
        //    if (subnode_element.TypeCheck == 2)
        //    {
        //        tn.Nodes.Add(subnodename + "true");
        //        tn.Nodes.Add(subnodename + "false");


        //        treeviewnodeadder(flw2item, tn.Nodes[0]);
        //        treeviewnodeadder(flw2item, tn.Nodes[1]);
        //    }
        //    else
        //    {
        //        tn.Nodes.Add(subnodename);
        //    }
        //}

        public int Write(BinaryWriter bw, FileStream fs) {
            var filesize = 0;

            HashData = new List<HashData_And_TagItem>();
            long pos_fen1_sec_size , pos_fen1_offset;
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
                CS.Null_Writer_Int32(bw,2);
            }

            

            Console.WriteLine("HashData_add");
            var hash_duplicate_count = 0;


            //var array = Item1.ToArray();
            //var array2 = array.Distinct().ToArray();
            //var testarray = array.Where((x, y) => x.tagflag > 0).ToArray();

            foreach (var a in fen1.Item2.Select((Value, Index) => new { Value, Index })) {

                var hash = CS.MSBT_Hash(a.Value.tagname ,0x3B);
                //Console.WriteLine(hash.ToString("X"));

                Console.WriteLine("index     "+a.Index);
                if (a.Index == 0)
                {
                    HashData.Add(new HashData_And_TagItem(a.Value.tagname, a.Value.tagnum, hash, fen1.Hashes[a.Index].tagflag));
                    continue;
                }
                if (HashData[a.Index - (1 + hash_duplicate_count)].Hash == hash) {
                    HashData_And_TagItem newitem = new HashData_And_TagItem();
                    newitem = HashData[a.Index - (1 + hash_duplicate_count)];
                    //newitem.Hash = hash;
                    newitem.tagflag = fen1.Hashes[a.Index - 1+hash_duplicate_count].tagflag;
                    HashData[a.Index - (1 + hash_duplicate_count)] = newitem;

                    HashData.Add(new HashData_And_TagItem(a.Value.tagname, a.Value.tagnum, hash, fen1.Hashes[a.Index - (1 + hash_duplicate_count)].tagflag));

                    hash_duplicate_count++;
                    continue;
                }
                HashData.Add(new HashData_And_TagItem(a.Value.tagname, a.Value.tagnum, hash, fen1.Hashes[a.Index ].tagflag));
                
            }

            Console.WriteLine("HashData_sort");
            //ハッシュ値を並び替えリスト番号も順番変更
            IOrderedEnumerable<HashData_And_TagItem> sorted = HashData.OrderBy(x => x.Hash);
            var hashdata = sorted.ToArray();

            var pos_unknown_and_offsetend = fs.Position;

            List<int> pos_fen1_offset_entry_name = new List<int>();

            Console.WriteLine("HashData_write");
            foreach (var b in hashdata) {
                pos_fen1_offset_entry_name.Add((int)(fs.Position - pos_fen1_offset));
                bw.Write(CS.StringToBytes(((byte)(b.tagname.Length)).ToString("X2")));
                bw.Write(Encoding.GetEncoding(932).GetBytes((b.tagname)));
                bw.Write(CS.StringToBytes((b.tagnum).ToString("X8")));
            }

            var sectionend = fs.Position;


            fs.Seek(offset01,SeekOrigin.Begin);

            var dbcount = 0;

            var hashcounter = 0;
            Console.WriteLine("lastpoint");
            foreach (var c in hashdata.Select((Value, Index) => new { Value, Index })) {

                Console.WriteLine(c.Value.Hash +"___"+ c.Value.tagflag + "  " + c.Value.tagname);

                
                if (c.Index ==0) {
                    Console.WriteLine("はっしゅ" + c.Value.Hash.ToString("X"));
                    for (int k = 0; k<c.Value.Hash+1; k++) {
                        if (c.Value.Hash != k)  bw.Write(CS.StringToBytes((0).ToString("X8"))); 
                        else bw.Write(CS.StringToBytes(c.Value.tagflag.ToString("X8")));
                        
                        bw.Write(CS.StringToBytes(pos_fen1_offset_entry_name[c.Index].ToString("X8")));
                        hashcounter++;
                    }
                }
                else if (c.Value.Hash != hashdata[c.Index-1].Hash) {
                    var taglpeet = (c.Value.Hash - hashdata[c.Index - 1].Hash); 
                    for (int i = 0; i< taglpeet; i++) {
                        if (taglpeet - 1 == i)
                        {
                            bw.Write(CS.StringToBytes(c.Value.tagflag.ToString("X8")));
                        }
                        else {
                            bw.Write(CS.StringToBytes((0).ToString("X8")));
                        }
                        
                        bw.Write(CS.StringToBytes(pos_fen1_offset_entry_name[c.Index].ToString("X8"))); 
                    }
                }
                //if (c.Index != 0) { 
                //    for (int i = 0; i <) {

                //    } 
                //}
                //if (c.Value.tagflag == 0) dbcount++;
            }

            if (pos_unknown_and_offsetend> fs.Position) {
                //Console.WriteLine(pos_fen1_offset_entry_name[0] + pos_fen1_offset);
                Console.WriteLine(fs.Position);
                Console.WriteLine(0x3B *8);
                Console.WriteLine(pos_fen1_offset + 4);
                //Console.WriteLine(hashdata[0].Hash);

                Console.WriteLine(((0x3B * 8 + (pos_fen1_offset + 4)) - (fs.Position))/ 8);
                //((0x3B * 8 + (pos_fen1_offset + 4))) - (fs.Position)
                Console.WriteLine((0x3B) - (fs.Position - pos_fen1_offset + 4) / 8);

                var testfor = ((0x3B * 8 + (pos_fen1_offset + 4)) - (fs.Position)) / 8;
                for (long j = 0; j< testfor/*(0x3B) - (fs.Position - pos_fen1_offset + 4)/8*/; j++) {

                    bw.Write(CS.StringToBytes((0).ToString("X8")));
                    bw.Write(CS.StringToBytes(((int)sectionend - pos_fen1_offset).ToString("X8")));
                }
            }

            //foreach (var d in fen1.Hashes) {
            //    if (d.tagflag == 0) dbcount++;
            //}

            //セクションサイズの書き込み
            fs.Seek(pos_fen1_sec_size,SeekOrigin.Begin);
            bw.Write(CS.StringToBytes(((int)sectionend-pos_fen1_offset).ToString("X8")));

            fs.Seek(sectionend,SeekOrigin.Begin);
            CS.Padding_Writer(bw,fs.Position);

            filesize = (int)(fs.Position);
            return filesize;
            //Console.WriteLine("/////////////");
            //Console.WriteLine(fen1.Hashes.Count - dbcount);
        }

        public static void FEN1_Item_Change(ListBox lb, TextBox tb) {
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
            //foreach (int num in branch_list_no)
            //    txtb27.AppendText(Environment.NewLine + num);
            switch (tb.Name.Substring(tb.Name.Length - 2, 2)) {
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
