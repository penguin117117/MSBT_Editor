
namespace MSBT_Editor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stbStatusBar = new System.Windows.Forms.StatusStrip();
            this.stbStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbOpenedMSBTName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbOpenedMSBFName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbOpenedRARCName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbSavedFilePathLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbSavedFilePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Msbt上書き保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Msbt保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mSBF開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Msbf上書き保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Msbf保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ARC開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ARC上書き保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ARC保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstListsInsideMSBT = new System.Windows.Forms.ListBox();
            this.txtMSBTText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpMSBTSettings = new System.Windows.Forms.TabPage();
            this.gbxMSBTSettingsATR1 = new System.Windows.Forms.GroupBox();
            this.lblATR1SpecialText = new System.Windows.Forms.Label();
            this.txtATR1SpecialText = new System.Windows.Forms.TextBox();
            this.lblATR1Unknown6 = new System.Windows.Forms.Label();
            this.lblATR1MessageAreaID = new System.Windows.Forms.Label();
            this.lblATR1EventCameraID = new System.Windows.Forms.Label();
            this.lblATR1WindowID = new System.Windows.Forms.Label();
            this.lblATR1DialogID = new System.Windows.Forms.Label();
            this.lblATR1SimpleCamID = new System.Windows.Forms.Label();
            this.lblATR1SoundID = new System.Windows.Forms.Label();
            this.txtATR1Unknown6 = new System.Windows.Forms.TextBox();
            this.txtATR1MessageAreaID = new System.Windows.Forms.TextBox();
            this.txtATR1EventCameraID = new System.Windows.Forms.TextBox();
            this.txtATR1WindowID = new System.Windows.Forms.TextBox();
            this.txtATR1DialogID = new System.Windows.Forms.TextBox();
            this.txtATR1SimpleCamID = new System.Windows.Forms.TextBox();
            this.txtATR1SoundID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnInsertColorTag = new System.Windows.Forms.Button();
            this.btnInsertPlayerCharacterTag = new System.Windows.Forms.Button();
            this.cmbCenterTag = new System.Windows.Forms.ComboBox();
            this.btnInsertCenterTag = new System.Windows.Forms.Button();
            this.cmbColorTag = new System.Windows.Forms.ComboBox();
            this.btnInsertLineControlTag = new System.Windows.Forms.Button();
            this.cmbFontSizeTag = new System.Windows.Forms.ComboBox();
            this.btnInsertFontSizeTag = new System.Windows.Forms.Button();
            this.cmbLineControlTag = new System.Windows.Forms.ComboBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.gbxTimerTag = new System.Windows.Forms.GroupBox();
            this.btnInsertTimerTag = new System.Windows.Forms.Button();
            this.lblTimerTagDelayTime = new System.Windows.Forms.Label();
            this.txtTimerTagDelayTime = new System.Windows.Forms.TextBox();
            this.gbxRubiTag = new System.Windows.Forms.GroupBox();
            this.lblRubiTagDiscription = new System.Windows.Forms.Label();
            this.btnInsertRubiTag = new System.Windows.Forms.Button();
            this.lblRubiTagKanjiCount = new System.Windows.Forms.Label();
            this.lblRubiTagRubiCount = new System.Windows.Forms.Label();
            this.txtRubiTagRubiCount = new System.Windows.Forms.TextBox();
            this.txtRubiTagKanjiCount = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.gbxSpecialTag = new System.Windows.Forms.GroupBox();
            this.btnInsertTotalPlayTimeTag = new System.Windows.Forms.Button();
            this.btnInsertUserNameTag = new System.Windows.Forms.Button();
            this.btnInsertScoreTag = new System.Windows.Forms.Button();
            this.btnInsertWorldNoTag = new System.Windows.Forms.Button();
            this.btnInsertNumbersBelowDecimalPoint = new System.Windows.Forms.Button();
            this.btnInsertSecondTag = new System.Windows.Forms.Button();
            this.btnInsertMinuteTag = new System.Windows.Forms.Button();
            this.btnInsertHourTag = new System.Windows.Forms.Button();
            this.btnInsertVariableInt5DigitsTag = new System.Windows.Forms.Button();
            this.btnInsertVariableInt4DigitsTag = new System.Windows.Forms.Button();
            this.btnInsertVariableInt3DigitsTag = new System.Windows.Forms.Button();
            this.btnInsertResultScenarioNameTag = new System.Windows.Forms.Button();
            this.btnInsertResultGalaxyNameTag = new System.Windows.Forms.Button();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.btnInsertOthersIconTag = new System.Windows.Forms.Button();
            this.cmbOthersIconTag = new System.Windows.Forms.ComboBox();
            this.lblOthersIconTag = new System.Windows.Forms.Label();
            this.lblObjectIconTag = new System.Windows.Forms.Label();
            this.btnInsertObjectIconTag = new System.Windows.Forms.Button();
            this.cmbObjectIconTag = new System.Windows.Forms.ComboBox();
            this.lblCharacterIconTag = new System.Windows.Forms.Label();
            this.btnInsertCharacterIconTag = new System.Windows.Forms.Button();
            this.cmbCharacterIconTag = new System.Windows.Forms.ComboBox();
            this.AdvancedTagsTabPage = new System.Windows.Forms.TabPage();
            this.gbxSoundEffectTag = new System.Windows.Forms.GroupBox();
            this.lblSoundEffectTagDiscription1 = new System.Windows.Forms.Label();
            this.btnInsertSoundEffectTag = new System.Windows.Forms.Button();
            this.lblSoundEffectTagDiscription2 = new System.Windows.Forms.Label();
            this.txtSoundEffectName = new System.Windows.Forms.TextBox();
            this.gbxCustomIconTag = new System.Windows.Forms.GroupBox();
            this.lblCustomIconHex = new System.Windows.Forms.Label();
            this.btnInsertCustomIconTag = new System.Windows.Forms.Button();
            this.lblCustomIconTagDiscription1 = new System.Windows.Forms.Label();
            this.txtCustomIconHex = new System.Windows.Forms.TextBox();
            this.tbpListEdit = new System.Windows.Forms.TabPage();
            this.gbxListEditFEN1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteFEN1List = new System.Windows.Forms.Button();
            this.btnAddFEN1List = new System.Windows.Forms.Button();
            this.txtFEN1ListName = new System.Windows.Forms.TextBox();
            this.lblFEN1ListName = new System.Windows.Forms.Label();
            this.gbxListEditFLW2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteFLW2List = new System.Windows.Forms.Button();
            this.btnAddFLW2List = new System.Windows.Forms.Button();
            this.lblFLW2ListEditDiscription = new System.Windows.Forms.Label();
            this.gbxListEditMSBT = new System.Windows.Forms.GroupBox();
            this.lblMSBTListEditDiscription = new System.Windows.Forms.Label();
            this.lblMSBTListName = new System.Windows.Forms.Label();
            this.txtSelectedMSBTListName = new System.Windows.Forms.TextBox();
            this.lblMSBTListEditNote = new System.Windows.Forms.Label();
            this.btnDeleteMSBTList = new System.Windows.Forms.Button();
            this.txtMSBTListName = new System.Windows.Forms.TextBox();
            this.btnAddMSBTList = new System.Windows.Forms.Button();
            this.tbpMSBFSetting = new System.Windows.Forms.TabPage();
            this.chkShowTvwMSBFFlow = new System.Windows.Forms.CheckBox();
            this.btnReloadTvwMSBFFlow = new System.Windows.Forms.Button();
            this.txtReadOnlyMSBTText = new System.Windows.Forms.TextBox();
            this.lblMSBFFlow = new System.Windows.Forms.Label();
            this.tvwMSBFFlow = new System.Windows.Forms.TreeView();
            this.lblMSBFSettingNote = new System.Windows.Forms.Label();
            this.gbxFEN1 = new System.Windows.Forms.GroupBox();
            this.lblFLW2StartIndex = new System.Windows.Forms.Label();
            this.lblFEN1Arg0 = new System.Windows.Forms.Label();
            this.txtFEN1StartIndex = new System.Windows.Forms.TextBox();
            this.txtFEN1Arg0 = new System.Windows.Forms.TextBox();
            this.gbxFLW2 = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.gbxFLW2Branch = new System.Windows.Forms.GroupBox();
            this.txtFLW2BranchFalse = new System.Windows.Forms.TextBox();
            this.txtFLW2BranchTrue = new System.Windows.Forms.TextBox();
            this.lblFLW2BranchFalse = new System.Windows.Forms.Label();
            this.lblFLW2BranchTrue = new System.Windows.Forms.Label();
            this.lblFLW2Arg4 = new System.Windows.Forms.Label();
            this.lblFLW2Arg3 = new System.Windows.Forms.Label();
            this.lblFLW2Arg2 = new System.Windows.Forms.Label();
            this.lblFLW2Arg1 = new System.Windows.Forms.Label();
            this.txtFLW2Arg4 = new System.Windows.Forms.TextBox();
            this.txtFLW2Arg3 = new System.Windows.Forms.TextBox();
            this.txtFLW2Arg2 = new System.Windows.Forms.TextBox();
            this.txtFLW2Arg1 = new System.Windows.Forms.TextBox();
            this.txtFLW2Padding = new System.Windows.Forms.TextBox();
            this.lblFLW2Padding = new System.Windows.Forms.Label();
            this.txtFLW2FlowType = new System.Windows.Forms.TextBox();
            this.lblFLW2FlowType = new System.Windows.Forms.Label();
            this.tbpDebugMSBF = new System.Windows.Forms.TabPage();
            this.lblMSBFHashCalculator = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.button30 = new System.Windows.Forms.Button();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.btnCalculateHash = new System.Windows.Forms.Button();
            this.txtListNameToCalculateHash = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.tbpDebug = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UnknownTag = new System.Windows.Forms.TextBox();
            this.MSBT_Debug_Text = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.btnReleaseDebugTextFile = new System.Windows.Forms.Button();
            this.tbpCredit = new System.Windows.Forms.TabPage();
            this.gbxCreditLBL1 = new System.Windows.Forms.GroupBox();
            this.lblCreditLBL1Note = new System.Windows.Forms.Label();
            this.lblLBL1TagIndex = new System.Windows.Forms.Label();
            this.txtLBL1TagIndex = new System.Windows.Forms.TextBox();
            this.txtATR1SpecialTextOffset = new System.Windows.Forms.TextBox();
            this.gbxCreditProgrammer = new System.Windows.Forms.GroupBox();
            this.label54 = new System.Windows.Forms.Label();
            this.gbxCreditContributor = new System.Windows.Forms.GroupBox();
            this.lblCreditEvanbowl = new System.Windows.Forms.Label();
            this.lblCreditPenguin = new System.Windows.Forms.Label();
            this.lblATR1SpecialTextOffset = new System.Windows.Forms.Label();
            this.gbxCreditDebugger = new System.Windows.Forms.GroupBox();
            this.label55 = new System.Windows.Forms.Label();
            this.gbxCreditDebuggerVIP = new System.Windows.Forms.GroupBox();
            this.lblCreditXenon = new System.Windows.Forms.Label();
            this.lblCreditDossun = new System.Windows.Forms.Label();
            this.lblCreditPorto = new System.Windows.Forms.Label();
            this.lblCreditHiiraghi = new System.Windows.Forms.Label();
            this.lblCreditEigen = new System.Windows.Forms.Label();
            this.gbxCreditSectionEntrySize = new System.Windows.Forms.GroupBox();
            this.txtATR1EntrySize = new System.Windows.Forms.TextBox();
            this.lblATR1EntrySize = new System.Windows.Forms.Label();
            this.lblCreditSectionEntrySizegbxCreditSectionEntrySizeNote = new System.Windows.Forms.Label();
            this.txtLBL1EntrySize = new System.Windows.Forms.TextBox();
            this.lblLBL1EntrySize = new System.Windows.Forms.Label();
            this.tbpInfomation = new System.Windows.Forms.TabPage();
            this.gbxCurrentVersion = new System.Windows.Forms.GroupBox();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.lblGitHubReleasesURL = new System.Windows.Forms.Label();
            this.gbxHowToUse = new System.Windows.Forms.GroupBox();
            this.lblSMG2HackWikiURL = new System.Windows.Forms.Label();
            this.llbSMG2HackWikiURL = new System.Windows.Forms.LinkLabel();
            this.lblSMG2HackDiscordURL = new System.Windows.Forms.Label();
            this.llbSMG2HackDiscordURL = new System.Windows.Forms.LinkLabel();
            this.lblGitHubIssuesURL = new System.Windows.Forms.Label();
            this.llbGitHubRepositoryURL = new System.Windows.Forms.LinkLabel();
            this.llbGitHubReleasesURL = new System.Windows.Forms.LinkLabel();
            this.lblGitHubRepositoryURL = new System.Windows.Forms.Label();
            this.llbGitHubIssuesURL = new System.Windows.Forms.LinkLabel();
            this.lstListsInsideFEN1 = new System.Windows.Forms.ListBox();
            this.lstListsInsideFLW2 = new System.Windows.Forms.ListBox();
            this.lblMSBT = new System.Windows.Forms.Label();
            this.lblFLW2 = new System.Windows.Forms.Label();
            this.lblFEN1 = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblMSBTListSelectIndex = new System.Windows.Forms.Label();
            this.lblFLW2ListSelectIndex = new System.Windows.Forms.Label();
            this.lblFEN1ListSelectIndex = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tbpFilesInsideRARC = new System.Windows.Forms.TabPage();
            this.chkMSBAutoSave = new System.Windows.Forms.CheckBox();
            this.lblSaveSystemDiscription = new System.Windows.Forms.Label();
            this.lstFilesInsideRARC = new System.Windows.Forms.ListBox();
            this.tbpListsInsideMSB = new System.Windows.Forms.TabPage();
            this.stbStatusBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpMSBTSettings.SuspendLayout();
            this.gbxMSBTSettingsATR1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.gbxTimerTag.SuspendLayout();
            this.gbxRubiTag.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.gbxSpecialTag.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.AdvancedTagsTabPage.SuspendLayout();
            this.gbxSoundEffectTag.SuspendLayout();
            this.gbxCustomIconTag.SuspendLayout();
            this.tbpListEdit.SuspendLayout();
            this.gbxListEditFEN1.SuspendLayout();
            this.gbxListEditFLW2.SuspendLayout();
            this.gbxListEditMSBT.SuspendLayout();
            this.tbpMSBFSetting.SuspendLayout();
            this.gbxFEN1.SuspendLayout();
            this.gbxFLW2.SuspendLayout();
            this.gbxFLW2Branch.SuspendLayout();
            this.tbpDebugMSBF.SuspendLayout();
            this.tbpDebug.SuspendLayout();
            this.tbpCredit.SuspendLayout();
            this.gbxCreditLBL1.SuspendLayout();
            this.gbxCreditProgrammer.SuspendLayout();
            this.gbxCreditContributor.SuspendLayout();
            this.gbxCreditDebugger.SuspendLayout();
            this.gbxCreditDebuggerVIP.SuspendLayout();
            this.gbxCreditSectionEntrySize.SuspendLayout();
            this.tbpInfomation.SuspendLayout();
            this.gbxCurrentVersion.SuspendLayout();
            this.gbxHowToUse.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tbpFilesInsideRARC.SuspendLayout();
            this.tbpListsInsideMSB.SuspendLayout();
            this.SuspendLayout();
            // 
            // stbStatusBar
            // 
            this.stbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbStatusLabel,
            this.stbOpenedMSBTName,
            this.toolStripStatusLabel3,
            this.stbOpenedMSBFName,
            this.toolStripStatusLabel5,
            this.stbOpenedRARCName,
            this.toolStripStatusLabel8,
            this.stbSavedFilePathLabel,
            this.stbSavedFilePath});
            this.stbStatusBar.Location = new System.Drawing.Point(0, 521);
            this.stbStatusBar.Name = "stbStatusBar";
            this.stbStatusBar.Size = new System.Drawing.Size(1028, 22);
            this.stbStatusBar.TabIndex = 0;
            this.stbStatusBar.Text = "statusStrip1";
            // 
            // stbStatusLabel
            // 
            this.stbStatusLabel.Name = "stbStatusLabel";
            this.stbStatusLabel.Size = new System.Drawing.Size(43, 17);
            this.stbStatusLabel.Text = "状態：";
            // 
            // stbOpenedMSBTName
            // 
            this.stbOpenedMSBTName.Name = "stbOpenedMSBTName";
            this.stbOpenedMSBTName.Size = new System.Drawing.Size(105, 17);
            this.stbOpenedMSBTName.Text = "<MSBTファイルなし>";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel3.Text = "｜";
            // 
            // stbOpenedMSBFName
            // 
            this.stbOpenedMSBFName.Name = "stbOpenedMSBFName";
            this.stbOpenedMSBFName.Size = new System.Drawing.Size(105, 17);
            this.stbOpenedMSBFName.Text = "<MSBFファイルなし>";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel5.Text = "｜";
            // 
            // stbOpenedRARCName
            // 
            this.stbOpenedRARCName.Name = "stbOpenedRARCName";
            this.stbOpenedRARCName.Size = new System.Drawing.Size(104, 17);
            this.stbOpenedRARCName.Text = "<RARCファイルなし>";
            this.stbOpenedRARCName.Click += new System.EventHandler(this.StbOpenedRARCName_Click);
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel8.Text = "｜";
            // 
            // stbSavedFilePathLabel
            // 
            this.stbSavedFilePathLabel.Name = "stbSavedFilePathLabel";
            this.stbSavedFilePathLabel.Size = new System.Drawing.Size(77, 17);
            this.stbSavedFilePathLabel.Text = "ファイル保存：";
            // 
            // stbSavedFilePath
            // 
            this.stbSavedFilePath.Name = "stbSavedFilePath";
            this.stbSavedFilePath.Size = new System.Drawing.Size(10, 17);
            this.stbSavedFilePath.Text = " ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.toolStripSeparator3,
            this.Msbt上書き保存ToolStripMenuItem,
            this.Msbt保存ToolStripMenuItem,
            this.toolStripSeparator1,
            this.mSBF開くToolStripMenuItem,
            this.Msbf上書き保存ToolStripMenuItem,
            this.Msbf保存ToolStripMenuItem,
            this.toolStripSeparator2,
            this.ARC開くToolStripMenuItem,
            this.ARC上書き保存ToolStripMenuItem,
            this.ARC保存ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.開くToolStripMenuItem.Text = "開く";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // Msbt上書き保存ToolStripMenuItem
            // 
            this.Msbt上書き保存ToolStripMenuItem.Name = "Msbt上書き保存ToolStripMenuItem";
            this.Msbt上書き保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.Msbt上書き保存ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.Msbt上書き保存ToolStripMenuItem.Text = "MSBT上書き保存";
            this.Msbt上書き保存ToolStripMenuItem.Click += new System.EventHandler(this.Msbt上書き保存ToolStripMenuItem_Click);
            // 
            // Msbt保存ToolStripMenuItem
            // 
            this.Msbt保存ToolStripMenuItem.Name = "Msbt保存ToolStripMenuItem";
            this.Msbt保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.Msbt保存ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.Msbt保存ToolStripMenuItem.Text = "MSBT保存";
            this.Msbt保存ToolStripMenuItem.Click += new System.EventHandler(this.Msbt保存ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // mSBF開くToolStripMenuItem
            // 
            this.mSBF開くToolStripMenuItem.Name = "mSBF開くToolStripMenuItem";
            this.mSBF開くToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.mSBF開くToolStripMenuItem.Text = "MSBF開く";
            this.mSBF開くToolStripMenuItem.Visible = false;
            this.mSBF開くToolStripMenuItem.Click += new System.EventHandler(this.MSBF開くToolStripMenuItem_Click);
            // 
            // Msbf上書き保存ToolStripMenuItem
            // 
            this.Msbf上書き保存ToolStripMenuItem.Name = "Msbf上書き保存ToolStripMenuItem";
            this.Msbf上書き保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.Msbf上書き保存ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.Msbf上書き保存ToolStripMenuItem.Text = "MSBF上書き保存";
            this.Msbf上書き保存ToolStripMenuItem.Click += new System.EventHandler(this.Msbf上書き保存ToolStripMenuItem_Click);
            // 
            // Msbf保存ToolStripMenuItem
            // 
            this.Msbf保存ToolStripMenuItem.Name = "Msbf保存ToolStripMenuItem";
            this.Msbf保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.Msbf保存ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.Msbf保存ToolStripMenuItem.Text = "MSBF保存";
            this.Msbf保存ToolStripMenuItem.Click += new System.EventHandler(this.Msbf保存ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // ARC開くToolStripMenuItem
            // 
            this.ARC開くToolStripMenuItem.Name = "ARC開くToolStripMenuItem";
            this.ARC開くToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ARC開くToolStripMenuItem.Text = "ARC開く";
            this.ARC開くToolStripMenuItem.Visible = false;
            this.ARC開くToolStripMenuItem.Click += new System.EventHandler(this.ARC開くToolStripMenuItem_Click);
            // 
            // ARC上書き保存ToolStripMenuItem
            // 
            this.ARC上書き保存ToolStripMenuItem.Name = "ARC上書き保存ToolStripMenuItem";
            this.ARC上書き保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ARC上書き保存ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ARC上書き保存ToolStripMenuItem.Text = "ARC上書き保存";
            this.ARC上書き保存ToolStripMenuItem.Click += new System.EventHandler(this.ARC上書き保存ToolStripMenuItem_Click);
            // 
            // ARC保存ToolStripMenuItem
            // 
            this.ARC保存ToolStripMenuItem.Name = "ARC保存ToolStripMenuItem";
            this.ARC保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.ARC保存ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ARC保存ToolStripMenuItem.Text = "ARC保存";
            this.ARC保存ToolStripMenuItem.Click += new System.EventHandler(this.ARC保存ToolStripMenuItem_Click);
            // 
            // lstListsInsideMSBT
            // 
            this.lstListsInsideMSBT.FormattingEnabled = true;
            this.lstListsInsideMSBT.HorizontalScrollbar = true;
            this.lstListsInsideMSBT.ItemHeight = 12;
            this.lstListsInsideMSBT.Location = new System.Drawing.Point(6, 27);
            this.lstListsInsideMSBT.Name = "lstListsInsideMSBT";
            this.lstListsInsideMSBT.ScrollAlwaysVisible = true;
            this.lstListsInsideMSBT.Size = new System.Drawing.Size(204, 424);
            this.lstListsInsideMSBT.TabIndex = 2;
            this.lstListsInsideMSBT.SelectedIndexChanged += new System.EventHandler(this.LstListsInsideMSBT_SelectedIndexChanged);
            // 
            // txtMSBTText
            // 
            this.txtMSBTText.Location = new System.Drawing.Point(6, 6);
            this.txtMSBTText.Multiline = true;
            this.txtMSBTText.Name = "txtMSBTText";
            this.txtMSBTText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMSBTText.Size = new System.Drawing.Size(548, 256);
            this.txtMSBTText.TabIndex = 3;
            this.txtMSBTText.TextChanged += new System.EventHandler(this.TxtMsbtText_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(548, 128);
            this.textBox2.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpMSBTSettings);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tbpListEdit);
            this.tabControl1.Controls.Add(this.tbpMSBFSetting);
            this.tabControl1.Controls.Add(this.tbpDebugMSBF);
            this.tabControl1.Controls.Add(this.tbpDebug);
            this.tabControl1.Controls.Add(this.tbpCredit);
            this.tabControl1.Controls.Add(this.tbpInfomation);
            this.tabControl1.Location = new System.Drawing.Point(452, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 460);
            this.tabControl1.TabIndex = 5;
            // 
            // tbpMSBTSettings
            // 
            this.tbpMSBTSettings.Controls.Add(this.gbxMSBTSettingsATR1);
            this.tbpMSBTSettings.Location = new System.Drawing.Point(4, 22);
            this.tbpMSBTSettings.Name = "tbpMSBTSettings";
            this.tbpMSBTSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMSBTSettings.Size = new System.Drawing.Size(560, 434);
            this.tbpMSBTSettings.TabIndex = 0;
            this.tbpMSBTSettings.Text = "MSBTテキストの詳細設定";
            this.tbpMSBTSettings.UseVisualStyleBackColor = true;
            // 
            // gbxMSBTSettingsATR1
            // 
            this.gbxMSBTSettingsATR1.Controls.Add(this.lblATR1SpecialText);
            this.gbxMSBTSettingsATR1.Controls.Add(this.txtATR1SpecialText);
            this.gbxMSBTSettingsATR1.Controls.Add(this.lblATR1Unknown6);
            this.gbxMSBTSettingsATR1.Controls.Add(this.lblATR1MessageAreaID);
            this.gbxMSBTSettingsATR1.Controls.Add(this.lblATR1EventCameraID);
            this.gbxMSBTSettingsATR1.Controls.Add(this.lblATR1WindowID);
            this.gbxMSBTSettingsATR1.Controls.Add(this.lblATR1DialogID);
            this.gbxMSBTSettingsATR1.Controls.Add(this.lblATR1SimpleCamID);
            this.gbxMSBTSettingsATR1.Controls.Add(this.lblATR1SoundID);
            this.gbxMSBTSettingsATR1.Controls.Add(this.txtATR1Unknown6);
            this.gbxMSBTSettingsATR1.Controls.Add(this.txtATR1MessageAreaID);
            this.gbxMSBTSettingsATR1.Controls.Add(this.txtATR1EventCameraID);
            this.gbxMSBTSettingsATR1.Controls.Add(this.txtATR1WindowID);
            this.gbxMSBTSettingsATR1.Controls.Add(this.txtATR1DialogID);
            this.gbxMSBTSettingsATR1.Controls.Add(this.txtATR1SimpleCamID);
            this.gbxMSBTSettingsATR1.Controls.Add(this.txtATR1SoundID);
            this.gbxMSBTSettingsATR1.Location = new System.Drawing.Point(6, 6);
            this.gbxMSBTSettingsATR1.Name = "gbxMSBTSettingsATR1";
            this.gbxMSBTSettingsATR1.Size = new System.Drawing.Size(548, 290);
            this.gbxMSBTSettingsATR1.TabIndex = 4;
            this.gbxMSBTSettingsATR1.TabStop = false;
            this.gbxMSBTSettingsATR1.Text = "選択されたMSBTメッセージの詳細設定";
            // 
            // lblATR1SpecialText
            // 
            this.lblATR1SpecialText.AutoSize = true;
            this.lblATR1SpecialText.Location = new System.Drawing.Point(6, 197);
            this.lblATR1SpecialText.Name = "lblATR1SpecialText";
            this.lblATR1SpecialText.Size = new System.Drawing.Size(231, 12);
            this.lblATR1SpecialText.TabIndex = 17;
            this.lblATR1SpecialText.Text = "特殊テキスト(基本null) ※上級者以外触らない";
            // 
            // txtATR1SpecialText
            // 
            this.txtATR1SpecialText.Location = new System.Drawing.Point(8, 212);
            this.txtATR1SpecialText.Multiline = true;
            this.txtATR1SpecialText.Name = "txtATR1SpecialText";
            this.txtATR1SpecialText.Size = new System.Drawing.Size(536, 68);
            this.txtATR1SpecialText.TabIndex = 16;
            this.txtATR1SpecialText.TextChanged += new System.EventHandler(this.TxtATR1SpecialText_TextChanged);
            this.txtATR1SpecialText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtATR1SpecialText_KeyPress);
            // 
            // lblATR1Unknown6
            // 
            this.lblATR1Unknown6.AutoSize = true;
            this.lblATR1Unknown6.Location = new System.Drawing.Point(6, 175);
            this.lblATR1Unknown6.Name = "lblATR1Unknown6";
            this.lblATR1Unknown6.Size = new System.Drawing.Size(61, 12);
            this.lblATR1Unknown6.TabIndex = 14;
            this.lblATR1Unknown6.Text = "分からない6";
            // 
            // lblATR1MessageAreaID
            // 
            this.lblATR1MessageAreaID.AutoSize = true;
            this.lblATR1MessageAreaID.Location = new System.Drawing.Point(6, 149);
            this.lblATR1MessageAreaID.Name = "lblATR1MessageAreaID";
            this.lblATR1MessageAreaID.Size = new System.Drawing.Size(100, 12);
            this.lblATR1MessageAreaID.TabIndex = 13;
            this.lblATR1MessageAreaID.Text = "会話制御エリアarg0";
            // 
            // lblATR1EventCameraID
            // 
            this.lblATR1EventCameraID.AutoSize = true;
            this.lblATR1EventCameraID.Location = new System.Drawing.Point(6, 122);
            this.lblATR1EventCameraID.Name = "lblATR1EventCameraID";
            this.lblATR1EventCameraID.Size = new System.Drawing.Size(77, 12);
            this.lblATR1EventCameraID.TabIndex = 12;
            this.lblATR1EventCameraID.Text = "イベントカメラID";
            // 
            // lblATR1WindowID
            // 
            this.lblATR1WindowID.AutoSize = true;
            this.lblATR1WindowID.Location = new System.Drawing.Point(6, 96);
            this.lblATR1WindowID.Name = "lblATR1WindowID";
            this.lblATR1WindowID.Size = new System.Drawing.Size(74, 12);
            this.lblATR1WindowID.TabIndex = 11;
            this.lblATR1WindowID.Text = "ウィンドウタイプ";
            // 
            // lblATR1DialogID
            // 
            this.lblATR1DialogID.AutoSize = true;
            this.lblATR1DialogID.Location = new System.Drawing.Point(6, 71);
            this.lblATR1DialogID.Name = "lblATR1DialogID";
            this.lblATR1DialogID.Size = new System.Drawing.Size(76, 12);
            this.lblATR1DialogID.TabIndex = 10;
            this.lblATR1DialogID.Text = "ダイアログタイプ";
            // 
            // lblATR1SimpleCamID
            // 
            this.lblATR1SimpleCamID.AutoSize = true;
            this.lblATR1SimpleCamID.Location = new System.Drawing.Point(6, 46);
            this.lblATR1SimpleCamID.Name = "lblATR1SimpleCamID";
            this.lblATR1SimpleCamID.Size = new System.Drawing.Size(30, 12);
            this.lblATR1SimpleCamID.TabIndex = 9;
            this.lblATR1SimpleCamID.Text = "カメラ";
            // 
            // lblATR1SoundID
            // 
            this.lblATR1SoundID.AutoSize = true;
            this.lblATR1SoundID.Location = new System.Drawing.Point(6, 21);
            this.lblATR1SoundID.Name = "lblATR1SoundID";
            this.lblATR1SoundID.Size = new System.Drawing.Size(42, 12);
            this.lblATR1SoundID.TabIndex = 8;
            this.lblATR1SoundID.Text = "サウンド";
            // 
            // txtATR1Unknown6
            // 
            this.txtATR1Unknown6.Location = new System.Drawing.Point(147, 172);
            this.txtATR1Unknown6.MaxLength = 2;
            this.txtATR1Unknown6.Name = "txtATR1Unknown6";
            this.txtATR1Unknown6.Size = new System.Drawing.Size(100, 19);
            this.txtATR1Unknown6.TabIndex = 6;
            this.txtATR1Unknown6.TextChanged += new System.EventHandler(this.TxtATR1Unknown6_TextChanged);
            this.txtATR1Unknown6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtATR1Unknown6_KeyPress);
            // 
            // txtATR1MessageAreaID
            // 
            this.txtATR1MessageAreaID.Location = new System.Drawing.Point(147, 146);
            this.txtATR1MessageAreaID.Name = "txtATR1MessageAreaID";
            this.txtATR1MessageAreaID.Size = new System.Drawing.Size(100, 19);
            this.txtATR1MessageAreaID.TabIndex = 5;
            this.txtATR1MessageAreaID.TextChanged += new System.EventHandler(this.TxtATR1MessageAreaID_TextChanged);
            this.txtATR1MessageAreaID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtATR1MessageAreaID_KeyPress);
            // 
            // txtATR1EventCameraID
            // 
            this.txtATR1EventCameraID.Location = new System.Drawing.Point(147, 119);
            this.txtATR1EventCameraID.MaxLength = 4;
            this.txtATR1EventCameraID.Name = "txtATR1EventCameraID";
            this.txtATR1EventCameraID.Size = new System.Drawing.Size(100, 19);
            this.txtATR1EventCameraID.TabIndex = 4;
            this.txtATR1EventCameraID.TextChanged += new System.EventHandler(this.TxtATR1EventCameraID_TextChanged);
            this.txtATR1EventCameraID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtATR1EventCameraID_KeyPress);
            // 
            // txtATR1WindowID
            // 
            this.txtATR1WindowID.Location = new System.Drawing.Point(147, 93);
            this.txtATR1WindowID.MaxLength = 2;
            this.txtATR1WindowID.Name = "txtATR1WindowID";
            this.txtATR1WindowID.Size = new System.Drawing.Size(100, 19);
            this.txtATR1WindowID.TabIndex = 3;
            this.txtATR1WindowID.TextChanged += new System.EventHandler(this.TxtATR1WindowID_TextChanged);
            this.txtATR1WindowID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtATR1WindowID_KeyPress);
            // 
            // txtATR1DialogID
            // 
            this.txtATR1DialogID.Location = new System.Drawing.Point(147, 68);
            this.txtATR1DialogID.MaxLength = 2;
            this.txtATR1DialogID.Name = "txtATR1DialogID";
            this.txtATR1DialogID.Size = new System.Drawing.Size(100, 19);
            this.txtATR1DialogID.TabIndex = 2;
            this.txtATR1DialogID.TextChanged += new System.EventHandler(this.TxtATR1DialogID_TextChanged);
            this.txtATR1DialogID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtATR1DialogID_KeyPress);
            // 
            // txtATR1SimpleCamID
            // 
            this.txtATR1SimpleCamID.Location = new System.Drawing.Point(147, 43);
            this.txtATR1SimpleCamID.MaxLength = 2;
            this.txtATR1SimpleCamID.Name = "txtATR1SimpleCamID";
            this.txtATR1SimpleCamID.Size = new System.Drawing.Size(100, 19);
            this.txtATR1SimpleCamID.TabIndex = 1;
            this.txtATR1SimpleCamID.TextChanged += new System.EventHandler(this.TxtATR1SimpleCamID_TextChanged);
            this.txtATR1SimpleCamID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtATR1SimpleCamID_KeyPress);
            // 
            // txtATR1SoundID
            // 
            this.txtATR1SoundID.Location = new System.Drawing.Point(147, 18);
            this.txtATR1SoundID.MaxLength = 2;
            this.txtATR1SoundID.Name = "txtATR1SoundID";
            this.txtATR1SoundID.Size = new System.Drawing.Size(100, 19);
            this.txtATR1SoundID.TabIndex = 0;
            this.txtATR1SoundID.TextChanged += new System.EventHandler(this.TxtATR1SoundID_TextChanged);
            this.txtATR1SoundID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtATR1SoundID_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.txtMSBTText);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(560, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MSBTテキスト編集";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Controls.Add(this.AdvancedTagsTabPage);
            this.tabControl2.Location = new System.Drawing.Point(6, 268);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(548, 167);
            this.tabControl2.TabIndex = 12;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnInsertColorTag);
            this.tabPage6.Controls.Add(this.btnInsertPlayerCharacterTag);
            this.tabPage6.Controls.Add(this.cmbCenterTag);
            this.tabPage6.Controls.Add(this.btnInsertCenterTag);
            this.tabPage6.Controls.Add(this.cmbColorTag);
            this.tabPage6.Controls.Add(this.btnInsertLineControlTag);
            this.tabPage6.Controls.Add(this.cmbFontSizeTag);
            this.tabPage6.Controls.Add(this.btnInsertFontSizeTag);
            this.tabPage6.Controls.Add(this.cmbLineControlTag);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(540, 141);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "汎用タグ";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnInsertColorTag
            // 
            this.btnInsertColorTag.Location = new System.Drawing.Point(133, 7);
            this.btnInsertColorTag.Name = "btnInsertColorTag";
            this.btnInsertColorTag.Size = new System.Drawing.Size(152, 23);
            this.btnInsertColorTag.TabIndex = 5;
            this.btnInsertColorTag.Text = "カラータグ挿入";
            this.btnInsertColorTag.UseVisualStyleBackColor = true;
            this.btnInsertColorTag.Click += new System.EventHandler(this.BtnInsertColorTag_Click);
            // 
            // btnInsertPlayerCharacterTag
            // 
            this.btnInsertPlayerCharacterTag.Location = new System.Drawing.Point(385, 9);
            this.btnInsertPlayerCharacterTag.Name = "btnInsertPlayerCharacterTag";
            this.btnInsertPlayerCharacterTag.Size = new System.Drawing.Size(149, 23);
            this.btnInsertPlayerCharacterTag.TabIndex = 0;
            this.btnInsertPlayerCharacterTag.Text = "プレイキャラクター";
            this.btnInsertPlayerCharacterTag.UseVisualStyleBackColor = true;
            this.btnInsertPlayerCharacterTag.Click += new System.EventHandler(this.BtnInsertPlayerCharacterTag_Click);
            // 
            // cmbCenterTag
            // 
            this.cmbCenterTag.FormattingEnabled = true;
            this.cmbCenterTag.Items.AddRange(new object[] {
            "横方向",
            "縦方向"});
            this.cmbCenterTag.Location = new System.Drawing.Point(6, 90);
            this.cmbCenterTag.Name = "cmbCenterTag";
            this.cmbCenterTag.Size = new System.Drawing.Size(121, 20);
            this.cmbCenterTag.TabIndex = 10;
            this.cmbCenterTag.Text = "横方向";
            // 
            // btnInsertCenterTag
            // 
            this.btnInsertCenterTag.Location = new System.Drawing.Point(133, 88);
            this.btnInsertCenterTag.Name = "btnInsertCenterTag";
            this.btnInsertCenterTag.Size = new System.Drawing.Size(152, 23);
            this.btnInsertCenterTag.TabIndex = 11;
            this.btnInsertCenterTag.Text = "センタリングタグ挿入";
            this.btnInsertCenterTag.UseVisualStyleBackColor = true;
            this.btnInsertCenterTag.Click += new System.EventHandler(this.BtnInsertCenterTag_Click);
            // 
            // cmbColorTag
            // 
            this.cmbColorTag.FormattingEnabled = true;
            this.cmbColorTag.Items.AddRange(new object[] {
            "ブラック",
            "レッド",
            "グリーン",
            "ブルー",
            "イエロー",
            "パープル",
            "オレンジ",
            "グレー",
            "カラーエンドタグ"});
            this.cmbColorTag.Location = new System.Drawing.Point(6, 9);
            this.cmbColorTag.Name = "cmbColorTag";
            this.cmbColorTag.Size = new System.Drawing.Size(121, 20);
            this.cmbColorTag.TabIndex = 4;
            this.cmbColorTag.Text = "ブラック";
            // 
            // btnInsertLineControlTag
            // 
            this.btnInsertLineControlTag.Location = new System.Drawing.Point(133, 36);
            this.btnInsertLineControlTag.Name = "btnInsertLineControlTag";
            this.btnInsertLineControlTag.Size = new System.Drawing.Size(152, 23);
            this.btnInsertLineControlTag.TabIndex = 7;
            this.btnInsertLineControlTag.Text = "行制御タグ挿入";
            this.btnInsertLineControlTag.UseVisualStyleBackColor = true;
            this.btnInsertLineControlTag.Click += new System.EventHandler(this.BtnInsertLineControlTag_Click);
            // 
            // cmbFontSizeTag
            // 
            this.cmbFontSizeTag.FormattingEnabled = true;
            this.cmbFontSizeTag.Items.AddRange(new object[] {
            "小",
            "普通",
            "大"});
            this.cmbFontSizeTag.Location = new System.Drawing.Point(6, 64);
            this.cmbFontSizeTag.Name = "cmbFontSizeTag";
            this.cmbFontSizeTag.Size = new System.Drawing.Size(121, 20);
            this.cmbFontSizeTag.TabIndex = 8;
            this.cmbFontSizeTag.Text = "普通";
            // 
            // btnInsertFontSizeTag
            // 
            this.btnInsertFontSizeTag.Location = new System.Drawing.Point(133, 62);
            this.btnInsertFontSizeTag.Name = "btnInsertFontSizeTag";
            this.btnInsertFontSizeTag.Size = new System.Drawing.Size(152, 23);
            this.btnInsertFontSizeTag.TabIndex = 9;
            this.btnInsertFontSizeTag.Text = "サイズタグ挿入";
            this.btnInsertFontSizeTag.UseVisualStyleBackColor = true;
            this.btnInsertFontSizeTag.Click += new System.EventHandler(this.BtnInsertFontSizeTag_Click);
            // 
            // cmbLineControlTag
            // 
            this.cmbLineControlTag.FormattingEnabled = true;
            this.cmbLineControlTag.Items.AddRange(new object[] {
            "改行",
            "次のページ",
            "終了"});
            this.cmbLineControlTag.Location = new System.Drawing.Point(6, 38);
            this.cmbLineControlTag.Name = "cmbLineControlTag";
            this.cmbLineControlTag.Size = new System.Drawing.Size(121, 20);
            this.cmbLineControlTag.TabIndex = 6;
            this.cmbLineControlTag.Text = "改行";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.gbxTimerTag);
            this.tabPage7.Controls.Add(this.gbxRubiTag);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(540, 141);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "数値必要タグ";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // gbxTimerTag
            // 
            this.gbxTimerTag.Controls.Add(this.btnInsertTimerTag);
            this.gbxTimerTag.Controls.Add(this.lblTimerTagDelayTime);
            this.gbxTimerTag.Controls.Add(this.txtTimerTagDelayTime);
            this.gbxTimerTag.Location = new System.Drawing.Point(361, 6);
            this.gbxTimerTag.Name = "gbxTimerTag";
            this.gbxTimerTag.Size = new System.Drawing.Size(173, 129);
            this.gbxTimerTag.TabIndex = 3;
            this.gbxTimerTag.TabStop = false;
            this.gbxTimerTag.Text = "タイマー";
            // 
            // btnInsertTimerTag
            // 
            this.btnInsertTimerTag.Location = new System.Drawing.Point(67, 41);
            this.btnInsertTimerTag.Name = "btnInsertTimerTag";
            this.btnInsertTimerTag.Size = new System.Drawing.Size(100, 23);
            this.btnInsertTimerTag.TabIndex = 2;
            this.btnInsertTimerTag.Text = "タイマータグ挿入";
            this.btnInsertTimerTag.UseVisualStyleBackColor = true;
            this.btnInsertTimerTag.Click += new System.EventHandler(this.BtnInsertTimerTag_Click);
            // 
            // lblTimerTagDelayTime
            // 
            this.lblTimerTagDelayTime.AutoSize = true;
            this.lblTimerTagDelayTime.Location = new System.Drawing.Point(6, 21);
            this.lblTimerTagDelayTime.Name = "lblTimerTagDelayTime";
            this.lblTimerTagDelayTime.Size = new System.Drawing.Size(29, 12);
            this.lblTimerTagDelayTime.TabIndex = 1;
            this.lblTimerTagDelayTime.Text = "時間";
            // 
            // txtTimerTagDelayTime
            // 
            this.txtTimerTagDelayTime.Location = new System.Drawing.Point(67, 18);
            this.txtTimerTagDelayTime.Name = "txtTimerTagDelayTime";
            this.txtTimerTagDelayTime.Size = new System.Drawing.Size(100, 19);
            this.txtTimerTagDelayTime.TabIndex = 0;
            this.txtTimerTagDelayTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTimerTagDelayTime_KeyPress);
            // 
            // gbxRubiTag
            // 
            this.gbxRubiTag.Controls.Add(this.lblRubiTagDiscription);
            this.gbxRubiTag.Controls.Add(this.btnInsertRubiTag);
            this.gbxRubiTag.Controls.Add(this.lblRubiTagKanjiCount);
            this.gbxRubiTag.Controls.Add(this.lblRubiTagRubiCount);
            this.gbxRubiTag.Controls.Add(this.txtRubiTagRubiCount);
            this.gbxRubiTag.Controls.Add(this.txtRubiTagKanjiCount);
            this.gbxRubiTag.Location = new System.Drawing.Point(6, 6);
            this.gbxRubiTag.Name = "gbxRubiTag";
            this.gbxRubiTag.Size = new System.Drawing.Size(349, 129);
            this.gbxRubiTag.TabIndex = 2;
            this.gbxRubiTag.TabStop = false;
            this.gbxRubiTag.Text = "ルビ";
            // 
            // lblRubiTagDiscription
            // 
            this.lblRubiTagDiscription.AutoSize = true;
            this.lblRubiTagDiscription.Location = new System.Drawing.Point(6, 67);
            this.lblRubiTagDiscription.Name = "lblRubiTagDiscription";
            this.lblRubiTagDiscription.Size = new System.Drawing.Size(285, 24);
            this.lblRubiTagDiscription.TabIndex = 5;
            this.lblRubiTagDiscription.Text = "例：<Rubi=\"9\" Target=\"5\">しんぎんがていこく新銀河帝国\r\n漢字の数は5文字まで対応ふりがなの上限は不明";
            // 
            // btnInsertRubiTag
            // 
            this.btnInsertRubiTag.Location = new System.Drawing.Point(185, 41);
            this.btnInsertRubiTag.Name = "btnInsertRubiTag";
            this.btnInsertRubiTag.Size = new System.Drawing.Size(100, 23);
            this.btnInsertRubiTag.TabIndex = 4;
            this.btnInsertRubiTag.Text = "ルビタグ挿入";
            this.btnInsertRubiTag.UseVisualStyleBackColor = true;
            this.btnInsertRubiTag.Click += new System.EventHandler(this.BtnInsertRubiTag_Click);
            // 
            // lblRubiTagKanjiCount
            // 
            this.lblRubiTagKanjiCount.AutoSize = true;
            this.lblRubiTagKanjiCount.Location = new System.Drawing.Point(6, 46);
            this.lblRubiTagKanjiCount.Name = "lblRubiTagKanjiCount";
            this.lblRubiTagKanjiCount.Size = new System.Drawing.Size(51, 12);
            this.lblRubiTagKanjiCount.TabIndex = 3;
            this.lblRubiTagKanjiCount.Text = "漢字の数";
            // 
            // lblRubiTagRubiCount
            // 
            this.lblRubiTagRubiCount.AutoSize = true;
            this.lblRubiTagRubiCount.Location = new System.Drawing.Point(6, 21);
            this.lblRubiTagRubiCount.Name = "lblRubiTagRubiCount";
            this.lblRubiTagRubiCount.Size = new System.Drawing.Size(65, 12);
            this.lblRubiTagRubiCount.TabIndex = 2;
            this.lblRubiTagRubiCount.Text = "ふりがなの数";
            // 
            // txtRubiTagRubiCount
            // 
            this.txtRubiTagRubiCount.Location = new System.Drawing.Point(79, 18);
            this.txtRubiTagRubiCount.Name = "txtRubiTagRubiCount";
            this.txtRubiTagRubiCount.Size = new System.Drawing.Size(100, 19);
            this.txtRubiTagRubiCount.TabIndex = 0;
            this.txtRubiTagRubiCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRubiTagRubiCount_KeyPress);
            // 
            // txtRubiTagKanjiCount
            // 
            this.txtRubiTagKanjiCount.Location = new System.Drawing.Point(79, 43);
            this.txtRubiTagKanjiCount.Name = "txtRubiTagKanjiCount";
            this.txtRubiTagKanjiCount.Size = new System.Drawing.Size(100, 19);
            this.txtRubiTagKanjiCount.TabIndex = 1;
            this.txtRubiTagKanjiCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRubiTagKanjiCount_KeyPress);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.gbxSpecialTag);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(540, 141);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "特殊タグ";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // gbxSpecialTag
            // 
            this.gbxSpecialTag.Controls.Add(this.btnInsertTotalPlayTimeTag);
            this.gbxSpecialTag.Controls.Add(this.btnInsertUserNameTag);
            this.gbxSpecialTag.Controls.Add(this.btnInsertScoreTag);
            this.gbxSpecialTag.Controls.Add(this.btnInsertWorldNoTag);
            this.gbxSpecialTag.Controls.Add(this.btnInsertNumbersBelowDecimalPoint);
            this.gbxSpecialTag.Controls.Add(this.btnInsertSecondTag);
            this.gbxSpecialTag.Controls.Add(this.btnInsertMinuteTag);
            this.gbxSpecialTag.Controls.Add(this.btnInsertHourTag);
            this.gbxSpecialTag.Controls.Add(this.btnInsertVariableInt5DigitsTag);
            this.gbxSpecialTag.Controls.Add(this.btnInsertVariableInt4DigitsTag);
            this.gbxSpecialTag.Controls.Add(this.btnInsertVariableInt3DigitsTag);
            this.gbxSpecialTag.Controls.Add(this.btnInsertResultScenarioNameTag);
            this.gbxSpecialTag.Controls.Add(this.btnInsertResultGalaxyNameTag);
            this.gbxSpecialTag.Location = new System.Drawing.Point(6, 6);
            this.gbxSpecialTag.Name = "gbxSpecialTag";
            this.gbxSpecialTag.Size = new System.Drawing.Size(528, 129);
            this.gbxSpecialTag.TabIndex = 4;
            this.gbxSpecialTag.TabStop = false;
            this.gbxSpecialTag.Text = "システムメッセージ専用(その他で使えるか不明)";
            // 
            // btnInsertTotalPlayTimeTag
            // 
            this.btnInsertTotalPlayTimeTag.Location = new System.Drawing.Point(161, 76);
            this.btnInsertTotalPlayTimeTag.Name = "btnInsertTotalPlayTimeTag";
            this.btnInsertTotalPlayTimeTag.Size = new System.Drawing.Size(149, 23);
            this.btnInsertTotalPlayTimeTag.TabIndex = 13;
            this.btnInsertTotalPlayTimeTag.Text = "トータルプレイ時間";
            this.btnInsertTotalPlayTimeTag.UseVisualStyleBackColor = true;
            this.btnInsertTotalPlayTimeTag.Click += new System.EventHandler(this.BtnInsertTotalPlayTimeTag_Click);
            // 
            // btnInsertUserNameTag
            // 
            this.btnInsertUserNameTag.Location = new System.Drawing.Point(161, 47);
            this.btnInsertUserNameTag.Name = "btnInsertUserNameTag";
            this.btnInsertUserNameTag.Size = new System.Drawing.Size(149, 23);
            this.btnInsertUserNameTag.TabIndex = 12;
            this.btnInsertUserNameTag.Text = "ユーザー名";
            this.btnInsertUserNameTag.UseVisualStyleBackColor = true;
            this.btnInsertUserNameTag.Click += new System.EventHandler(this.BtnInsertUserNameTag_Click);
            // 
            // btnInsertScoreTag
            // 
            this.btnInsertScoreTag.Location = new System.Drawing.Point(161, 18);
            this.btnInsertScoreTag.Name = "btnInsertScoreTag";
            this.btnInsertScoreTag.Size = new System.Drawing.Size(149, 23);
            this.btnInsertScoreTag.TabIndex = 11;
            this.btnInsertScoreTag.Text = "スコア";
            this.btnInsertScoreTag.UseVisualStyleBackColor = true;
            this.btnInsertScoreTag.Click += new System.EventHandler(this.BtnInsertScoreTag_Click);
            // 
            // btnInsertWorldNoTag
            // 
            this.btnInsertWorldNoTag.Location = new System.Drawing.Point(6, 76);
            this.btnInsertWorldNoTag.Name = "btnInsertWorldNoTag";
            this.btnInsertWorldNoTag.Size = new System.Drawing.Size(149, 23);
            this.btnInsertWorldNoTag.TabIndex = 10;
            this.btnInsertWorldNoTag.Text = "ワールドナンバー";
            this.btnInsertWorldNoTag.UseVisualStyleBackColor = true;
            this.btnInsertWorldNoTag.Click += new System.EventHandler(this.BtnInsertWorldNoTag_Click);
            // 
            // btnInsertNumbersBelowDecimalPoint
            // 
            this.btnInsertNumbersBelowDecimalPoint.Location = new System.Drawing.Point(355, 100);
            this.btnInsertNumbersBelowDecimalPoint.Name = "btnInsertNumbersBelowDecimalPoint";
            this.btnInsertNumbersBelowDecimalPoint.Size = new System.Drawing.Size(167, 23);
            this.btnInsertNumbersBelowDecimalPoint.TabIndex = 9;
            this.btnInsertNumbersBelowDecimalPoint.Text = "小数点以下";
            this.btnInsertNumbersBelowDecimalPoint.UseVisualStyleBackColor = true;
            this.btnInsertNumbersBelowDecimalPoint.Click += new System.EventHandler(this.BtnInsertNumbersBelowDecimalPoint_Click);
            // 
            // btnInsertSecondTag
            // 
            this.btnInsertSecondTag.Location = new System.Drawing.Point(445, 74);
            this.btnInsertSecondTag.Name = "btnInsertSecondTag";
            this.btnInsertSecondTag.Size = new System.Drawing.Size(77, 23);
            this.btnInsertSecondTag.TabIndex = 8;
            this.btnInsertSecondTag.Text = "秒";
            this.btnInsertSecondTag.UseVisualStyleBackColor = true;
            this.btnInsertSecondTag.Click += new System.EventHandler(this.BtnInsertSecondTag_Click);
            // 
            // btnInsertMinuteTag
            // 
            this.btnInsertMinuteTag.Location = new System.Drawing.Point(445, 47);
            this.btnInsertMinuteTag.Name = "btnInsertMinuteTag";
            this.btnInsertMinuteTag.Size = new System.Drawing.Size(77, 23);
            this.btnInsertMinuteTag.TabIndex = 7;
            this.btnInsertMinuteTag.Text = "分";
            this.btnInsertMinuteTag.UseVisualStyleBackColor = true;
            this.btnInsertMinuteTag.Click += new System.EventHandler(this.BtnInsertMinuteTag_Click);
            // 
            // btnInsertHourTag
            // 
            this.btnInsertHourTag.Location = new System.Drawing.Point(445, 18);
            this.btnInsertHourTag.Name = "btnInsertHourTag";
            this.btnInsertHourTag.Size = new System.Drawing.Size(77, 23);
            this.btnInsertHourTag.TabIndex = 6;
            this.btnInsertHourTag.Text = "時間";
            this.btnInsertHourTag.UseVisualStyleBackColor = true;
            this.btnInsertHourTag.Click += new System.EventHandler(this.BtnInsertHourTag_Click);
            // 
            // btnInsertVariableInt5DigitsTag
            // 
            this.btnInsertVariableInt5DigitsTag.Location = new System.Drawing.Point(355, 74);
            this.btnInsertVariableInt5DigitsTag.Name = "btnInsertVariableInt5DigitsTag";
            this.btnInsertVariableInt5DigitsTag.Size = new System.Drawing.Size(84, 23);
            this.btnInsertVariableInt5DigitsTag.TabIndex = 5;
            this.btnInsertVariableInt5DigitsTag.Text = "参照値3";
            this.btnInsertVariableInt5DigitsTag.UseVisualStyleBackColor = true;
            this.btnInsertVariableInt5DigitsTag.Click += new System.EventHandler(this.BtnInsertVariableInt5DigitsTag_Click);
            // 
            // btnInsertVariableInt4DigitsTag
            // 
            this.btnInsertVariableInt4DigitsTag.Location = new System.Drawing.Point(355, 47);
            this.btnInsertVariableInt4DigitsTag.Name = "btnInsertVariableInt4DigitsTag";
            this.btnInsertVariableInt4DigitsTag.Size = new System.Drawing.Size(84, 23);
            this.btnInsertVariableInt4DigitsTag.TabIndex = 4;
            this.btnInsertVariableInt4DigitsTag.Text = "参照値2";
            this.btnInsertVariableInt4DigitsTag.UseVisualStyleBackColor = true;
            this.btnInsertVariableInt4DigitsTag.Click += new System.EventHandler(this.BtnInsertVariableInt4DigitsTag_Click);
            // 
            // btnInsertVariableInt3DigitsTag
            // 
            this.btnInsertVariableInt3DigitsTag.Location = new System.Drawing.Point(355, 18);
            this.btnInsertVariableInt3DigitsTag.Name = "btnInsertVariableInt3DigitsTag";
            this.btnInsertVariableInt3DigitsTag.Size = new System.Drawing.Size(84, 23);
            this.btnInsertVariableInt3DigitsTag.TabIndex = 1;
            this.btnInsertVariableInt3DigitsTag.Text = "参照値1";
            this.btnInsertVariableInt3DigitsTag.UseVisualStyleBackColor = true;
            this.btnInsertVariableInt3DigitsTag.Click += new System.EventHandler(this.BtnInsertVariableInt3DigitsTag_Click);
            // 
            // btnInsertResultScenarioNameTag
            // 
            this.btnInsertResultScenarioNameTag.Location = new System.Drawing.Point(6, 47);
            this.btnInsertResultScenarioNameTag.Name = "btnInsertResultScenarioNameTag";
            this.btnInsertResultScenarioNameTag.Size = new System.Drawing.Size(149, 23);
            this.btnInsertResultScenarioNameTag.TabIndex = 3;
            this.btnInsertResultScenarioNameTag.Text = "リザルトシナリオ名";
            this.btnInsertResultScenarioNameTag.UseVisualStyleBackColor = true;
            this.btnInsertResultScenarioNameTag.Click += new System.EventHandler(this.BtnInsertResultScenarioNameTag_Click);
            // 
            // btnInsertResultGalaxyNameTag
            // 
            this.btnInsertResultGalaxyNameTag.Location = new System.Drawing.Point(6, 18);
            this.btnInsertResultGalaxyNameTag.Name = "btnInsertResultGalaxyNameTag";
            this.btnInsertResultGalaxyNameTag.Size = new System.Drawing.Size(149, 23);
            this.btnInsertResultGalaxyNameTag.TabIndex = 2;
            this.btnInsertResultGalaxyNameTag.Text = "リザルトギャラクシー名";
            this.btnInsertResultGalaxyNameTag.UseVisualStyleBackColor = true;
            this.btnInsertResultGalaxyNameTag.Click += new System.EventHandler(this.BtnInsertResultGalaxyNameTag_Click);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.btnInsertOthersIconTag);
            this.tabPage9.Controls.Add(this.cmbOthersIconTag);
            this.tabPage9.Controls.Add(this.lblOthersIconTag);
            this.tabPage9.Controls.Add(this.lblObjectIconTag);
            this.tabPage9.Controls.Add(this.btnInsertObjectIconTag);
            this.tabPage9.Controls.Add(this.cmbObjectIconTag);
            this.tabPage9.Controls.Add(this.lblCharacterIconTag);
            this.tabPage9.Controls.Add(this.btnInsertCharacterIconTag);
            this.tabPage9.Controls.Add(this.cmbCharacterIconTag);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(540, 141);
            this.tabPage9.TabIndex = 3;
            this.tabPage9.Text = "アイコンタグ";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // btnInsertOthersIconTag
            // 
            this.btnInsertOthersIconTag.Location = new System.Drawing.Point(135, 100);
            this.btnInsertOthersIconTag.Name = "btnInsertOthersIconTag";
            this.btnInsertOthersIconTag.Size = new System.Drawing.Size(149, 23);
            this.btnInsertOthersIconTag.TabIndex = 8;
            this.btnInsertOthersIconTag.Text = "操作,その他タグ挿入";
            this.btnInsertOthersIconTag.UseVisualStyleBackColor = true;
            this.btnInsertOthersIconTag.Click += new System.EventHandler(this.BtnInsertOthersIconTag_Click);
            // 
            // cmbOthersIconTag
            // 
            this.cmbOthersIconTag.FormattingEnabled = true;
            this.cmbOthersIconTag.Location = new System.Drawing.Point(8, 102);
            this.cmbOthersIconTag.Name = "cmbOthersIconTag";
            this.cmbOthersIconTag.Size = new System.Drawing.Size(121, 20);
            this.cmbOthersIconTag.TabIndex = 7;
            this.cmbOthersIconTag.Text = "ポインター";
            // 
            // lblOthersIconTag
            // 
            this.lblOthersIconTag.AutoSize = true;
            this.lblOthersIconTag.Location = new System.Drawing.Point(6, 87);
            this.lblOthersIconTag.Name = "lblOthersIconTag";
            this.lblOthersIconTag.Size = new System.Drawing.Size(68, 12);
            this.lblOthersIconTag.TabIndex = 6;
            this.lblOthersIconTag.Text = "操作、その他";
            // 
            // lblObjectIconTag
            // 
            this.lblObjectIconTag.AutoSize = true;
            this.lblObjectIconTag.Location = new System.Drawing.Point(6, 49);
            this.lblObjectIconTag.Name = "lblObjectIconTag";
            this.lblObjectIconTag.Size = new System.Drawing.Size(101, 12);
            this.lblObjectIconTag.TabIndex = 5;
            this.lblObjectIconTag.Text = "アイテム、オブジェクト";
            // 
            // btnInsertObjectIconTag
            // 
            this.btnInsertObjectIconTag.Location = new System.Drawing.Point(135, 62);
            this.btnInsertObjectIconTag.Name = "btnInsertObjectIconTag";
            this.btnInsertObjectIconTag.Size = new System.Drawing.Size(149, 23);
            this.btnInsertObjectIconTag.TabIndex = 4;
            this.btnInsertObjectIconTag.Text = "アイテム.オブジェクトタグ挿入";
            this.btnInsertObjectIconTag.UseVisualStyleBackColor = true;
            this.btnInsertObjectIconTag.Click += new System.EventHandler(this.BtnInsertObjectIconTag_Click);
            // 
            // cmbObjectIconTag
            // 
            this.cmbObjectIconTag.FormattingEnabled = true;
            this.cmbObjectIconTag.Location = new System.Drawing.Point(8, 64);
            this.cmbObjectIconTag.Name = "cmbObjectIconTag";
            this.cmbObjectIconTag.Size = new System.Drawing.Size(121, 20);
            this.cmbObjectIconTag.TabIndex = 3;
            this.cmbObjectIconTag.Text = "彗星メダル";
            // 
            // lblCharacterIconTag
            // 
            this.lblCharacterIconTag.AutoSize = true;
            this.lblCharacterIconTag.Location = new System.Drawing.Point(6, 11);
            this.lblCharacterIconTag.Name = "lblCharacterIconTag";
            this.lblCharacterIconTag.Size = new System.Drawing.Size(69, 12);
            this.lblCharacterIconTag.TabIndex = 2;
            this.lblCharacterIconTag.Text = "キャラクター系";
            // 
            // btnInsertCharacterIconTag
            // 
            this.btnInsertCharacterIconTag.Location = new System.Drawing.Point(135, 24);
            this.btnInsertCharacterIconTag.Name = "btnInsertCharacterIconTag";
            this.btnInsertCharacterIconTag.Size = new System.Drawing.Size(149, 23);
            this.btnInsertCharacterIconTag.TabIndex = 1;
            this.btnInsertCharacterIconTag.Text = "NPC,キャラタグ挿入";
            this.btnInsertCharacterIconTag.UseVisualStyleBackColor = true;
            this.btnInsertCharacterIconTag.Click += new System.EventHandler(this.BtnInsertCharacterIconTag_Click);
            // 
            // cmbCharacterIconTag
            // 
            this.cmbCharacterIconTag.FormattingEnabled = true;
            this.cmbCharacterIconTag.Location = new System.Drawing.Point(8, 26);
            this.cmbCharacterIconTag.Name = "cmbCharacterIconTag";
            this.cmbCharacterIconTag.Size = new System.Drawing.Size(121, 20);
            this.cmbCharacterIconTag.TabIndex = 0;
            this.cmbCharacterIconTag.Text = "ピーチ";
            // 
            // AdvancedTagsTabPage
            // 
            this.AdvancedTagsTabPage.Controls.Add(this.gbxSoundEffectTag);
            this.AdvancedTagsTabPage.Controls.Add(this.gbxCustomIconTag);
            this.AdvancedTagsTabPage.Location = new System.Drawing.Point(4, 22);
            this.AdvancedTagsTabPage.Name = "AdvancedTagsTabPage";
            this.AdvancedTagsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdvancedTagsTabPage.Size = new System.Drawing.Size(540, 141);
            this.AdvancedTagsTabPage.TabIndex = 4;
            this.AdvancedTagsTabPage.Text = "上級者向けタグ";
            this.AdvancedTagsTabPage.UseVisualStyleBackColor = true;
            // 
            // gbxSoundEffectTag
            // 
            this.gbxSoundEffectTag.Controls.Add(this.lblSoundEffectTagDiscription1);
            this.gbxSoundEffectTag.Controls.Add(this.btnInsertSoundEffectTag);
            this.gbxSoundEffectTag.Controls.Add(this.lblSoundEffectTagDiscription2);
            this.gbxSoundEffectTag.Controls.Add(this.txtSoundEffectName);
            this.gbxSoundEffectTag.Location = new System.Drawing.Point(6, 6);
            this.gbxSoundEffectTag.Name = "gbxSoundEffectTag";
            this.gbxSoundEffectTag.Size = new System.Drawing.Size(255, 129);
            this.gbxSoundEffectTag.TabIndex = 13;
            this.gbxSoundEffectTag.TabStop = false;
            this.gbxSoundEffectTag.Text = "SEタグ";
            // 
            // lblSoundEffectTagDiscription1
            // 
            this.lblSoundEffectTagDiscription1.AutoSize = true;
            this.lblSoundEffectTagDiscription1.Location = new System.Drawing.Point(6, 18);
            this.lblSoundEffectTagDiscription1.Name = "lblSoundEffectTagDiscription1";
            this.lblSoundEffectTagDiscription1.Size = new System.Drawing.Size(199, 24);
            this.lblSoundEffectTagDiscription1.TabIndex = 16;
            this.lblSoundEffectTagDiscription1.Text = "使えないステージがあります。\r\nハードコードされている可能性があります。";
            // 
            // btnInsertSoundEffectTag
            // 
            this.btnInsertSoundEffectTag.Location = new System.Drawing.Point(6, 100);
            this.btnInsertSoundEffectTag.Name = "btnInsertSoundEffectTag";
            this.btnInsertSoundEffectTag.Size = new System.Drawing.Size(149, 23);
            this.btnInsertSoundEffectTag.TabIndex = 14;
            this.btnInsertSoundEffectTag.Text = "SEタグ挿入";
            this.btnInsertSoundEffectTag.UseVisualStyleBackColor = true;
            this.btnInsertSoundEffectTag.Click += new System.EventHandler(this.BtnInsertSoundEffectTag_Click);
            // 
            // lblSoundEffectTagDiscription2
            // 
            this.lblSoundEffectTagDiscription2.AutoSize = true;
            this.lblSoundEffectTagDiscription2.Location = new System.Drawing.Point(6, 48);
            this.lblSoundEffectTagDiscription2.Name = "lblSoundEffectTagDiscription2";
            this.lblSoundEffectTagDiscription2.Size = new System.Drawing.Size(163, 24);
            this.lblSoundEffectTagDiscription2.TabIndex = 15;
            this.lblSoundEffectTagDiscription2.Text = "SEの名前を入力\r\n例：SE_BV_KOOPA_BURN_RUN";
            // 
            // txtSoundEffectName
            // 
            this.txtSoundEffectName.Location = new System.Drawing.Point(6, 75);
            this.txtSoundEffectName.Name = "txtSoundEffectName";
            this.txtSoundEffectName.Size = new System.Drawing.Size(149, 19);
            this.txtSoundEffectName.TabIndex = 13;
            // 
            // gbxCustomIconTag
            // 
            this.gbxCustomIconTag.Controls.Add(this.lblCustomIconHex);
            this.gbxCustomIconTag.Controls.Add(this.btnInsertCustomIconTag);
            this.gbxCustomIconTag.Controls.Add(this.lblCustomIconTagDiscription1);
            this.gbxCustomIconTag.Controls.Add(this.txtCustomIconHex);
            this.gbxCustomIconTag.Location = new System.Drawing.Point(275, 6);
            this.gbxCustomIconTag.Name = "gbxCustomIconTag";
            this.gbxCustomIconTag.Size = new System.Drawing.Size(259, 129);
            this.gbxCustomIconTag.TabIndex = 12;
            this.gbxCustomIconTag.TabStop = false;
            this.gbxCustomIconTag.Text = "カスタムアイコンタグ";
            // 
            // lblCustomIconHex
            // 
            this.lblCustomIconHex.AutoSize = true;
            this.lblCustomIconHex.Location = new System.Drawing.Point(6, 60);
            this.lblCustomIconHex.Name = "lblCustomIconHex";
            this.lblCustomIconHex.Size = new System.Drawing.Size(106, 12);
            this.lblCustomIconHex.TabIndex = 12;
            this.lblCustomIconHex.Text = "末尾6バイト(16進数)";
            // 
            // btnInsertCustomIconTag
            // 
            this.btnInsertCustomIconTag.Location = new System.Drawing.Point(8, 100);
            this.btnInsertCustomIconTag.Name = "btnInsertCustomIconTag";
            this.btnInsertCustomIconTag.Size = new System.Drawing.Size(149, 23);
            this.btnInsertCustomIconTag.TabIndex = 10;
            this.btnInsertCustomIconTag.Text = "カスタムアイコン挿入";
            this.btnInsertCustomIconTag.UseVisualStyleBackColor = true;
            this.btnInsertCustomIconTag.Click += new System.EventHandler(this.BtnInsertCustomIconTag_Click);
            // 
            // lblCustomIconTagDiscription1
            // 
            this.lblCustomIconTagDiscription1.AutoSize = true;
            this.lblCustomIconTagDiscription1.Location = new System.Drawing.Point(6, 18);
            this.lblCustomIconTagDiscription1.Name = "lblCustomIconTagDiscription1";
            this.lblCustomIconTagDiscription1.Size = new System.Drawing.Size(215, 24);
            this.lblCustomIconTagDiscription1.TabIndex = 11;
            this.lblCustomIconTagDiscription1.Text = "アイコンを作成した場合のみ使用可能\r\nそれ以外の場合で使用するとフリーズします。\r\n";
            // 
            // txtCustomIconHex
            // 
            this.txtCustomIconHex.Location = new System.Drawing.Point(8, 75);
            this.txtCustomIconHex.MaxLength = 12;
            this.txtCustomIconHex.Name = "txtCustomIconHex";
            this.txtCustomIconHex.Size = new System.Drawing.Size(149, 19);
            this.txtCustomIconHex.TabIndex = 9;
            this.txtCustomIconHex.Text = "000000000000";
            this.txtCustomIconHex.TextChanged += new System.EventHandler(this.UserIconInsertTextBox_TextChanged);
            this.txtCustomIconHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserIconInsertTextBox_KeyPress);
            // 
            // tbpListEdit
            // 
            this.tbpListEdit.Controls.Add(this.gbxListEditFEN1);
            this.tbpListEdit.Controls.Add(this.gbxListEditFLW2);
            this.tbpListEdit.Controls.Add(this.gbxListEditMSBT);
            this.tbpListEdit.Location = new System.Drawing.Point(4, 22);
            this.tbpListEdit.Name = "tbpListEdit";
            this.tbpListEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListEdit.Size = new System.Drawing.Size(560, 434);
            this.tbpListEdit.TabIndex = 2;
            this.tbpListEdit.Text = "リスト編集";
            this.tbpListEdit.UseVisualStyleBackColor = true;
            // 
            // gbxListEditFEN1
            // 
            this.gbxListEditFEN1.Controls.Add(this.btnDeleteFEN1List);
            this.gbxListEditFEN1.Controls.Add(this.btnAddFEN1List);
            this.gbxListEditFEN1.Controls.Add(this.txtFEN1ListName);
            this.gbxListEditFEN1.Controls.Add(this.lblFEN1ListName);
            this.gbxListEditFEN1.Location = new System.Drawing.Point(3, 270);
            this.gbxListEditFEN1.Name = "gbxListEditFEN1";
            this.gbxListEditFEN1.Size = new System.Drawing.Size(224, 119);
            this.gbxListEditFEN1.TabIndex = 6;
            this.gbxListEditFEN1.TabStop = false;
            this.gbxListEditFEN1.Text = "FEN1";
            // 
            // btnDeleteFEN1List
            // 
            this.btnDeleteFEN1List.Location = new System.Drawing.Point(137, 90);
            this.btnDeleteFEN1List.Name = "btnDeleteFEN1List";
            this.btnDeleteFEN1List.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFEN1List.TabIndex = 3;
            this.btnDeleteFEN1List.Text = "削除";
            this.btnDeleteFEN1List.UseVisualStyleBackColor = true;
            this.btnDeleteFEN1List.Click += new System.EventHandler(this.BtnDeleteFEN1List_Click);
            // 
            // btnAddFEN1List
            // 
            this.btnAddFEN1List.Location = new System.Drawing.Point(8, 90);
            this.btnAddFEN1List.Name = "btnAddFEN1List";
            this.btnAddFEN1List.Size = new System.Drawing.Size(75, 23);
            this.btnAddFEN1List.TabIndex = 2;
            this.btnAddFEN1List.Text = "追加";
            this.btnAddFEN1List.UseVisualStyleBackColor = true;
            this.btnAddFEN1List.Click += new System.EventHandler(this.BtnAddFEN1List_Click);
            // 
            // txtFEN1ListName
            // 
            this.txtFEN1ListName.Location = new System.Drawing.Point(8, 51);
            this.txtFEN1ListName.Name = "txtFEN1ListName";
            this.txtFEN1ListName.Size = new System.Drawing.Size(204, 19);
            this.txtFEN1ListName.TabIndex = 1;
            this.txtFEN1ListName.TextChanged += new System.EventHandler(this.TxtFEN1ListName_TextChanged);
            // 
            // lblFEN1ListName
            // 
            this.lblFEN1ListName.AutoSize = true;
            this.lblFEN1ListName.Location = new System.Drawing.Point(6, 19);
            this.lblFEN1ListName.Name = "lblFEN1ListName";
            this.lblFEN1ListName.Size = new System.Drawing.Size(168, 12);
            this.lblFEN1ListName.TabIndex = 0;
            this.lblFEN1ListName.Text = "名前必須(Flowなどを省いた名前)";
            // 
            // gbxListEditFLW2
            // 
            this.gbxListEditFLW2.Controls.Add(this.btnDeleteFLW2List);
            this.gbxListEditFLW2.Controls.Add(this.btnAddFLW2List);
            this.gbxListEditFLW2.Controls.Add(this.lblFLW2ListEditDiscription);
            this.gbxListEditFLW2.Location = new System.Drawing.Point(3, 164);
            this.gbxListEditFLW2.Name = "gbxListEditFLW2";
            this.gbxListEditFLW2.Size = new System.Drawing.Size(224, 100);
            this.gbxListEditFLW2.TabIndex = 5;
            this.gbxListEditFLW2.TabStop = false;
            this.gbxListEditFLW2.Text = "FLW2";
            // 
            // btnDeleteFLW2List
            // 
            this.btnDeleteFLW2List.Location = new System.Drawing.Point(137, 58);
            this.btnDeleteFLW2List.Name = "btnDeleteFLW2List";
            this.btnDeleteFLW2List.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFLW2List.TabIndex = 3;
            this.btnDeleteFLW2List.Text = "削除";
            this.btnDeleteFLW2List.UseVisualStyleBackColor = true;
            this.btnDeleteFLW2List.Click += new System.EventHandler(this.BtnDeleteFLW2List_Click);
            // 
            // btnAddFLW2List
            // 
            this.btnAddFLW2List.Location = new System.Drawing.Point(8, 58);
            this.btnAddFLW2List.Name = "btnAddFLW2List";
            this.btnAddFLW2List.Size = new System.Drawing.Size(75, 23);
            this.btnAddFLW2List.TabIndex = 2;
            this.btnAddFLW2List.Text = "追加";
            this.btnAddFLW2List.UseVisualStyleBackColor = true;
            this.btnAddFLW2List.Click += new System.EventHandler(this.BtnAddFLW2List_Click);
            // 
            // lblFLW2ListEditDiscription
            // 
            this.lblFLW2ListEditDiscription.AutoSize = true;
            this.lblFLW2ListEditDiscription.Location = new System.Drawing.Point(6, 22);
            this.lblFLW2ListEditDiscription.Name = "lblFLW2ListEditDiscription";
            this.lblFLW2ListEditDiscription.Size = new System.Drawing.Size(135, 12);
            this.lblFLW2ListEditDiscription.TabIndex = 0;
            this.lblFLW2ListEditDiscription.Text = "この項目は名前が不要です";
            // 
            // gbxListEditMSBT
            // 
            this.gbxListEditMSBT.Controls.Add(this.lblMSBTListEditDiscription);
            this.gbxListEditMSBT.Controls.Add(this.lblMSBTListName);
            this.gbxListEditMSBT.Controls.Add(this.txtSelectedMSBTListName);
            this.gbxListEditMSBT.Controls.Add(this.lblMSBTListEditNote);
            this.gbxListEditMSBT.Controls.Add(this.btnDeleteMSBTList);
            this.gbxListEditMSBT.Controls.Add(this.txtMSBTListName);
            this.gbxListEditMSBT.Controls.Add(this.btnAddMSBTList);
            this.gbxListEditMSBT.Location = new System.Drawing.Point(3, 6);
            this.gbxListEditMSBT.Name = "gbxListEditMSBT";
            this.gbxListEditMSBT.Size = new System.Drawing.Size(224, 152);
            this.gbxListEditMSBT.TabIndex = 4;
            this.gbxListEditMSBT.TabStop = false;
            this.gbxListEditMSBT.Text = "MSBT";
            // 
            // lblMSBTListEditDiscription
            // 
            this.lblMSBTListEditDiscription.AutoSize = true;
            this.lblMSBTListEditDiscription.Location = new System.Drawing.Point(6, 39);
            this.lblMSBTListEditDiscription.Name = "lblMSBTListEditDiscription";
            this.lblMSBTListEditDiscription.Size = new System.Drawing.Size(142, 24);
            this.lblMSBTListEditDiscription.TabIndex = 4;
            this.lblMSBTListEditDiscription.Text = "削除は対象のリスト選択後に\r\n右の削除ボタンを押す";
            // 
            // lblMSBTListName
            // 
            this.lblMSBTListName.AutoSize = true;
            this.lblMSBTListName.Location = new System.Drawing.Point(6, 15);
            this.lblMSBTListName.Name = "lblMSBTListName";
            this.lblMSBTListName.Size = new System.Drawing.Size(115, 12);
            this.lblMSBTListName.TabIndex = 3;
            this.lblMSBTListName.Text = "追加するMSBTリスト名";
            // 
            // txtSelectedMSBTListName
            // 
            this.txtSelectedMSBTListName.Location = new System.Drawing.Point(8, 116);
            this.txtSelectedMSBTListName.Name = "txtSelectedMSBTListName";
            this.txtSelectedMSBTListName.ReadOnly = true;
            this.txtSelectedMSBTListName.Size = new System.Drawing.Size(204, 19);
            this.txtSelectedMSBTListName.TabIndex = 1;
            this.txtSelectedMSBTListName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox30_MouseClick);
            this.txtSelectedMSBTListName.TextChanged += new System.EventHandler(this.textBox30_TextChanged);
            // 
            // lblMSBTListEditNote
            // 
            this.lblMSBTListEditNote.AutoSize = true;
            this.lblMSBTListEditNote.ForeColor = System.Drawing.Color.Red;
            this.lblMSBTListEditNote.Location = new System.Drawing.Point(6, 27);
            this.lblMSBTListEditNote.Name = "lblMSBTListEditNote";
            this.lblMSBTListEditNote.Size = new System.Drawing.Size(176, 12);
            this.lblMSBTListEditNote.TabIndex = 5;
            this.lblMSBTListEditNote.Text = "※ゲームの命名規則を守ってください";
            // 
            // btnDeleteMSBTList
            // 
            this.btnDeleteMSBTList.Location = new System.Drawing.Point(137, 91);
            this.btnDeleteMSBTList.Name = "btnDeleteMSBTList";
            this.btnDeleteMSBTList.Size = new System.Drawing.Size(75, 19);
            this.btnDeleteMSBTList.TabIndex = 2;
            this.btnDeleteMSBTList.Text = "削除";
            this.btnDeleteMSBTList.UseVisualStyleBackColor = true;
            this.btnDeleteMSBTList.Click += new System.EventHandler(this.BtnDeleteMSBTList_Click);
            // 
            // txtMSBTListName
            // 
            this.txtMSBTListName.Location = new System.Drawing.Point(8, 66);
            this.txtMSBTListName.Name = "txtMSBTListName";
            this.txtMSBTListName.Size = new System.Drawing.Size(204, 19);
            this.txtMSBTListName.TabIndex = 0;
            this.txtMSBTListName.TextChanged += new System.EventHandler(this.TxtMSBTListName_TextChanged);
            // 
            // btnAddMSBTList
            // 
            this.btnAddMSBTList.Location = new System.Drawing.Point(8, 91);
            this.btnAddMSBTList.Name = "btnAddMSBTList";
            this.btnAddMSBTList.Size = new System.Drawing.Size(75, 19);
            this.btnAddMSBTList.TabIndex = 1;
            this.btnAddMSBTList.Text = "追加";
            this.btnAddMSBTList.UseVisualStyleBackColor = true;
            this.btnAddMSBTList.Click += new System.EventHandler(this.BtnAddMSBTList_Click);
            // 
            // tbpMSBFSetting
            // 
            this.tbpMSBFSetting.Controls.Add(this.chkShowTvwMSBFFlow);
            this.tbpMSBFSetting.Controls.Add(this.btnReloadTvwMSBFFlow);
            this.tbpMSBFSetting.Controls.Add(this.txtReadOnlyMSBTText);
            this.tbpMSBFSetting.Controls.Add(this.lblMSBFFlow);
            this.tbpMSBFSetting.Controls.Add(this.tvwMSBFFlow);
            this.tbpMSBFSetting.Controls.Add(this.lblMSBFSettingNote);
            this.tbpMSBFSetting.Controls.Add(this.gbxFEN1);
            this.tbpMSBFSetting.Controls.Add(this.gbxFLW2);
            this.tbpMSBFSetting.Location = new System.Drawing.Point(4, 22);
            this.tbpMSBFSetting.Name = "tbpMSBFSetting";
            this.tbpMSBFSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMSBFSetting.Size = new System.Drawing.Size(560, 434);
            this.tbpMSBFSetting.TabIndex = 3;
            this.tbpMSBFSetting.Text = "MSBF";
            this.tbpMSBFSetting.UseVisualStyleBackColor = true;
            // 
            // chkShowTvwMSBFFlow
            // 
            this.chkShowTvwMSBFFlow.AutoSize = true;
            this.chkShowTvwMSBFFlow.Location = new System.Drawing.Point(464, 9);
            this.chkShowTvwMSBFFlow.Name = "chkShowTvwMSBFFlow";
            this.chkShowTvwMSBFFlow.Size = new System.Drawing.Size(40, 16);
            this.chkShowTvwMSBFFlow.TabIndex = 19;
            this.chkShowTvwMSBFFlow.Text = "ON";
            this.chkShowTvwMSBFFlow.UseVisualStyleBackColor = true;
            this.chkShowTvwMSBFFlow.CheckedChanged += new System.EventHandler(this.ChkShowTvwMSBFFlow_CheckedChanged);
            // 
            // btnReloadTvwMSBFFlow
            // 
            this.btnReloadTvwMSBFFlow.Location = new System.Drawing.Point(439, 341);
            this.btnReloadTvwMSBFFlow.Name = "btnReloadTvwMSBFFlow";
            this.btnReloadTvwMSBFFlow.Size = new System.Drawing.Size(115, 23);
            this.btnReloadTvwMSBFFlow.TabIndex = 18;
            this.btnReloadTvwMSBFFlow.Text = "アップデート/Reload ";
            this.btnReloadTvwMSBFFlow.UseVisualStyleBackColor = true;
            this.btnReloadTvwMSBFFlow.Click += new System.EventHandler(this.BtnReloadTvwMSBFFlow_Click);
            // 
            // txtReadOnlyMSBTText
            // 
            this.txtReadOnlyMSBTText.Location = new System.Drawing.Point(6, 370);
            this.txtReadOnlyMSBTText.Multiline = true;
            this.txtReadOnlyMSBTText.Name = "txtReadOnlyMSBTText";
            this.txtReadOnlyMSBTText.ReadOnly = true;
            this.txtReadOnlyMSBTText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReadOnlyMSBTText.Size = new System.Drawing.Size(548, 58);
            this.txtReadOnlyMSBTText.TabIndex = 17;
            this.txtReadOnlyMSBTText.TextChanged += new System.EventHandler(this.TxtReadOnlyMSBTText_TextChanged);
            // 
            // lblMSBFFlow
            // 
            this.lblMSBFFlow.AutoSize = true;
            this.lblMSBFFlow.Location = new System.Drawing.Point(329, 10);
            this.lblMSBFFlow.Name = "lblMSBFFlow";
            this.lblMSBFFlow.Size = new System.Drawing.Size(129, 12);
            this.lblMSBFFlow.TabIndex = 16;
            this.lblMSBFFlow.Text = "テスト機能/Test function";
            // 
            // tvwMSBFFlow
            // 
            this.tvwMSBFFlow.Location = new System.Drawing.Point(329, 28);
            this.tvwMSBFFlow.Name = "tvwMSBFFlow";
            this.tvwMSBFFlow.Size = new System.Drawing.Size(225, 304);
            this.tvwMSBFFlow.TabIndex = 15;
            this.tvwMSBFFlow.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvwMSBFFlow_AfterSelect);
            // 
            // lblMSBFSettingNote
            // 
            this.lblMSBFSettingNote.AutoSize = true;
            this.lblMSBFSettingNote.Location = new System.Drawing.Point(6, 335);
            this.lblMSBFSettingNote.Name = "lblMSBFSettingNote";
            this.lblMSBFSettingNote.Size = new System.Drawing.Size(210, 24);
            this.lblMSBFSettingNote.TabIndex = 14;
            this.lblMSBFSettingNote.Text = "※まだすべての機能が解明できていないので\r\n　不具合が発生する可能性があります";
            // 
            // gbxFEN1
            // 
            this.gbxFEN1.Controls.Add(this.lblFLW2StartIndex);
            this.gbxFEN1.Controls.Add(this.lblFEN1Arg0);
            this.gbxFEN1.Controls.Add(this.txtFEN1StartIndex);
            this.gbxFEN1.Controls.Add(this.txtFEN1Arg0);
            this.gbxFEN1.Location = new System.Drawing.Point(6, 262);
            this.gbxFEN1.Name = "gbxFEN1";
            this.gbxFEN1.Size = new System.Drawing.Size(317, 70);
            this.gbxFEN1.TabIndex = 13;
            this.gbxFEN1.TabStop = false;
            this.gbxFEN1.Text = "FEN1";
            // 
            // lblFLW2StartIndex
            // 
            this.lblFLW2StartIndex.AutoSize = true;
            this.lblFLW2StartIndex.Location = new System.Drawing.Point(6, 42);
            this.lblFLW2StartIndex.Name = "lblFLW2StartIndex";
            this.lblFLW2StartIndex.Size = new System.Drawing.Size(109, 12);
            this.lblFLW2StartIndex.TabIndex = 4;
            this.lblFLW2StartIndex.Text = "FLW2開始インデックス";
            // 
            // lblFEN1Arg0
            // 
            this.lblFEN1Arg0.AutoSize = true;
            this.lblFEN1Arg0.Location = new System.Drawing.Point(6, 18);
            this.lblFEN1Arg0.Name = "lblFEN1Arg0";
            this.lblFEN1Arg0.Size = new System.Drawing.Size(29, 12);
            this.lblFEN1Arg0.TabIndex = 3;
            this.lblFEN1Arg0.Text = "不明";
            // 
            // txtFEN1StartIndex
            // 
            this.txtFEN1StartIndex.Location = new System.Drawing.Point(178, 39);
            this.txtFEN1StartIndex.Name = "txtFEN1StartIndex";
            this.txtFEN1StartIndex.Size = new System.Drawing.Size(100, 19);
            this.txtFEN1StartIndex.TabIndex = 2;
            this.txtFEN1StartIndex.TextChanged += new System.EventHandler(this.TxtFEN1StartIndex_TextChanged);
            // 
            // txtFEN1Arg0
            // 
            this.txtFEN1Arg0.Enabled = false;
            this.txtFEN1Arg0.Location = new System.Drawing.Point(178, 15);
            this.txtFEN1Arg0.Name = "txtFEN1Arg0";
            this.txtFEN1Arg0.Size = new System.Drawing.Size(100, 19);
            this.txtFEN1Arg0.TabIndex = 1;
            this.txtFEN1Arg0.TextChanged += new System.EventHandler(this.TxtFEN1Arg0_TextChanged);
            // 
            // gbxFLW2
            // 
            this.gbxFLW2.Controls.Add(this.label41);
            this.gbxFLW2.Controls.Add(this.gbxFLW2Branch);
            this.gbxFLW2.Controls.Add(this.lblFLW2Arg4);
            this.gbxFLW2.Controls.Add(this.lblFLW2Arg3);
            this.gbxFLW2.Controls.Add(this.lblFLW2Arg2);
            this.gbxFLW2.Controls.Add(this.lblFLW2Arg1);
            this.gbxFLW2.Controls.Add(this.txtFLW2Arg4);
            this.gbxFLW2.Controls.Add(this.txtFLW2Arg3);
            this.gbxFLW2.Controls.Add(this.txtFLW2Arg2);
            this.gbxFLW2.Controls.Add(this.txtFLW2Arg1);
            this.gbxFLW2.Controls.Add(this.txtFLW2Padding);
            this.gbxFLW2.Controls.Add(this.lblFLW2Padding);
            this.gbxFLW2.Controls.Add(this.txtFLW2FlowType);
            this.gbxFLW2.Controls.Add(this.lblFLW2FlowType);
            this.gbxFLW2.Location = new System.Drawing.Point(6, 10);
            this.gbxFLW2.Name = "gbxFLW2";
            this.gbxFLW2.Size = new System.Drawing.Size(317, 246);
            this.gbxFLW2.TabIndex = 1;
            this.gbxFLW2.TabStop = false;
            this.gbxFLW2.Text = "FLW2";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 37);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(17, 12);
            this.label41.TabIndex = 13;
            this.label41.Text = "∟";
            // 
            // gbxFLW2Branch
            // 
            this.gbxFLW2Branch.Controls.Add(this.txtFLW2BranchFalse);
            this.gbxFLW2Branch.Controls.Add(this.txtFLW2BranchTrue);
            this.gbxFLW2Branch.Controls.Add(this.lblFLW2BranchFalse);
            this.gbxFLW2Branch.Controls.Add(this.lblFLW2BranchTrue);
            this.gbxFLW2Branch.Location = new System.Drawing.Point(28, 37);
            this.gbxFLW2Branch.Name = "gbxFLW2Branch";
            this.gbxFLW2Branch.Size = new System.Drawing.Size(269, 70);
            this.gbxFLW2Branch.TabIndex = 12;
            this.gbxFLW2Branch.TabStop = false;
            this.gbxFLW2Branch.Text = "フロータイプ2の場合のみ";
            // 
            // txtFLW2BranchFalse
            // 
            this.txtFLW2BranchFalse.Location = new System.Drawing.Point(150, 41);
            this.txtFLW2BranchFalse.MaxLength = 4;
            this.txtFLW2BranchFalse.Name = "txtFLW2BranchFalse";
            this.txtFLW2BranchFalse.Size = new System.Drawing.Size(100, 19);
            this.txtFLW2BranchFalse.TabIndex = 3;
            this.txtFLW2BranchFalse.TextChanged += new System.EventHandler(this.TxtFLW2BranchFalse_TextChanged);
            this.txtFLW2BranchFalse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFLW2BranchTrue_KeyPress);
            // 
            // txtFLW2BranchTrue
            // 
            this.txtFLW2BranchTrue.Location = new System.Drawing.Point(150, 16);
            this.txtFLW2BranchTrue.MaxLength = 4;
            this.txtFLW2BranchTrue.Name = "txtFLW2BranchTrue";
            this.txtFLW2BranchTrue.Size = new System.Drawing.Size(100, 19);
            this.txtFLW2BranchTrue.TabIndex = 2;
            this.txtFLW2BranchTrue.TextChanged += new System.EventHandler(this.TxtFLW2BranchTrue_TextChanged);
            this.txtFLW2BranchTrue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFLW2BranchTrue_KeyPress);
            // 
            // lblFLW2BranchFalse
            // 
            this.lblFLW2BranchFalse.AutoSize = true;
            this.lblFLW2BranchFalse.Location = new System.Drawing.Point(6, 44);
            this.lblFLW2BranchFalse.Name = "lblFLW2BranchFalse";
            this.lblFLW2BranchFalse.Size = new System.Drawing.Size(59, 12);
            this.lblFLW2BranchFalse.TabIndex = 1;
            this.lblFLW2BranchFalse.Text = "ジャンプ先2";
            // 
            // lblFLW2BranchTrue
            // 
            this.lblFLW2BranchTrue.AutoSize = true;
            this.lblFLW2BranchTrue.Location = new System.Drawing.Point(6, 19);
            this.lblFLW2BranchTrue.Name = "lblFLW2BranchTrue";
            this.lblFLW2BranchTrue.Size = new System.Drawing.Size(59, 12);
            this.lblFLW2BranchTrue.TabIndex = 0;
            this.lblFLW2BranchTrue.Text = "ジャンプ先1";
            // 
            // lblFLW2Arg4
            // 
            this.lblFLW2Arg4.AutoSize = true;
            this.lblFLW2Arg4.Location = new System.Drawing.Point(6, 218);
            this.lblFLW2Arg4.Name = "lblFLW2Arg4";
            this.lblFLW2Arg4.Size = new System.Drawing.Size(35, 12);
            this.lblFLW2Arg4.TabIndex = 11;
            this.lblFLW2Arg4.Text = "不明5";
            // 
            // lblFLW2Arg3
            // 
            this.lblFLW2Arg3.AutoSize = true;
            this.lblFLW2Arg3.Location = new System.Drawing.Point(6, 193);
            this.lblFLW2Arg3.Name = "lblFLW2Arg3";
            this.lblFLW2Arg3.Size = new System.Drawing.Size(35, 12);
            this.lblFLW2Arg3.TabIndex = 10;
            this.lblFLW2Arg3.Text = "不明4";
            // 
            // lblFLW2Arg2
            // 
            this.lblFLW2Arg2.AutoSize = true;
            this.lblFLW2Arg2.Location = new System.Drawing.Point(6, 168);
            this.lblFLW2Arg2.Name = "lblFLW2Arg2";
            this.lblFLW2Arg2.Size = new System.Drawing.Size(35, 12);
            this.lblFLW2Arg2.TabIndex = 9;
            this.lblFLW2Arg2.Text = "不明3";
            // 
            // lblFLW2Arg1
            // 
            this.lblFLW2Arg1.AutoSize = true;
            this.lblFLW2Arg1.Location = new System.Drawing.Point(6, 143);
            this.lblFLW2Arg1.Name = "lblFLW2Arg1";
            this.lblFLW2Arg1.Size = new System.Drawing.Size(35, 12);
            this.lblFLW2Arg1.TabIndex = 8;
            this.lblFLW2Arg1.Text = "不明2";
            // 
            // txtFLW2Arg4
            // 
            this.txtFLW2Arg4.Location = new System.Drawing.Point(178, 215);
            this.txtFLW2Arg4.MaxLength = 4;
            this.txtFLW2Arg4.Name = "txtFLW2Arg4";
            this.txtFLW2Arg4.Size = new System.Drawing.Size(100, 19);
            this.txtFLW2Arg4.TabIndex = 7;
            this.txtFLW2Arg4.TextChanged += new System.EventHandler(this.TxtFLW2Arg4_TextChanged);
            this.txtFLW2Arg4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFLW2BranchTrue_KeyPress);
            // 
            // txtFLW2Arg3
            // 
            this.txtFLW2Arg3.Location = new System.Drawing.Point(178, 190);
            this.txtFLW2Arg3.MaxLength = 4;
            this.txtFLW2Arg3.Name = "txtFLW2Arg3";
            this.txtFLW2Arg3.Size = new System.Drawing.Size(100, 19);
            this.txtFLW2Arg3.TabIndex = 6;
            this.txtFLW2Arg3.TextChanged += new System.EventHandler(this.TxtFLW2Arg3_TextChanged);
            this.txtFLW2Arg3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFLW2BranchTrue_KeyPress);
            // 
            // txtFLW2Arg2
            // 
            this.txtFLW2Arg2.Location = new System.Drawing.Point(178, 165);
            this.txtFLW2Arg2.MaxLength = 4;
            this.txtFLW2Arg2.Name = "txtFLW2Arg2";
            this.txtFLW2Arg2.Size = new System.Drawing.Size(100, 19);
            this.txtFLW2Arg2.TabIndex = 5;
            this.txtFLW2Arg2.TextChanged += new System.EventHandler(this.TxtFLW2Arg2_TextChanged);
            this.txtFLW2Arg2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFLW2BranchTrue_KeyPress);
            // 
            // txtFLW2Arg1
            // 
            this.txtFLW2Arg1.Location = new System.Drawing.Point(178, 140);
            this.txtFLW2Arg1.MaxLength = 4;
            this.txtFLW2Arg1.Name = "txtFLW2Arg1";
            this.txtFLW2Arg1.Size = new System.Drawing.Size(100, 19);
            this.txtFLW2Arg1.TabIndex = 4;
            this.txtFLW2Arg1.TextChanged += new System.EventHandler(this.TxtFLW2Arg1_TextChanged);
            this.txtFLW2Arg1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFLW2BranchTrue_KeyPress);
            // 
            // txtFLW2Padding
            // 
            this.txtFLW2Padding.Location = new System.Drawing.Point(178, 115);
            this.txtFLW2Padding.MaxLength = 4;
            this.txtFLW2Padding.Name = "txtFLW2Padding";
            this.txtFLW2Padding.Size = new System.Drawing.Size(100, 19);
            this.txtFLW2Padding.TabIndex = 3;
            this.txtFLW2Padding.TextChanged += new System.EventHandler(this.TxtFLW2Padding_TextChanged);
            this.txtFLW2Padding.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFLW2BranchTrue_KeyPress);
            // 
            // lblFLW2Padding
            // 
            this.lblFLW2Padding.AutoSize = true;
            this.lblFLW2Padding.Location = new System.Drawing.Point(6, 118);
            this.lblFLW2Padding.Name = "lblFLW2Padding";
            this.lblFLW2Padding.Size = new System.Drawing.Size(62, 12);
            this.lblFLW2Padding.TabIndex = 2;
            this.lblFLW2Padding.Text = "パディング？";
            // 
            // txtFLW2FlowType
            // 
            this.txtFLW2FlowType.Location = new System.Drawing.Point(178, 12);
            this.txtFLW2FlowType.MaxLength = 4;
            this.txtFLW2FlowType.Name = "txtFLW2FlowType";
            this.txtFLW2FlowType.Size = new System.Drawing.Size(100, 19);
            this.txtFLW2FlowType.TabIndex = 1;
            this.txtFLW2FlowType.TextChanged += new System.EventHandler(this.TxtFLW2FlowType_TextChanged);
            this.txtFLW2FlowType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFLW2FlowType_KeyPress);
            // 
            // lblFLW2FlowType
            // 
            this.lblFLW2FlowType.AutoSize = true;
            this.lblFLW2FlowType.Location = new System.Drawing.Point(6, 15);
            this.lblFLW2FlowType.Name = "lblFLW2FlowType";
            this.lblFLW2FlowType.Size = new System.Drawing.Size(58, 12);
            this.lblFLW2FlowType.TabIndex = 0;
            this.lblFLW2FlowType.Text = "フロータイプ";
            // 
            // tbpDebugMSBF
            // 
            this.tbpDebugMSBF.Controls.Add(this.lblMSBFHashCalculator);
            this.tbpDebugMSBF.Controls.Add(this.textBox34);
            this.tbpDebugMSBF.Controls.Add(this.button30);
            this.tbpDebugMSBF.Controls.Add(this.textBox33);
            this.tbpDebugMSBF.Controls.Add(this.textBox32);
            this.tbpDebugMSBF.Controls.Add(this.btnCalculateHash);
            this.tbpDebugMSBF.Controls.Add(this.txtListNameToCalculateHash);
            this.tbpDebugMSBF.Controls.Add(this.richTextBox1);
            this.tbpDebugMSBF.Controls.Add(this.textBox13);
            this.tbpDebugMSBF.Location = new System.Drawing.Point(4, 22);
            this.tbpDebugMSBF.Name = "tbpDebugMSBF";
            this.tbpDebugMSBF.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDebugMSBF.Size = new System.Drawing.Size(560, 434);
            this.tbpDebugMSBF.TabIndex = 4;
            this.tbpDebugMSBF.Text = "MSBFデバッグ";
            this.tbpDebugMSBF.UseVisualStyleBackColor = true;
            // 
            // lblMSBFHashCalculator
            // 
            this.lblMSBFHashCalculator.AutoSize = true;
            this.lblMSBFHashCalculator.Location = new System.Drawing.Point(6, 12);
            this.lblMSBFHashCalculator.Name = "lblMSBFHashCalculator";
            this.lblMSBFHashCalculator.Size = new System.Drawing.Size(107, 12);
            this.lblMSBFHashCalculator.TabIndex = 16;
            this.lblMSBFHashCalculator.Text = "MSBFハッシュ計算機";
            this.lblMSBFHashCalculator.Click += new System.EventHandler(this.LblMSBFHashCalculator_Click);
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(6, 184);
            this.textBox34.Multiline = true;
            this.textBox34.Name = "textBox34";
            this.textBox34.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox34.Size = new System.Drawing.Size(548, 98);
            this.textBox34.TabIndex = 15;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(95, 386);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(75, 23);
            this.button30.TabIndex = 14;
            this.button30.Text = "button30";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Visible = false;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(6, 77);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(133, 19);
            this.textBox33.TabIndex = 11;
            this.textBox33.TextChanged += new System.EventHandler(this.textBox33_TextChanged);
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(6, 52);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(133, 19);
            this.textBox32.TabIndex = 10;
            this.textBox32.TextChanged += new System.EventHandler(this.textBox32_TextChanged);
            // 
            // btnCalculateHash
            // 
            this.btnCalculateHash.Location = new System.Drawing.Point(274, 25);
            this.btnCalculateHash.Name = "btnCalculateHash";
            this.btnCalculateHash.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateHash.TabIndex = 9;
            this.btnCalculateHash.Text = "計算";
            this.btnCalculateHash.UseVisualStyleBackColor = true;
            this.btnCalculateHash.Click += new System.EventHandler(this.BtnCalculateHash_Click);
            // 
            // txtListNameToCalculateHash
            // 
            this.txtListNameToCalculateHash.Location = new System.Drawing.Point(6, 27);
            this.txtListNameToCalculateHash.Name = "txtListNameToCalculateHash";
            this.txtListNameToCalculateHash.Size = new System.Drawing.Size(262, 19);
            this.txtListNameToCalculateHash.TabIndex = 8;
            this.txtListNameToCalculateHash.TextChanged += new System.EventHandler(this.TxtListNameToCalculateHash_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 288);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(83, 121);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(6, 112);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox13.Size = new System.Drawing.Size(548, 66);
            this.textBox13.TabIndex = 7;
            // 
            // tbpDebug
            // 
            this.tbpDebug.Controls.Add(this.textBox1);
            this.tbpDebug.Controls.Add(this.button1);
            this.tbpDebug.Controls.Add(this.UnknownTag);
            this.tbpDebug.Controls.Add(this.MSBT_Debug_Text);
            this.tbpDebug.Controls.Add(this.textBox27);
            this.tbpDebug.Controls.Add(this.btnReleaseDebugTextFile);
            this.tbpDebug.Controls.Add(this.textBox2);
            this.tbpDebug.Location = new System.Drawing.Point(4, 22);
            this.tbpDebug.Name = "tbpDebug";
            this.tbpDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDebug.Size = new System.Drawing.Size(560, 434);
            this.tbpDebug.TabIndex = 5;
            this.tbpDebug.Text = "デバッグ";
            this.tbpDebug.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 16;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "TextSort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UnknownTag
            // 
            this.UnknownTag.Location = new System.Drawing.Point(6, 265);
            this.UnknownTag.Multiline = true;
            this.UnknownTag.Name = "UnknownTag";
            this.UnknownTag.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UnknownTag.Size = new System.Drawing.Size(548, 122);
            this.UnknownTag.TabIndex = 14;
            // 
            // MSBT_Debug_Text
            // 
            this.MSBT_Debug_Text.Location = new System.Drawing.Point(6, 229);
            this.MSBT_Debug_Text.Multiline = true;
            this.MSBT_Debug_Text.Name = "MSBT_Debug_Text";
            this.MSBT_Debug_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MSBT_Debug_Text.Size = new System.Drawing.Size(548, 30);
            this.MSBT_Debug_Text.TabIndex = 0;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(6, 144);
            this.textBox27.Multiline = true;
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(333, 79);
            this.textBox27.TabIndex = 13;
            // 
            // btnReleaseDebugTextFile
            // 
            this.btnReleaseDebugTextFile.Location = new System.Drawing.Point(345, 200);
            this.btnReleaseDebugTextFile.Name = "btnReleaseDebugTextFile";
            this.btnReleaseDebugTextFile.Size = new System.Drawing.Size(209, 23);
            this.btnReleaseDebugTextFile.TabIndex = 8;
            this.btnReleaseDebugTextFile.Text = "デバッグテキストファイル排出";
            this.btnReleaseDebugTextFile.UseVisualStyleBackColor = true;
            this.btnReleaseDebugTextFile.Click += new System.EventHandler(this.BtnReleaseDebugTextFile_Click);
            // 
            // tbpCredit
            // 
            this.tbpCredit.Controls.Add(this.gbxCreditLBL1);
            this.tbpCredit.Controls.Add(this.txtATR1SpecialTextOffset);
            this.tbpCredit.Controls.Add(this.gbxCreditProgrammer);
            this.tbpCredit.Controls.Add(this.lblATR1SpecialTextOffset);
            this.tbpCredit.Controls.Add(this.gbxCreditDebugger);
            this.tbpCredit.Controls.Add(this.gbxCreditSectionEntrySize);
            this.tbpCredit.Location = new System.Drawing.Point(4, 22);
            this.tbpCredit.Name = "tbpCredit";
            this.tbpCredit.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCredit.Size = new System.Drawing.Size(560, 434);
            this.tbpCredit.TabIndex = 6;
            this.tbpCredit.Text = "Credit";
            this.tbpCredit.UseVisualStyleBackColor = true;
            // 
            // gbxCreditLBL1
            // 
            this.gbxCreditLBL1.Controls.Add(this.lblCreditLBL1Note);
            this.gbxCreditLBL1.Controls.Add(this.lblLBL1TagIndex);
            this.gbxCreditLBL1.Controls.Add(this.txtLBL1TagIndex);
            this.gbxCreditLBL1.Location = new System.Drawing.Point(283, 337);
            this.gbxCreditLBL1.Name = "gbxCreditLBL1";
            this.gbxCreditLBL1.Size = new System.Drawing.Size(233, 91);
            this.gbxCreditLBL1.TabIndex = 7;
            this.gbxCreditLBL1.TabStop = false;
            this.gbxCreditLBL1.Text = "LBL1";
            this.gbxCreditLBL1.Visible = false;
            // 
            // lblCreditLBL1Note
            // 
            this.lblCreditLBL1Note.AutoSize = true;
            this.lblCreditLBL1Note.ForeColor = System.Drawing.Color.Red;
            this.lblCreditLBL1Note.Location = new System.Drawing.Point(6, 13);
            this.lblCreditLBL1Note.Name = "lblCreditLBL1Note";
            this.lblCreditLBL1Note.Size = new System.Drawing.Size(162, 24);
            this.lblCreditLBL1Note.TabIndex = 7;
            this.lblCreditLBL1Note.Text = "この項目が　0　の場合\r\nゲームにテキストが認識されません";
            // 
            // lblLBL1TagIndex
            // 
            this.lblLBL1TagIndex.AutoSize = true;
            this.lblLBL1TagIndex.Location = new System.Drawing.Point(6, 47);
            this.lblLBL1TagIndex.Name = "lblLBL1TagIndex";
            this.lblLBL1TagIndex.Size = new System.Drawing.Size(86, 12);
            this.lblLBL1TagIndex.TabIndex = 6;
            this.lblLBL1TagIndex.Text = "タグインデックス？";
            // 
            // txtLBL1TagIndex
            // 
            this.txtLBL1TagIndex.Enabled = false;
            this.txtLBL1TagIndex.Location = new System.Drawing.Point(127, 44);
            this.txtLBL1TagIndex.Name = "txtLBL1TagIndex";
            this.txtLBL1TagIndex.Size = new System.Drawing.Size(100, 19);
            this.txtLBL1TagIndex.TabIndex = 5;
            this.txtLBL1TagIndex.TextChanged += new System.EventHandler(this.TxtLBL1TagIndex_TextChanged);
            // 
            // txtATR1SpecialTextOffset
            // 
            this.txtATR1SpecialTextOffset.Enabled = false;
            this.txtATR1SpecialTextOffset.Location = new System.Drawing.Point(133, 294);
            this.txtATR1SpecialTextOffset.MaxLength = 2;
            this.txtATR1SpecialTextOffset.Name = "txtATR1SpecialTextOffset";
            this.txtATR1SpecialTextOffset.Size = new System.Drawing.Size(100, 19);
            this.txtATR1SpecialTextOffset.TabIndex = 7;
            this.txtATR1SpecialTextOffset.Visible = false;
            // 
            // gbxCreditProgrammer
            // 
            this.gbxCreditProgrammer.Controls.Add(this.label54);
            this.gbxCreditProgrammer.Controls.Add(this.gbxCreditContributor);
            this.gbxCreditProgrammer.Controls.Add(this.lblCreditPenguin);
            this.gbxCreditProgrammer.Location = new System.Drawing.Point(6, 6);
            this.gbxCreditProgrammer.Name = "gbxCreditProgrammer";
            this.gbxCreditProgrammer.Size = new System.Drawing.Size(255, 100);
            this.gbxCreditProgrammer.TabIndex = 1;
            this.gbxCreditProgrammer.TabStop = false;
            this.gbxCreditProgrammer.Text = "プログラミングとその他全般";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(10, 69);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(177, 24);
            this.label54.TabIndex = 5;
            this.label54.Text = "ツールの完成に協力して下さった\r\nEvanbowlさんありがとうございました。";
            // 
            // gbxCreditContributor
            // 
            this.gbxCreditContributor.Controls.Add(this.lblCreditEvanbowl);
            this.gbxCreditContributor.Location = new System.Drawing.Point(4, 30);
            this.gbxCreditContributor.Name = "gbxCreditContributor";
            this.gbxCreditContributor.Size = new System.Drawing.Size(245, 36);
            this.gbxCreditContributor.TabIndex = 16;
            this.gbxCreditContributor.TabStop = false;
            this.gbxCreditContributor.Text = "Contributor";
            // 
            // lblCreditEvanbowl
            // 
            this.lblCreditEvanbowl.AutoSize = true;
            this.lblCreditEvanbowl.Location = new System.Drawing.Point(6, 15);
            this.lblCreditEvanbowl.Name = "lblCreditEvanbowl";
            this.lblCreditEvanbowl.Size = new System.Drawing.Size(53, 12);
            this.lblCreditEvanbowl.TabIndex = 4;
            this.lblCreditEvanbowl.Text = "Evanbowl";
            // 
            // lblCreditPenguin
            // 
            this.lblCreditPenguin.AutoSize = true;
            this.lblCreditPenguin.Location = new System.Drawing.Point(10, 15);
            this.lblCreditPenguin.Name = "lblCreditPenguin";
            this.lblCreditPenguin.Size = new System.Drawing.Size(53, 12);
            this.lblCreditPenguin.TabIndex = 0;
            this.lblCreditPenguin.Text = "ぺんぐいん";
            // 
            // lblATR1SpecialTextOffset
            // 
            this.lblATR1SpecialTextOffset.AutoSize = true;
            this.lblATR1SpecialTextOffset.Location = new System.Drawing.Point(22, 297);
            this.lblATR1SpecialTextOffset.Name = "lblATR1SpecialTextOffset";
            this.lblATR1SpecialTextOffset.Size = new System.Drawing.Size(105, 12);
            this.lblATR1SpecialTextOffset.TabIndex = 15;
            this.lblATR1SpecialTextOffset.Text = "nullオフセット触らない";
            this.lblATR1SpecialTextOffset.Visible = false;
            // 
            // gbxCreditDebugger
            // 
            this.gbxCreditDebugger.Controls.Add(this.label55);
            this.gbxCreditDebugger.Controls.Add(this.gbxCreditDebuggerVIP);
            this.gbxCreditDebugger.Controls.Add(this.lblCreditPorto);
            this.gbxCreditDebugger.Controls.Add(this.lblCreditHiiraghi);
            this.gbxCreditDebugger.Controls.Add(this.lblCreditEigen);
            this.gbxCreditDebugger.Location = new System.Drawing.Point(6, 112);
            this.gbxCreditDebugger.Name = "gbxCreditDebugger";
            this.gbxCreditDebugger.Size = new System.Drawing.Size(255, 116);
            this.gbxCreditDebugger.TabIndex = 0;
            this.gbxCreditDebugger.TabStop = false;
            this.gbxCreditDebugger.Text = "デバッガー";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(10, 89);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(149, 24);
            this.label55.TabIndex = 2;
            this.label55.Text = "デバッガーの皆様もご協力頂き\r\nありがとうございました。";
            // 
            // gbxCreditDebuggerVIP
            // 
            this.gbxCreditDebuggerVIP.Controls.Add(this.lblCreditXenon);
            this.gbxCreditDebuggerVIP.Controls.Add(this.lblCreditDossun);
            this.gbxCreditDebuggerVIP.Location = new System.Drawing.Point(4, 18);
            this.gbxCreditDebuggerVIP.Name = "gbxCreditDebuggerVIP";
            this.gbxCreditDebuggerVIP.Size = new System.Drawing.Size(245, 35);
            this.gbxCreditDebuggerVIP.TabIndex = 16;
            this.gbxCreditDebuggerVIP.TabStop = false;
            this.gbxCreditDebuggerVIP.Text = "一部値の解析";
            // 
            // lblCreditXenon
            // 
            this.lblCreditXenon.AutoSize = true;
            this.lblCreditXenon.Location = new System.Drawing.Point(6, 15);
            this.lblCreditXenon.Name = "lblCreditXenon";
            this.lblCreditXenon.Size = new System.Drawing.Size(36, 12);
            this.lblCreditXenon.TabIndex = 0;
            this.lblCreditXenon.Text = "Xenon";
            // 
            // lblCreditDossun
            // 
            this.lblCreditDossun.AutoSize = true;
            this.lblCreditDossun.Location = new System.Drawing.Point(74, 15);
            this.lblCreditDossun.Name = "lblCreditDossun";
            this.lblCreditDossun.Size = new System.Drawing.Size(43, 12);
            this.lblCreditDossun.TabIndex = 1;
            this.lblCreditDossun.Text = "Dossun";
            // 
            // lblCreditPorto
            // 
            this.lblCreditPorto.AutoSize = true;
            this.lblCreditPorto.Location = new System.Drawing.Point(153, 59);
            this.lblCreditPorto.Name = "lblCreditPorto";
            this.lblCreditPorto.Size = new System.Drawing.Size(68, 12);
            this.lblCreditPorto.TabIndex = 5;
            this.lblCreditPorto.Text = "ChurenPorto";
            // 
            // lblCreditHiiraghi
            // 
            this.lblCreditHiiraghi.AutoSize = true;
            this.lblCreditHiiraghi.Location = new System.Drawing.Point(78, 59);
            this.lblCreditHiiraghi.Name = "lblCreditHiiraghi";
            this.lblCreditHiiraghi.Size = new System.Drawing.Size(47, 12);
            this.lblCreditHiiraghi.TabIndex = 3;
            this.lblCreditHiiraghi.Text = "柊：貴星";
            // 
            // lblCreditEigen
            // 
            this.lblCreditEigen.AutoSize = true;
            this.lblCreditEigen.Location = new System.Drawing.Point(10, 59);
            this.lblCreditEigen.Name = "lblCreditEigen";
            this.lblCreditEigen.Size = new System.Drawing.Size(29, 12);
            this.lblCreditEigen.TabIndex = 2;
            this.lblCreditEigen.Text = "映幻";
            // 
            // gbxCreditSectionEntrySize
            // 
            this.gbxCreditSectionEntrySize.Controls.Add(this.txtATR1EntrySize);
            this.gbxCreditSectionEntrySize.Controls.Add(this.lblATR1EntrySize);
            this.gbxCreditSectionEntrySize.Controls.Add(this.lblCreditSectionEntrySizegbxCreditSectionEntrySizeNote);
            this.gbxCreditSectionEntrySize.Controls.Add(this.txtLBL1EntrySize);
            this.gbxCreditSectionEntrySize.Controls.Add(this.lblLBL1EntrySize);
            this.gbxCreditSectionEntrySize.Location = new System.Drawing.Point(14, 331);
            this.gbxCreditSectionEntrySize.Name = "gbxCreditSectionEntrySize";
            this.gbxCreditSectionEntrySize.Size = new System.Drawing.Size(263, 91);
            this.gbxCreditSectionEntrySize.TabIndex = 8;
            this.gbxCreditSectionEntrySize.TabStop = false;
            this.gbxCreditSectionEntrySize.Text = "各セクションのエントリーサイズ";
            this.gbxCreditSectionEntrySize.Visible = false;
            // 
            // txtATR1EntrySize
            // 
            this.txtATR1EntrySize.Enabled = false;
            this.txtATR1EntrySize.Location = new System.Drawing.Point(147, 68);
            this.txtATR1EntrySize.Name = "txtATR1EntrySize";
            this.txtATR1EntrySize.Size = new System.Drawing.Size(100, 19);
            this.txtATR1EntrySize.TabIndex = 3;
            this.txtATR1EntrySize.TextChanged += new System.EventHandler(this.TxtATR1EntrySize_TextChanged);
            // 
            // lblATR1EntrySize
            // 
            this.lblATR1EntrySize.AutoSize = true;
            this.lblATR1EntrySize.Location = new System.Drawing.Point(6, 71);
            this.lblATR1EntrySize.Name = "lblATR1EntrySize";
            this.lblATR1EntrySize.Size = new System.Drawing.Size(34, 12);
            this.lblATR1EntrySize.TabIndex = 2;
            this.lblATR1EntrySize.Text = "ATR1";
            // 
            // lblCreditSectionEntrySizegbxCreditSectionEntrySizeNote
            // 
            this.lblCreditSectionEntrySizegbxCreditSectionEntrySizeNote.AutoSize = true;
            this.lblCreditSectionEntrySizegbxCreditSectionEntrySizeNote.ForeColor = System.Drawing.Color.Red;
            this.lblCreditSectionEntrySizegbxCreditSectionEntrySizeNote.Location = new System.Drawing.Point(6, 13);
            this.lblCreditSectionEntrySizegbxCreditSectionEntrySizeNote.Name = "lblCreditSectionEntrySizegbxCreditSectionEntrySizeNote";
            this.lblCreditSectionEntrySizegbxCreditSectionEntrySizeNote.Size = new System.Drawing.Size(146, 24);
            this.lblCreditSectionEntrySizegbxCreditSectionEntrySizeNote.TabIndex = 2;
            this.lblCreditSectionEntrySizegbxCreditSectionEntrySizeNote.Text = "※初心者は触らないでください\r\nデータが破損する恐れあり";
            // 
            // txtLBL1EntrySize
            // 
            this.txtLBL1EntrySize.Enabled = false;
            this.txtLBL1EntrySize.Location = new System.Drawing.Point(147, 44);
            this.txtLBL1EntrySize.Name = "txtLBL1EntrySize";
            this.txtLBL1EntrySize.Size = new System.Drawing.Size(100, 19);
            this.txtLBL1EntrySize.TabIndex = 1;
            this.txtLBL1EntrySize.TextChanged += new System.EventHandler(this.TxtLBL1EntrySize_TextChanged);
            // 
            // lblLBL1EntrySize
            // 
            this.lblLBL1EntrySize.AutoSize = true;
            this.lblLBL1EntrySize.Location = new System.Drawing.Point(6, 47);
            this.lblLBL1EntrySize.Name = "lblLBL1EntrySize";
            this.lblLBL1EntrySize.Size = new System.Drawing.Size(31, 12);
            this.lblLBL1EntrySize.TabIndex = 0;
            this.lblLBL1EntrySize.Text = "LBL1";
            // 
            // tbpInfomation
            // 
            this.tbpInfomation.Controls.Add(this.gbxCurrentVersion);
            this.tbpInfomation.Controls.Add(this.lblGitHubReleasesURL);
            this.tbpInfomation.Controls.Add(this.gbxHowToUse);
            this.tbpInfomation.Controls.Add(this.lblGitHubIssuesURL);
            this.tbpInfomation.Controls.Add(this.llbGitHubRepositoryURL);
            this.tbpInfomation.Controls.Add(this.llbGitHubReleasesURL);
            this.tbpInfomation.Controls.Add(this.lblGitHubRepositoryURL);
            this.tbpInfomation.Controls.Add(this.llbGitHubIssuesURL);
            this.tbpInfomation.Location = new System.Drawing.Point(4, 22);
            this.tbpInfomation.Name = "tbpInfomation";
            this.tbpInfomation.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInfomation.Size = new System.Drawing.Size(560, 434);
            this.tbpInfomation.TabIndex = 7;
            this.tbpInfomation.Text = "情報";
            this.tbpInfomation.UseVisualStyleBackColor = true;
            // 
            // gbxCurrentVersion
            // 
            this.gbxCurrentVersion.Controls.Add(this.lblCurrentVersion);
            this.gbxCurrentVersion.Location = new System.Drawing.Point(6, 6);
            this.gbxCurrentVersion.Name = "gbxCurrentVersion";
            this.gbxCurrentVersion.Size = new System.Drawing.Size(443, 53);
            this.gbxCurrentVersion.TabIndex = 9;
            this.gbxCurrentVersion.TabStop = false;
            this.gbxCurrentVersion.Text = "ご利用のバージョン/Current Version";
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.AutoSize = true;
            this.lblCurrentVersion.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCurrentVersion.ForeColor = System.Drawing.Color.Green;
            this.lblCurrentVersion.Location = new System.Drawing.Point(7, 15);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(48, 27);
            this.lblCurrentVersion.TabIndex = 8;
            this.lblCurrentVersion.Text = "ver";
            // 
            // lblGitHubReleasesURL
            // 
            this.lblGitHubReleasesURL.AutoSize = true;
            this.lblGitHubReleasesURL.Location = new System.Drawing.Point(16, 62);
            this.lblGitHubReleasesURL.Name = "lblGitHubReleasesURL";
            this.lblGitHubReleasesURL.Size = new System.Drawing.Size(215, 12);
            this.lblGitHubReleasesURL.TabIndex = 1;
            this.lblGitHubReleasesURL.Text = "このツールの最新版はこちらからお探しください";
            // 
            // gbxHowToUse
            // 
            this.gbxHowToUse.Controls.Add(this.lblSMG2HackWikiURL);
            this.gbxHowToUse.Controls.Add(this.llbSMG2HackWikiURL);
            this.gbxHowToUse.Controls.Add(this.lblSMG2HackDiscordURL);
            this.gbxHowToUse.Controls.Add(this.llbSMG2HackDiscordURL);
            this.gbxHowToUse.Location = new System.Drawing.Point(6, 154);
            this.gbxHowToUse.Name = "gbxHowToUse";
            this.gbxHowToUse.Size = new System.Drawing.Size(313, 85);
            this.gbxHowToUse.TabIndex = 6;
            this.gbxHowToUse.TabStop = false;
            this.gbxHowToUse.Text = "ツールの使い方が分からない場合はこちらを参照してください";
            // 
            // lblSMG2HackWikiURL
            // 
            this.lblSMG2HackWikiURL.AutoSize = true;
            this.lblSMG2HackWikiURL.Location = new System.Drawing.Point(10, 15);
            this.lblSMG2HackWikiURL.Name = "lblSMG2HackWikiURL";
            this.lblSMG2HackWikiURL.Size = new System.Drawing.Size(25, 12);
            this.lblSMG2HackWikiURL.TabIndex = 19;
            this.lblSMG2HackWikiURL.Text = "wiki";
            // 
            // llbSMG2HackWikiURL
            // 
            this.llbSMG2HackWikiURL.AutoSize = true;
            this.llbSMG2HackWikiURL.Location = new System.Drawing.Point(10, 27);
            this.llbSMG2HackWikiURL.Name = "llbSMG2HackWikiURL";
            this.llbSMG2HackWikiURL.Size = new System.Drawing.Size(290, 12);
            this.llbSMG2HackWikiURL.TabIndex = 18;
            this.llbSMG2HackWikiURL.TabStop = true;
            this.llbSMG2HackWikiURL.Text = "http://mariogalaxy2hack.wiki.fc2.com/wiki/MSBT_Editor";
            this.llbSMG2HackWikiURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbSMG2HackWikiURL_LinkClicked);
            // 
            // lblSMG2HackDiscordURL
            // 
            this.lblSMG2HackDiscordURL.AutoSize = true;
            this.lblSMG2HackDiscordURL.Location = new System.Drawing.Point(10, 49);
            this.lblSMG2HackDiscordURL.Name = "lblSMG2HackDiscordURL";
            this.lblSMG2HackDiscordURL.Size = new System.Drawing.Size(90, 12);
            this.lblSMG2HackDiscordURL.TabIndex = 17;
            this.lblSMG2HackDiscordURL.Text = "Discord招待URL";
            // 
            // llbSMG2HackDiscordURL
            // 
            this.llbSMG2HackDiscordURL.AutoSize = true;
            this.llbSMG2HackDiscordURL.Location = new System.Drawing.Point(10, 61);
            this.llbSMG2HackDiscordURL.Name = "llbSMG2HackDiscordURL";
            this.llbSMG2HackDiscordURL.Size = new System.Drawing.Size(150, 12);
            this.llbSMG2HackDiscordURL.TabIndex = 16;
            this.llbSMG2HackDiscordURL.TabStop = true;
            this.llbSMG2HackDiscordURL.Text = "https://discord.gg/B4EwY7h";
            this.llbSMG2HackDiscordURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbSMG2HackDiscordURL_LinkClicked);
            // 
            // lblGitHubIssuesURL
            // 
            this.lblGitHubIssuesURL.AutoSize = true;
            this.lblGitHubIssuesURL.Location = new System.Drawing.Point(16, 125);
            this.lblGitHubIssuesURL.Name = "lblGitHubIssuesURL";
            this.lblGitHubIssuesURL.Size = new System.Drawing.Size(83, 12);
            this.lblGitHubIssuesURL.TabIndex = 5;
            this.lblGitHubIssuesURL.Text = "バグ報告はこちら";
            // 
            // llbGitHubRepositoryURL
            // 
            this.llbGitHubRepositoryURL.AutoSize = true;
            this.llbGitHubRepositoryURL.Location = new System.Drawing.Point(16, 104);
            this.llbGitHubRepositoryURL.Name = "llbGitHubRepositoryURL";
            this.llbGitHubRepositoryURL.Size = new System.Drawing.Size(251, 12);
            this.llbGitHubRepositoryURL.TabIndex = 2;
            this.llbGitHubRepositoryURL.TabStop = true;
            this.llbGitHubRepositoryURL.Text = "https://github.com/penguin117117/MSBT_Editor";
            this.llbGitHubRepositoryURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbGitHubRepositoryURL_LinkClicked);
            // 
            // llbGitHubReleasesURL
            // 
            this.llbGitHubReleasesURL.AutoSize = true;
            this.llbGitHubReleasesURL.Location = new System.Drawing.Point(16, 74);
            this.llbGitHubReleasesURL.Name = "llbGitHubReleasesURL";
            this.llbGitHubReleasesURL.Size = new System.Drawing.Size(300, 12);
            this.llbGitHubReleasesURL.TabIndex = 0;
            this.llbGitHubReleasesURL.TabStop = true;
            this.llbGitHubReleasesURL.Text = "https://github.com/penguin117117/MSBT_Editor/releases";
            this.llbGitHubReleasesURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbGitHubReleasesURL_LinkClicked);
            // 
            // lblGitHubRepositoryURL
            // 
            this.lblGitHubRepositoryURL.AutoSize = true;
            this.lblGitHubRepositoryURL.Location = new System.Drawing.Point(16, 92);
            this.lblGitHubRepositoryURL.Name = "lblGitHubRepositoryURL";
            this.lblGitHubRepositoryURL.Size = new System.Drawing.Size(95, 12);
            this.lblGitHubRepositoryURL.TabIndex = 3;
            this.lblGitHubRepositoryURL.Text = "ソースコードはこちら";
            // 
            // llbGitHubIssuesURL
            // 
            this.llbGitHubIssuesURL.AutoSize = true;
            this.llbGitHubIssuesURL.Location = new System.Drawing.Point(16, 137);
            this.llbGitHubIssuesURL.Name = "llbGitHubIssuesURL";
            this.llbGitHubIssuesURL.Size = new System.Drawing.Size(290, 12);
            this.llbGitHubIssuesURL.TabIndex = 4;
            this.llbGitHubIssuesURL.TabStop = true;
            this.llbGitHubIssuesURL.Text = "https://github.com/penguin117117/MSBT_Editor/issues";
            this.llbGitHubIssuesURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbGitHubIssuesURL_LinkClicked);
            // 
            // lstListsInsideFEN1
            // 
            this.lstListsInsideFEN1.FormattingEnabled = true;
            this.lstListsInsideFEN1.ItemHeight = 12;
            this.lstListsInsideFEN1.Location = new System.Drawing.Point(216, 243);
            this.lstListsInsideFEN1.Name = "lstListsInsideFEN1";
            this.lstListsInsideFEN1.ScrollAlwaysVisible = true;
            this.lstListsInsideFEN1.Size = new System.Drawing.Size(204, 208);
            this.lstListsInsideFEN1.TabIndex = 0;
            this.lstListsInsideFEN1.SelectedIndexChanged += new System.EventHandler(this.LstListsInsideFEN1_SelectedIndexChanged);
            // 
            // lstListsInsideFLW2
            // 
            this.lstListsInsideFLW2.FormattingEnabled = true;
            this.lstListsInsideFLW2.ItemHeight = 12;
            this.lstListsInsideFLW2.Location = new System.Drawing.Point(218, 27);
            this.lstListsInsideFLW2.Name = "lstListsInsideFLW2";
            this.lstListsInsideFLW2.ScrollAlwaysVisible = true;
            this.lstListsInsideFLW2.Size = new System.Drawing.Size(204, 196);
            this.lstListsInsideFLW2.TabIndex = 0;
            this.lstListsInsideFLW2.SelectedIndexChanged += new System.EventHandler(this.LstListsInsideFLW2_SelectedIndexChanged);
            // 
            // lblMSBT
            // 
            this.lblMSBT.AutoSize = true;
            this.lblMSBT.Location = new System.Drawing.Point(6, 14);
            this.lblMSBT.Name = "lblMSBT";
            this.lblMSBT.Size = new System.Drawing.Size(36, 12);
            this.lblMSBT.TabIndex = 7;
            this.lblMSBT.Text = "MSBT";
            // 
            // lblFLW2
            // 
            this.lblFLW2.AutoSize = true;
            this.lblFLW2.Location = new System.Drawing.Point(218, 14);
            this.lblFLW2.Name = "lblFLW2";
            this.lblFLW2.Size = new System.Drawing.Size(33, 12);
            this.lblFLW2.TabIndex = 8;
            this.lblFLW2.Text = "FLW2";
            // 
            // lblFEN1
            // 
            this.lblFEN1.AutoSize = true;
            this.lblFEN1.Location = new System.Drawing.Point(218, 226);
            this.lblFEN1.Name = "lblFEN1";
            this.lblFEN1.Size = new System.Drawing.Size(33, 12);
            this.lblFEN1.TabIndex = 9;
            this.lblFEN1.Text = "FEN1";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "日本語",
            "EN"});
            this.cmbLanguage.Location = new System.Drawing.Point(899, 28);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(121, 20);
            this.cmbLanguage.TabIndex = 0;
            this.cmbLanguage.Text = "日本語";
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.CmbLanguage_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(844, 31);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(53, 12);
            this.lblLanguage.TabIndex = 10;
            this.lblLanguage.Text = "Language";
            // 
            // lblMSBTListSelectIndex
            // 
            this.lblMSBTListSelectIndex.AutoSize = true;
            this.lblMSBTListSelectIndex.Location = new System.Drawing.Point(187, 14);
            this.lblMSBTListSelectIndex.Name = "lblMSBTListSelectIndex";
            this.lblMSBTListSelectIndex.Size = new System.Drawing.Size(23, 12);
            this.lblMSBTListSelectIndex.TabIndex = 11;
            this.lblMSBTListSelectIndex.Text = "null";
            // 
            // lblFLW2ListSelectIndex
            // 
            this.lblFLW2ListSelectIndex.AutoSize = true;
            this.lblFLW2ListSelectIndex.Location = new System.Drawing.Point(399, 14);
            this.lblFLW2ListSelectIndex.Name = "lblFLW2ListSelectIndex";
            this.lblFLW2ListSelectIndex.Size = new System.Drawing.Size(23, 12);
            this.lblFLW2ListSelectIndex.TabIndex = 12;
            this.lblFLW2ListSelectIndex.Text = "null";
            // 
            // lblFEN1ListSelectIndex
            // 
            this.lblFEN1ListSelectIndex.AutoSize = true;
            this.lblFEN1ListSelectIndex.Location = new System.Drawing.Point(397, 226);
            this.lblFEN1ListSelectIndex.Name = "lblFEN1ListSelectIndex";
            this.lblFEN1ListSelectIndex.Size = new System.Drawing.Size(23, 12);
            this.lblFEN1ListSelectIndex.TabIndex = 13;
            this.lblFEN1ListSelectIndex.Text = "null";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tbpFilesInsideRARC);
            this.tabControl3.Controls.Add(this.tbpListsInsideMSB);
            this.tabControl3.Location = new System.Drawing.Point(12, 28);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(438, 483);
            this.tabControl3.TabIndex = 14;
            // 
            // tbpFilesInsideRARC
            // 
            this.tbpFilesInsideRARC.Controls.Add(this.chkMSBAutoSave);
            this.tbpFilesInsideRARC.Controls.Add(this.lblSaveSystemDiscription);
            this.tbpFilesInsideRARC.Controls.Add(this.lstFilesInsideRARC);
            this.tbpFilesInsideRARC.Location = new System.Drawing.Point(4, 22);
            this.tbpFilesInsideRARC.Name = "tbpFilesInsideRARC";
            this.tbpFilesInsideRARC.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFilesInsideRARC.Size = new System.Drawing.Size(430, 457);
            this.tbpFilesInsideRARC.TabIndex = 0;
            this.tbpFilesInsideRARC.Text = "ARCファイルの中身";
            this.tbpFilesInsideRARC.UseVisualStyleBackColor = true;
            // 
            // chkMSBAutoSave
            // 
            this.chkMSBAutoSave.AutoSize = true;
            this.chkMSBAutoSave.Location = new System.Drawing.Point(223, 268);
            this.chkMSBAutoSave.Name = "chkMSBAutoSave";
            this.chkMSBAutoSave.Size = new System.Drawing.Size(201, 16);
            this.chkMSBAutoSave.TabIndex = 2;
            this.chkMSBAutoSave.Text = "(Msbt Msbf) オートセーブ/AutoSave";
            this.chkMSBAutoSave.UseVisualStyleBackColor = true;
            this.chkMSBAutoSave.CheckedChanged += new System.EventHandler(this.ChkMSBAutoSave_CheckedChanged);
            // 
            // lblSaveSystemDiscription
            // 
            this.lblSaveSystemDiscription.AutoSize = true;
            this.lblSaveSystemDiscription.Location = new System.Drawing.Point(6, 287);
            this.lblSaveSystemDiscription.Name = "lblSaveSystemDiscription";
            this.lblSaveSystemDiscription.Size = new System.Drawing.Size(297, 60);
            this.lblSaveSystemDiscription.TabIndex = 1;
            this.lblSaveSystemDiscription.Text = "ARCファイルから開いた\r\nMsbtやMsbfの内容を変更した際は上書き保存をしてください。\r\n上書き保存してからリストを選択し直さないと、\r\n変更が保存されませ" +
    "ん。\r\n全ての変更が終わったらARCを保存してください。";
            // 
            // lstFilesInsideRARC
            // 
            this.lstFilesInsideRARC.FormattingEnabled = true;
            this.lstFilesInsideRARC.ItemHeight = 12;
            this.lstFilesInsideRARC.Location = new System.Drawing.Point(6, 6);
            this.lstFilesInsideRARC.Name = "lstFilesInsideRARC";
            this.lstFilesInsideRARC.Size = new System.Drawing.Size(418, 256);
            this.lstFilesInsideRARC.TabIndex = 0;
            this.lstFilesInsideRARC.SelectedIndexChanged += new System.EventHandler(this.LstFilesInsideRARC_SelectedIndexChanged);
            this.lstFilesInsideRARC.SelectedValueChanged += new System.EventHandler(this.LstFilesInsideRARC_SelectedValueChanged);
            this.lstFilesInsideRARC.CursorChanged += new System.EventHandler(this.LstFilesInsideRARC_CursorChanged);
            this.lstFilesInsideRARC.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.LstFilesInsideRARC_ChangeUICues);
            this.lstFilesInsideRARC.Validating += new System.ComponentModel.CancelEventHandler(this.LstFilesInsideRARC_Validating);
            // 
            // tbpListsInsideMSB
            // 
            this.tbpListsInsideMSB.Controls.Add(this.lblMSBT);
            this.tbpListsInsideMSB.Controls.Add(this.lblFEN1ListSelectIndex);
            this.tbpListsInsideMSB.Controls.Add(this.lblFLW2ListSelectIndex);
            this.tbpListsInsideMSB.Controls.Add(this.lstListsInsideMSBT);
            this.tbpListsInsideMSB.Controls.Add(this.lblFEN1);
            this.tbpListsInsideMSB.Controls.Add(this.lstListsInsideFLW2);
            this.tbpListsInsideMSB.Controls.Add(this.lblMSBTListSelectIndex);
            this.tbpListsInsideMSB.Controls.Add(this.lstListsInsideFEN1);
            this.tbpListsInsideMSB.Controls.Add(this.lblFLW2);
            this.tbpListsInsideMSB.Location = new System.Drawing.Point(4, 22);
            this.tbpListsInsideMSB.Name = "tbpListsInsideMSB";
            this.tbpListsInsideMSB.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListsInsideMSB.Size = new System.Drawing.Size(430, 457);
            this.tbpListsInsideMSB.TabIndex = 1;
            this.tbpListsInsideMSB.Text = "MSBTとMSBF";
            this.tbpListsInsideMSB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 543);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.stbStatusBar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MSBT_Editor_SMG2 By ぺんぐいん";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.stbStatusBar.ResumeLayout(false);
            this.stbStatusBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpMSBTSettings.ResumeLayout(false);
            this.gbxMSBTSettingsATR1.ResumeLayout(false);
            this.gbxMSBTSettingsATR1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.gbxTimerTag.ResumeLayout(false);
            this.gbxTimerTag.PerformLayout();
            this.gbxRubiTag.ResumeLayout(false);
            this.gbxRubiTag.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.gbxSpecialTag.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.AdvancedTagsTabPage.ResumeLayout(false);
            this.gbxSoundEffectTag.ResumeLayout(false);
            this.gbxSoundEffectTag.PerformLayout();
            this.gbxCustomIconTag.ResumeLayout(false);
            this.gbxCustomIconTag.PerformLayout();
            this.tbpListEdit.ResumeLayout(false);
            this.gbxListEditFEN1.ResumeLayout(false);
            this.gbxListEditFEN1.PerformLayout();
            this.gbxListEditFLW2.ResumeLayout(false);
            this.gbxListEditFLW2.PerformLayout();
            this.gbxListEditMSBT.ResumeLayout(false);
            this.gbxListEditMSBT.PerformLayout();
            this.tbpMSBFSetting.ResumeLayout(false);
            this.tbpMSBFSetting.PerformLayout();
            this.gbxFEN1.ResumeLayout(false);
            this.gbxFEN1.PerformLayout();
            this.gbxFLW2.ResumeLayout(false);
            this.gbxFLW2.PerformLayout();
            this.gbxFLW2Branch.ResumeLayout(false);
            this.gbxFLW2Branch.PerformLayout();
            this.tbpDebugMSBF.ResumeLayout(false);
            this.tbpDebugMSBF.PerformLayout();
            this.tbpDebug.ResumeLayout(false);
            this.tbpDebug.PerformLayout();
            this.tbpCredit.ResumeLayout(false);
            this.tbpCredit.PerformLayout();
            this.gbxCreditLBL1.ResumeLayout(false);
            this.gbxCreditLBL1.PerformLayout();
            this.gbxCreditProgrammer.ResumeLayout(false);
            this.gbxCreditProgrammer.PerformLayout();
            this.gbxCreditContributor.ResumeLayout(false);
            this.gbxCreditContributor.PerformLayout();
            this.gbxCreditDebugger.ResumeLayout(false);
            this.gbxCreditDebugger.PerformLayout();
            this.gbxCreditDebuggerVIP.ResumeLayout(false);
            this.gbxCreditDebuggerVIP.PerformLayout();
            this.gbxCreditSectionEntrySize.ResumeLayout(false);
            this.gbxCreditSectionEntrySize.PerformLayout();
            this.tbpInfomation.ResumeLayout(false);
            this.tbpInfomation.PerformLayout();
            this.gbxCurrentVersion.ResumeLayout(false);
            this.gbxCurrentVersion.PerformLayout();
            this.gbxHowToUse.ResumeLayout(false);
            this.gbxHowToUse.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tbpFilesInsideRARC.ResumeLayout(false);
            this.tbpFilesInsideRARC.PerformLayout();
            this.tbpListsInsideMSB.ResumeLayout(false);
            this.tbpListsInsideMSB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stbStatusBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.TextBox txtMSBTText;
        public System.Windows.Forms.ListBox lstListsInsideMSBT;
        public System.Windows.Forms.ToolStripStatusLabel stbOpenedMSBTName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel stbOpenedMSBFName;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtATR1SpecialTextOffset;
        private System.Windows.Forms.TextBox txtATR1Unknown6;
        private System.Windows.Forms.TextBox txtATR1MessageAreaID;
        private System.Windows.Forms.TextBox txtATR1EventCameraID;
        private System.Windows.Forms.TextBox txtATR1WindowID;
        private System.Windows.Forms.TextBox txtATR1DialogID;
        private System.Windows.Forms.TextBox txtATR1SimpleCamID;
        private System.Windows.Forms.TextBox txtATR1SoundID;
        private System.Windows.Forms.TextBox txtLBL1TagIndex;
        public System.Windows.Forms.TextBox textBox13;
        public System.Windows.Forms.TextBox txtATR1SpecialText;
        public System.Windows.Forms.TextBox MSBT_Debug_Text;
        private System.Windows.Forms.TabPage tbpDebugMSBF;
        private System.Windows.Forms.TextBox txtMSBTListName;
        private System.Windows.Forms.GroupBox gbxCreditLBL1;
        private System.Windows.Forms.Label lblLBL1EntrySize;
        public System.Windows.Forms.TextBox txtLBL1EntrySize;
        private System.Windows.Forms.Label lblATR1EntrySize;
        public System.Windows.Forms.TextBox txtATR1EntrySize;
        private System.Windows.Forms.Button btnReleaseDebugTextFile;
        private System.Windows.Forms.TextBox txtFLW2BranchFalse;
        private System.Windows.Forms.TextBox txtFLW2BranchTrue;
        private System.Windows.Forms.GroupBox gbxFLW2;
        public System.Windows.Forms.TextBox txtFLW2Arg4;
        public System.Windows.Forms.TextBox txtFLW2Arg3;
        public System.Windows.Forms.TextBox txtFLW2Arg2;
        public System.Windows.Forms.TextBox txtFLW2Arg1;
        public System.Windows.Forms.TextBox txtFLW2Padding;
        public System.Windows.Forms.TextBox txtFLW2FlowType;
        public System.Windows.Forms.ListBox lstListsInsideFLW2;
        private System.Windows.Forms.TabPage tbpDebug;
        public System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.GroupBox gbxFEN1;
        public System.Windows.Forms.ListBox lstListsInsideFEN1;
        private System.Windows.Forms.TextBox txtFEN1StartIndex;
        private System.Windows.Forms.TextBox txtFEN1Arg0;
        private System.Windows.Forms.GroupBox gbxListEditMSBT;
        public System.Windows.Forms.Label lblFLW2Arg4;
        public System.Windows.Forms.Label lblFLW2Arg3;
        public System.Windows.Forms.Label lblFLW2Arg2;
        public System.Windows.Forms.Label lblFLW2Arg1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox gbxListEditFEN1;
        private System.Windows.Forms.TextBox txtFEN1ListName;
        private System.Windows.Forms.GroupBox gbxListEditFLW2;
        private System.Windows.Forms.TextBox txtSelectedMSBTListName;
        private System.Windows.Forms.Label lblMSBT;
        private System.Windows.Forms.Label lblFLW2;
        private System.Windows.Forms.Label lblFEN1;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblLanguage;
        public System.Windows.Forms.ToolStripStatusLabel stbStatusLabel;
        public System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Msbt上書き保存ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Msbt保存ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mSBF開くToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Msbf上書き保存ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Msbf保存ToolStripMenuItem;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tbpMSBTSettings;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tbpListEdit;
        public System.Windows.Forms.TabPage tbpMSBFSetting;
        public System.Windows.Forms.Label lblATR1SpecialTextOffset;
        public System.Windows.Forms.Label lblATR1Unknown6;
        public System.Windows.Forms.Label lblATR1MessageAreaID;
        public System.Windows.Forms.Label lblATR1EventCameraID;
        public System.Windows.Forms.Label lblATR1WindowID;
        public System.Windows.Forms.Label lblATR1DialogID;
        public System.Windows.Forms.Label lblATR1SimpleCamID;
        public System.Windows.Forms.Label lblATR1SoundID;
        public System.Windows.Forms.Label lblATR1SpecialText;
        public System.Windows.Forms.Label lblLBL1TagIndex;
        public System.Windows.Forms.Label lblCreditLBL1Note;
        public System.Windows.Forms.Label lblFLW2BranchFalse;
        public System.Windows.Forms.Label lblFLW2BranchTrue;
        public System.Windows.Forms.Label lblFLW2Padding;
        public System.Windows.Forms.Label lblFLW2FlowType;
        public System.Windows.Forms.Label lblFLW2StartIndex;
        public System.Windows.Forms.Label lblFEN1Arg0;
        public System.Windows.Forms.GroupBox gbxFLW2Branch;
        private System.Windows.Forms.Label label41;
        public System.Windows.Forms.Label lblCreditSectionEntrySizegbxCreditSectionEntrySizeNote;
        public System.Windows.Forms.Button btnAddMSBTList;
        public System.Windows.Forms.Button btnDeleteMSBTList;
        public System.Windows.Forms.Label lblMSBTListEditNote;
        public System.Windows.Forms.Label lblMSBTListEditDiscription;
        public System.Windows.Forms.Label lblMSBTListName;
        public System.Windows.Forms.Button btnDeleteFEN1List;
        public System.Windows.Forms.Button btnAddFEN1List;
        public System.Windows.Forms.Label lblFEN1ListName;
        public System.Windows.Forms.Button btnDeleteFLW2List;
        public System.Windows.Forms.Button btnAddFLW2List;
        public System.Windows.Forms.Label lblFLW2ListEditDiscription;
        public System.Windows.Forms.TabControl tabControl2;
        public System.Windows.Forms.TabPage tabPage6;
        public System.Windows.Forms.TabPage tabPage7;
        public System.Windows.Forms.TabPage tabPage8;
        public System.Windows.Forms.TabPage tabPage9;
        public System.Windows.Forms.ComboBox cmbColorTag;
        public System.Windows.Forms.ComboBox cmbLineControlTag;
        public System.Windows.Forms.ComboBox cmbFontSizeTag;
        public System.Windows.Forms.ComboBox cmbCenterTag;
        public System.Windows.Forms.Button btnInsertColorTag;
        public System.Windows.Forms.Button btnInsertLineControlTag;
        public System.Windows.Forms.Button btnInsertFontSizeTag;
        public System.Windows.Forms.Button btnInsertCenterTag;
        private System.Windows.Forms.Label lblMSBTListSelectIndex;
        private System.Windows.Forms.Label lblFLW2ListSelectIndex;
        private System.Windows.Forms.Label lblFEN1ListSelectIndex;
        public System.Windows.Forms.GroupBox gbxCreditSectionEntrySize;
        public System.Windows.Forms.Label lblMSBFSettingNote;
        public System.Windows.Forms.TreeView tvwMSBFFlow;
        public System.Windows.Forms.TextBox UnknownTag;
        private System.Windows.Forms.Button btnCalculateHash;
        private System.Windows.Forms.TextBox txtListNameToCalculateHash;
        private System.Windows.Forms.Label lblMSBFFlow;
        public System.Windows.Forms.ComboBox cmbCharacterIconTag;
        public System.Windows.Forms.ComboBox cmbObjectIconTag;
        public System.Windows.Forms.ComboBox cmbOthersIconTag;
        public System.Windows.Forms.GroupBox gbxRubiTag;
        public System.Windows.Forms.Button btnInsertRubiTag;
        public System.Windows.Forms.Label lblRubiTagKanjiCount;
        public System.Windows.Forms.Label lblRubiTagRubiCount;
        public System.Windows.Forms.TextBox txtRubiTagRubiCount;
        public System.Windows.Forms.TextBox txtRubiTagKanjiCount;
        public System.Windows.Forms.GroupBox gbxTimerTag;
        public System.Windows.Forms.Button btnInsertTimerTag;
        public System.Windows.Forms.Label lblTimerTagDelayTime;
        public System.Windows.Forms.TextBox txtTimerTagDelayTime;
        public System.Windows.Forms.Button btnInsertPlayerCharacterTag;
        public System.Windows.Forms.Button btnInsertVariableInt3DigitsTag;
        public System.Windows.Forms.Button btnInsertResultGalaxyNameTag;
        public System.Windows.Forms.Button btnInsertResultScenarioNameTag;
        public System.Windows.Forms.GroupBox gbxSpecialTag;
        public System.Windows.Forms.Button btnInsertSecondTag;
        public System.Windows.Forms.Button btnInsertMinuteTag;
        public System.Windows.Forms.Button btnInsertHourTag;
        public System.Windows.Forms.Button btnInsertVariableInt5DigitsTag;
        public System.Windows.Forms.Button btnInsertVariableInt4DigitsTag;
        public System.Windows.Forms.Button btnInsertNumbersBelowDecimalPoint;
        public System.Windows.Forms.Button btnInsertCharacterIconTag;
        public System.Windows.Forms.Label lblCharacterIconTag;
        public System.Windows.Forms.Button btnInsertObjectIconTag;
        public System.Windows.Forms.Label lblObjectIconTag;
        public System.Windows.Forms.Button btnInsertOthersIconTag;
        public System.Windows.Forms.Label lblOthersIconTag;
        public System.Windows.Forms.Button btnInsertTotalPlayTimeTag;
        public System.Windows.Forms.Button btnInsertUserNameTag;
        public System.Windows.Forms.Button btnInsertScoreTag;
        public System.Windows.Forms.Button btnInsertWorldNoTag;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.TabPage tbpCredit;
        private System.Windows.Forms.GroupBox gbxCreditProgrammer;
        private System.Windows.Forms.Label lblCreditPenguin;
        private System.Windows.Forms.GroupBox gbxCreditDebugger;
        private System.Windows.Forms.Label lblCreditPorto;
        private System.Windows.Forms.Label lblCreditEvanbowl;
        private System.Windows.Forms.Label lblCreditHiiraghi;
        private System.Windows.Forms.Label lblCreditEigen;
        private System.Windows.Forms.Label lblCreditDossun;
        private System.Windows.Forms.Label lblCreditXenon;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripStatusLabel stbSavedFilePathLabel;
        public System.Windows.Forms.ToolStripStatusLabel stbSavedFilePath;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox txtReadOnlyMSBTText;
        private System.Windows.Forms.Button btnReloadTvwMSBFFlow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.CheckBox chkShowTvwMSBFFlow;
        private System.Windows.Forms.Label lblMSBFHashCalculator;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TabPage tbpListsInsideMSB;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        public System.Windows.Forms.ToolStripStatusLabel stbOpenedRARCName;
        private System.Windows.Forms.TextBox txtCustomIconHex;
        private System.Windows.Forms.TextBox txtSoundEffectName;
        public System.Windows.Forms.ListBox lstFilesInsideRARC;
        public System.Windows.Forms.Label lblSaveSystemDiscription;
        public System.Windows.Forms.GroupBox gbxMSBTSettingsATR1;
        public System.Windows.Forms.TabPage AdvancedTagsTabPage;
        private System.Windows.Forms.GroupBox gbxCreditDebuggerVIP;
        private System.Windows.Forms.GroupBox gbxCreditContributor;
        private System.Windows.Forms.GroupBox gbxHowToUse;
        private System.Windows.Forms.Label lblSMG2HackWikiURL;
        private System.Windows.Forms.LinkLabel llbSMG2HackWikiURL;
        private System.Windows.Forms.Label lblSMG2HackDiscordURL;
        private System.Windows.Forms.LinkLabel llbSMG2HackDiscordURL;
        private System.Windows.Forms.Label lblGitHubIssuesURL;
        private System.Windows.Forms.LinkLabel llbGitHubIssuesURL;
        private System.Windows.Forms.Label lblGitHubRepositoryURL;
        private System.Windows.Forms.LinkLabel llbGitHubRepositoryURL;
        private System.Windows.Forms.Label lblGitHubReleasesURL;
        private System.Windows.Forms.LinkLabel llbGitHubReleasesURL;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.GroupBox gbxCurrentVersion;
        public System.Windows.Forms.ToolStripMenuItem ARC開くToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ARC上書き保存ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ARC保存ToolStripMenuItem;
        public System.Windows.Forms.TabControl tabControl3;
        public System.Windows.Forms.TabPage tbpFilesInsideRARC;
        public System.Windows.Forms.Button btnInsertCustomIconTag;
        public System.Windows.Forms.GroupBox gbxCustomIconTag;
        public System.Windows.Forms.Label lblCustomIconHex;
        public System.Windows.Forms.Label lblCustomIconTagDiscription1;
        public System.Windows.Forms.Button btnInsertSoundEffectTag;
        public System.Windows.Forms.GroupBox gbxSoundEffectTag;
        public System.Windows.Forms.Label lblSoundEffectTagDiscription1;
        public System.Windows.Forms.Label lblSoundEffectTagDiscription2;
        public System.Windows.Forms.TabPage tbpInfomation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRubiTagDiscription;
        private System.Windows.Forms.CheckBox chkMSBAutoSave;
        private System.Windows.Forms.TextBox textBox1;
    }
}

