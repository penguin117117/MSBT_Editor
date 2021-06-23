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
    public class FLW2:objects
    {
        //変数宣言
        private static string magic;
        private static Int32 sec_size;
        private static Int32 unknown1;
        private static Int32 unknown2;
        private static Int16 entry;
        private static Int16 unknown3;
        private static Int32 padding;

        public string Magic {
            private set => magic = value;
            get => magic;
        }

        public int Section_Size {
            private set => sec_size = value;
            get => sec_size;
        }

        public int Unknown1 {
            private set => unknown1 = value;
            get => unknown1;
        }

        public int Unknown2 {
            private set => unknown2 = value;
            get => unknown2;
        }

        public Int16 Entry {
            private set => entry = value;
            get => entry;
        }

        public Int16 Unknown3 {
            private set => unknown3 = value;
            get => unknown3;
        }

        public int Padding {
            private set => padding = value;
            get => padding;
        }


        //構造体
        public struct flw2_item
        {
            public Int16 TypeCheck;
            public Int16 Unknown1;
            public Int16 Unknown2;
            public Int16 Unknown3;
            public Int16 Unknown4;
            public Int16 Unknown5;
            public flw2_item(Int16 unk0, Int16 unk1, Int16 unk2, Int16 unk3, Int16 unk4, Int16 unk5)
            {
                if (unk0 < 1 || unk0 > 4) unk0 = 1;
                TypeCheck = unk0;
                Unknown1 = unk1;
                Unknown2 = unk2;
                Unknown3 = unk3;
                Unknown4 = unk4;
                Unknown5 = unk5;
            }
        }


        //リスト宣言
        private static List<flw2_item> item;
        private static List<int> branch_no;
        private static List<int> branch_list_no;

        public List<flw2_item> Item{
            set => item = value;
            get => item;
        }

        public List<int> Branch_No {
            set => branch_no = value;
            get => branch_no;
        }

        public List<int> Branch_List_No
        {
            set => branch_list_no = value;
            get => branch_list_no;
        }

        public void Read(BinaryReader br, FileStream fs) {

            //初期化
            Item = new List<flw2_item>();
            Branch_No = new List<int>();
            Branch_List_No = new List<int>();

            //ヘッダー情報
            Magic        = CS.Byte2Char(br);
            Section_Size = CS.Byte2Int(br);
            Unknown1     = CS.Byte2Int(br);
            Unknown2     = CS.Byte2Int(br);

            //オフセット値記憶
            var pos1 = fs.Position;

            //ヘッダー情報続き
            Entry        = CS.Byte2Short(br);
            Unknown3     = CS.Byte2Short(br);
            Padding      = CS.Byte2Int(br);

            //ヘッダー情報デバッグ
            Debugger.MSBF_Text(Magic.ToString());
            Debugger.MSBF_Text(Section_Size.ToString());
            Debugger.MSBF_Text(Unknown1.ToString());
            Debugger.MSBF_Text(Unknown2.ToString());
            Debugger.MSBF_Text(Entry.ToString());
            Debugger.MSBF_Text(Unknown3.ToString());
            Debugger.MSBF_Text(Padding.ToString());
            Debugger.MSBF_Text("");

            //データ読み取り
            for (int i = 0; i< entry; i++) {

                //読み取り
                var type = CS.Byte2Short(br);
                var unk1 = CS.Byte2Short(br);
                var unk2 = CS.Byte2Short(br);
                var unk3 = CS.Byte2Short(br);
                var unk4 = CS.Byte2Short(br);
                var unk5 = CS.Byte2Short(br);

                //読み取ったデータをリストへ
                Item.Add(new flw2_item(type,unk1,unk2,unk3,unk4,unk5));

                //フロータイプチェックとリスト名変更さらにリストへ追加
                var liststr = MSBF_Type_Check(type , i);
                list2.Items.Add(liststr);

                //データ項目デバッグ
                Debugger.HashTxt(type.ToString("X4"), false, true);
                Debugger.HashTxt(" " + unk1.ToString("X4"), false, false);
                Debugger.HashTxt(" " + unk2.ToString("X4"), false, false);
                Debugger.HashTxt(" " + unk3.ToString("X4"), false, false);
                Debugger.HashTxt(" " + unk4.ToString("X4"), false, false);
                Debugger.HashTxt(" " + unk5.ToString("X4"), false, false);
            }

            //分岐データ
            Debugger.HashTxt("//分岐番号");
            for (int k = 0; k < (Unknown3); k+=2) {

                //読み取り
                var b_no1 = CS.Byte2Short(br);
                var b_no2 = CS.Byte2Short(br);

                //読み取ったデータをリストへ
                Branch_No.Add(b_no1);
                Branch_No.Add(b_no2);

                //分岐データデバッグ
                Debugger.HashTxt(b_no1.ToString("X4"));
                Debugger.HashTxt(b_no2.ToString("X4"));
            }

            //パディング読み取り
            CS.MSBF_Padding(br,fs.Position);
        }

        public static string MSBF_Type_Check(int num , int index , bool delete_flag = false) {
            string str = "";

            
            switch (num) {
                case 0x0001:
                    str = "会話決定とジャンプ？";
                    if (delete_flag == true)
                    {
                        branch_list_no.RemoveAt(FLW2.branch_list_no.IndexOf(index));
                    }
                    break;
                case 0x0002:
                    str = "分岐？";
                    if (delete_flag == false)
                    {

                        branch_list_no.Add(index);
                    }
                    
                    
                    break;
                case 0x0003:
                    str = "イベント制御？";
                    if (delete_flag == true)
                    {
                        branch_list_no.RemoveAt(FLW2.branch_list_no.IndexOf(index));
                    }
                    break;
                case 0x0004:
                    str = "メッセージグループ？";
                    if (delete_flag == true)
                    {
                        branch_list_no.RemoveAt(FLW2.branch_list_no.IndexOf(index));
                    }
                    break;
                default:
                    str = "エラーデータ「正しいデータを読み込んで」";
                    break;
            }
            return str;
        }

        public static void FLW2_Item_Change(ListBox lb,TextBox tb) {
            //エラー対策
            if (lb.Items.Count == 0) return;
            if (tb.Text.Length !=4) return ;

            //インデックス位置を保持
            var index = lb.SelectedIndex;

            //インデックス番号が-1の時0にする
            if (index == -1) index = 0;

            //インスタンス生成
            FLW2 flw2 = new FLW2();
            FLW2.flw2_item item = flw2.Item[index];


            var numhex = Int16.Parse(tb.Text, System.Globalization.NumberStyles.HexNumber);
            //foreach (int num in branch_list_no)
            //    txtb27.AppendText(Environment.NewLine + num);
            switch (tb.Name.Substring(tb.Name.Length-2,2)) {
                case "19":
                    if (item.TypeCheck != 2 && numhex == 2)
                    {
                        txtb27.AppendText(Environment.NewLine + "X→2");
                        if (-1 != FLW2.branch_list_no.IndexOf(index)) return;
                        foreach (var blnitem in FLW2.branch_list_no.Select((Value, Index) => new { Value, Index })) {
                            if (blnitem.Value  > index) {

                                lb.Items[index] = MSBF_Type_Check(numhex, index ,true);

                                txtb27.Text　= (Environment.NewLine+ "前" + FLW2.branch_list_no[index]);
                                FLW2.branch_list_no.Insert(blnitem.Index,index);
                                txtb27.AppendText(Environment.NewLine + FLW2.branch_list_no[index]);

                                FLW2.branch_no.Insert(blnitem.Index,0x0000);
                                FLW2.branch_no.Insert(blnitem.Index, 0x0000);
                                item.Unknown5 = Convert.ToInt16(blnitem.Index);
                                //txtb27.AppendText(Environment.NewLine + blnitem.Value+"___"+blnitem.Index.ToString());
                                break;
                            }
                        }
                        //foreach(int num in branch_list_no)
                        //txtb27.AppendText(Environment.NewLine + num);

                        //txtb27.AppendText(Environment.NewLine);

                        //foreach (int num in branch_no)
                        //    txtb27.AppendText(Environment.NewLine + num);

                        //FLW2.branch_no.Add(0x0000);
                        //FLW2.branch_no.Add(0x0000);
                        //var branchpos = FLW2.branch_no.Count() - 2;
                        //item.Unknown5 = Convert.ToInt16(branchpos);
                        

                        //lb.Items[index] = MSBF_Type_Check(numhex, index);
                        lb.SelectedIndex = index;


                        
                    }
                    else if (item.TypeCheck == 2 && numhex != 2)
                    {
                        txtb27.AppendText("2→X");

                        if (-1 == FLW2.branch_list_no.IndexOf(index)) return;

                        lb.Items[index] = MSBF_Type_Check(numhex, index, true);
                        lb.SelectedIndex = index;

                        FLW2.branch_no.RemoveAt(item.Unknown5);
                        FLW2.branch_no.RemoveAt(item.Unknown5);

                        for (int i = 0; i < FLW2.branch_list_no.Count(); i++)
                        {
                            FLW2 flw2_1 = new FLW2();
                            FLW2.flw2_item item1 = flw2_1.Item[FLW2.branch_list_no[i]];
                            Console.WriteLine("bln" + FLW2.branch_list_no[i]);
                            if (item1.Unknown5 != 0) item1.Unknown5 -= 2;
                            flw2_1.Item[FLW2.branch_list_no[i]] = item1;
                        }
                        item.TypeCheck = numhex;
                        
                        //Console.WriteLine(index + "_" + branch_list_no[item.Unknown5] +"_"+ branch_list_no[item.Unknown5+1]);
                        //var branchpos = FLW2.branch_no.Count() - 2;
                        //txtb24.Focus();
                        //txtb24.Text = branchpos.ToString("X4");
                        //item.Unknown5 = Convert.ToInt16(branchpos);
                    }
                    

                    item.TypeCheck = numhex;
                    break;
                case "20":
                    item.Unknown1 = numhex;
                    break;
                case "21":
                    item.Unknown2 = numhex;
                    break;
                case "22":
                    item.Unknown3 = numhex;
                    break;
                case "23":
                    item.Unknown4 = numhex;
                    break;
                case "24":
                    item.Unknown5 = numhex;
                    break;
            }
            //item.TypeCheck = Int16.Parse(tb.Text);
            flw2.Item[index] = item;
        }

        public static void FLW2_FlowType2_Branch(ListBox lb, TextBox tb) {
            txtb27.AppendText(Environment.NewLine+"///////////check");
            foreach (int num in FLW2.branch_no)
                txtb27.AppendText(Environment.NewLine + num);

            //エラー対策
            if (lb.Items.Count == 0) return;
            if (tb.Text.Length != 4) return;

            //リストボックスのインデックス取得
            var index = lb.SelectedIndex;
            Console.WriteLine("///////////OK");
            //現在のインデックスがflowtype2のセクションか判別
            if (-1 == FLW2.branch_list_no.IndexOf(index))return ;
            Console.WriteLine("flowtype2");

            //ジャンプ先1と2のインデックスを取得
            var branchindex1 = FLW2.branch_list_no.IndexOf(index);
            var branchindex2 = branchindex1 + 1;

            Console.WriteLine(branchindex1+"_"+branchindex2+"__"+ FLW2.branch_list_no.IndexOf(index));
            //ジャンプ先1と2の書き換え
            switch (tb.Name.Substring(tb.Name.Length - 2, 2))
            {
                case "25":
                    branch_no[branchindex1] = Int16.Parse(tb.Text, System.Globalization.NumberStyles.HexNumber);
                    Console.WriteLine("25__" + branch_no[branchindex1]);
                    break;
                case "26":
                    branch_no[branchindex2] = Int16.Parse(tb.Text, System.Globalization.NumberStyles.HexNumber);
                    Console.WriteLine("26__" + branch_no[branchindex2]);
                    break;
            }
        }

    }
}
