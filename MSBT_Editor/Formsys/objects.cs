using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSBT_Editor.Formsys
{
    public class Objects
    {
        protected static TextBox txtb1 = Form1.Form1Instance.txtMsbtText;
        protected static TextBox txtb2 = Form1.Form1Instance.textBox2;
        protected static TextBox txtb11 = Form1.Form1Instance.txtAtr1SpecialText;
        protected static TextBox txtb14 = Form1.Form1Instance.txtLbl1EntrySize;
        protected static TextBox txtb15 = Form1.Form1Instance.txtAtr1EntrySize;
        protected static TextBox txtb24 = Form1.Form1Instance.txtFlw2Arg4;
        protected static TextBox txtb27 = Form1.Form1Instance.textBox27;

        //button 1~9
        protected static Button listadd = Form1.Form1Instance.btnAddMsbtList;
        protected static Button listdelete = Form1.Form1Instance.btnDeleteMsbtList;
        protected static Button button1 = Form1.Form1Instance.btnInsertColorTag;
        protected static Button button2 = Form1.Form1Instance.btnInsertLineControlTag;
        protected static Button button3 = Form1.Form1Instance.btnInsertFontSizeTag;
        protected static Button button4 = Form1.Form1Instance.btnInsertCenterTag;
        protected static Button button5 = Form1.Form1Instance.btnInsertRubiTag;
        protected static Button button6 = Form1.Form1Instance.btnInsertTimerTag;
        protected static Button button7 = Form1.Form1Instance.btnInsertPlayerCharacterTag;
        protected static Button button8 = Form1.Form1Instance.btnInsertVariableInt3DigitsTag;
        protected static Button button9 = Form1.Form1Instance.btnInsertResultGalaxyNameTag;

        //Button 10~19
        protected static Button button10 = Form1.Form1Instance.btnInsertResultScenarioNameTag;
        protected static Button button11 = Form1.Form1Instance.btnInsertCharacterIconTag;
        protected static Button button12 = Form1.Form1Instance.btnInsertObjectIconTag;
        protected static Button button13 = Form1.Form1Instance.btnInsertOtherIconTag;
        protected static Button button14 = Form1.Form1Instance.btnInsertVariableInt4DigitsTag;
        protected static Button button15 = Form1.Form1Instance.btnInsertVariableInt5DigitsTag;
        protected static Button button16 = Form1.Form1Instance.btnInsertHourTag;
        protected static Button button17 = Form1.Form1Instance.btnInsertMinuteTag;
        protected static Button button18 = Form1.Form1Instance.btnInsertSecondTag;
        protected static Button button19 = Form1.Form1Instance.btnInsertNumbersBelowDecimalPointTag;

        protected static Button button21 = Form1.Form1Instance.btnAddFlw2List;
        protected static Button button22 = Form1.Form1Instance.btnDeleteFlw2List;
        protected static Button button23 = Form1.Form1Instance.btnAddFen1List;
        protected static Button button24 = Form1.Form1Instance.btnDeleteFen1List;

        protected static Button button26 = Form1.Form1Instance.btnInsertWorldNoTag;
        protected static Button button27 = Form1.Form1Instance.btnInsertScoreTag;
        protected static Button button28 = Form1.Form1Instance.btnInsertUserNameTag;
        protected static Button button29 = Form1.Form1Instance.btnInsertTotalPlayTimeTag;

        protected static Button MsbtSETagInsertButton = Form1.Form1Instance.btnInsertSoundEffectTag;
        protected static Button UserIconInsertButton = Form1.Form1Instance.btnInsertCustomIconTag;

        //label 0～9
        protected static Label labeltxt01 = Form1.Form1Instance.lblAtr1SoundID;
        protected static Label labeltxt02 = Form1.Form1Instance.lblAtr1SimpleCameraID;
        protected static Label labeltxt03 = Form1.Form1Instance.lblAtr1DialogID;
        protected static Label labeltxt04 = Form1.Form1Instance.lblAtr1WindowID;
        protected static Label labeltxt05 = Form1.Form1Instance.lblAtr1EventCameraID;
        protected static Label labeltxt06 = Form1.Form1Instance.lblAtr1MessageAreaID;
        protected static Label labeltxt07 = Form1.Form1Instance.lblAtr1Unknown6;
        protected static Label labeltxt08 = Form1.Form1Instance.lblAtr1SpecialTextOffset;
        protected static Label labeltxt09 = Form1.Form1Instance.lblAtr1SpecialText;

        //label 10～19
        protected static Label labeltxt10 = Form1.Form1Instance.lblLbl1TagIndex;
        protected static Label labeltxt11 = Form1.Form1Instance.lblMsbtListName;
        protected static Label labeltxt12 = Form1.Form1Instance.lblMsbtListEditDiscription;
        protected static Label labeltxt13 = Form1.Form1Instance.lblMsbtListEditNote;
        protected static Label labeltxt15 = Form1.Form1Instance.lblCreditSectionEntrySize;

        protected static Label labeltxt17 = Form1.Form1Instance.lblRubiTagRubiCount;
        protected static Label labeltxt18 = Form1.Form1Instance.lblRubiTagKanjiCount;
        protected static Label labeltxt19 = Form1.Form1Instance.lblTimerTagDelayTime;

        //label 20～29
        protected static Label labeltxt20 = Form1.Form1Instance.lblCharacterIconTag;
        protected static Label labeltxt21 = Form1.Form1Instance.lblObjectIconTag;
        protected static Label labeltxt22 = Form1.Form1Instance.lblOtherIconTag;
        protected static Label labeltxt23 = Form1.Form1Instance.lblFlw2FlowType;
        protected static Label labeltxt24 = Form1.Form1Instance.lblFlw2Padding;
        protected static Label labeltxt25 = Form1.Form1Instance.lblFlw2Arg1;
        protected static Label labeltxt26 = Form1.Form1Instance.lblFlw2Arg2;
        protected static Label labeltxt27 = Form1.Form1Instance.lblFlw2Arg3;
        protected static Label labeltxt28 = Form1.Form1Instance.lblFlw2Arg4;
        protected static Label labeltxt29 = Form1.Form1Instance.lblFlw2BranchTrue;

        //label 30～39
        protected static Label labeltxt30 = Form1.Form1Instance.lblFlw2BranchFalse;
        protected static Label labeltxt31 = Form1.Form1Instance.lblFen1Arg0;
        protected static Label labeltxt32 = Form1.Form1Instance.lblFlw2StartIndex;
        protected static Label labeltxt33 = Form1.Form1Instance.lblMsbfSettingNote;
        protected static Label labeltxt34 = Form1.Form1Instance.lblFlw2ListEditDiscription;
        protected static Label labeltxt35 = Form1.Form1Instance.lblFen1ListName;
        protected static Label labeltxt39 = Form1.Form1Instance.lblCreditLbl1Note;

        protected static Label Label58 = Form1.Form1Instance.lblSaveSystemDiscription;

        protected static Label UserIconInsertLabel1 = Form1.Form1Instance.lblCustomIconTagDiscription1;
        protected static Label UserIconInsertLabel2 = Form1.Form1Instance.lblCustomIconHex;
        protected static Label SETagInsertLabel1 = Form1.Form1Instance.lblSoundEffectTagDiscription1;
        protected static Label SETagInsertLabel2 = Form1.Form1Instance.lblSoundEffectTagDiscription2;

        protected static TextBox msbtdebugtxt = Form1.Form1Instance.MSBT_Debug_Text;
        protected static TextBox txtb13 = Form1.Form1Instance.txtFlw2DebugHex;
        protected static ListBox MsbtListBox = Form1.Form1Instance.lstListsInsideMsbt;
        protected static ListBox list2 = Form1.Form1Instance.lstListsInsideFlw2;
        protected static ListBox list3 = Form1.Form1Instance.lstListsInsideFen1;
        protected static ListBox ARCListBox = Form1.Form1Instance.lstFilesInsideRarc;

        //
        protected static TreeView treeview1 = Form1.Form1Instance.tvwMsbfFlow;

        //
        protected static CheckBox chk1 = Form1.Form1Instance.chkShowTvwMsbfFlow;

        //combbox
        protected static ComboBox combo1 = Form1.Form1Instance.cmbColorTag;
        protected static ComboBox combo2 = Form1.Form1Instance.cmbLineControlTag;
        protected static ComboBox combo3 = Form1.Form1Instance.cmbFontSizeTag;
        protected static ComboBox combo4 = Form1.Form1Instance.cmbCenterTag;
        protected static ComboBox combo5 = Form1.Form1Instance.cmbCharacterIconTag;
        protected static ComboBox combo6 = Form1.Form1Instance.cmbObjectIconTag;
        protected static ComboBox combo7 = Form1.Form1Instance.cmbOtherIconTag;

        //groupbox
        protected static GroupBox Atr1GroupBox = Form1.Form1Instance.gbxMsbtSettingAtr1;
        protected static GroupBox groupbox3 = Form1.Form1Instance.gbxCreditSectionEntrySize;
        protected static GroupBox groupbox4 = Form1.Form1Instance.gbxRubiTag;
        protected static GroupBox groupbox5 = Form1.Form1Instance.gbxTimerTag;
        protected static GroupBox groupbox6 = Form1.Form1Instance.gbxSpecialTag;
        protected static GroupBox groupbox8 = Form1.Form1Instance.gbxFlw2Branch;

        protected static GroupBox groupbox15 = Form1.Form1Instance.gbxCustomIconTag;
        protected static GroupBox groupbox16 = Form1.Form1Instance.gbxSoundEffectTag;

        //tab
        protected static TabControl tbc1 = Form1.Form1Instance.tabControl1;
        protected static TabControl tbc3 = Form1.Form1Instance.tabControl3;
        protected static TabPage tabp1 = Form1.Form1Instance.tbpMsbtSetting;
        protected static TabPage tabp2 = Form1.Form1Instance.tbpMsbtTextEdit;
        protected static TabPage tabp3 = Form1.Form1Instance.tbpListEdit;
        protected static TabPage tabp4 = Form1.Form1Instance.tbpMsbfSetting;
        protected static TabPage AdvancedTagTabPage = Form1.Form1Instance.AdvancedTagTabPage;

        protected static TabPage tabp6 = Form1.Form1Instance.tbpGeneralTag;
        protected static TabPage tabp7 = Form1.Form1Instance.tbpValueTag;
        protected static TabPage tabp8 = Form1.Form1Instance.tbpSpecialTag;
        protected static TabPage tabp9 = Form1.Form1Instance.tbpIconTag;
        protected static TabPage tabp12 = Form1.Form1Instance.tbpFilesInsideRarc;
        protected static TabPage tabp14 = Form1.Form1Instance.tbpInfomation;

        //menu
        protected static ToolStripMenuItem tlmi_file = Form1.Form1Instance.ファイルToolStripMenuItem;
        protected static ToolStripMenuItem tlmi_msbt_open = Form1.Form1Instance.開くToolStripMenuItem;
        protected static ToolStripMenuItem tlmi_msbt_save = Form1.Form1Instance.Msbt上書き保存ToolStripMenuItem;
        protected static ToolStripMenuItem tlmi_msbt_save_as = Form1.Form1Instance.Msbt保存ToolStripMenuItem;
        protected static ToolStripMenuItem tlmi_msbf_open = Form1.Form1Instance.Msbf開くToolStripMenuItem;
        protected static ToolStripMenuItem tlmi_msbf_save = Form1.Form1Instance.Msbf上書き保存ToolStripMenuItem;
        protected static ToolStripMenuItem tlmi_msbf_save_as = Form1.Form1Instance.Msbf保存ToolStripMenuItem;
        protected static ToolStripMenuItem tlmi_arc_open = Form1.Form1Instance.Arc開くToolStripMenuItem;
        protected static ToolStripMenuItem tlmi_arc_save = Form1.Form1Instance.Arc上書き保存ToolStripMenuItem;
        protected static ToolStripMenuItem tlmi_arc_save_as = Form1.Form1Instance.Arc保存ToolStripMenuItem;

        //stats
        protected static ToolStripStatusLabel tssl1 = Form1.Form1Instance.stbStatusLabel;
        protected static ToolStripStatusLabel tssl2 = Form1.Form1Instance.stbOpenedMsbtName;
        protected static ToolStripStatusLabel tssl4 = Form1.Form1Instance.stbOpenedMsbfName;
        protected static ToolStripStatusLabel tssl6 = Form1.Form1Instance.stbSavedFilePathLabel;
        protected static ToolStripStatusLabel tssl7 = Form1.Form1Instance.stbOpenedRarcName;
        protected static ToolStripStatusLabel SaveStatusPathString = Form1.Form1Instance.stbSavedFilePath;

        //
        protected static TextBox unknowntag = Form1.Form1Instance.txtUnknownTag;
    }
}
