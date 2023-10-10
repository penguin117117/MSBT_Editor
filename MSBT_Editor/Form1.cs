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
using MSBT_Editor.MSBTsys;


namespace MSBT_Editor
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        private static Form1 _form1Instance;

        //開発専用のメニューを表示します
        public static readonly bool UseDevelopMenue = true;
        public static readonly bool UseDebugMenue   = true;

        private static bool s_useAutoSave = false;

        public static Form1 Form1Instance
        {
            set => _form1Instance = value;
            get => _form1Instance;
        }

        #region 開く保存ボタン
        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.Open(1);
        private void Msbt保存ToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.SaveAs(1);
        private void Msbt上書き保存ToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.Save(Dialog.Save_Path_Msbt,1);
        

        private void MSBF開くToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.Open(2);
        private void Msbf保存ToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.SaveAs(2);
        private void Msbf上書き保存ToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.Save(Dialog.Save_Path_Msbf,2);

        private void ARC開くToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.Open(3);
        private void ARC保存ToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.SaveAs(3);
        private void ARC上書き保存ToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.ArcSave();
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.Form1Instance = this;

            //開発中のフォームパーツの表示非表示を設定する。
            DebugFormPartsVisible();
            DevFormPartsVisible();

            VersionChecer();

            //言語設定
            LangageComboBox.Text = Properties.Settings.Default.言語;
            Langage.Langage_Check();

            checkBox1.Checked = true;

            //コマンドライン引数を配列で取得する
            string[] FilePathStrings = Environment.GetCommandLineArgs();
            if (FilePathStrings.Length > 1) Dialog.FileCheck(FilePathStrings[1]);


        }

        private void VersionChecer() {
            System.Diagnostics.FileVersionInfo ver =
        System.Diagnostics.FileVersionInfo.GetVersionInfo(
        System.Reflection.Assembly.GetExecutingAssembly().Location);
            label65.Text = Path.GetFileNameWithoutExtension(ver.InternalName.ToString());
            label65.Font = new Font(label65.Font.FontFamily,20);

        }

        #region デバッグと開発専用
        private void MultipleFileRead(string[] fileName,out bool readFiles) {
            readFiles = false;
            foreach (var item in fileName)
            {
                Dialog.FileCheck(item);
                if ((toolStripStatusLabel2.Text 
                    == Langage.FileReadStatusJP[0])||
                    (toolStripStatusLabel2.Text 
                    == Langage.FileReadStatusUS[0])) 
                    return;
                string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string msbtname = Path.GetFileNameWithoutExtension(toolStripStatusLabel2.Text);
                string textpath = Path.Combine(Path.GetDirectoryName(appPath), "Debug_" + msbtname + ".txt");
                textBox34.AppendText(textpath + Environment.NewLine);
                //File.WriteAllText(textpath, UnknownTag.Text);
            }
            readFiles = true;
        }

        private void DebugFormPartsVisible() {
            if (UseDebugMenue == false) 
            {
                label53.Visible = false;
                HashCalculation.Visible = false;
                button25.Visible = false;
                textBox32.Visible = false;
                textBox33.Visible = false;
                textBox13.Visible = false;
                textBox34.Visible = false;
                textBox2.Visible = false;
                textBox27.Visible = false;
                button20.Visible = false;
                MSBT_Debug_Text.Visible = false;
                UnknownTag.Visible = false;
                tabControl1.TabPages.Remove(tabPage5);
                tabControl1.TabPages.Remove(tabPage10);
            }
        }

        private void DevFormPartsVisible() {
            if (UseDevelopMenue == false)
            {
                //ARC機能の非表示
                //tabControl3.TabPages.Remove(tabPage12);
                //ARC開くToolStripMenuItem.Visible = false;
                //ARC上書き保存ToolStripMenuItem.Visible = false;
                //ARC保存ToolStripMenuItem.Visible = false;
            }
        }
        #endregion

        public static int ListBoxIndex_NegativeThenSetIndexZero(ListBox lb)
        {
            if ((lb.SelectedIndex < 0))
                lb.SelectedIndex = 0;
            if (lb.SelectedIndex > MSBT_Data.MSBT_All_Data.Item.Count())
                lb.SelectedIndex = 0;
            return lb.SelectedIndex;
        }

        private void MsbtListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MSBT_Data.MSBT_All_Data.Text.Count < 1) return;

            var MsbtSelectIndex = ListBoxIndex_NegativeThenSetIndexZero(MsbtListBox);
            var MsbtAllData     = MSBT_Data.MSBT_All_Data;
            var SpecialText     = MSBT_Data.Atr1SpecialText;
            ATR1.AttributeData Tmp;
            try
            {
                 Tmp = MsbtAllData.Item[MsbtSelectIndex];
            }
            catch (Exception)
            {
                MsbtSelectIndex = MsbtListBox.SelectedIndex = 0;
                 Tmp = MsbtAllData.Item[MsbtSelectIndex];
            }
            

            MsbtText.Text              = MsbtAllData.Text[MsbtSelectIndex];
            ReadOnlyMsbtText.Text      = MsbtText.Text;
            Atr1SoundID.Text           = Tmp.SoundID.ToString("X2");
            Atr1SimpleCamID.Text       = Tmp.SimpleCameraID.ToString("X2");
            Atr1DialogID.Text          = Tmp.DialogID.ToString("X2");
            Atr1WindowID.Text          = Tmp.WindowID.ToString("X2");
            Atr1EventCameraID.Text     = Tmp.EventCameraID.ToString("X4");
            Atr1MessageAreaID.Text     = Tmp.MessageAreaID.ToString("X2");
            Atr1Unknown6.Text          = Tmp.unknown6.ToString("X2");
            Atr1SpecialTextOffset.Text = Tmp.SpecialTextOffset.ToString("X8");
            Atr1SpecialText.Text       = SpecialText[MsbtSelectIndex];
            MsbtSelectedListName.Text  = MsbtListBox.Text;
            MsbtListSelectIndex.Text   = "0x" + MsbtListBox.SelectedIndex.ToString("X");

            if (UseDebugMenue == false) return;
            //ハッシュスキップ数を表示
            var FindMsbtListTextIndexNum = LBL1.NameList.IndexOf(MsbtListBox.Text);
            if (-1 != FindMsbtListTextIndexNum)
            {
                textBox12.Text = LBL1.HashSkipList[FindMsbtListTextIndexNum].ToString("X8");
            }
            else
            {
                textBox12.Text = "";
            }
        }

        private void Atr1SoundID_TextChanged(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            //Console.WriteLine(e.GetType().FullName);
            var Element = MSBT_Data.MSBT_All_Data.Item[MsbtListBox.SelectedIndex];
            Element.SoundID = ATR1.ATR1TextBoxChange(Atr1SoundID, Element.SoundID);
            MSBT_Data.MSBT_All_Data.Item[MsbtListBox.SelectedIndex] = Element;
        }

        private void ATR1_TextChanged(object sender, EventArgs e)
        {
            //ATR1セクションのテキストボックスの変更を
            //纏めるためのメソッドを作成中
            Console.WriteLine(((TextBox)sender).Name);
            ATR1.ATR1_Change(Atr1SimpleCamID);
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
                LBL1.HashSkipList[LBL1.NameList.IndexOf(liststrs)] = Int32.Parse(textBox12.Text, NumberStyles.HexNumber);
            }
        }

        private void MsbtText_TextChanged(object sender, EventArgs e)
        {

            if (MsbtListBox.Items.Count != 0)
            {
                MSBT_Data.MSBT_All_Data.Text[MsbtListBox.SelectedIndex] = MsbtText.Text;
            }

        }

        //非常によくない複雑で長い処理。改善する必要があります。
        //修正すると複数箇所に影響を及ぼすので慎重に修復する必要があります。
        private void AddListText_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count != 0)
            {
                if (ListNameText.Text == string.Empty) return;

                LBL1 lbl1 = new LBL1
                {
                    HashData = new List<LBL1.Hash_Data>(),
                    Item_1st = new List<LBL1.LBL_1st_Item>()
                };
                long ListCounter = 0;

                //リストボックス1のデータをハッシュデータ構造体に入れる
                foreach (var ListName in MsbtListBox.Items)
                {
                    var Hash = Calculation_System.MSBT_Hash(ListName.ToString(), lbl1.EntrySize);
                    lbl1.HashData.Add(new LBL1.Hash_Data(Hash, ListCounter));
                    ListCounter++;
                }

                var HashList = new List<LBL1.Hash_Data>(lbl1.HashData);
                HashList.Sort((a, b) => a.Hash.CompareTo(b.Hash));
                var NewHash = Calculation_System.MSBT_Hash(ListNameText.Text, lbl1.EntrySize);
                var HashMatchData = HashList.LastOrDefault(Old => Old.Hash == NewHash);

                //ハッシュ値がデフォルトの場合、新しいハッシュ値がハッシュリストの値を超える値を返す
                if (HashMatchData.Hash == default) 
                    HashMatchData = HashList.LastOrDefault(Old => Old.Hash > NewHash);

                //ハッシュ値を基準に見つかったハッシュ構造体のリスト値に+1した値にリストを挿入する
                HashMatchData.MsbtListBoxIndex++;
                MsbtListBox.Items.Insert((int)HashMatchData.MsbtListBoxIndex, ListNameText.Text);

                //リストボックスを名前順にソート
                MsbtListBox.Sorted = true;
                MsbtListBox.Sorted = false;

                var MsbtTextMatchData = MsbtListBox.Items.IndexOf(ListNameText.Text);

                MSBT_Data.MSBT_All_Data.Text.Insert(MsbtTextMatchData, "テキスト</End>");
                MSBT_Data.MSBT_All_Data.Item.Insert(MsbtTextMatchData, new ATR1.AttributeData(0x1, 0x0, 0x0, 0x0, 0x0, 0xFF, 0xFF, 0x00));
                MSBT_Data.Atr1SpecialText.Insert(MsbtTextMatchData, "");

                //重複したデータを削除
                var UnduplicatedData = HashList.Distinct();
                HashList = new List<LBL1.Hash_Data>(UnduplicatedData);

                var FoundHashList = HashList.LastOrDefault(x => x.Hash == NewHash);
                if (FoundHashList.Hash == default) FoundHashList = HashList.LastOrDefault(x => x.Hash > NewHash); ;
                //ラベル情報を追加する
                var lbl1_newindex = HashList.LastIndexOf(FoundHashList);
                //lbl1_newindex ++;
                foreach (var items in LBL1.NameList.Select((Value, Index) => (Value, Index)))
                {

                    var hashdata = Calculation_System.MSBT_Hash(items.Value, lbl1.EntrySize);

                    lbl1.Item_1st.Add(new LBL1.LBL_1st_Item(LBL1.HashSkipList[items.Index], LBL1.NameList[items.Index], hashdata));
                    Console.WriteLine(hashdata.ToString("X8"));
                    Console.WriteLine(items.Value);
                }
                lbl1.Item_1st.Sort((a, b) => a.Hash.CompareTo(b.Hash));
                var found1stitem = lbl1.Item_1st.LastOrDefault(x => x.Hash == NewHash);
                if (found1stitem.Hash == default) found1stitem = lbl1.Item_1st.LastOrDefault(x => x.Hash > NewHash);

                var newindex = lbl1.Item_1st.LastIndexOf(found1stitem);

                lbl1_newindex = /*testindex*/newindex;


                if (lbl1_newindex != -1)
                {
                    //Debugger.HashTxt("lbl newindex" + lbl1_newindex.ToString());
                    LBL1.NameOffsetList.Insert(lbl1_newindex, 0);
                    LBL1.NameList.Insert(lbl1_newindex, ListNameText.Text);
                    LBL1.HashSkipList.Insert(lbl1_newindex, 0x00000001);
                    LBL1.BeginEntryAdressList.Insert(lbl1_newindex, 0);
                }
                //Console.WriteLine("listname" + LBL1.NameList.IndexOf(ListNameText.Text).ToString("X"));
                //BattanKing002_Flow000
                //ScenarioName_RedBlueExGalaxy3
                //MSBFファイルのフロータイプ1の対象MSBTの挿入以降の番号に+1する
                if (listBox2.Items.Count == 0 || listBox3.Items.Count == 0) return;
                FLW2 flw2 = new FLW2();
                List<FLW2.flw2_item> copyitem = new List<FLW2.flw2_item>(flw2.Item);
                foreach (var flw2item in copyitem.Select((Value, Index) => (Value, Index)))
                {
                    if (flw2item.Value.TypeCheck != 1) continue;
                    if (flw2item.Value.Unknown3 < MsbtTextMatchData) continue;
                    FLW2.flw2_item newitem = flw2item.Value;
                    newitem.Unknown3++;
                    flw2.Item[flw2item.Index] = newitem;
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
                    MSBT_Data.Data_List msbtdatalist = new MSBTsys.MSBT_Data.Data_List();
                    msbtdatalist.Item = new List<ATR1.AttributeData>();
                    msbtdatalist.Text = new List<string>();
                    MSBT_Data.Atr1SpecialText = new List<string>();
                    LBL1.NameList = new List<string>();
                    LBL1.HashSkipList = new List<int>();
                    LBL1.BeginEntryAdressList = new List<long>();
                    LBL1.NameOffsetList = new List<int>();
                    //LBL1.LBL_1st_Item  = new();

                    //値を入れておく
                    MSBT_Data.MSBT_All_Data = msbtdatalist;

                    //リストボックス1とMSBTのデータに追加する
                    MsbtListBox.Items.Add(ListNameText.Text);
                    if (Properties.Settings.Default.言語 == "EN")
                        MSBT_Data.MSBT_All_Data.Text.Add("Default Text</End>");
                    else
                        MSBT_Data.MSBT_All_Data.Text.Add("テキスト</End>");
                    MSBT_Data.MSBT_All_Data.Item.Add(new ATR1.AttributeData(0x1, 0x0, 0x0, 0x0, 0x0, 0xFF, 0xFF, 0x00));
                    MSBT_Data.Atr1SpecialText.Add("");

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
            if (MsbtListBox.Items.Count != 0 && (MSBT_Data.MSBT_All_Data.Item.Count != 0) && MSBT_Data.MSBT_All_Data.Text.Count != 0)
            {
                var array_list_name = LBL1.NameList.ToArray();
                var array_search = Array.IndexOf(array_list_name, MsbtListBox.SelectedItem.ToString());
                ////Console.WriteLine("array_search -1");
                //if (array_search == -1) return;
                //Console.WriteLine("array_search -1以外");
                MSBT_Data.MSBT_All_Data.Item.RemoveRange(MsbtListBox.SelectedIndex, 1);
                MSBT_Data.MSBT_All_Data.Text.RemoveRange(MsbtListBox.SelectedIndex, 1);
                MSBT_Data.Atr1SpecialText.RemoveRange(MsbtListBox.SelectedIndex, 1);


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
            _ = new LBL1
            {
                EntrySize = Int32.Parse(textBox14.Text)
            };
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            _ = new ATR1
            {
                EntrySize = Int32.Parse(textBox15.Text)
            };
        }

        private void ColorTagInsertButton_Click(object sender, EventArgs e)
        {
            var ColorTag = new MSBT_TagData.TagInsertModified(new MSBT_TagData.ColorTag())
            {
                TagComboBox = ColorTagSelectComboBox,
                MsbtListBox = MsbtListBox,
                MsbtTextBox = MsbtText
            };
            ColorTag.ToMsbtTextBoxInsert();
        }

        private void LineControlTagInsertButton_Click(object sender, EventArgs e)
        {
            var LineControlTag = new MSBT_TagData.TagInsertModified(new MSBT_TagData.LineControlTag())
            {
                TagComboBox = LineControlTagSelectComboBox,
                MsbtListBox = MsbtListBox,
                MsbtTextBox = MsbtText
            };
            LineControlTag.ToMsbtTextBoxInsert();
        }

        private void FontSizeTagInsertButton_Click(object sender, EventArgs e)
        {
            var FontSizeTag = new MSBT_TagData.TagInsertModified(new MSBT_TagData.FontSizeTag())
            {
                TagComboBox = FontSizeTagSelectComboBox,
                MsbtListBox = MsbtListBox,
                MsbtTextBox = MsbtText
            };
            FontSizeTag.ToMsbtTextBoxInsert();
        }


        private void CenterTagInsertButton_Click(object sender, EventArgs e)
        {
            var CenterTag = new MSBT_TagData.TagInsertModified(new MSBT_TagData.CenterTag())
            {
                TagComboBox = CenterTagSelectComboBox,
                MsbtListBox = MsbtListBox,
                MsbtTextBox = MsbtText
            };
            CenterTag.ToMsbtTextBoxInsert();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            if (textBox16.Text == "" || textBox17.Text == "") return;
            string furigana = textBox16.Text;
            string kanji = textBox17.Text;
            string tag = "<Rubi=\"" + furigana + "\" Target=\"" + kanji + "\">";
            Calculation_System.TextBoxInsert(MsbtText, tag);
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyDecChar(e);
        private void textBox17_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyDecChar(e);
        private void textBox18_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyDecChar(e);
        

        private void button6_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            if (textBox18.Text == "") return;
            string time = textBox18.Text;
            string tag = "</Timer=\"" + time + "\">";
            Calculation_System.TextBoxInsert(MsbtText, tag);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</PlayCharacter>";
            Calculation_System.TextBoxInsert(MsbtText, tag);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</ReferenceValue1>";
            Calculation_System.TextBoxInsert(MsbtText, tag);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</ResultGalaxyName>";
            Calculation_System.TextBoxInsert(MsbtText, tag);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</ResultScenarioName>";
            Calculation_System.TextBoxInsert(MsbtText, tag);
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

                Calculation_System.TextBoxTagAdder(MsbtListBox, MsbtText, comboBox5, IconTag);
            }
            else
            {
                string[] IconTag = { "<Icon=\"Peach\">", "<Icon=\"Koopa\">", "<Icon=\"Kinopio\">", "<Icon=\"Mario\">", "<Icon=\"Mario2\">", "<Icon=\"Tico\">", "<Icon=\"Yoshi\">", "<Icon=\"HarapekoTico\">", "<Icon=\"Luigi\">", "<Icon=\"MasterTico\">", "<Icon=\"Columa\">", "<Icon=\"Begoman\">", "<Icon=\"Kuribo\">", "<Icon=\"Star Bunny\">" };
                Calculation_System.TextBoxTagAdder(MsbtListBox, MsbtText, comboBox5, IconTag);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] IconTag = { "<Icon=\"CometMedal\">", "<Icon=\"Coins\">", "<Icon=\"Starbit\">", "<Icon=\"StarPiece\">", "<Icon=\"PurpleStarbit\">", "<Icon=\"SilverStar\">", "<Icon=\"Star\">", "<Icon=\"GrandStar\">", "<Icon=\"BronzeStar\">", "<Icon=\"Coin\">", "<Icon=\"PurpleCoin\">", "<Icon=\"1UPMushroom\">", "<Icon=\"LifeUpMushroom\">", "<Icon=\"BlueStar\">", "<Icon=\"StarRing\">", "<Icon=\"Flower\">", "<Icon=\"Coconut\">", "<Icon=\"BlueChip\">", "<Icon=\"BlueFruit\">", "<Icon=\"CheckPointFlag\">", "<Icon=\"GrandBronzeStar\">" };
            Calculation_System.TextBoxTagAdder(MsbtListBox, MsbtText, comboBox6, IconTag);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] IconTag = { "<Icon=\"Pointer\">", "<Icon=\"PointerYellow\">", "<Icon=\"PointerHand\">", "<Icon=\"WiiMote\">", "<Icon=\"AButton\">", "<Icon=\"BButton\">", "<Icon=\"CButton\">", "<Icon=\"ZButton\">", "<Icon=\"DPad\">", "<Icon=\"DPadDown\">", "<Icon=\"DPadUp\">", "<Icon=\"JoyStick\">", "<Icon=\"Nunchuck\">", "<Icon=\"Aim\">", "<Icon=\"MButton\">", "<Icon=\"PButton\">", "<Icon=\"XIcon\">", "<Icon=\"GreenComet\">", "<Icon=\"SilverCrown\">", "<Icon=\"SilverCrownwJewel\">", "<Icon=\"GoldCrown\">", "<Icon=\"Letter\">", "<Icon=\"ArrowDown\">", "<Icon=\"StopWatch\">", "<Icon=\"1Button\">", "<Icon=\"2Button\">", "<Icon=\"HomeButton\">", "<Icon=\"PointerGrip\">", "<Icon=\"PointerNonGrip\">", "<Icon=\"QuestionMark\">", "<Icon=\"YellowComet\">", "<Icon=\"GreenQuestionMark\">", "<Icon=\"EmptyStar\">", "<Icon=\"EmptyCometMedal\">", "<Icon=\"EmptyStarComet\">", "<Icon=\"HiddenStar\">", "<Icon=\"BronzeComet\">" };
            Calculation_System.TextBoxTagAdder(MsbtListBox, MsbtText, comboBox7, IconTag);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</ReferenceValue2>";
            Calculation_System.TextBoxInsert(MsbtText, tag);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</ReferenceValue3>";
            Calculation_System.TextBoxInsert(MsbtText, tag);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</Hour>";
            Calculation_System.TextBoxInsert(MsbtText, tag);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</Minutes>";
            Calculation_System.TextBoxInsert(MsbtText, tag);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</Seconds>";
            Calculation_System.TextBoxInsert(MsbtText, tag);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</AfterTheDecimalPoint>";
            Calculation_System.TextBoxInsert(MsbtText, tag);
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
            this.Flw2Branch1Text.TextChanged -= new EventHandler(this.Flw2Branch1Text_TextChanged);
            this.Flw2Branch2Text.TextChanged -= new EventHandler(this.Flw2Branch2Text_TextChanged);

            if (listBox2.Items.Count == 0) return;
            var index = listBox2.SelectedIndex;
            if (index == -1) index = 0;
            FLW2 flw2 = new FLW2();
            //Console.WriteLine(index);
            Flw2FllowTypeText.Text = flw2.Item[index].TypeCheck.ToString("X4");
            Flw2PaddingText.Text = flw2.Item[index].Unknown1.ToString("X4");
            Flw2Arg1Text.Text = flw2.Item[index].Unknown2.ToString("X4");
            Flw2Arg2Text.Text = flw2.Item[index].Unknown3.ToString("X4");
            Flw2Arg3Text.Text = flw2.Item[index].Unknown4.ToString("X4");
            Flw2Arg4Text.Text = flw2.Item[index].Unknown5.ToString("X4");

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
                this.Flw2Branch1Text.TextChanged += new EventHandler(this.Flw2Branch1Text_TextChanged);
                this.Flw2Branch2Text.TextChanged += new EventHandler(this.Flw2Branch2Text_TextChanged);
                return;
            }
            if (-1 == flw2.Branch_List_No.IndexOf(index))
            {

                Flw2Branch1Text.Text = "";
                Flw2Branch2Text.Text = "";
                label43.Text = "0x" + listBox2.SelectedIndex.ToString("X");
                this.Flw2Branch1Text.TextChanged += new EventHandler(this.Flw2Branch1Text_TextChanged);
                this.Flw2Branch2Text.TextChanged += new EventHandler(this.Flw2Branch2Text_TextChanged);
                return;
            }
            textBox27.AppendText(Environment.NewLine + "selectlist");
            textBox27.AppendText(Environment.NewLine + flw2.Branch_No[flw2.Branch_List_No.IndexOf(index)].ToString("X4") + "___" + flw2.Branch_List_No.IndexOf(index));

            Flw2Branch1Text.Text = flw2.Branch_No[(flw2.Branch_List_No.IndexOf(index) * 2)].ToString("X4");
            Flw2Branch2Text.Text = flw2.Branch_No[(flw2.Branch_List_No.IndexOf(index) * 2) + 1].ToString("X4");

            label43.Text = "0x" + listBox2.SelectedIndex.ToString("X");
            this.Flw2Branch1Text.TextChanged += new EventHandler(this.Flw2Branch1Text_TextChanged);
            this.Flw2Branch2Text.TextChanged += new EventHandler(this.Flw2Branch2Text_TextChanged);
        }

        private void Flw2FllowTypeText_TextChanged(object sender, EventArgs e)
        {
            this.listBox2.SelectedIndexChanged -= new EventHandler(this.listBox2_SelectedIndexChanged);
            FLW2.FLW2_Item_Change(listBox2, Flw2FllowTypeText);
            this.listBox2.SelectedIndexChanged += new EventHandler(this.listBox2_SelectedIndexChanged);
        }

        private void Flw2PaddingText_TextChanged(object sender, EventArgs e)
        {
            this.listBox2.SelectedIndexChanged -= new EventHandler(this.listBox2_SelectedIndexChanged);
            FLW2.FLW2_Item_Change(listBox2, Flw2PaddingText);
            this.listBox2.SelectedIndexChanged += new EventHandler(this.listBox2_SelectedIndexChanged);
        }

        private void Flw2Arg1Text_TextChanged(object sender, EventArgs e)
        {
            FLW2.FLW2_Item_Change(listBox2, Flw2Arg1Text);
        }

        private void Flw2Arg2Text_TextChanged(object sender, EventArgs e)
        {
            FLW2.FLW2_Item_Change(listBox2, Flw2Arg2Text);
        }

        private void Flw2Arg3Text_TextChanged(object sender, EventArgs e)
        {
            FLW2.FLW2_Item_Change(listBox2, Flw2Arg3Text);
        }

        private void Flw2Arg4Text_TextChanged(object sender, EventArgs e)
        {
            FLW2.FLW2_Item_Change(listBox2, Flw2Arg4Text);
        }

        private void Flw2Branch1Text_TextChanged(object sender, EventArgs e)
        {
            textBox27.AppendText(Environment.NewLine + "25text");
            FLW2.FLW2_FlowType2_Branch(listBox2, Flw2Branch1Text);
        }

        private void Flw2Branch2Text_TextChanged(object sender, EventArgs e)
        {
            FLW2.FLW2_FlowType2_Branch(listBox2, Flw2Branch2Text);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var filecount = fileName.Count();

            if (UseDebugMenue == true) 
            {
                MultipleFileRead(fileName, out bool readFiles);
                if (readFiles == true) return;
            }
            

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

        private void LangageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LangageComboBox.SelectedIndex)
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

        private void MsbfTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            FLW2 flw2 = new FLW2();
            if (MsbfTreeView.Nodes.Count == 0) return;
            if (MsbfTreeView.SelectedNode.Tag == default) return;

            //var oldindex = MsbfTreeView.SelectedNode;
            var rootnode = Form1.Tvparenfinder(MsbfTreeView);

            var rootnodelistbox3find = 0;
            if (listBox3.Items.Count != 0)
            {
                rootnodelistbox3find = listBox3.Items.IndexOf(rootnode.Text);
                listBox3.SelectedIndex = rootnodelistbox3find;
            }


            var roottag = (FLW2.flw2_item)rootnode.Tag;
            var a = (FLW2.flw2_item)MsbfTreeView.SelectedNode.Tag;
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
            Calculation_System.TextBoxInsert(MsbtText, tag);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</Score01>";
            Calculation_System.TextBoxInsert(MsbtText, tag);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</UserName>";
            Calculation_System.TextBoxInsert(MsbtText, tag);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (MsbtListBox.Items.Count < 1) return;
            string tag = "</TotalPlayTime>";
            Calculation_System.TextBoxInsert(MsbtText, tag);
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
            try { FEN1.TreeLoder(fen1.Item2); }
            catch (Exception ex){
                MsbfTreeView.Nodes.Clear();
                Console.WriteLine("errrrrrror"); 
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button31.Enabled = true;
                MsbfTreeView.Enabled = true;
                checkBox1.Text = "ON";
            }
            else
            {
                button31.Enabled = false;
                MsbfTreeView.Enabled = false;
                MsbfTreeView.Nodes.Clear();
                checkBox1.Text = "OFF";
            }
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void HashCalculation_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void toolStripStatusLabel7_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }
        //ATR1セクションテキストボックスのキープレスイベント
        private void Atr1SoundID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void Atr1SimpleCamID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void Atr1DialogID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void Atr1WindowID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void Atr1EventCameraID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void Atr1MessageAreaID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void Atr1Unknown6_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void Atr1SpecialText_KeyPress(object sender, KeyPressEventArgs e)
        {

            KeyPressEventSupport.CanWriteChar(e, true);
        }

        private void textBox30_MouseClick(object sender, MouseEventArgs e)
        {
            this.MsbtSelectedListName.SelectAll();
        }

        private void UserIconInsertButton_Click(object sender, EventArgs e)
        {
            
            var Tag = UserIconInsertTextBox.Text;
            var StrCount = Tag.Length;

            //末尾6バイト(12文字)の制限
            //例:<UserIcon="000E0003 00350002003A">
            if (StrCount != 12) return; 

            if (MsbtListBox.Items.Count < 1) return;
            
            Tag = "<UserIcon=\"000E0003"+ Tag + "\">";
            
            
            
            
            Calculation_System.TextBoxInsert(MsbtText,Tag);
        }

        private void UserIconInsertTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UserIconInsertTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            KeyPressEventSupport.OnlyHexChar(e, true);
        }

        

        private void MsbtSETagInsertButton_Click(object sender, EventArgs e)
        {
            //<SE="SE_BV_KOOPA_BURN_RUN">
            var Tag = SETagInsertTextBox.Text;
            if (Tag == string.Empty) return;

            if (MsbtListBox.Items.Count < 1) return;

            Tag = "<SE=\"" + Tag + "\">";
            Calculation_System.TextBoxInsert(MsbtText, Tag);
        }

        private void ReadOnlyMsbtText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var ResourceARCFolder = Path.GetDirectoryName(Application.ExecutablePath) + "\\res\\" + "ARC";
            if (Directory.Exists(ResourceARCFolder)) Directory.Delete(ResourceARCFolder,true);
        }

        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/penguin117117/MSBT_Editor/releases");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/penguin117117/MSBT_Editor");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/penguin117117/MSBT_Editor/issues");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel5.LinkVisited = true;
            System.Diagnostics.Process.Start("http://mariogalaxy2hack.wiki.fc2.com/wiki/MSBT_Editor");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://discord.gg/B4EwY7h");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Flw2FllowTypeText_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true); 

        private void Flw2Branch1Text_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void button1_Click(object sender, EventArgs e)
        {
            string[] OldStrings = UnknownTag.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            UnknownTag.Text = string.Empty;
            var Sorted = OldStrings.OrderBy(sort => sort).ToArray();

            foreach (var tes in Sorted) UnknownTag.AppendText(tes+Environment.NewLine);
        }

        private void MsbtMsbfAutoSaveCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (MsbtMsbfAutoSaveCheckBox.Checked == false)
            {
                s_useAutoSave = false;
            }
            else
            {
                s_useAutoSave = true;
            }
        }

        private void ARCListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(ARCListBox.SelectedValue);
        }
        private void ARCListBox_SelectedIndexChanged(object sender, EventArgs e/*EventHandler e*/)
        {

            var SaveSelect = DialogResult;

            if (Dialog.ArcInsideMsbtAndMsbfPath.Count < 1) return;
            if (ARCListBox.Items.Count < 0) return;

            var Index = ARCListBox.SelectedIndex;
            if (Properties.Settings.Default.ARCListIndexOld == -1)
            {
                Properties.Settings.Default.ARCListIndexOld = Index;
                Properties.Settings.Default.Save();
            }

            //if (s_useAutoSave == false && Properties.Settings.Default.ARCListIndexOld != Index)
            //{
            //    SaveSelect =
            //    MessageBox.Show(
            //        "ファイルを上書きしますか？",
            //        "質問",
            //        MessageBoxButtons.YesNo,
            //        MessageBoxIcon.Information,
            //        MessageBoxDefaultButton.Button2
            //    );
            //}

            //if (DialogResult.No == SaveSelect) 
            //{
            //    if (Properties.Settings.Default.ARCListIndexOld < 0) return;
            //    ARCListBox.SelectedIndex = Properties.Settings.Default.ARCListIndexOld;
            //    return;
            //}

            //if (s_useAutoSave == true) SaveSelect = DialogResult.Yes;

            //連続で選択した際にデータが壊れないようにしています。
            ARCListBox.Enabled = false;

            var PathExtention = Path.GetExtension(ARCListBox.Text).ToLower();
            var PathFileName = ARCListBox.Text;
            //Dialog.FileCheckの処理中にこのイベントを発生させないようにしている。
            this.ARCListBox.SelectedIndexChanged -= new EventHandler(this.ARCListBox_SelectedIndexChanged);

            //if (Path.GetExtension()) ;
            var OldPath = ARCListBox.Items[Properties.Settings.Default.ARCListIndexOld].ToString();


            var MsbtOldName = toolStripStatusLabel2.Text;
            var MsbfOldName = toolStripStatusLabel4.Text;

            bool IsMsbtDef = false;
            bool IsMsbfDef = false;

            if (MsbtOldName == Langage.FileReadStatusJP[0]) IsMsbtDef = true;
            if (MsbfOldName == Langage.FileReadStatusJP[1]) IsMsbfDef = true;


            if (Properties.Settings.Default.言語 == "EN") 
            {
                if (MsbtOldName == Langage.FileReadStatusUS[0]) IsMsbtDef = true;
                if (MsbfOldName == Langage.FileReadStatusUS[1]) IsMsbfDef = true;
            }
            
            if ((PathExtention == ".msbt") && (Dialog.Save_Path_Msbt != ARCListBox.Text))
            {

                if ((s_useAutoSave == false) &&  (MsbtOldName != PathFileName) && IsMsbtDef == false)
                {
                    SaveSelect =
                    MessageBox.Show(
                        "ファイルを上書きしますか？",
                        "質問",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button2
                    );
                }

                if (DialogResult.No == SaveSelect)
                {
                    if (Properties.Settings.Default.ARCListIndexOld < 0) 
                    {
                        //if (ARCListBox.Items.Count < 1) 
                        //{
                        //    throw new Exception("ARCListの数が0以下です。");
                        //}
                        //this.ARCListBox.SelectedIndexChanged += new EventHandler(this.ARCListBox_SelectedIndexChanged);

                        return;
                    }
                    //ARCListBox.Enabled = true;
                    //ARCListBox.SelectedIndex = Properties.Settings.Default.ARCListIndexOld;
                    //this.ARCListBox.SelectedIndexChanged += new EventHandler(this.ARCListBox_SelectedIndexChanged);
                    //ARCListBox.Focus();
                    //return;
                }

                if (s_useAutoSave == true) 
                {
                    SaveSelect = DialogResult.Yes;
                    if (File.Exists(Dialog.Save_Path_Msbt)) Dialog.Save(Dialog.Save_Path_Msbt, 1);
                } 
                
                
                
            }
            else if ((PathExtention == ".msbf") && (Dialog.Save_Path_Msbf != ARCListBox.Text))
            {
                if ((s_useAutoSave == false)  && (MsbfOldName != PathFileName) && IsMsbfDef == false)
                {
                    SaveSelect =
                    MessageBox.Show(
                        "ファイルを上書きしますか？",
                        "質問",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button2
                    );
                }

                if (DialogResult.No == SaveSelect)
                {
                    if (Properties.Settings.Default.ARCListIndexOld < 0) return;
                    ARCListBox.SelectedIndex = Properties.Settings.Default.ARCListIndexOld;
                    ARCListBox.Enabled = true;
                    return;
                }

                if (s_useAutoSave == true) 
                {
                SaveSelect = DialogResult.Yes;
                if (File.Exists(Dialog.Save_Path_Msbf)) Dialog.Save(Dialog.Save_Path_Msbf, 2);
                } 
            }
            else 
            {
                this.ARCListBox.SelectedIndexChanged += new EventHandler(this.ARCListBox_SelectedIndexChanged);
                ARCListBox.Enabled = true;
                return;
            }

            Dialog.FileCheck(Dialog.ArcInsideMsbtAndMsbfPath[Index]);
            this.ARCListBox.SelectedIndexChanged += new EventHandler(this.ARCListBox_SelectedIndexChanged);

            //古いリストのセレクト番号を上書き
            Properties.Settings.Default.ARCListIndexOld = Index;
            Properties.Settings.Default.Save();

            ARCListBox.Enabled = true;
            ARCListBox.Focus();
        }

        private void ARCListBox_CursorChanged(object sender, EventArgs e)
        {
            Console.WriteLine(ARCListBox.SelectedValue);
        }

        private void ARCListBox_Validating(object sender, CancelEventArgs e)
        {
            Console.WriteLine(ARCListBox.SelectedValue);
        }

        private void ARCListBox_ChangeUICues(object sender, UICuesEventArgs e)
        {
            
            Console.WriteLine(ARCListBox.SelectedValue);
        }
    }
}
