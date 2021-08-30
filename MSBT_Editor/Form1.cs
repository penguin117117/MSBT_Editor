using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MSBT_Editor.FileSys;
using MSBT_Editor.Formsys;
using MSBT_Editor.Sectionsys;
using System.IO;
using System.Globalization;


namespace MSBT_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Form1 _form1Instance;


        public static Form1 Form1Instance
        {
            set => _form1Instance = value;
            get => _form1Instance;
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialog.Open(1);
        }
        private void 上書き保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action ac = () => Dialog.SaveAs(1);
            Dialog.MSBT_Item_And_ListItem_Checker(ac);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MSBTsys.MSBT_Header msbth = new MSBTsys.MSBT_Header();


            Action ac = () => Dialog.Save(msbth);
            Dialog.MSBT_Item_And_ListItem_Checker(ac);
        }

        private void MSBF開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialog.Open(2);
        }

        private void MSBF上書き保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action ac = () => Dialog.SaveAs(2);
            Dialog.MSBF_Item_And_ListItem_Checker(ac);
        }

        private void MSBF保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MSBFsys.MSBF_Header msbfh = new MSBFsys.MSBF_Header();
            Action ac = () => Dialog.Save(msbfh);
            Dialog.MSBF_Item_And_ListItem_Checker(ac);
        }

        //public static readonly string[] IconNameJP01 = { "ピーチ", "クッパ", "キノピオ", "マリオ", "マリオ2", "チコ", "ヨッシー", "腹ペコチコ", "ルイージ", "ベビーチコ", "アシストチコ", "ベーゴマン", "クリボー" , "星ウサギ" };
        //public static readonly string[] IconNameJP02 = { "彗星メダル", "コイン×3", "カラフルスターピース", "イエローチップ", "スターピース紫", "シルバースター", "スター", "グランドスター", "ブロンズスター", "コイン", "パープルコイン", "1UPキノコ", "ライフアップキノコ", "ブルースター", "スターリング", "ヨッシーキャプチャー花" , "ココナッツ","ブルーチップ","バルーンフルーツ","中間ポイント","グランドブロンズスター"};
        //public static readonly string[] IconNameJP03 = { "ポインター", "2Pポインター", "ハンドポインター選択", "Wiiリモコン", "Aボタン", "Bボタン", "Cボタン", "Zボタン", "十字ボタン", "十字ボタン下", "十字ボタン上", "スティック", "ヌンチャク", "照準", "マイナスボタン", "プラスボタン", "×(かける)アイコン", "グリーンコメット", "銀の王冠", "銀の王冠宝石付き", "金の王冠", "手紙", "矢印下", "ストップウォッチ" ,"1ボタン", "2ボタン", "ホームボタン", "ハンドポインター握り", "ハンドポインター", "？マーク", "イエローコメット", "？マーク緑", "空のスター", "空の彗星メダル", "空の彗星", "隠しスター", "ブロンズコメット" };

        //public static readonly string[] IconNameEN01 = { "Peach", "Bowser", "Toad", "Mario", "Mario2", "Luma", "Yoshi", "HungryLuma", "Luigi", "MasterLuma", "Co-StarLuma", "Topman", "Goomba" , "StarBunny"};
        //public static readonly string[] IconNameEN02 = { "CometMedal", "Coin×3", "RainbowStarBit", "YellowChip", "PurpleStarBit", "SilverStar", "Star", "GrandStar", "BronzeStar", "Coin", "PurpleCoin", "1UPMushroom", "LifeUpMushroom", "BlueStar", "StarRing", "YoshiCapture" , "Coconut","BlueChip", "BlueFruit", "CheckPointFlag","GrandBronzeStar"};
        //public static readonly string[] IconNameEN03 = { "Pointer", "2PPointer", "HandPointer", "WiiRemote", "AButton", "BButton", "CButton", "ZButton", "十PadButton", "十PadButtonUnder", "十PadButtonUp", "ControllerStick", "Nunchuck", "Aim", "MinusButton", "PlusButton", "×Icon", "GreenComet", "SilverCrown", "SilverCrownJewel", "GoldCrown", "Letter", "ArrowUnder", "StopWatch", "1Button", "2Button", "HomeButton", "PointerGrip", "PointerNonGrip", "QuestionMark", "YellowComet", "GreenQuestionMark", "EmptyStar", "EmptyCometMedal", "EmptyStarComet", "HiddenStar", "BronzeComet" };

        private void Form1_Load(object sender, EventArgs e)
        {

            Console.WriteLine("testes");

            Form1.Form1Instance = this;

            //言語設定
            comboBox8.Text = Properties.Settings.Default.言語;
            Langage.Langage_Check();

            checkBox1.Checked = true;

            //コマンドライン引数を配列で取得する
            string[] files = Environment.GetCommandLineArgs();
            if (files.Length > 1) Dialog.FileCheck(files[1]);


        }
        public static int ListBoxIndex_NegativeThenSetIndexZero(ListBox lb)
        {
            if (lb.SelectedIndex < 0)
                lb.SelectedIndex = 0;
            return lb.SelectedIndex;
        }

        private void MsbtListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MSBTsys.MSBT_Data.MSBT_All_Data.Text.Count < 1) return;
            var MsbtSelectIndex = ListBoxIndex_NegativeThenSetIndexZero(MsbtListBox);
            var MsbtAllData     = MSBTsys.MSBT_Data.MSBT_All_Data;
            var SpecialText     = MSBTsys.MSBT_Data.Atr1SpecialText;
            textBox1.Text       = MsbtAllData.Text[MsbtSelectIndex];

            var Tmp = MsbtAllData.Item[MsbtSelectIndex];

            Atr1SoundID.Text      = Tmp.SoundID.ToString("X2");
            Atr1SimpleCamID.Text  = Tmp.SimpleCameraID.ToString("X2");
            Atr1DialogID.Text = Tmp.DialogID.ToString("X2");
            Atr1WindowID.Text = Tmp.WindowID.ToString("X2");
            Atr1EventCameraID.Text = Tmp.EventCameraID.ToString("X4");
            Atr1MessageAreaID.Text = Tmp.MessageAreaID.ToString("X2");
            Atr1Unknown6.Text = Tmp.unknown6.ToString("X2");
            Atr1SpecialTextOffset.Text = Tmp.SpecialTextOffset.ToString("X8");

            Atr1SpecialText.Text = SpecialText[MsbtSelectIndex];

            textBox35.Text = textBox1.Text;

            var liststrs = MsbtListBox.Text;
            if (-1 != LBL1.NameList.IndexOf(liststrs))
            {
                var unknownlbldata = LBL1.BeginEntryAdressList[LBL1.NameList.IndexOf(liststrs)].ToString("X");
                textBox12.Text = LBL1.HashSkipList[LBL1.NameList.IndexOf(liststrs)].ToString("X8");
            }
            else
            {
                textBox12.Text = "";
            }



            label42.Text = "0x" + MsbtListBox.SelectedIndex.ToString("X");
        }

        private void Atr1SoundID_TextChanged(object sender, EventArgs e) {
            if (MsbtListBox.Items.Count < 1) return;
            
            var Element = MSBTsys.MSBT_Data.MSBT_All_Data.Item[MsbtListBox.SelectedIndex];
            Element.SoundID = ATR1.ATR1TextBoxChange(Atr1SoundID,Element.SoundID);
            MSBTsys.MSBT_Data.MSBT_All_Data.Item[MsbtListBox.SelectedIndex] = Element;
        }
        

        private void Atr1SimpleCamID_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(Atr1SimpleCamID);
        }

        private void Atr1DialogID_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(Atr1DialogID);
        }

        private void Atr1WindowID_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(Atr1WindowID);
        }

        private void Atr1EventCameraID_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(Atr1EventCameraID);
        }

        private void Atr1MessageAreaID_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(Atr1MessageAreaID);
        }

        private void Atr1Unknown6_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(Atr1Unknown6);
        }

        private void Atr1SpecialText_TextChanged(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            ATR1.SpecialTextList[MsbtListBox.SelectedIndex] = Atr1SpecialText.Text;

        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {
            var liststrs = MsbtListBox.Text;
            if (-1 != LBL1.NameList.IndexOf(liststrs))
            {
                var unknownlbldata = LBL1.BeginEntryAdressList[LBL1.NameList.IndexOf(liststrs)].ToString("X");
                LBL1.HashSkipList[LBL1.NameList.IndexOf(liststrs)] = Int32.Parse(textBox12.Text, System.Globalization.NumberStyles.HexNumber);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            if (MsbtListBox.Items.Count != 0)
            {
                MSBTsys.MSBT_Data.MSBT_All_Data.Text[MsbtListBox.SelectedIndex] = textBox1.Text;
            }

        }

        //非常によくない複雑で長い処理。改善する必要があります。
        //修正すると複数箇所に影響を及ぼすので慎重に修復する必要があります。
        private void AddListText_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count != 0)
            {
                //既存のデータに追加する場合
                if (ListNameText.Text != string.Empty)
                {
                    //インスタンス生成と初期化
                    LBL1 lbl1 = new LBL1();
                    lbl1.HashData = new List<LBL1.Hash_Data>();
                    lbl1.Item_1st = new List<LBL1.LBL_1st_Item>();
                    long listcounter = 0;

                    //リストボックス1のデータをハッシュデータ構造体に入れる
                    foreach (var listname in MsbtListBox.Items)
                    {

                        lbl1.HashData.Add(new LBL1.Hash_Data(Calculation_System.MSBT_Hash(listname.ToString(), lbl1.EntrySize), listcounter));

                        listcounter++;
                    }

                    //ハッシュデータ構造体に入っているデータを編集用の構造体に入れる
                    List<LBL1.Hash_Data> hashlist = new List<LBL1.Hash_Data>(lbl1.HashData);

                    //ハッシュリデータを昇順に並べ替えをする
                    hashlist.Sort((a, b) => a.Hash.CompareTo(b.Hash));

                    //追加するリスト名をハッシュ値に変換
                    var newhash = Calculation_System.MSBT_Hash(ListNameText.Text, lbl1.EntrySize);

                    //ハッシュ値を比較して同じ値があった場合は数値を返して、それ以外の場合はdefaultを返す
                    LBL1.Hash_Data equal_flag = hashlist.LastOrDefault(x => x.Hash == newhash);

                    //ハッシュ値がデフォルトの場合、新しいハッシュ値がハッシュリストの値を超える値を返す
                    if (equal_flag.Hash == default) equal_flag = hashlist.LastOrDefault(x => x.Hash > newhash);

                    //ハッシュ値を基準に見つかったハッシュ構造体のリスト値に+1した値にリストを挿入する
                    equal_flag.MsbtListBoxIndex++;


                    MsbtListBox.Items.Insert((int)equal_flag.MsbtListBoxIndex, ListNameText.Text);

                    //リストボックスを名前順にソート
                    MsbtListBox.Sorted = true;
                    MsbtListBox.Sorted = false;

                    //追加したリスト名のインデックスを検索
                    var testindex = MsbtListBox.Items.IndexOf(ListNameText.Text);

                    //MSBTのデータを先ほどのインデックス位置に挿入
                    MSBTsys.MSBT_Data.MSBT_All_Data.Text.Insert(testindex, "テキスト</End>");
                    MSBTsys.MSBT_Data.MSBT_All_Data.Item.Insert(testindex, new ATR1.AttributeData(0x1, 0x0, 0x0, 0x0, 0x0, 0xFF, 0xFF, 0x00));
                    MSBTsys.MSBT_Data.Atr1SpecialText.Insert(testindex, "");

                    //重複したデータを削除
                    IEnumerable<LBL1.Hash_Data> noduplicates = hashlist.Distinct();
                    hashlist = new List<LBL1.Hash_Data>(noduplicates);

                    var foundhashlist = hashlist.LastOrDefault(x => x.Hash == newhash);
                    if (foundhashlist.Hash == default) foundhashlist = hashlist.LastOrDefault(x => x.Hash > newhash); ;
                    //ラベル情報を追加する
                    var lbl1_newindex = hashlist.LastIndexOf(foundhashlist);
                    //lbl1_newindex ++;
                    foreach (var items in LBL1.NameList.Select((Value, Index) => (Value, Index)))
                    {

                        var hashdata = Calculation_System.MSBT_Hash(items.Value, lbl1.EntrySize);

                        lbl1.Item_1st.Add(new LBL1.LBL_1st_Item(LBL1.HashSkipList[items.Index], LBL1.NameList[items.Index], hashdata));
                        Console.WriteLine(hashdata.ToString("X8"));
                        Console.WriteLine(items.Value);
                    }
                    lbl1.Item_1st.Sort((a, b) => a.Hash.CompareTo(b.Hash));
                    var found1stitem = lbl1.Item_1st.LastOrDefault(x => x.Hash == newhash);
                    if (found1stitem.Hash == default) found1stitem = lbl1.Item_1st.LastOrDefault(x => x.Hash > newhash);

                    var newindex = lbl1.Item_1st.LastIndexOf(found1stitem);

                    lbl1_newindex = /*testindex*/newindex;


                    if (lbl1_newindex != -1)
                    {
                        Debugger.HashTxt("lbl newindex" + lbl1_newindex.ToString());
                        LBL1.NameOffsetList.Insert(lbl1_newindex, 0);
                        LBL1.NameList.Insert(lbl1_newindex, ListNameText.Text);
                        LBL1.HashSkipList.Insert(lbl1_newindex, 0x00000001);
                        LBL1.BeginEntryAdressList.Insert(lbl1_newindex, 0);
                    }
                    Console.WriteLine("listname" + LBL1.NameList.IndexOf(ListNameText.Text).ToString("X"));
                    //BattanKing002_Flow000
                    //ScenarioName_RedBlueExGalaxy3
                    //MSBFファイルのフロータイプ1の対象MSBTの挿入以降の番号に+1する
                    if (listBox2.Items.Count == 0 || listBox3.Items.Count == 0) return;
                    FLW2 flw2 = new FLW2();
                    List<FLW2.flw2_item> copyitem = new List<FLW2.flw2_item>(flw2.Item);
                    foreach (var flw2item in copyitem.Select((Value, Index) => (Value, Index)))
                    {
                        if (flw2item.Value.TypeCheck != 1) continue;
                        if (flw2item.Value.Unknown3 < testindex) continue;
                        FLW2.flw2_item newitem = flw2item.Value;
                        newitem.Unknown3++;
                        flw2.Item[flw2item.Index] = newitem;
                    }
                }

            }
            else
            {
                //初回にデータを入れる場合
                if (ListNameText.Text != "")
                {
                    LBL1 lbl1 = new LBL1();
                    lbl1.EntrySize = 101;

                    //初期化
                    MSBTsys.MSBT_Data.Data_List msbtdatalist = new MSBTsys.MSBT_Data.Data_List();
                    msbtdatalist.Item = new List<ATR1.AttributeData>();
                    msbtdatalist.Text = new List<string>();
                    MSBTsys.MSBT_Data.Atr1SpecialText = new List<string>();
                    LBL1.NameList = new List<string>();
                    LBL1.HashSkipList = new List<int>();
                    LBL1.BeginEntryAdressList = new List<long>();
                    LBL1.NameOffsetList = new List<int>();
                    //LBL1.LBL_1st_Item  = new();

                    //値を入れておく
                    MSBTsys.MSBT_Data.MSBT_All_Data = msbtdatalist;

                    //リストボックス1とMSBTのデータに追加する
                    MsbtListBox.Items.Add(ListNameText.Text);
                    if (Properties.Settings.Default.言語 == "EN")
                        MSBTsys.MSBT_Data.MSBT_All_Data.Text.Add("Default Text</End>");
                    else
                        MSBTsys.MSBT_Data.MSBT_All_Data.Text.Add("テキスト</End>");
                    MSBTsys.MSBT_Data.MSBT_All_Data.Item.Add(new ATR1.AttributeData(0x1, 0x0, 0x0, 0x0, 0x0, 0xFF, 0xFF, 0x00));
                    MSBTsys.MSBT_Data.Atr1SpecialText.Add("");

                    //ラベル情報を追加する
                    LBL1.NameOffsetList.Add(0);
                    LBL1.NameList.Add(ListNameText.Text);
                    LBL1.HashSkipList.Add(1);
                    LBL1.BeginEntryAdressList.Add(0);
                }
            }
        }

        private void DeleteListText_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count != 0 && (MSBTsys.MSBT_Data.MSBT_All_Data.Item.Count != 0) && MSBTsys.MSBT_Data.MSBT_All_Data.Text.Count != 0)
            {
                var array_list_name = LBL1.NameList.ToArray();
                var array_search = Array.IndexOf(array_list_name, MsbtListBox.SelectedItem.ToString());
                ////Console.WriteLine("array_search -1");
                //if (array_search == -1) return;
                //Console.WriteLine("array_search -1以外");
                MSBTsys.MSBT_Data.MSBT_All_Data.Item.RemoveRange(MsbtListBox.SelectedIndex, 1);
                MSBTsys.MSBT_Data.MSBT_All_Data.Text.RemoveRange(MsbtListBox.SelectedIndex, 1);
                MSBTsys.MSBT_Data.Atr1SpecialText.RemoveRange(MsbtListBox.SelectedIndex, 1);


                //ハッシュスキップされている値の場合
                if (array_search != -1)
                {
                    Debugger.HashTxt(array_search.ToString());
                    Debugger.HashTxt(LBL1.NameList[array_search]);
                    Debugger.HashTxt(LBL1.HashSkipList[array_search].ToString());
                    Debugger.HashTxt(LBL1.BeginEntryAdressList[array_search].ToString());

                    LBL1.NameOffsetList.RemoveAt(array_search);
                    LBL1.NameList.RemoveAt(array_search);
                    LBL1.HashSkipList.RemoveAt(array_search);
                    LBL1.BeginEntryAdressList.RemoveAt(array_search);


                }

                //LBL1.list_name.RemoveRange(array_search , 1);
                //LBL1.unknown.RemoveRange(array_search, 1);
                //LBL1.unknownpos.RemoveRange(array_search, 1);
                var listselect = MsbtListBox.SelectedIndex;
                MsbtListBox.Items.RemoveAt(listselect);
            }
        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {
            LBL1 lbl1 = new LBL1();
            lbl1.EntrySize = Int32.Parse(textBox14.Text);
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            ATR1 atr1 = new ATR1();
            atr1.EntrySize = Int32.Parse(textBox15.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;

            string color = "";

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    color = "Black";
                    break;
                case 1:
                    color = "Red";
                    break;
                case 2:
                    color = "Green";
                    break;
                case 3:
                    color = "Blue";
                    break;
                case 4:
                    color = "Yellow";
                    break;
                case 5:
                    color = "Purple";
                    break;
                case 6:
                    color = "Orange";
                    break;
                case 7:
                    color = "Gray";
                    break;
                case 8:
                    Calculation_System.TextBoxInsert(textBox1, "</Color>");
                    return;
                default:
                    color = "Black";
                    break;
            }

            string tag = "<Color=\"" + color + "\">";

            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;

            string tag = "";

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    tag = "</br>" + Environment.NewLine;
                    break;
                case 1:
                    tag = "</New_Page>" + Environment.NewLine + Environment.NewLine;
                    break;
                case 2:
                    tag = "</End>";
                    break;
                default:
                    tag = "</br>" + Environment.NewLine;
                    break;
            }
            if (tag == "</End>")
            {
                if (textBox1.Text.IndexOf("</End>") != -1)
                {
                    MessageBox.Show("</End>が二つ以上あるとデータが" + "\n\r" + "破損するので挿入をキャンセルしました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;

            string tag = "";

            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    tag = "<Size=\"Small\">";
                    break;
                case 1:
                    tag = "<Size=\"Normal\">";
                    break;
                case 2:
                    tag = "<Size=\"Large\">";
                    break;
                default:
                    tag = "<Size=\"Normal\">";
                    break;
            }

            Calculation_System.TextBoxInsert(textBox1, tag);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;

            string tag = "";


            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    tag = "</XCenter>";
                    break;
                case 1:
                    tag = "</YCenter>";
                    break;
                default:
                    tag = "</XCenter>";
                    break;
            }

            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            if (textBox16.Text == "" || textBox17.Text == "") return;
            string furigana = textBox16.Text;
            string kanji = textBox17.Text;
            string tag = "<Rubi=\"" + furigana + "\" Target=\"" + kanji + "\">";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressEventSupport.OnlyDecChar(e);
        }

        

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressEventSupport.OnlyDecChar(e);
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressEventSupport.OnlyDecChar(e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            if (textBox18.Text == "") return;
            string time = textBox18.Text;
            string tag = "</Timer=\"" + time + "\">";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</PlayCharacter>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</StarShipTag>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</ResultGalaxyName>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</ResultScenarioName>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.言語 == "EN")
            {//all icons in one combo
                string[] IconTag = {
                    "<Icon=\"AButton\">",
                    "<Icon=\"BButton\">",
                    "<Icon=\"CButton\">",
                    "<Icon=\"WiiMote\">",
                    "<Icon=\"Nunchuck\">",
                    "<Icon=\"1Button\">",
                    "<Icon=\"2Button\">",
                    "<Icon=\"Star\">",
                    "<Icon=\"StarRing\">",
                    "<Icon=\"BlueStar\">",
                    "<Icon=\"Pointer\">",
                    "<Icon=\"PurpleStarbit\">",
                    "<Icon=\"Coconut\">",
                    "<Icon=\"ArrowDown\">",
                    "<Icon=\"StarBunny\">",
                    "<Icon=\"JoyStick\">",
                    "<Icon=\"XIcon\">",
                    "<Icon=\"Coin\">",
                    "<Icon=\"Mario2\">",
                    "<Icon=\"DPad\">",
                    "<Icon=\"BlueStarPiece\">",
                    "<Icon=\"StarPiece\">",
                    "<Icon=\"HomeButton\">",
                    "<Icon=\"MButton\">",
                    "<Icon=\"PButton\">",
                    "<Icon=\"ZButton\">",
                    "<Icon=\"SilverStar\">",
                    "<Icon=\"GrandStar\">",
                    "<Icon=\"Luigi\">",
                    "<Icon=\"PointerYellow\">",
                    "<Icon=\"PurpleCoin\">",
                    "<Icon=\"GreenComet\">",
                    "<Icon=\"GoldCrown\">",
                    "<Icon=\"Aim\">",
                    "<Icon=\"Koopa\">",
                    "<Icon=\"PointerHandSelected\">",
                    "<Icon=\"PointerHand\">",
                    "<Icon=\"PointerHandSelecting\">",
                    "<Icon=\"Starbit\">",
                    "<Icon=\"Peach\">",
                    "<Icon=\"Letter\">",
                    "<Icon=\"QuestionMark\">",
                    "<Icon=\"1UPMushroom\">",
                    "<Icon=\"LifeUpMushroom\">",
                    "<Icon=\"HarapekoTico\">",
                    "<Icon=\"Tico\">",
                    "<Icon=\"CometStar\">",
                    "<Icon=\"QuestionMarkGreen\">",
                    "<Icon=\"StopWatch\">",
                    "<Icon=\"MasterTico\">",
                    "<Icon=\"Yoshi\">",
                    "<Icon=\"CometMedal\">",
                    "<Icon=\"SilverCrown\">",
                    "<Icon=\"Flower\">",
                    "<Icon=\"CheckpointFlag\">",
                    "<Icon=\"EmptyStar\">",
                    "<Icon=\"EmptyCometMedal\">",
                    "<Icon=\"EmptyCometStar\">",
                    "<Icon=\"EmptyHiddenStar\">",
                    "<Icon=\"BronzeStar\">",
                    "<Icon=\"BlimpFruit\">",
                    "<Icon=\"SilverCrownwJewel\">",
                    "<Icon=\"BronzeGrandStar\">",
                    "<Icon=\"Begoman\">",
                    "<Icon=\"Kuribo\">",
                    "<Icon=\"Coins\">",
                    "<Icon=\"DPadUp\">",
                    "<Icon=\"DPadDown\">",
                    "<Icon=\"Columa\">",
                    "<Icon=\"Kinopio\">",
                    "<Icon=\"BronzeComet\">", };

                Calculation_System.TextBoxTagAdder(MsbtListBox, textBox1, comboBox5, IconTag);
            }
            else
            {
                string[] IconTag = { "<Icon=\"Peach\">", "<Icon=\"Koopa\">", "<Icon=\"Kinopio\">", "<Icon=\"Mario\">", "<Icon=\"Mario2\">", "<Icon=\"Tico\">", "<Icon=\"Yoshi\">", "<Icon=\"HarapekoTico\">", "<Icon=\"Luigi\">", "<Icon=\"MasterTico\">", "<Icon=\"Columa\">", "<Icon=\"Begoman\">", "<Icon=\"Kuribo\">", "<Icon=\"Star Bunny\">" };
                Calculation_System.TextBoxTagAdder(MsbtListBox, textBox1, comboBox5, IconTag);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] IconTag = { "<Icon=\"CometMedal\">", "<Icon=\"Coins\">", "<Icon=\"Starbit\">", "<Icon=\"StarPiece\">", "<Icon=\"PurpleStarbit\">", "<Icon=\"SilverStar\">", "<Icon=\"Star\">", "<Icon=\"GrandStar\">", "<Icon=\"BronzeStar\">", "<Icon=\"Coin\">", "<Icon=\"PurpleCoin\">", "<Icon=\"1UPMushroom\">", "<Icon=\"LifeUpMushroom\">", "<Icon=\"BlueStar\">", "<Icon=\"StarRing\">", "<Icon=\"Flower\">", "<Icon=\"Coconut\">", "<Icon=\"BlueChip\">", "<Icon=\"BlueFruit\">", "<Icon=\"CheckPointFlag\">", "<Icon=\"GrandBronzeStar\">" };
            Calculation_System.TextBoxTagAdder(MsbtListBox, textBox1, comboBox6, IconTag);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] IconTag = { "<Icon=\"Pointer\">", "<Icon=\"PointerYellow\">", "<Icon=\"PointerHand\">", "<Icon=\"WiiMote\">", "<Icon=\"AButton\">", "<Icon=\"BButton\">", "<Icon=\"CButton\">", "<Icon=\"ZButton\">", "<Icon=\"DPad\">", "<Icon=\"DPadDown\">", "<Icon=\"DPadUp\">", "<Icon=\"JoyStick\">", "<Icon=\"Nunchuck\">", "<Icon=\"Aim\">", "<Icon=\"MButton\">", "<Icon=\"PButton\">", "<Icon=\"XIcon\">", "<Icon=\"GreenComet\">", "<Icon=\"SilverCrown\">", "<Icon=\"SilverCrownwJewel\">", "<Icon=\"GoldCrown\">", "<Icon=\"Letter\">", "<Icon=\"ArrowDown\">", "<Icon=\"StopWatch\">", "<Icon=\"1Button\">", "<Icon=\"2Button\">", "<Icon=\"HomeButton\">", "<Icon=\"PointerGrip\">", "<Icon=\"PointerNonGrip\">", "<Icon=\"QuestionMark\">", "<Icon=\"YellowComet\">", "<Icon=\"GreenQuestionMark\">", "<Icon=\"EmptyStar\">", "<Icon=\"EmptyCometMedal\">", "<Icon=\"EmptyStarComet\">", "<Icon=\"HiddenStar\">", "<Icon=\"BronzeComet\">" };
            Calculation_System.TextBoxTagAdder(MsbtListBox, textBox1, comboBox7, IconTag);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</Year01>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</Year02>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</Hour>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</Minutes>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</Seconds>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</AfterTheDecimalPoint>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (toolStripStatusLabel2.Text == " ") return;
            if (textBox13.Text == "") return;
            string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string msbtname = Path.GetFileNameWithoutExtension(toolStripStatusLabel2.Text);
            string textpath = Path.Combine(Path.GetDirectoryName(appPath), msbtname + ".txt");
            //Console.WriteLine(textpath);

            File.WriteAllText(textpath, textBox13.Text);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox25.TextChanged -= new EventHandler(this.textBox25_TextChanged);
            this.textBox26.TextChanged -= new EventHandler(this.textBox26_TextChanged);

            if (listBox2.Items.Count == 0) return;
            var index = listBox2.SelectedIndex;
            if (index == -1) index = 0;
            FLW2 flw2 = new FLW2();
            //Console.WriteLine(index);
            textBox19.Text = flw2.Item[index].TypeCheck.ToString("X4");
            textBox20.Text = flw2.Item[index].Unknown1.ToString("X4");
            textBox21.Text = flw2.Item[index].Unknown2.ToString("X4");
            textBox22.Text = flw2.Item[index].Unknown3.ToString("X4");
            textBox23.Text = flw2.Item[index].Unknown4.ToString("X4");
            textBox24.Text = flw2.Item[index].Unknown5.ToString("X4");

            switch (flw2.Item[index].TypeCheck.ToString("X4"))
            {
                case "0001":
                    label25.Text = "グループ番号";
                    label26.Text = "Msbtテキストlist番号";
                    label27.Text = "FLW2オフセット";
                    label28.Text = "不明5";
                    if (Properties.Settings.Default.言語 == "日本語") break;
                    label25.Text = "Group number";
                    label26.Text = "MSBT Entry";
                    label27.Text = "Next Flow";
                    label28.Text = "Unknown5";
                    break;
                case "0002":
                    label25.Text = "0002固定";
                    label26.Text = "不明3";
                    label27.Text = "不明4";
                    label28.Text = "分岐先オフセット";
                    if (Properties.Settings.Default.言語 == "日本語") break;
                    label25.Text = "Always 0002";
                    label26.Text = "Condition ID";
                    label27.Text = "Unknown4";
                    label28.Text = "Unknown5";
                    break;
                case "0004":
                    label25.Text = "ジャンプ先";
                    label26.Text = "不明3";
                    label27.Text = "不明4";
                    label28.Text = "不明5";
                    if (Properties.Settings.Default.言語 == "日本語") break;
                    label25.Text = "Next Flow ID";
                    label26.Text = "Unknown3";
                    label27.Text = "Unknown4";
                    label28.Text = "Unknown5";
                    break;
                case "0003":
                    label25.Text = "イベント番号";
                    label26.Text = "FLWオフセット";
                    label27.Text = "不明4";
                    label28.Text = "不明5";
                    if (Properties.Settings.Default.言語 == "日本語") break;
                    label25.Text = "Event ID";
                    label26.Text = "Next Flow";
                    label27.Text = "Unknown4";
                    label28.Text = "Unknown5";
                    break;
                default:
                    label25.Text = "不明2";
                    label26.Text = "不明3";
                    label27.Text = "不明4";
                    label28.Text = "不明5";
                    if (Properties.Settings.Default.言語 == "日本語") break;
                    label25.Text = "Unknown2";
                    label26.Text = "Unknown3";
                    label27.Text = "Unknown4";
                    label28.Text = "Unknown5";
                    break;

            }

            var blnc = flw2.Branch_List_No.Count * 2;
            var bnc = flw2.Branch_No.Count;

            if (blnc != bnc)
            {
                label43.Text = "0x" + listBox2.SelectedIndex.ToString("X");
                this.textBox25.TextChanged += new EventHandler(this.textBox25_TextChanged);
                this.textBox26.TextChanged += new EventHandler(this.textBox26_TextChanged);
                return;
            }
            if (-1 == flw2.Branch_List_No.IndexOf(index))
            {

                textBox25.Text = "";
                textBox26.Text = "";
                label43.Text = "0x" + listBox2.SelectedIndex.ToString("X");
                this.textBox25.TextChanged += new EventHandler(this.textBox25_TextChanged);
                this.textBox26.TextChanged += new EventHandler(this.textBox26_TextChanged);
                return;
            }
            textBox27.AppendText(Environment.NewLine + "selectlist");
            textBox27.AppendText(Environment.NewLine + flw2.Branch_No[flw2.Branch_List_No.IndexOf(index)].ToString("X4") + "___" + flw2.Branch_List_No.IndexOf(index));

            textBox25.Text = flw2.Branch_No[(flw2.Branch_List_No.IndexOf(index) * 2)].ToString("X4");
            textBox26.Text = flw2.Branch_No[(flw2.Branch_List_No.IndexOf(index) * 2) + 1].ToString("X4");

            label43.Text = "0x" + listBox2.SelectedIndex.ToString("X");
            this.textBox25.TextChanged += new EventHandler(this.textBox25_TextChanged);
            this.textBox26.TextChanged += new EventHandler(this.textBox26_TextChanged);
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            this.listBox2.SelectedIndexChanged -= new EventHandler(this.listBox2_SelectedIndexChanged);
            FLW2.FLW2_Item_Change(listBox2, textBox19);
            this.listBox2.SelectedIndexChanged += new EventHandler(this.listBox2_SelectedIndexChanged);
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            this.listBox2.SelectedIndexChanged -= new EventHandler(this.listBox2_SelectedIndexChanged);
            FLW2.FLW2_Item_Change(listBox2, textBox20);
            this.listBox2.SelectedIndexChanged += new EventHandler(this.listBox2_SelectedIndexChanged);
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            FLW2.FLW2_Item_Change(listBox2, textBox21);
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            FLW2.FLW2_Item_Change(listBox2, textBox22);
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            FLW2.FLW2_Item_Change(listBox2, textBox23);
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            FLW2.FLW2_Item_Change(listBox2, textBox24);
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            textBox27.AppendText(Environment.NewLine + "25text");
            FLW2.FLW2_FlowType2_Branch(listBox2, textBox25);
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            FLW2.FLW2_FlowType2_Branch(listBox2, textBox26);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var filecount = fileName.Count();

            //デバッグに必須なので消さない
            //foreach (var item in fileName)
            //{
            //    UnknownTag.Text = "";
            //    Dialog.FileCheck(item);
            //    if (toolStripStatusLabel4.Text == " ") return;
            //    //if (UnknownTag.Text == "") return;
            //    string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //    string msbtname = Path.GetFileNameWithoutExtension(toolStripStatusLabel4.Text);
            //    string textpath = Path.Combine(Path.GetDirectoryName(appPath), "Debug_" + msbtname + ".txt");
            //    textBox34.AppendText(textpath + Environment.NewLine);
            //    //File.WriteAllText(textpath, UnknownTag.Text);
            //}
            //return;
            if (filecount == 2)
            {
                var path1 = Path.GetExtension(fileName[0]);
                var path2 = Path.GetExtension(fileName[1]);

                if (path1 == path2)
                {
                    MessageBox.Show("2つファイルを読み込む場合" + "\n\r" + "MSBTとMSBFの組み合わせのみです", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            switch (filecount)
            {
                case 1:
                    Dialog.FileCheck(fileName[0]);
                    break;
                case 2:
                    Dialog.FileCheck(fileName[0]);
                    Dialog.FileCheck(fileName[1]);
                    break;
                default:
                    MessageBox.Show("3つ以上のファイルはドロップできません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            FEN1.FEN1_Item_Change(listBox3, textBox28);
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            FEN1.FEN1_Item_Change(listBox3, textBox29);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox28.TextChanged -= new EventHandler(this.textBox28_TextChanged);
            this.textBox29.TextChanged -= new EventHandler(this.textBox29_TextChanged);

            if (listBox3.Items.Count == 0) return;
            var index = listBox3.SelectedIndex;
            if (index == -1) index = 0;

            FEN1 fen1 = new FEN1();
            var hashes = Calculation_System.MSBT_Hash(fen1.Item2[index].tagname, 0x3B);

            //textBox28.Text = fen1.Item1[index].tagflag.ToString("X8");
            textBox28.Text = fen1.Hashes[index].tagflag.ToString("X8");
            textBox29.Text = fen1.Item2[index].tagnum.ToString("X8");

            if (listBox2.Items.Count > fen1.Item2[index].tagnum) listBox2.SelectedIndex = fen1.Item2[index].tagnum;

            label44.Text = "0x" + listBox3.SelectedIndex.ToString("X");
            this.textBox28.TextChanged += new EventHandler(this.textBox28_TextChanged);
            this.textBox29.TextChanged += new EventHandler(this.textBox29_TextChanged);

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            FLW2 flw2 = new FLW2();
            if (listBox2.Items.Count != 0)
            {
                listBox2.Items.Add(Langage.FLW2_List_Langage(4));
                flw2.Item.Add(new FLW2.flw2_item(4, 0, 0, 0, 0, 0));
                listBox2.EndUpdate();
            }
            else
            {
                listBox2.Items.Add(Langage.FLW2_List_Langage(4));
                flw2.Item = new List<FLW2.flw2_item>();
                flw2.Item.Add(new FLW2.flw2_item(4, 0, 0, 0, 0, 0));
                flw2.Branch_List_No = new List<int>();
                flw2.Branch_No = new List<short>();
                listBox2.EndUpdate();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            FLW2 flw2 = new FLW2();

            if (listBox2.Items.Count != 0 && (flw2.Item.Count != 0) && (flw2.Branch_List_No != null) && (flw2.Branch_No != null))
            {


                var listselect = listBox2.SelectedIndex;
                listBox2.Items.RemoveAt(listselect);
                if (flw2.Item[listselect].TypeCheck == 2)
                {
                    flw2.Branch_No.RemoveAt((flw2.Branch_List_No.IndexOf(listselect)) * 2);
                    flw2.Branch_List_No.RemoveAt(flw2.Branch_List_No.IndexOf(listselect));
                }
                flw2.Item.RemoveAt(listselect);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            FEN1 fen1 = new FEN1();
            FLW2 flw2 = new FLW2();

            short list2count = 0;
            if (listBox3.Items.Count != 0)
            {
                list2count = (short)fen1.Item2.Count;
                if (textBox31.Text != "")
                {
                    listBox3.Items.Add(textBox31.Text);
                    fen1.Item1.Add(new FEN1.Element(1, 0));
                    var item2count = fen1.Item2.Count;
                    fen1.Item2.Add(new FEN1.ElementTag(textBox31.Text, listBox2.Items.Count));
                    var hash = Calculation_System.MSBT_Hash(textBox31.Text, 0x3B);
                    fen1.Hashes.Add(new FEN1.Hash_And_Unknown(1, hash));
                    //treeView1.Nodes.Add(textBox31.Text);


                    //if (listBox2.Items.Count != 0)
                    //{
                    //    listBox2.Items.Add(Langage.FLW2_List_Langage(4));
                    //    flw2.Item.Add(new FLW2.flw2_item(4, 0, list2count, 0, 0, 0));
                    //    listBox2.EndUpdate();
                    //}
                    //else
                    //{
                    //    listBox2.Items.Add(Langage.FLW2_List_Langage(4));
                    //    flw2.Item = new List<FLW2.flw2_item>();
                    //    flw2.Item.Add(new FLW2.flw2_item(4, 0, list2count, 0, 0, 0));
                    //    flw2.Branch_List_No = new List<int>();
                    //    flw2.Branch_No = new List<short>();
                    //    listBox2.EndUpdate();
                    //}
                    //treeView1.Nodes[list2count].Tag = new FLW2.flw2_item(4, 0, list2count, 0, 0, 0);
                }
            }
            else
            {
                if (textBox31.Text != "")
                {
                    fen1.Item1 = new List<FEN1.Element>();
                    fen1.Item2 = new List<FEN1.ElementTag>();
                    fen1.Hashes = new List<FEN1.Hash_And_Unknown>();


                    listBox3.Items.Add(textBox31.Text);
                    fen1.Item1.Add(new FEN1.Element(1, 0));
                    fen1.Item2.Add(new FEN1.ElementTag(textBox31.Text, listBox2.Items.Count));

                    var hash = Calculation_System.MSBT_Hash(textBox31.Text, 0x3B);
                    fen1.Hashes.Add(new FEN1.Hash_And_Unknown(1, hash));
                    //treeView1.Nodes.Add(textBox31.Text);

                    //if (listBox2.Items.Count != 0)
                    //{
                    //    listBox2.Items.Add(Langage.FLW2_List_Langage(4));
                    //    flw2.Item.Add(new FLW2.flw2_item(4, 0, list2count, 0, 0, 0));
                    //    listBox2.EndUpdate();
                    //}
                    //else
                    //{
                    //    listBox2.Items.Add(Langage.FLW2_List_Langage(4));
                    //    flw2.Item = new List<FLW2.flw2_item>();
                    //    flw2.Item.Add(new FLW2.flw2_item(4, 0, list2count, 0, 0, 0));
                    //    flw2.Branch_List_No = new List<int>();
                    //    flw2.Branch_No = new List<short>();
                    //    listBox2.EndUpdate();
                    //}
                    //treeView1.Nodes[list2count].Tag = new FLW2.flw2_item(4, 0, list2count, 0, 0, 0);
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            FEN1 fen1 = new FEN1();

            if (listBox3.Items.Count != 0 && (fen1.Item1.Count != 0) && (fen1.Item2.Count != 0) && (fen1.Hashes.Count != 0))
            {
                Console.WriteLine(fen1.Item1.Count());
                Console.WriteLine(fen1.Item2.Count());
                Console.WriteLine(fen1.Hashes.Count());



                var listselect = listBox3.SelectedIndex;


                //fen1.Item1.RemoveAt(listselect);
                fen1.Item2.RemoveAt(listselect);
                fen1.Hashes.RemoveAt(listselect);

                listBox3.Items.RemoveAt(listselect);
            }
        }

        private void ListNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox8.SelectedIndex)
            {
                case 0:
                    Properties.Settings.Default.言語 = "日本語";

                    break;
                case 1:
                    Properties.Settings.Default.言語 = "EN";
                    break;
                default:
                    Properties.Settings.Default.言語 = "日本語";
                    break;
            }

            Properties.Settings.Default.Save();
            Formsys.Langage.Langage_Check();
        }

        public static TreeNode Tvparenfinder(TreeView tv)
        {
            var rootnode = tv.SelectedNode;
            //this.textBox25.TextChanged -= new EventHandler(this.textBox25_TextChanged)
            //this.treeView1.AfterSelect -= new EventHandler(this.treeView1_AfterSelect);
            while (rootnode.Parent != null)
            {
                rootnode = rootnode.Parent;
            }
            return rootnode;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            FLW2 flw2 = new FLW2();
            if (treeView1.Nodes.Count == 0) return;
            if (treeView1.SelectedNode.Tag == default) return;

            var oldindex = treeView1.SelectedNode;
            var rootnode = Form1.Tvparenfinder(treeView1);

            var rootnodelistbox3find = 0;
            if (listBox3.Items.Count != 0)
            {
                rootnodelistbox3find = listBox3.Items.IndexOf(rootnode.Text);
                listBox3.SelectedIndex = rootnodelistbox3find;
            }


            var roottag = (FLW2.flw2_item)rootnode.Tag;
            var a = (FLW2.flw2_item)treeView1.SelectedNode.Tag;
            var find = flw2.Item.IndexOf(a);
            switch (a.TypeCheck)
            {
                case 1:
                    //Console.WriteLine("メッセージ");
                    if (MsbtListBox.Items.Count == 0) break;
                    if (MsbtListBox.Items.Count > a.Unknown3) MsbtListBox.SelectedIndex = a.Unknown3;
                    if (listBox2.Items.Count == 0) break;
                    if (listBox2.Items.Count > find) listBox2.SelectedIndex = find;
                    break;
                case 2:
                    //Console.WriteLine("分岐");
                    if (listBox2.Items.Count == 0) break;
                    if (listBox2.Items.Count > find) listBox2.SelectedIndex = find;
                    break;
                case 3:
                    //Console.WriteLine("イベント");
                    if (listBox2.Items.Count == 0) break;
                    if (listBox2.Items.Count > find) listBox2.SelectedIndex = find;
                    break;
                case 4:
                    //Console.WriteLine("エントリーポイント");
                    if (listBox2.Items.Count == 0) break;
                    if (listBox2.Items.Count > find) listBox2.SelectedIndex = find;
                    break;
                default:

                    break;
            }

            //if (a.TypeCheck == 4) Console.WriteLine("せれくとつりー");

        }

        private void button25_Click(object sender, EventArgs e)
        {
            TXT2 txt2 = new TXT2();
            var str = HashCalculation.Text;
            var hash = Calculation_System.MSBT_Hash(str, 0x6);
            HashCalculation.Text = hash.ToString("X8");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</WorldNo>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</Score01>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</UserName>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</TotalPlayTime>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            var strbytes = Encoding.GetEncoding("utf-16BE").GetBytes(textBox32.Text);
            textBox33.Text = "";
            foreach (var hexbit in strbytes) textBox33.AppendText(Environment.NewLine + hexbit.ToString("X2"));
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //if (richTextBox1.Text.Contains("<Icon=\"AButton\">"))
            //{
            //    //richTextBox1.Find("");
            //    //richTextBox1.SelectionStart = richTextBox1.Find("<Icon=\"AButton\">", RichTextBoxFinds.WholeWord);
            //    //richTextBox1.SelectionLength = 16;
            //    //Image img = Image.FromFile(@"F:\Kari\LocalizeData\JpJapanese\LayoutData\Font\a.png");
            //    //Clipboard.SetImage(img);
            //    //this.richTextBox1.Paste();
            //}

            //int pos = 0;
            //for (; ; )
            //{
            //    //文字列を検索して、選択状態にする
            //    pos = richTextBox1.Find("<Icon=\"AButton\">", pos, RichTextBoxFinds.None);
            //    if (pos < 0)
            //    {
            //        break;
            //    }
            //    //背景色を赤にする
            //    Image img = Image.FromFile(@"F:\Kari\LocalizeData\JpJapanese\LayoutData\Font\a.png");

            //    Clipboard.SetImage(img);
            //    richTextBox1.Paste();
            //    pos++;
            //}

        }

        private void button31_Click(object sender, EventArgs e)
        {
            var yesno = MessageBox.Show("ツリーを更新しますか？", "質問", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (yesno == DialogResult.No) return;
            FEN1 fen1 = new FEN1();
            FEN1.TreeLoder(fen1.Item2);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button31.Enabled = true;
                treeView1.Enabled = true;
                checkBox1.Text = "ON";
            }
            else
            {
                button31.Enabled = false;
                treeView1.Enabled = false;
                treeView1.Nodes.Clear();
                checkBox1.Text = "OFF";
            }
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void HashCalculation_TextChanged(object sender, EventArgs e)
        {

        }

        private void ARC開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialog.Open(3);
        }

        private void toolStripStatusLabel7_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }
        //ATR1セクションテキストボックスのキープレスイベント
        private void Atr1SoundID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e,true);

        private void Atr1SimpleCamID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void Atr1DialogID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void Atr1WindowID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void Atr1EventCameraID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void Atr1MessageAreaID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void Atr1Unknown6_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void Atr1SpecialText_KeyPress(object sender, KeyPressEventArgs e) {
            
            KeyPressEventSupport.CanWriteChar(e, true);
        }
    }
}
