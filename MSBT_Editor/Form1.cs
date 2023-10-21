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
        public static readonly bool EnableDevelopMenu = true;
        public static readonly bool EnableDebugMenu = true;

        private static bool s_useAutoSave = false;

        public static Form1 Form1Instance
        {
            set => _form1Instance = value;
            get => _form1Instance;
        }

        #region 開く保存ボタン
        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.Open(1);
        private void Msbt保存ToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.SaveAs(1);
        private void Msbt上書き保存ToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.Save(Dialog.Save_Path_Msbt, 1);


        private void Msbf開くToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.Open(2);
        private void Msbf保存ToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.SaveAs(2);
        private void Msbf上書き保存ToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.Save(Dialog.Save_Path_Msbf, 2);

        private void Arc開くToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.Open(3);
        private void Arc保存ToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.SaveAs(3);
        private void Arc上書き保存ToolStripMenuItem_Click(object sender, EventArgs e) => Dialog.ArcSave();
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.Form1Instance = this;

            //開発中のフォームパーツの表示非表示を設定する。
            DebugFormPartsVisible();
            DevFormPartsVisible();

            VersionChecer();

            //言語設定
            cmbLanguage.Text = Properties.Settings.Default.言語;
            Language.Language_Check();

            chkShowTvwMsbfFlow.Checked = true;

            //コマンドライン引数を配列で取得する
            string[] FilePathStrings = Environment.GetCommandLineArgs();
            if (FilePathStrings.Length > 1) Dialog.FileCheck(FilePathStrings[1]);


        }

        private void VersionChecer()
        {
            System.Diagnostics.FileVersionInfo ver =
        System.Diagnostics.FileVersionInfo.GetVersionInfo(
        System.Reflection.Assembly.GetExecutingAssembly().Location);
            lblCurrentVersion.Text = Path.GetFileNameWithoutExtension(ver.InternalName.ToString());
            lblCurrentVersion.Font = new Font(lblCurrentVersion.Font.FontFamily, 20);

        }

        #region デバッグと開発専用
        private void MultipleFileRead(string[] fileName, out bool readFiles)
        {
            readFiles = false;
            foreach (var item in fileName)
            {
                Dialog.FileCheck(item);
                if ((stbOpenedMsbtName.Text
                    == Language.FileReadStatusJP[0]) ||
                    (stbOpenedMsbtName.Text
                    == Language.FileReadStatusUS[0]))
                    return;
                string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string msbtname = Path.GetFileNameWithoutExtension(stbOpenedMsbtName.Text);
                string textpath = Path.Combine(Path.GetDirectoryName(appPath), "Debug_" + msbtname + ".txt");
                textBox34.AppendText(textpath + Environment.NewLine);
                //File.WriteAllText(textpath, UnknownTag.Text);
            }
            readFiles = true;
        }

        private void DebugFormPartsVisible()
        {
            if (EnableDebugMenu == false)
            {
                lblMsbfHashCalculator.Visible = false;
                txtListNameToCalculateHash.Visible = false;
                btnCalculateHash.Visible = false;
                textBox32.Visible = false;
                textBox33.Visible = false;
                txtFlw2DebugHex.Visible = false;
                textBox34.Visible = false;
                textBox2.Visible = false;
                textBox27.Visible = false;
                btnReleaseDebugTextFile.Visible = false;
                MSBT_Debug_Text.Visible = false;
                txtUnknownTag.Visible = false;
                tabControl1.TabPages.Remove(tbpDebugMsbf);
                tabControl1.TabPages.Remove(tbpDebug);
            }
        }

        private void DevFormPartsVisible()
        {
            if (EnableDevelopMenu == false)
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
            if ((lb.SelectedIndex < 0)) lb.SelectedIndex = 0;
            if (lb.SelectedIndex > MSBT_Data.MSBT_All_Data.Item.Count()) lb.SelectedIndex = 0;
            return lb.SelectedIndex;
        }

        private void LstListsInsideMsbt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (MSBT_Data.MSBT_All_Data.Text.Count == default)
            //{
            //    MsbtText.Clear();
            //    ReadOnlyMsbtText.Clear();
            //    Atr1SoundID.Clear();
            //    Atr1SimpleCamID.Clear();
            //    Atr1DialogID.Clear();
            //    Atr1WindowID.Clear();
            //    Atr1EventCameraID.Clear();
            //    Atr1MessageAreaID.Clear();
            //    Atr1Unknown6.Clear();
            //    Atr1SpecialTextOffset.Clear();
            //    Atr1SpecialText.Clear();
            //    MsbtSelectedListName.Clear();
            //    MsbtListSelectIndex.Text = "0x00";
            //    return;
            //}

            if (MSBT_Data.MSBT_All_Data.Text.Count < 1) return;

            var MsbtSelectIndex = ListBoxIndex_NegativeThenSetIndexZero(lstListsInsideMsbt);
            var MsbtAllData = MSBT_Data.MSBT_All_Data;
            var SpecialText = MSBT_Data.Atr1SpecialText;
            ATR1.AttributeData Tmp;
            try
            {
                Tmp = MsbtAllData.Item[MsbtSelectIndex];
            }
            catch (Exception)
            {
                MsbtSelectIndex = lstListsInsideMsbt.SelectedIndex = 0;
                Tmp = MsbtAllData.Item[MsbtSelectIndex];
            }

            txtMsbtText.Text = MsbtAllData.Text[MsbtSelectIndex];
            txtReadOnlyMsbtText.Text = txtMsbtText.Text;
            txtAtr1SoundID.Text = Tmp.SoundID.ToString("X2");
            txtAtr1SimpleCameraID.Text = Tmp.SimpleCameraID.ToString("X2");
            txtAtr1DialogID.Text = Tmp.DialogID.ToString("X2");
            txtAtr1WindowID.Text = Tmp.WindowID.ToString("X2");
            txtAtr1EventCameraID.Text = Tmp.EventCameraID.ToString("X4");
            txtAtr1MessageAreaID.Text = Tmp.MessageAreaID.ToString("X2");
            txtAtr1Unknown6.Text = Tmp.unknown6.ToString("X2");
            txtAtr1SpecialTextOffset.Text = Tmp.SpecialTextOffset.ToString("X8");
            txtAtr1SpecialText.Text = SpecialText[MsbtSelectIndex];
            txtSelectedMsbtListName.Text = lstListsInsideMsbt.Text;
            lblMsbtListSelectIndex.Text = "0x" + lstListsInsideMsbt.SelectedIndex.ToString("X");

            if (EnableDebugMenu == false) return;
            //ハッシュスキップ数を表示
            var FindMsbtListTextIndexNum = LBL1.NameList.IndexOf(lstListsInsideMsbt.Text);
            if (-1 != FindMsbtListTextIndexNum)
            {
                txtLbl1TagIndex.Text = LBL1.HashSkipList[FindMsbtListTextIndexNum].ToString("X8");
            }
            else
            {
                txtLbl1TagIndex.Text = "";
            }
        }

        private void TxtAtr1SoundID_TextChanged(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            //Console.WriteLine(e.GetType().FullName);
            var Element = MSBT_Data.MSBT_All_Data.Item[lstListsInsideMsbt.SelectedIndex];
            Element.SoundID = ATR1.ATR1TextBoxChange(txtAtr1SoundID, Element.SoundID);
            MSBT_Data.MSBT_All_Data.Item[lstListsInsideMsbt.SelectedIndex] = Element;
        }

        private void ATR1_TextChanged(object sender, EventArgs e)
        {
            //ATR1セクションのテキストボックスの変更を
            //纏めるためのメソッドを作成中
            Console.WriteLine(((TextBox)sender).Name);
            ATR1.ATR1_Change(txtAtr1SimpleCameraID);
        }

        private void TxtAtr1SimpleCameraID_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(txtAtr1SimpleCameraID);
        }

        private void TxtAtr1DialogID_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(txtAtr1DialogID);
        }

        private void TxtAtr1WindowID_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(txtAtr1WindowID);
        }

        private void TxtAtr1EventCameraID_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(txtAtr1EventCameraID);
        }

        private void TxtAtr1MessageAreaID_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(txtAtr1MessageAreaID);
        }

        private void TxtAtr1Unknown6_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(txtAtr1Unknown6);
        }

        private void TxtAtr1SpecialText_TextChanged(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            ATR1.SpecialTextList[lstListsInsideMsbt.SelectedIndex] = txtAtr1SpecialText.Text;
        }

        private void TxtLbl1TagIndex_TextChanged(object sender, EventArgs e)
        {
            var liststrs = lstListsInsideMsbt.Text;
            if (-1 != LBL1.NameList.IndexOf(liststrs))
            {
                var unknownlbldata = LBL1.BeginEntryAdressList[LBL1.NameList.IndexOf(liststrs)].ToString("X");
                LBL1.HashSkipList[LBL1.NameList.IndexOf(liststrs)] = Int32.Parse(txtLbl1TagIndex.Text, NumberStyles.HexNumber);
            }
        }

        private void TxtMsbtText_TextChanged(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count != 0)
            {
                MSBT_Data.MSBT_All_Data.Text[lstListsInsideMsbt.SelectedIndex] = txtMsbtText.Text;
            }
        }

        //非常によくない複雑で長い処理。改善する必要があります。
        //修正すると複数箇所に影響を及ぼすので慎重に修復する必要があります。
        private void BtnAddMsbtList_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count != 0)
            {
                if (txtMsbtListName.Text == string.Empty) return;

                LBL1 lbl1 = new LBL1
                {
                    HashData = new List<LBL1.Hash_Data>(),
                    Item_1st = new List<LBL1.LBL_1st_Item>()
                };
                long ListCounter = 0;

                //リストボックス1のデータをハッシュデータ構造体に入れる
                foreach (var ListName in lstListsInsideMsbt.Items)
                {
                    var Hash = Calculation_System.MSBT_Hash(ListName.ToString(), lbl1.EntrySize);
                    lbl1.HashData.Add(new LBL1.Hash_Data(Hash, ListCounter));
                    ListCounter++;
                }

                var HashList = new List<LBL1.Hash_Data>(lbl1.HashData);
                HashList.Sort((a, b) => a.Hash.CompareTo(b.Hash));
                var NewHash = Calculation_System.MSBT_Hash(txtMsbtListName.Text, lbl1.EntrySize);
                var HashMatchData = HashList.LastOrDefault(Old => Old.Hash == NewHash);

                //ハッシュ値がデフォルトの場合、新しいハッシュ値がハッシュリストの値を超える値を返す
                if (HashMatchData.Hash == default)
                    HashMatchData = HashList.LastOrDefault(Old => Old.Hash > NewHash);

                //ハッシュ値を基準に見つかったハッシュ構造体のリスト値に+1した値にリストを挿入する
                HashMatchData.MsbtListBoxIndex++;
                lstListsInsideMsbt.Items.Insert((int)HashMatchData.MsbtListBoxIndex, txtMsbtListName.Text);

                //リストボックスを名前順にソート
                lstListsInsideMsbt.Sorted = true;
                lstListsInsideMsbt.Sorted = false;

                var MsbtTextMatchData = lstListsInsideMsbt.Items.IndexOf(txtMsbtListName.Text);

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
                    LBL1.NameList.Insert(lbl1_newindex, txtMsbtListName.Text);
                    LBL1.HashSkipList.Insert(lbl1_newindex, 0x00000001);
                    LBL1.BeginEntryAdressList.Insert(lbl1_newindex, 0);
                }
                //Console.WriteLine("listname" + LBL1.NameList.IndexOf(ListNameText.Text).ToString("X"));
                //BattanKing002_Flow000
                //ScenarioName_RedBlueExGalaxy3
                //MSBFファイルのフロータイプ1の対象MSBTの挿入以降の番号に+1する
                if (lstListsInsideFlw2.Items.Count == 0 || lstListsInsideFen1.Items.Count == 0) return;
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
                if (txtMsbtListName.Text != "")
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
                    lstListsInsideMsbt.Items.Add(txtMsbtListName.Text);
                    if (Properties.Settings.Default.言語 == "EN")
                        MSBT_Data.MSBT_All_Data.Text.Add("Default Text</End>");
                    else
                        MSBT_Data.MSBT_All_Data.Text.Add("テキスト</End>");
                    MSBT_Data.MSBT_All_Data.Item.Add(new ATR1.AttributeData(0x1, 0x0, 0x0, 0x0, 0x0, 0xFF, 0xFF, 0x00));
                    MSBT_Data.Atr1SpecialText.Add("");

                    //ラベル情報を追加する
                    LBL1.NameOffsetList.Add(0);
                    LBL1.NameList.Add(txtMsbtListName.Text);
                    LBL1.HashSkipList.Add(1);
                    LBL1.BeginEntryAdressList.Add(0);
                }
            }
        }

        private void BtnDeleteMsbtList_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count != 0 && (MSBT_Data.MSBT_All_Data.Item.Count != 0) && MSBT_Data.MSBT_All_Data.Text.Count != 0)
            {
                var array_list_name = LBL1.NameList.ToArray();
                var array_search = Array.IndexOf(array_list_name, lstListsInsideMsbt.SelectedItem.ToString());
                ////Console.WriteLine("array_search -1");
                //if (array_search == -1) return;
                //Console.WriteLine("array_search -1以外");
                MSBT_Data.MSBT_All_Data.Item.RemoveRange(lstListsInsideMsbt.SelectedIndex, 1);
                MSBT_Data.MSBT_All_Data.Text.RemoveRange(lstListsInsideMsbt.SelectedIndex, 1);
                MSBT_Data.Atr1SpecialText.RemoveRange(lstListsInsideMsbt.SelectedIndex, 1);


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
                var listselect = lstListsInsideMsbt.SelectedIndex;
                lstListsInsideMsbt.Items.RemoveAt(listselect);
            }
        }

        private void TxtLbl1EntrySize_TextChanged(object sender, EventArgs e)
        {
            _ = new LBL1
            {
                EntrySize = Int32.Parse(txtLbl1EntrySize.Text)
            };
        }

        private void TxtAtr1EntrySize_TextChanged(object sender, EventArgs e)
        {
            _ = new ATR1
            {
                EntrySize = Int32.Parse(txtAtr1EntrySize.Text)
            };
        }

        private void BtnInsertColorTag_Click(object sender, EventArgs e)
        {
            var ColorTag = new MSBT_TagData.TagInsertModified(new MSBT_TagData.ColorTag())
            {
                TagComboBox = cmbColorTag,
                MsbtListBox = lstListsInsideMsbt,
                MsbtTextBox = txtMsbtText
            };
            ColorTag.ToMsbtTextBoxInsert();
        }

        private void BtnInsertLineControlTag_Click(object sender, EventArgs e)
        {
            var LineControlTag = new MSBT_TagData.TagInsertModified(new MSBT_TagData.LineControlTag())
            {
                TagComboBox = cmbLineControlTag,
                MsbtListBox = lstListsInsideMsbt,
                MsbtTextBox = txtMsbtText
            };
            LineControlTag.ToMsbtTextBoxInsert();
        }

        private void BtnInsertFontSizeTag_Click(object sender, EventArgs e)
        {
            var FontSizeTag = new MSBT_TagData.TagInsertModified(new MSBT_TagData.FontSizeTag())
            {
                TagComboBox = cmbFontSizeTag,
                MsbtListBox = lstListsInsideMsbt,
                MsbtTextBox = txtMsbtText
            };
            FontSizeTag.ToMsbtTextBoxInsert();
        }


        private void BtnInsertCenterTag_Click(object sender, EventArgs e)
        {
            var CenterTag = new MSBT_TagData.TagInsertModified(new MSBT_TagData.CenterTag())
            {
                TagComboBox = cmbCenterTag,
                MsbtListBox = lstListsInsideMsbt,
                MsbtTextBox = txtMsbtText
            };
            CenterTag.ToMsbtTextBoxInsert();
        }

        private void BtnInsertRubiTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            if (txtRubiTagRubiCount.Text == "" || txtRubiTagKanjiCount.Text == "") return;
            string furigana = txtRubiTagRubiCount.Text;
            string kanji = txtRubiTagKanjiCount.Text;
            string tag = "<Rubi=\"" + furigana + "\" Target=\"" + kanji + "\">";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void TxtRubiTagRubiCount_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyDecChar(e);
        private void TxtRubiTagKanjiCount_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyDecChar(e);
        private void TxtTimerTagDelayTime_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyDecChar(e);


        private void BtnInsertTimerTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            if (txtTimerTagDelayTime.Text == "") return;
            string time = txtTimerTagDelayTime.Text;
            string tag = "</Timer=\"" + time + "\">";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void BtnInsertPlayerCharacterTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            string tag = "</PlayCharacter>";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void BtnInsertVariableInt3DigitsTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            string tag = "</ReferenceValue1>";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void BtnInsertResultGalaxyNameTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            string tag = "</ResultGalaxyName>";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void BtnInsertResultScenarioNameTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            string tag = "</ResultScenarioName>";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void BtnInsertCharacterIconTag_Click(object sender, EventArgs e)
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

                Calculation_System.TextBoxTagAdder(lstListsInsideMsbt, txtMsbtText, cmbCharacterIconTag, IconTag);
            }
            else
            {
                string[] IconTag = { "<Icon=\"Peach\">", "<Icon=\"Koopa\">", "<Icon=\"Kinopio\">", "<Icon=\"Mario\">", "<Icon=\"Mario2\">", "<Icon=\"Tico\">", "<Icon=\"Yoshi\">", "<Icon=\"HarapekoTico\">", "<Icon=\"Luigi\">", "<Icon=\"MasterTico\">", "<Icon=\"Columa\">", "<Icon=\"Begoman\">", "<Icon=\"Kuribo\">", "<Icon=\"Star Bunny\">" };
                Calculation_System.TextBoxTagAdder(lstListsInsideMsbt, txtMsbtText, cmbCharacterIconTag, IconTag);
            }
        }

        private void BtnInsertObjectIconTag_Click(object sender, EventArgs e)
        {
            string[] IconTag = { "<Icon=\"CometMedal\">", "<Icon=\"Coins\">", "<Icon=\"Starbit\">", "<Icon=\"StarPiece\">", "<Icon=\"PurpleStarbit\">", "<Icon=\"SilverStar\">", "<Icon=\"Star\">", "<Icon=\"GrandStar\">", "<Icon=\"BronzeStar\">", "<Icon=\"Coin\">", "<Icon=\"PurpleCoin\">", "<Icon=\"1UPMushroom\">", "<Icon=\"LifeUpMushroom\">", "<Icon=\"BlueStar\">", "<Icon=\"StarRing\">", "<Icon=\"Flower\">", "<Icon=\"Coconut\">", "<Icon=\"BlueChip\">", "<Icon=\"BlueFruit\">", "<Icon=\"CheckPointFlag\">", "<Icon=\"GrandBronzeStar\">" };
            Calculation_System.TextBoxTagAdder(lstListsInsideMsbt, txtMsbtText, cmbObjectIconTag, IconTag);
        }

        private void BtnInsertOtherIconTag_Click(object sender, EventArgs e)
        {
            string[] IconTag = { "<Icon=\"Pointer\">", "<Icon=\"PointerYellow\">", "<Icon=\"PointerHand\">", "<Icon=\"WiiMote\">", "<Icon=\"AButton\">", "<Icon=\"BButton\">", "<Icon=\"CButton\">", "<Icon=\"ZButton\">", "<Icon=\"DPad\">", "<Icon=\"DPadDown\">", "<Icon=\"DPadUp\">", "<Icon=\"JoyStick\">", "<Icon=\"Nunchuck\">", "<Icon=\"Aim\">", "<Icon=\"MButton\">", "<Icon=\"PButton\">", "<Icon=\"XIcon\">", "<Icon=\"GreenComet\">", "<Icon=\"SilverCrown\">", "<Icon=\"SilverCrownwJewel\">", "<Icon=\"GoldCrown\">", "<Icon=\"Letter\">", "<Icon=\"ArrowDown\">", "<Icon=\"StopWatch\">", "<Icon=\"1Button\">", "<Icon=\"2Button\">", "<Icon=\"HomeButton\">", "<Icon=\"PointerGrip\">", "<Icon=\"PointerNonGrip\">", "<Icon=\"QuestionMark\">", "<Icon=\"YellowComet\">", "<Icon=\"GreenQuestionMark\">", "<Icon=\"EmptyStar\">", "<Icon=\"EmptyCometMedal\">", "<Icon=\"EmptyStarComet\">", "<Icon=\"HiddenStar\">", "<Icon=\"BronzeComet\">" };
            Calculation_System.TextBoxTagAdder(lstListsInsideMsbt, txtMsbtText, cmbOtherIconTag, IconTag);
        }

        private void BtnInsertVariableInt4DigitsTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            string tag = "</ReferenceValue2>";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void BtnInsertVariableInt5DigitsTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            string tag = "</ReferenceValue3>";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void BtnInsertHourTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            string tag = "</Hour>";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void BtnInsertMinuteTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            string tag = "</Minutes>";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void BtnInsertSecondTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            string tag = "</Seconds>";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void BtnInsertNumbersBelowDecimalPointTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            string tag = "</AfterTheDecimalPoint>";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void BtnReleaseDebugTextFile_Click(object sender, EventArgs e)
        {
            if (stbOpenedMsbtName.Text == " ") return;
            if (txtFlw2DebugHex.Text == "") return;
            string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string msbtname = Path.GetFileNameWithoutExtension(stbOpenedMsbtName.Text);
            string textpath = Path.Combine(Path.GetDirectoryName(appPath), msbtname + ".txt");
            //Console.WriteLine(textpath);

            File.WriteAllText(textpath, txtFlw2DebugHex.Text);
        }

        private void LstListsInsideFlw2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtFlw2BranchTrue.TextChanged -= new EventHandler(this.TxtFlw2BranchTrue_TextChanged);
            this.txtFlw2BranchFalse.TextChanged -= new EventHandler(this.TxtFlw2BranchFalse_TextChanged);

            if (lstListsInsideFlw2.Items.Count == 0) return;
            var index = lstListsInsideFlw2.SelectedIndex;
            if (index == -1) index = 0;
            FLW2 flw2 = new FLW2();
            //Console.WriteLine(index);
            txtFlw2FlowType.Text = flw2.Item[index].TypeCheck.ToString("X4");
            txtFlw2Padding.Text = flw2.Item[index].Unknown1.ToString("X4");
            txtFlw2Arg1.Text = flw2.Item[index].Unknown2.ToString("X4");
            txtFlw2Arg2.Text = flw2.Item[index].Unknown3.ToString("X4");
            txtFlw2Arg3.Text = flw2.Item[index].Unknown4.ToString("X4");
            txtFlw2Arg4.Text = flw2.Item[index].Unknown5.ToString("X4");

            switch (flw2.Item[index].TypeCheck.ToString("X4"))
            {
                case "0001":
                    lblFlw2Arg1.Text = "グループ番号";
                    lblFlw2Arg2.Text = "MSBTテキストlist番号";
                    lblFlw2Arg3.Text = "FLW2オフセット";
                    lblFlw2Arg4.Text = "不明5";
                    if (Properties.Settings.Default.言語 == "日本語") break;
                    lblFlw2Arg1.Text = "Group number";
                    lblFlw2Arg2.Text = "MSBT Entry";
                    lblFlw2Arg3.Text = "Next Flow";
                    lblFlw2Arg4.Text = "Unknown5";
                    break;
                case "0002":
                    lblFlw2Arg1.Text = "0002固定";
                    lblFlw2Arg2.Text = "不明3";
                    lblFlw2Arg3.Text = "不明4";
                    lblFlw2Arg4.Text = "分岐先オフセット";
                    if (Properties.Settings.Default.言語 == "日本語") break;
                    lblFlw2Arg1.Text = "Always 0002";
                    lblFlw2Arg2.Text = "Condition ID";
                    lblFlw2Arg3.Text = "Unknown4";
                    lblFlw2Arg4.Text = "Unknown5";
                    break;
                case "0004":
                    lblFlw2Arg1.Text = "ジャンプ先";
                    lblFlw2Arg2.Text = "不明3";
                    lblFlw2Arg3.Text = "不明4";
                    lblFlw2Arg4.Text = "不明5";
                    if (Properties.Settings.Default.言語 == "日本語") break;
                    lblFlw2Arg1.Text = "Next Flow ID";
                    lblFlw2Arg2.Text = "Unknown3";
                    lblFlw2Arg3.Text = "Unknown4";
                    lblFlw2Arg4.Text = "Unknown5";
                    break;
                case "0003":
                    lblFlw2Arg1.Text = "イベント番号";
                    lblFlw2Arg2.Text = "FLWオフセット";
                    lblFlw2Arg3.Text = "不明4";
                    lblFlw2Arg4.Text = "不明5";
                    if (Properties.Settings.Default.言語 == "日本語") break;
                    lblFlw2Arg1.Text = "Event ID";
                    lblFlw2Arg2.Text = "Next Flow";
                    lblFlw2Arg3.Text = "Unknown4";
                    lblFlw2Arg4.Text = "Unknown5";
                    break;
                default:
                    lblFlw2Arg1.Text = "不明2";
                    lblFlw2Arg2.Text = "不明3";
                    lblFlw2Arg3.Text = "不明4";
                    lblFlw2Arg4.Text = "不明5";
                    if (Properties.Settings.Default.言語 == "日本語") break;
                    lblFlw2Arg1.Text = "Unknown2";
                    lblFlw2Arg2.Text = "Unknown3";
                    lblFlw2Arg3.Text = "Unknown4";
                    lblFlw2Arg4.Text = "Unknown5";
                    break;

            }

            var blnc = flw2.Branch_List_No.Count * 2;
            var bnc = flw2.Branch_No.Count;

            if (blnc != bnc)
            {
                lblFlw2ListSelectIndex.Text = "0x" + lstListsInsideFlw2.SelectedIndex.ToString("X");
                this.txtFlw2BranchTrue.TextChanged += new EventHandler(this.TxtFlw2BranchTrue_TextChanged);
                this.txtFlw2BranchFalse.TextChanged += new EventHandler(this.TxtFlw2BranchFalse_TextChanged);
                return;
            }
            if (-1 == flw2.Branch_List_No.IndexOf(index))
            {

                txtFlw2BranchTrue.Text = "";
                txtFlw2BranchFalse.Text = "";
                lblFlw2ListSelectIndex.Text = "0x" + lstListsInsideFlw2.SelectedIndex.ToString("X");
                this.txtFlw2BranchTrue.TextChanged += new EventHandler(this.TxtFlw2BranchTrue_TextChanged);
                this.txtFlw2BranchFalse.TextChanged += new EventHandler(this.TxtFlw2BranchFalse_TextChanged);
                return;
            }
            textBox27.AppendText(Environment.NewLine + "selectlist");
            textBox27.AppendText(Environment.NewLine + flw2.Branch_No[flw2.Branch_List_No.IndexOf(index)].ToString("X4") + "___" + flw2.Branch_List_No.IndexOf(index));

            txtFlw2BranchTrue.Text = flw2.Branch_No[(flw2.Branch_List_No.IndexOf(index) * 2)].ToString("X4");
            txtFlw2BranchFalse.Text = flw2.Branch_No[(flw2.Branch_List_No.IndexOf(index) * 2) + 1].ToString("X4");

            lblFlw2ListSelectIndex.Text = "0x" + lstListsInsideFlw2.SelectedIndex.ToString("X");
            this.txtFlw2BranchTrue.TextChanged += new EventHandler(this.TxtFlw2BranchTrue_TextChanged);
            this.txtFlw2BranchFalse.TextChanged += new EventHandler(this.TxtFlw2BranchFalse_TextChanged);
        }

        private void TxtFlw2FlowType_TextChanged(object sender, EventArgs e)
        {
            this.lstListsInsideFlw2.SelectedIndexChanged -= new EventHandler(this.LstListsInsideFlw2_SelectedIndexChanged);
            FLW2.FLW2_Item_Change(lstListsInsideFlw2, txtFlw2FlowType);
            this.lstListsInsideFlw2.SelectedIndexChanged += new EventHandler(this.LstListsInsideFlw2_SelectedIndexChanged);
        }

        private void TxtFlw2Padding_TextChanged(object sender, EventArgs e)
        {
            this.lstListsInsideFlw2.SelectedIndexChanged -= new EventHandler(this.LstListsInsideFlw2_SelectedIndexChanged);
            FLW2.FLW2_Item_Change(lstListsInsideFlw2, txtFlw2Padding);
            this.lstListsInsideFlw2.SelectedIndexChanged += new EventHandler(this.LstListsInsideFlw2_SelectedIndexChanged);
        }

        private void TxtFlw2Arg1_TextChanged(object sender, EventArgs e)
        {
            FLW2.FLW2_Item_Change(lstListsInsideFlw2, txtFlw2Arg1);
        }

        private void TxtFlw2Arg2_TextChanged(object sender, EventArgs e)
        {
            FLW2.FLW2_Item_Change(lstListsInsideFlw2, txtFlw2Arg2);
        }

        private void TxtFlw2Arg3_TextChanged(object sender, EventArgs e)
        {
            FLW2.FLW2_Item_Change(lstListsInsideFlw2, txtFlw2Arg3);
        }

        private void TxtFlw2Arg4_TextChanged(object sender, EventArgs e)
        {
            FLW2.FLW2_Item_Change(lstListsInsideFlw2, txtFlw2Arg4);
        }

        private void TxtFlw2BranchTrue_TextChanged(object sender, EventArgs e)
        {
            textBox27.AppendText(Environment.NewLine + "25text");
            FLW2.FLW2_FlowType2_Branch(lstListsInsideFlw2, txtFlw2BranchTrue);
        }

        private void TxtFlw2BranchFalse_TextChanged(object sender, EventArgs e)
        {
            FLW2.FLW2_FlowType2_Branch(lstListsInsideFlw2, txtFlw2BranchFalse);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var filecount = fileName.Count();

            if (EnableDebugMenu == true)
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

        private void TxtFen1Arg0_TextChanged(object sender, EventArgs e)
        {
            FEN1.FEN1_Item_Change(lstListsInsideFen1, txtFen1Arg0);
        }

        private void TxtFen1StartIndex_TextChanged(object sender, EventArgs e)
        {
            FEN1.FEN1_Item_Change(lstListsInsideFen1, txtFen1StartIndex);
        }

        private void LstListsInsideFen1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtFen1Arg0.TextChanged -= new EventHandler(this.TxtFen1Arg0_TextChanged);
            this.txtFen1StartIndex.TextChanged -= new EventHandler(this.TxtFen1StartIndex_TextChanged);

            if (lstListsInsideFen1.Items.Count == 0) return;
            var index = lstListsInsideFen1.SelectedIndex;
            if (index == -1) index = 0;

            FEN1 fen1 = new FEN1();
            var hashes = Calculation_System.MSBT_Hash(fen1.Item2[index].tagname, 0x3B);

            //textBox28.Text = fen1.Item1[index].tagflag.ToString("X8");
            txtFen1Arg0.Text = fen1.Hashes[index].tagflag.ToString("X8");
            txtFen1StartIndex.Text = fen1.Item2[index].tagnum.ToString("X8");

            if (lstListsInsideFlw2.Items.Count > fen1.Item2[index].tagnum) lstListsInsideFlw2.SelectedIndex = fen1.Item2[index].tagnum;

            lblFen1ListSelectIndex.Text = "0x" + lstListsInsideFen1.SelectedIndex.ToString("X");
            this.txtFen1Arg0.TextChanged += new EventHandler(this.TxtFen1Arg0_TextChanged);
            this.txtFen1StartIndex.TextChanged += new EventHandler(this.TxtFen1StartIndex_TextChanged);

        }

        private void BtnAddFlw2List_Click(object sender, EventArgs e)
        {
            FLW2 flw2 = new FLW2();
            if (lstListsInsideFlw2.Items.Count != 0)
            {
                lstListsInsideFlw2.Items.Add(Language.FLW2_List_Language(4));
                flw2.Item.Add(new FLW2.flw2_item(4, 0, 0, 0, 0, 0));
                lstListsInsideFlw2.EndUpdate();
            }
            else
            {
                lstListsInsideFlw2.Items.Add(Language.FLW2_List_Language(4));
                flw2.Item = new List<FLW2.flw2_item>();
                flw2.Item.Add(new FLW2.flw2_item(4, 0, 0, 0, 0, 0));
                flw2.Branch_List_No = new List<int>();
                flw2.Branch_No = new List<short>();
                lstListsInsideFlw2.EndUpdate();
            }
        }

        private void BtnDeleteFlw2List_Click(object sender, EventArgs e)
        {
            FLW2 flw2 = new FLW2();

            if (lstListsInsideFlw2.Items.Count != 0 && (flw2.Item.Count != 0) && (flw2.Branch_List_No != null) && (flw2.Branch_No != null))
            {
                var listselect = lstListsInsideFlw2.SelectedIndex;
                lstListsInsideFlw2.Items.RemoveAt(listselect);
                if (flw2.Item[listselect].TypeCheck == 2)
                {
                    flw2.Branch_No.RemoveAt((flw2.Branch_List_No.IndexOf(listselect)) * 2);
                    flw2.Branch_List_No.RemoveAt(flw2.Branch_List_No.IndexOf(listselect));
                }
                flw2.Item.RemoveAt(listselect);
            }
        }

        private void BtnAddFen1List_Click(object sender, EventArgs e)
        {
            FEN1 fen1 = new FEN1();
            FLW2 flw2 = new FLW2();

            short list2count = 0;
            if (lstListsInsideFen1.Items.Count != 0)
            {
                list2count = (short)fen1.Item2.Count;
                if (txtFen1ListName.Text != "")
                {
                    lstListsInsideFen1.Items.Add(txtFen1ListName.Text);
                    fen1.Item1.Add(new FEN1.Element(1, 0));
                    var item2count = fen1.Item2.Count;
                    fen1.Item2.Add(new FEN1.ElementTag(txtFen1ListName.Text, lstListsInsideFlw2.Items.Count));
                    var hash = Calculation_System.MSBT_Hash(txtFen1ListName.Text, 0x3B);
                    fen1.Hashes.Add(new FEN1.Hash_And_Unknown(1, hash));
                    //treeView1.Nodes.Add(textBox31.Text);


                    //if (listBox2.Items.Count != 0)
                    //{
                    //    listBox2.Items.Add(Language.FLW2_List_Language(4));
                    //    flw2.Item.Add(new FLW2.flw2_item(4, 0, list2count, 0, 0, 0));
                    //    listBox2.EndUpdate();
                    //}
                    //else
                    //{
                    //    listBox2.Items.Add(Language.FLW2_List_Language(4));
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
                if (txtFen1ListName.Text != "")
                {
                    fen1.Item1 = new List<FEN1.Element>();
                    fen1.Item2 = new List<FEN1.ElementTag>();
                    fen1.Hashes = new List<FEN1.Hash_And_Unknown>();


                    lstListsInsideFen1.Items.Add(txtFen1ListName.Text);
                    fen1.Item1.Add(new FEN1.Element(1, 0));
                    fen1.Item2.Add(new FEN1.ElementTag(txtFen1ListName.Text, lstListsInsideFlw2.Items.Count));

                    var hash = Calculation_System.MSBT_Hash(txtFen1ListName.Text, 0x3B);
                    fen1.Hashes.Add(new FEN1.Hash_And_Unknown(1, hash));
                    //treeView1.Nodes.Add(textBox31.Text);

                    //if (listBox2.Items.Count != 0)
                    //{
                    //    listBox2.Items.Add(Language.FLW2_List_Language(4));
                    //    flw2.Item.Add(new FLW2.flw2_item(4, 0, list2count, 0, 0, 0));
                    //    listBox2.EndUpdate();
                    //}
                    //else
                    //{
                    //    listBox2.Items.Add(Language.FLW2_List_Language(4));
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

        private void BtnDeleteFen1List_Click(object sender, EventArgs e)
        {
            FEN1 fen1 = new FEN1();

            if (lstListsInsideFen1.Items.Count != 0 && (fen1.Item1.Count != 0) && (fen1.Item2.Count != 0) && (fen1.Hashes.Count != 0))
            {
                Console.WriteLine(fen1.Item1.Count());
                Console.WriteLine(fen1.Item2.Count());
                Console.WriteLine(fen1.Hashes.Count());



                var listselect = lstListsInsideFen1.SelectedIndex;


                //fen1.Item1.RemoveAt(listselect);
                fen1.Item2.RemoveAt(listselect);
                fen1.Hashes.RemoveAt(listselect);

                lstListsInsideFen1.Items.RemoveAt(listselect);
            }
        }

        private void CmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbLanguage.SelectedIndex)
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
            Formsys.Language.Language_Check();
        }

        public static TreeNode TreeViewParentFinder(TreeView tv)
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

        private void TvwMsbfFlow_AfterSelect(object sender, TreeViewEventArgs e)
        {
            FLW2 flw2 = new FLW2();
            if (tvwMsbfFlow.Nodes.Count == 0) return;
            if (tvwMsbfFlow.SelectedNode.Tag == default) return;

            //var oldindex = MsbfTreeView.SelectedNode;
            var rootnode = Form1.TreeViewParentFinder(tvwMsbfFlow);

            var rootnodelistbox3find = 0;
            if (lstListsInsideFen1.Items.Count != 0)
            {
                rootnodelistbox3find = lstListsInsideFen1.Items.IndexOf(rootnode.Text);
                lstListsInsideFen1.SelectedIndex = rootnodelistbox3find;
            }


            var roottag = (FLW2.flw2_item)rootnode.Tag;
            var a = (FLW2.flw2_item)tvwMsbfFlow.SelectedNode.Tag;
            var find = flw2.Item.IndexOf(a);
            switch (a.TypeCheck)
            {
                case 1:
                    //Console.WriteLine("メッセージ");
                    if (lstListsInsideMsbt.Items.Count == 0) break;
                    if (lstListsInsideMsbt.Items.Count > a.Unknown3) lstListsInsideMsbt.SelectedIndex = a.Unknown3;
                    if (lstListsInsideFlw2.Items.Count == 0) break;
                    if (lstListsInsideFlw2.Items.Count > find) lstListsInsideFlw2.SelectedIndex = find;
                    break;
                case 2:
                    //Console.WriteLine("分岐");
                    if (lstListsInsideFlw2.Items.Count == 0) break;
                    if (lstListsInsideFlw2.Items.Count > find) lstListsInsideFlw2.SelectedIndex = find;
                    break;
                case 3:
                    //Console.WriteLine("イベント");
                    if (lstListsInsideFlw2.Items.Count == 0) break;
                    if (lstListsInsideFlw2.Items.Count > find) lstListsInsideFlw2.SelectedIndex = find;
                    break;
                case 4:
                    //Console.WriteLine("エントリーポイント");
                    if (lstListsInsideFlw2.Items.Count == 0) break;
                    if (lstListsInsideFlw2.Items.Count > find) lstListsInsideFlw2.SelectedIndex = find;
                    break;
                default:

                    break;
            }

            //if (a.TypeCheck == 4) Console.WriteLine("せれくとつりー");

        }

        private void BtnCalculateHash_Click(object sender, EventArgs e)
        {
            TXT2 txt2 = new TXT2();
            var str = txtListNameToCalculateHash.Text;
            var hash = Calculation_System.MSBT_Hash(str, 0x6);
            txtListNameToCalculateHash.Text = hash.ToString("X8");
        }

        private void BtnInsertWorldNoTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            string tag = "</WorldNo>";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void BtnInsertScoreTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            string tag = "</Score01>";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void BtnInsertUserNameTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            string tag = "</UserName>";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void BtnInsertTotalPlayTimeTag_Click(object sender, EventArgs e)
        {
            if (lstListsInsideMsbt.Items.Count < 1) return;
            string tag = "</TotalPlayTime>";
            Calculation_System.TextBoxInsert(txtMsbtText, tag);
        }

        private void TextBox32_TextChanged(object sender, EventArgs e)
        {
            var strbytes = Encoding.GetEncoding("utf-16BE").GetBytes(textBox32.Text);
            textBox33.Text = "";
            foreach (var hexbit in strbytes) textBox33.AppendText(Environment.NewLine + hexbit.ToString("X2"));
        }

        private void Button30_Click(object sender, EventArgs e)
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

        private void BtnReloadTvwMsbfFlow_Click(object sender, EventArgs e)
        {
            var yesno = MessageBox.Show("ツリーを更新しますか？", "質問", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (yesno == DialogResult.No) return;
            FEN1 fen1 = new FEN1();
            try { FEN1.TreeLoder(fen1.Item2); }
            catch (Exception ex)
            {
                tvwMsbfFlow.Nodes.Clear();
                Console.WriteLine("errrrrrror");
            }

        }

        private void ChkShowTvwMsbfFlow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowTvwMsbfFlow.Checked)
            {
                btnReloadTvwMsbfFlow.Enabled = true;
                tvwMsbfFlow.Enabled = true;
                chkShowTvwMsbfFlow.Text = "ON";
            }
            else
            {
                btnReloadTvwMsbfFlow.Enabled = false;
                tvwMsbfFlow.Enabled = false;
                tvwMsbfFlow.Nodes.Clear();
                chkShowTvwMsbfFlow.Text = "OFF";
            }
        }

        //ATR1セクションテキストボックスのキープレスイベント
        private void TxtAtr1SoundID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void TxtAtr1SimpleCameraID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void TxtAtr1DialogID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void TxtAtr1WindowID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void TxtAtr1EventCameraID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void TxtAtr1MessageAreaID_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void TxtAtr1Unknown6_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void TxtAtr1SpecialText_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressEventSupport.CanWriteChar(e, true);
        }

        private void TxtSelectedMsbtListName_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtSelectedMsbtListName.SelectAll();
        }

        private void BtnInsertCustomIconTag_Click(object sender, EventArgs e)
        {

            var Tag = txtCustomIconHex.Text;
            var StrCount = Tag.Length;

            //末尾6バイト(12文字)の制限
            //例:<UserIcon="000E0003 00350002003A">
            if (StrCount != 12) return;

            if (lstListsInsideMsbt.Items.Count < 1) return;

            Tag = "<UserIcon=\"000E0003" + Tag + "\">";




            Calculation_System.TextBoxInsert(txtMsbtText, Tag);
        }

        private void UserIconInsertTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressEventSupport.OnlyHexChar(e, true);
        }



        private void BtnInsertSoundEffectTag_Click(object sender, EventArgs e)
        {
            //<SE="SE_BV_KOOPA_BURN_RUN">
            var Tag = txtSoundEffectName.Text;
            if (Tag == string.Empty) return;

            if (lstListsInsideMsbt.Items.Count < 1) return;

            Tag = "<SE=\"" + Tag + "\">";
            Calculation_System.TextBoxInsert(txtMsbtText, Tag);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var ResourceRarcFolder = Path.GetDirectoryName(Application.ExecutablePath) + "\\res\\" + "ARC";
            if (Directory.Exists(ResourceRarcFolder)) Directory.Delete(ResourceRarcFolder, true);
        }



        private void LlbGitHubReleasesUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.llbGitHubReleasesUrl.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/penguin117117/MSBT_Editor/releases");
        }

        private void LlbGitHubRepositoryUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.llbGitHubRepositoryUrl.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/penguin117117/MSBT_Editor");
        }

        private void LlbGitHubIssuesUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.llbGitHubIssuesUrl.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/penguin117117/MSBT_Editor/issues");
        }

        private void LlbSMG2HackWikiUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.llbSMG2HackWikiUrl.LinkVisited = true;
            System.Diagnostics.Process.Start("http://mariogalaxy2hack.wiki.fc2.com/wiki/MSBT_Editor");
        }

        private void LlbSMG2HackDiscordUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.llbSMG2HackDiscordUrl.LinkVisited = true;
            System.Diagnostics.Process.Start("https://discord.gg/B4EwY7h");
        }

        private void TxtFlw2FlowType_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void TxtFlw2BranchTrue_KeyPress(object sender, KeyPressEventArgs e) => KeyPressEventSupport.OnlyHexChar(e, true);

        private void BtnTextSort_Click(object sender, EventArgs e)
        {
            string[] OldStrings = txtUnknownTag.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            txtUnknownTag.Text = string.Empty;
            var Sorted = OldStrings.OrderBy(sort => sort).ToArray();

            foreach (var tes in Sorted) txtUnknownTag.AppendText(tes + Environment.NewLine);
        }

        private void ChkMsbAutoSave_CheckedChanged(object sender, EventArgs e)
        {

            if (chkMsbAutoSave.Checked == false)
            {
                s_useAutoSave = false;
            }
            else
            {
                s_useAutoSave = true;
            }
        }

        private void LstFilesInsideRarc_SelectedValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(lstFilesInsideRarc.SelectedValue);
        }
        private void LstFilesInsideRarc_SelectedIndexChanged(object sender, EventArgs e/*EventHandler e*/)
        {

            var SaveSelect = DialogResult;

            if (Dialog.ArcInsideMsbtAndMsbfPath.Count < 1) return;
            if (lstFilesInsideRarc.Items.Count < 0) return;

            var Index = lstFilesInsideRarc.SelectedIndex;
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
            lstFilesInsideRarc.Enabled = false;

            var PathExtention = Path.GetExtension(lstFilesInsideRarc.Text).ToLower();
            var PathFileName = lstFilesInsideRarc.Text;
            //Dialog.FileCheckの処理中にこのイベントを発生させないようにしている。
            this.lstFilesInsideRarc.SelectedIndexChanged -= new EventHandler(this.LstFilesInsideRarc_SelectedIndexChanged);

            //if (Path.GetExtension()) ;
            var OldPath = lstFilesInsideRarc.Items[Properties.Settings.Default.ARCListIndexOld].ToString();


            var MsbtOldName = stbOpenedMsbtName.Text;
            var MsbfOldName = stbOpenedMsbfName.Text;

            bool IsMsbtDef = false;
            bool IsMsbfDef = false;

            if (MsbtOldName == Language.FileReadStatusJP[0]) IsMsbtDef = true;
            if (MsbfOldName == Language.FileReadStatusJP[1]) IsMsbfDef = true;


            if (Properties.Settings.Default.言語 == "EN")
            {
                if (MsbtOldName == Language.FileReadStatusUS[0]) IsMsbtDef = true;
                if (MsbfOldName == Language.FileReadStatusUS[1]) IsMsbfDef = true;
            }

            if ((PathExtention == ".msbt") && (Dialog.Save_Path_Msbt != lstFilesInsideRarc.Text))
            {

                if ((s_useAutoSave == false) && (MsbtOldName != PathFileName) && IsMsbtDef == false)
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
            else if ((PathExtention == ".msbf") && (Dialog.Save_Path_Msbf != lstFilesInsideRarc.Text))
            {
                if ((s_useAutoSave == false) && (MsbfOldName != PathFileName) && IsMsbfDef == false)
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
                    lstFilesInsideRarc.SelectedIndex = Properties.Settings.Default.ARCListIndexOld;
                    lstFilesInsideRarc.Enabled = true;
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
                this.lstFilesInsideRarc.SelectedIndexChanged += new EventHandler(this.LstFilesInsideRarc_SelectedIndexChanged);
                lstFilesInsideRarc.Enabled = true;
                return;
            }

            //MSBTの内容を一度全て消す
            if (PathExtention == ".msbt")    //MSBF読み込み時に、MSBT_Data.MSBT_All_Data.Text[]の最後の要素に""が代入されてしまうのを防ぐため
            {
                txtMsbtText.Clear();
                txtReadOnlyMsbtText.Clear();
            }
            txtAtr1SoundID.Clear();
            txtAtr1SimpleCameraID.Clear();
            txtAtr1DialogID.Clear();
            txtAtr1WindowID.Clear();
            txtAtr1EventCameraID.Clear();
            txtAtr1MessageAreaID.Clear();
            txtAtr1Unknown6.Clear();
            txtAtr1SpecialTextOffset.Clear();
            txtAtr1SpecialText.Clear();
            txtSelectedMsbtListName.Clear();
            lblMsbtListSelectIndex.Text = "0x00";

            Dialog.FileCheck(Dialog.ArcInsideMsbtAndMsbfPath[Index]);



            this.lstFilesInsideRarc.SelectedIndexChanged += new EventHandler(this.LstFilesInsideRarc_SelectedIndexChanged);

            //古いリストのセレクト番号を上書き
            Properties.Settings.Default.ARCListIndexOld = Index;
            Properties.Settings.Default.Save();

            lstFilesInsideRarc.Enabled = true;
            lstFilesInsideRarc.Focus();
        }

        private void LstFilesInsideRarc_CursorChanged(object sender, EventArgs e)
        {
            Console.WriteLine(lstFilesInsideRarc.SelectedValue);
        }

        private void LstFilesInsideRarc_Validating(object sender, CancelEventArgs e)
        {
            Console.WriteLine(lstFilesInsideRarc.SelectedValue);
        }

        private void LstFilesInsideRarc_ChangeUICues(object sender, UICuesEventArgs e)
        {
            Console.WriteLine(lstFilesInsideRarc.SelectedValue);
        }
    }
}
