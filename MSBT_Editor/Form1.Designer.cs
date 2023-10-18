
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
            this.stbOpenedMsbtName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbOpenedMsbfName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbOpenedRarcName = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.Msbf開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Msbf上書き保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Msbf保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Arc開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Arc上書き保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Arc保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstListsInsideMsbt = new System.Windows.Forms.ListBox();
            this.txtMsbtText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpMsbtSetting = new System.Windows.Forms.TabPage();
            this.gbxMsbtSettingAtr1 = new System.Windows.Forms.GroupBox();
            this.lblAtr1SpecialText = new System.Windows.Forms.Label();
            this.txtAtr1SpecialText = new System.Windows.Forms.TextBox();
            this.lblAtr1Unknown6 = new System.Windows.Forms.Label();
            this.lblAtr1MessageAreaID = new System.Windows.Forms.Label();
            this.lblAtr1EventCameraID = new System.Windows.Forms.Label();
            this.lblAtr1WindowID = new System.Windows.Forms.Label();
            this.lblAtr1DialogID = new System.Windows.Forms.Label();
            this.lblAtr1SimpleCamID = new System.Windows.Forms.Label();
            this.lblAtr1SoundID = new System.Windows.Forms.Label();
            this.txtAtr1Unknown6 = new System.Windows.Forms.TextBox();
            this.txtAtr1MessageAreaID = new System.Windows.Forms.TextBox();
            this.txtAtr1EventCameraID = new System.Windows.Forms.TextBox();
            this.txtAtr1WindowID = new System.Windows.Forms.TextBox();
            this.txtAtr1DialogID = new System.Windows.Forms.TextBox();
            this.txtAtr1SimpleCamID = new System.Windows.Forms.TextBox();
            this.txtAtr1SoundID = new System.Windows.Forms.TextBox();
            this.tbpMsbtTextEdit = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tbpGeneralTag = new System.Windows.Forms.TabPage();
            this.btnInsertColorTag = new System.Windows.Forms.Button();
            this.btnInsertPlayerCharacterTag = new System.Windows.Forms.Button();
            this.cmbCenterTag = new System.Windows.Forms.ComboBox();
            this.btnInsertCenterTag = new System.Windows.Forms.Button();
            this.cmbColorTag = new System.Windows.Forms.ComboBox();
            this.btnInsertLineControlTag = new System.Windows.Forms.Button();
            this.cmbFontSizeTag = new System.Windows.Forms.ComboBox();
            this.btnInsertFontSizeTag = new System.Windows.Forms.Button();
            this.cmbLineControlTag = new System.Windows.Forms.ComboBox();
            this.tbpValueTag = new System.Windows.Forms.TabPage();
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
            this.tbpSpecialTag = new System.Windows.Forms.TabPage();
            this.gbxSpecialTag = new System.Windows.Forms.GroupBox();
            this.btnInsertTotalPlayTimeTag = new System.Windows.Forms.Button();
            this.btnInsertUserNameTag = new System.Windows.Forms.Button();
            this.btnInsertScoreTag = new System.Windows.Forms.Button();
            this.btnInsertWorldNoTag = new System.Windows.Forms.Button();
            this.btnInsertNumbersBelowDecimalPointTag = new System.Windows.Forms.Button();
            this.btnInsertSecondTag = new System.Windows.Forms.Button();
            this.btnInsertMinuteTag = new System.Windows.Forms.Button();
            this.btnInsertHourTag = new System.Windows.Forms.Button();
            this.btnInsertVariableInt5DigitsTag = new System.Windows.Forms.Button();
            this.btnInsertVariableInt4DigitsTag = new System.Windows.Forms.Button();
            this.btnInsertVariableInt3DigitsTag = new System.Windows.Forms.Button();
            this.btnInsertResultScenarioNameTag = new System.Windows.Forms.Button();
            this.btnInsertResultGalaxyNameTag = new System.Windows.Forms.Button();
            this.tbpIconTag = new System.Windows.Forms.TabPage();
            this.btnInsertOtherIconTag = new System.Windows.Forms.Button();
            this.cmbOtherIconTag = new System.Windows.Forms.ComboBox();
            this.lblOtherIconTag = new System.Windows.Forms.Label();
            this.lblObjectIconTag = new System.Windows.Forms.Label();
            this.btnInsertObjectIconTag = new System.Windows.Forms.Button();
            this.cmbObjectIconTag = new System.Windows.Forms.ComboBox();
            this.lblCharacterIconTag = new System.Windows.Forms.Label();
            this.btnInsertCharacterIconTag = new System.Windows.Forms.Button();
            this.cmbCharacterIconTag = new System.Windows.Forms.ComboBox();
            this.AdvancedTagTabPage = new System.Windows.Forms.TabPage();
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
            this.gbxListEditFen1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteFen1List = new System.Windows.Forms.Button();
            this.btnAddFen1List = new System.Windows.Forms.Button();
            this.txtFen1ListName = new System.Windows.Forms.TextBox();
            this.lblFen1ListName = new System.Windows.Forms.Label();
            this.gbxListEditFlw2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteFlw2List = new System.Windows.Forms.Button();
            this.btnAddFlw2List = new System.Windows.Forms.Button();
            this.lblFlw2ListEditDiscription = new System.Windows.Forms.Label();
            this.gbxListEditMsbt = new System.Windows.Forms.GroupBox();
            this.lblMsbtListEditDiscription = new System.Windows.Forms.Label();
            this.lblMsbtListName = new System.Windows.Forms.Label();
            this.txtSelectedMsbtListName = new System.Windows.Forms.TextBox();
            this.lblMsbtListEditNote = new System.Windows.Forms.Label();
            this.btnDeleteMsbtList = new System.Windows.Forms.Button();
            this.txtMsbtListName = new System.Windows.Forms.TextBox();
            this.btnAddMsbtList = new System.Windows.Forms.Button();
            this.tbpMsbfSetting = new System.Windows.Forms.TabPage();
            this.chkShowTvwMsbfFlow = new System.Windows.Forms.CheckBox();
            this.btnReloadTvwMsbfFlow = new System.Windows.Forms.Button();
            this.txtReadOnlyMsbtText = new System.Windows.Forms.TextBox();
            this.lblMsbfFlow = new System.Windows.Forms.Label();
            this.tvwMsbfFlow = new System.Windows.Forms.TreeView();
            this.lblMsbfSettingNote = new System.Windows.Forms.Label();
            this.gbxFen1 = new System.Windows.Forms.GroupBox();
            this.lblFlw2StartIndex = new System.Windows.Forms.Label();
            this.lblFen1Arg0 = new System.Windows.Forms.Label();
            this.txtFen1StartIndex = new System.Windows.Forms.TextBox();
            this.txtFen1Arg0 = new System.Windows.Forms.TextBox();
            this.gbxFlw2 = new System.Windows.Forms.GroupBox();
            this.lblFlw2RightAngleSymbol = new System.Windows.Forms.Label();
            this.gbxFlw2Branch = new System.Windows.Forms.GroupBox();
            this.txtFlw2BranchFalse = new System.Windows.Forms.TextBox();
            this.txtFlw2BranchTrue = new System.Windows.Forms.TextBox();
            this.lblFlw2BranchFalse = new System.Windows.Forms.Label();
            this.lblFlw2BranchTrue = new System.Windows.Forms.Label();
            this.lblFlw2Arg4 = new System.Windows.Forms.Label();
            this.lblFlw2Arg3 = new System.Windows.Forms.Label();
            this.lblFlw2Arg2 = new System.Windows.Forms.Label();
            this.lblFlw2Arg1 = new System.Windows.Forms.Label();
            this.txtFlw2Arg4 = new System.Windows.Forms.TextBox();
            this.txtFlw2Arg3 = new System.Windows.Forms.TextBox();
            this.txtFlw2Arg2 = new System.Windows.Forms.TextBox();
            this.txtFlw2Arg1 = new System.Windows.Forms.TextBox();
            this.txtFlw2Padding = new System.Windows.Forms.TextBox();
            this.lblFlw2Padding = new System.Windows.Forms.Label();
            this.txtFlw2FlowType = new System.Windows.Forms.TextBox();
            this.lblFlw2FlowType = new System.Windows.Forms.Label();
            this.tbpDebugMsbf = new System.Windows.Forms.TabPage();
            this.lblMsbfHashCalculator = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.button30 = new System.Windows.Forms.Button();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.btnCalculateHash = new System.Windows.Forms.Button();
            this.txtListNameToCalculateHash = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtFlw2DebugHex = new System.Windows.Forms.TextBox();
            this.tbpDebug = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTextSort = new System.Windows.Forms.Button();
            this.txtUnknownTag = new System.Windows.Forms.TextBox();
            this.MSBT_Debug_Text = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.btnReleaseDebugTextFile = new System.Windows.Forms.Button();
            this.tbpCredit = new System.Windows.Forms.TabPage();
            this.gbxCreditLbl1 = new System.Windows.Forms.GroupBox();
            this.lblCreditLbl1Note = new System.Windows.Forms.Label();
            this.lblLbl1TagIndex = new System.Windows.Forms.Label();
            this.txtLbl1TagIndex = new System.Windows.Forms.TextBox();
            this.txtAtr1SpecialTextOffset = new System.Windows.Forms.TextBox();
            this.gbxCreditProgrammer = new System.Windows.Forms.GroupBox();
            this.lblCreditContributorAcknowledgment = new System.Windows.Forms.Label();
            this.gbxCreditContributor = new System.Windows.Forms.GroupBox();
            this.lblCreditEvanbowl = new System.Windows.Forms.Label();
            this.lblCreditPenguin = new System.Windows.Forms.Label();
            this.lblAtr1SpecialTextOffset = new System.Windows.Forms.Label();
            this.gbxCreditDebugger = new System.Windows.Forms.GroupBox();
            this.lblDebuggerAcknowledgment = new System.Windows.Forms.Label();
            this.gbxCreditDebuggerVIP = new System.Windows.Forms.GroupBox();
            this.lblCreditXenon = new System.Windows.Forms.Label();
            this.lblCreditDossun = new System.Windows.Forms.Label();
            this.lblCreditPorto = new System.Windows.Forms.Label();
            this.lblCreditHiiragi = new System.Windows.Forms.Label();
            this.lblCreditEigen = new System.Windows.Forms.Label();
            this.gbxCreditSectionEntrySize = new System.Windows.Forms.GroupBox();
            this.txtAtr1EntrySize = new System.Windows.Forms.TextBox();
            this.lblAtr1EntrySize = new System.Windows.Forms.Label();
            this.lblCreditSectionEntrySize = new System.Windows.Forms.Label();
            this.txtLbl1EntrySize = new System.Windows.Forms.TextBox();
            this.lblLbl1EntrySize = new System.Windows.Forms.Label();
            this.tbpInfomation = new System.Windows.Forms.TabPage();
            this.gbxCurrentVersion = new System.Windows.Forms.GroupBox();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.lblGitHubReleasesUrl = new System.Windows.Forms.Label();
            this.gbxHowToUse = new System.Windows.Forms.GroupBox();
            this.lblSMG2HackWikiUrl = new System.Windows.Forms.Label();
            this.llbSMG2HackWikiUrl = new System.Windows.Forms.LinkLabel();
            this.lblSMG2HackDiscordUrl = new System.Windows.Forms.Label();
            this.llbSMG2HackDiscordUrl = new System.Windows.Forms.LinkLabel();
            this.lblGitHubIssuesUrl = new System.Windows.Forms.Label();
            this.llbGitHubRepositoryUrl = new System.Windows.Forms.LinkLabel();
            this.llbGitHubReleasesUrl = new System.Windows.Forms.LinkLabel();
            this.lblGitHubRepositoryUrl = new System.Windows.Forms.Label();
            this.llbGitHubIssuesUrl = new System.Windows.Forms.LinkLabel();
            this.lstListsInsideFen1 = new System.Windows.Forms.ListBox();
            this.lstListsInsideFlw2 = new System.Windows.Forms.ListBox();
            this.lblMsbt = new System.Windows.Forms.Label();
            this.lblFlw2 = new System.Windows.Forms.Label();
            this.lblFen1 = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblMsbtListSelectIndex = new System.Windows.Forms.Label();
            this.lblFlw2ListSelectIndex = new System.Windows.Forms.Label();
            this.lblFen1ListSelectIndex = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tbpFilesInsideRarc = new System.Windows.Forms.TabPage();
            this.chkMsbAutoSave = new System.Windows.Forms.CheckBox();
            this.lblSaveSystemDiscription = new System.Windows.Forms.Label();
            this.lstFilesInsideRarc = new System.Windows.Forms.ListBox();
            this.tbpListsInsideMsb = new System.Windows.Forms.TabPage();
            this.stbStatusBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpMsbtSetting.SuspendLayout();
            this.gbxMsbtSettingAtr1.SuspendLayout();
            this.tbpMsbtTextEdit.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tbpGeneralTag.SuspendLayout();
            this.tbpValueTag.SuspendLayout();
            this.gbxTimerTag.SuspendLayout();
            this.gbxRubiTag.SuspendLayout();
            this.tbpSpecialTag.SuspendLayout();
            this.gbxSpecialTag.SuspendLayout();
            this.tbpIconTag.SuspendLayout();
            this.AdvancedTagTabPage.SuspendLayout();
            this.gbxSoundEffectTag.SuspendLayout();
            this.gbxCustomIconTag.SuspendLayout();
            this.tbpListEdit.SuspendLayout();
            this.gbxListEditFen1.SuspendLayout();
            this.gbxListEditFlw2.SuspendLayout();
            this.gbxListEditMsbt.SuspendLayout();
            this.tbpMsbfSetting.SuspendLayout();
            this.gbxFen1.SuspendLayout();
            this.gbxFlw2.SuspendLayout();
            this.gbxFlw2Branch.SuspendLayout();
            this.tbpDebugMsbf.SuspendLayout();
            this.tbpDebug.SuspendLayout();
            this.tbpCredit.SuspendLayout();
            this.gbxCreditLbl1.SuspendLayout();
            this.gbxCreditProgrammer.SuspendLayout();
            this.gbxCreditContributor.SuspendLayout();
            this.gbxCreditDebugger.SuspendLayout();
            this.gbxCreditDebuggerVIP.SuspendLayout();
            this.gbxCreditSectionEntrySize.SuspendLayout();
            this.tbpInfomation.SuspendLayout();
            this.gbxCurrentVersion.SuspendLayout();
            this.gbxHowToUse.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tbpFilesInsideRarc.SuspendLayout();
            this.tbpListsInsideMsb.SuspendLayout();
            this.SuspendLayout();
            // 
            // stbStatusBar
            // 
            this.stbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbStatusLabel,
            this.stbOpenedMsbtName,
            this.toolStripStatusLabel3,
            this.stbOpenedMsbfName,
            this.toolStripStatusLabel5,
            this.stbOpenedRarcName,
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
            // stbOpenedMsbtName
            // 
            this.stbOpenedMsbtName.Name = "stbOpenedMsbtName";
            this.stbOpenedMsbtName.Size = new System.Drawing.Size(105, 17);
            this.stbOpenedMsbtName.Text = "<MSBTファイルなし>";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel3.Text = "｜";
            // 
            // stbOpenedMsbfName
            // 
            this.stbOpenedMsbfName.Name = "stbOpenedMsbfName";
            this.stbOpenedMsbfName.Size = new System.Drawing.Size(105, 17);
            this.stbOpenedMsbfName.Text = "<MSBFファイルなし>";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel5.Text = "｜";
            // 
            // stbOpenedRarcName
            // 
            this.stbOpenedRarcName.Name = "stbOpenedRarcName";
            this.stbOpenedRarcName.Size = new System.Drawing.Size(97, 17);
            this.stbOpenedRarcName.Text = "<ARCファイルなし>";
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
            this.Msbf開くToolStripMenuItem,
            this.Msbf上書き保存ToolStripMenuItem,
            this.Msbf保存ToolStripMenuItem,
            this.toolStripSeparator2,
            this.Arc開くToolStripMenuItem,
            this.Arc上書き保存ToolStripMenuItem,
            this.Arc保存ToolStripMenuItem});
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
            // Msbf開くToolStripMenuItem
            // 
            this.Msbf開くToolStripMenuItem.Name = "Msbf開くToolStripMenuItem";
            this.Msbf開くToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.Msbf開くToolStripMenuItem.Text = "MSBF開く";
            this.Msbf開くToolStripMenuItem.Visible = false;
            this.Msbf開くToolStripMenuItem.Click += new System.EventHandler(this.Msbf開くToolStripMenuItem_Click);
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
            this.Arc開くToolStripMenuItem.Name = "ARC開くToolStripMenuItem";
            this.Arc開くToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.Arc開くToolStripMenuItem.Text = "ARC開く";
            this.Arc開くToolStripMenuItem.Visible = false;
            this.Arc開くToolStripMenuItem.Click += new System.EventHandler(this.Arc開くToolStripMenuItem_Click);
            // 
            // ARC上書き保存ToolStripMenuItem
            // 
            this.Arc上書き保存ToolStripMenuItem.Name = "ARC上書き保存ToolStripMenuItem";
            this.Arc上書き保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Arc上書き保存ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.Arc上書き保存ToolStripMenuItem.Text = "ARC上書き保存";
            this.Arc上書き保存ToolStripMenuItem.Click += new System.EventHandler(this.Arc上書き保存ToolStripMenuItem_Click);
            // 
            // ARC保存ToolStripMenuItem
            // 
            this.Arc保存ToolStripMenuItem.Name = "ARC保存ToolStripMenuItem";
            this.Arc保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.Arc保存ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.Arc保存ToolStripMenuItem.Text = "ARC保存";
            this.Arc保存ToolStripMenuItem.Click += new System.EventHandler(this.Arc保存ToolStripMenuItem_Click);
            // 
            // lstListsInsideMsbt
            // 
            this.lstListsInsideMsbt.FormattingEnabled = true;
            this.lstListsInsideMsbt.HorizontalScrollbar = true;
            this.lstListsInsideMsbt.ItemHeight = 12;
            this.lstListsInsideMsbt.Location = new System.Drawing.Point(6, 27);
            this.lstListsInsideMsbt.Name = "lstListsInsideMsbt";
            this.lstListsInsideMsbt.ScrollAlwaysVisible = true;
            this.lstListsInsideMsbt.Size = new System.Drawing.Size(204, 424);
            this.lstListsInsideMsbt.TabIndex = 2;
            this.lstListsInsideMsbt.SelectedIndexChanged += new System.EventHandler(this.LstListsInsideMsbt_SelectedIndexChanged);
            // 
            // txtMsbtText
            // 
            this.txtMsbtText.Location = new System.Drawing.Point(6, 6);
            this.txtMsbtText.Multiline = true;
            this.txtMsbtText.Name = "txtMsbtText";
            this.txtMsbtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsbtText.Size = new System.Drawing.Size(548, 256);
            this.txtMsbtText.TabIndex = 3;
            this.txtMsbtText.TextChanged += new System.EventHandler(this.TxtMsbtText_TextChanged);
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
            this.tabControl1.Controls.Add(this.tbpMsbtSetting);
            this.tabControl1.Controls.Add(this.tbpMsbtTextEdit);
            this.tabControl1.Controls.Add(this.tbpListEdit);
            this.tabControl1.Controls.Add(this.tbpMsbfSetting);
            this.tabControl1.Controls.Add(this.tbpDebugMsbf);
            this.tabControl1.Controls.Add(this.tbpDebug);
            this.tabControl1.Controls.Add(this.tbpCredit);
            this.tabControl1.Controls.Add(this.tbpInfomation);
            this.tabControl1.Location = new System.Drawing.Point(452, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 460);
            this.tabControl1.TabIndex = 5;
            // 
            // tbpMsbtSetting
            // 
            this.tbpMsbtSetting.Controls.Add(this.gbxMsbtSettingAtr1);
            this.tbpMsbtSetting.Location = new System.Drawing.Point(4, 22);
            this.tbpMsbtSetting.Name = "tbpMsbtSetting";
            this.tbpMsbtSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMsbtSetting.Size = new System.Drawing.Size(560, 434);
            this.tbpMsbtSetting.TabIndex = 0;
            this.tbpMsbtSetting.Text = "MSBTテキストの詳細設定";
            this.tbpMsbtSetting.UseVisualStyleBackColor = true;
            // 
            // gbxMsbtSettingAtr1
            // 
            this.gbxMsbtSettingAtr1.Controls.Add(this.lblAtr1SpecialText);
            this.gbxMsbtSettingAtr1.Controls.Add(this.txtAtr1SpecialText);
            this.gbxMsbtSettingAtr1.Controls.Add(this.lblAtr1Unknown6);
            this.gbxMsbtSettingAtr1.Controls.Add(this.lblAtr1MessageAreaID);
            this.gbxMsbtSettingAtr1.Controls.Add(this.lblAtr1EventCameraID);
            this.gbxMsbtSettingAtr1.Controls.Add(this.lblAtr1WindowID);
            this.gbxMsbtSettingAtr1.Controls.Add(this.lblAtr1DialogID);
            this.gbxMsbtSettingAtr1.Controls.Add(this.lblAtr1SimpleCamID);
            this.gbxMsbtSettingAtr1.Controls.Add(this.lblAtr1SoundID);
            this.gbxMsbtSettingAtr1.Controls.Add(this.txtAtr1Unknown6);
            this.gbxMsbtSettingAtr1.Controls.Add(this.txtAtr1MessageAreaID);
            this.gbxMsbtSettingAtr1.Controls.Add(this.txtAtr1EventCameraID);
            this.gbxMsbtSettingAtr1.Controls.Add(this.txtAtr1WindowID);
            this.gbxMsbtSettingAtr1.Controls.Add(this.txtAtr1DialogID);
            this.gbxMsbtSettingAtr1.Controls.Add(this.txtAtr1SimpleCamID);
            this.gbxMsbtSettingAtr1.Controls.Add(this.txtAtr1SoundID);
            this.gbxMsbtSettingAtr1.Location = new System.Drawing.Point(6, 6);
            this.gbxMsbtSettingAtr1.Name = "gbxMsbtSettingAtr1";
            this.gbxMsbtSettingAtr1.Size = new System.Drawing.Size(548, 290);
            this.gbxMsbtSettingAtr1.TabIndex = 4;
            this.gbxMsbtSettingAtr1.TabStop = false;
            this.gbxMsbtSettingAtr1.Text = "選択されたMSBTメッセージの詳細設定";
            // 
            // lblAtr1SpecialText
            // 
            this.lblAtr1SpecialText.AutoSize = true;
            this.lblAtr1SpecialText.Location = new System.Drawing.Point(6, 197);
            this.lblAtr1SpecialText.Name = "lblAtr1SpecialText";
            this.lblAtr1SpecialText.Size = new System.Drawing.Size(231, 12);
            this.lblAtr1SpecialText.TabIndex = 17;
            this.lblAtr1SpecialText.Text = "特殊テキスト(基本null) ※上級者以外触らない";
            // 
            // txtAtr1SpecialText
            // 
            this.txtAtr1SpecialText.Location = new System.Drawing.Point(8, 212);
            this.txtAtr1SpecialText.Multiline = true;
            this.txtAtr1SpecialText.Name = "txtAtr1SpecialText";
            this.txtAtr1SpecialText.Size = new System.Drawing.Size(536, 68);
            this.txtAtr1SpecialText.TabIndex = 16;
            this.txtAtr1SpecialText.TextChanged += new System.EventHandler(this.TxtAtr1SpecialText_TextChanged);
            this.txtAtr1SpecialText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAtr1SpecialText_KeyPress);
            // 
            // lblAtr1Unknown6
            // 
            this.lblAtr1Unknown6.AutoSize = true;
            this.lblAtr1Unknown6.Location = new System.Drawing.Point(6, 175);
            this.lblAtr1Unknown6.Name = "lblAtr1Unknown6";
            this.lblAtr1Unknown6.Size = new System.Drawing.Size(35, 12);
            this.lblAtr1Unknown6.TabIndex = 14;
            this.lblAtr1Unknown6.Text = "不明6";
            // 
            // lblAtr1MessageAreaID
            // 
            this.lblAtr1MessageAreaID.AutoSize = true;
            this.lblAtr1MessageAreaID.Location = new System.Drawing.Point(6, 149);
            this.lblAtr1MessageAreaID.Name = "lblAtr1MessageAreaID";
            this.lblAtr1MessageAreaID.Size = new System.Drawing.Size(100, 12);
            this.lblAtr1MessageAreaID.TabIndex = 13;
            this.lblAtr1MessageAreaID.Text = "会話制御エリアarg0";
            // 
            // lblAtr1EventCameraID
            // 
            this.lblAtr1EventCameraID.AutoSize = true;
            this.lblAtr1EventCameraID.Location = new System.Drawing.Point(6, 122);
            this.lblAtr1EventCameraID.Name = "lblAtr1EventCameraID";
            this.lblAtr1EventCameraID.Size = new System.Drawing.Size(77, 12);
            this.lblAtr1EventCameraID.TabIndex = 12;
            this.lblAtr1EventCameraID.Text = "イベントカメラID";
            // 
            // lblAtr1WindowID
            // 
            this.lblAtr1WindowID.AutoSize = true;
            this.lblAtr1WindowID.Location = new System.Drawing.Point(6, 96);
            this.lblAtr1WindowID.Name = "lblAtr1WindowID";
            this.lblAtr1WindowID.Size = new System.Drawing.Size(74, 12);
            this.lblAtr1WindowID.TabIndex = 11;
            this.lblAtr1WindowID.Text = "ウィンドウタイプ";
            // 
            // lblAtr1DialogID
            // 
            this.lblAtr1DialogID.AutoSize = true;
            this.lblAtr1DialogID.Location = new System.Drawing.Point(6, 71);
            this.lblAtr1DialogID.Name = "lblAtr1DialogID";
            this.lblAtr1DialogID.Size = new System.Drawing.Size(76, 12);
            this.lblAtr1DialogID.TabIndex = 10;
            this.lblAtr1DialogID.Text = "ダイアログタイプ";
            // 
            // lblAtr1SimpleCamID
            // 
            this.lblAtr1SimpleCamID.AutoSize = true;
            this.lblAtr1SimpleCamID.Location = new System.Drawing.Point(6, 46);
            this.lblAtr1SimpleCamID.Name = "lblAtr1SimpleCamID";
            this.lblAtr1SimpleCamID.Size = new System.Drawing.Size(30, 12);
            this.lblAtr1SimpleCamID.TabIndex = 9;
            this.lblAtr1SimpleCamID.Text = "カメラ";
            // 
            // lblAtr1SoundID
            // 
            this.lblAtr1SoundID.AutoSize = true;
            this.lblAtr1SoundID.Location = new System.Drawing.Point(6, 21);
            this.lblAtr1SoundID.Name = "lblAtr1SoundID";
            this.lblAtr1SoundID.Size = new System.Drawing.Size(42, 12);
            this.lblAtr1SoundID.TabIndex = 8;
            this.lblAtr1SoundID.Text = "サウンド";
            // 
            // txtAtr1Unknown6
            // 
            this.txtAtr1Unknown6.Location = new System.Drawing.Point(147, 172);
            this.txtAtr1Unknown6.MaxLength = 2;
            this.txtAtr1Unknown6.Name = "txtAtr1Unknown6";
            this.txtAtr1Unknown6.Size = new System.Drawing.Size(100, 19);
            this.txtAtr1Unknown6.TabIndex = 6;
            this.txtAtr1Unknown6.TextChanged += new System.EventHandler(this.TxtAtr1Unknown6_TextChanged);
            this.txtAtr1Unknown6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAtr1Unknown6_KeyPress);
            // 
            // txtAtr1MessageAreaID
            // 
            this.txtAtr1MessageAreaID.Location = new System.Drawing.Point(147, 146);
            this.txtAtr1MessageAreaID.Name = "txtAtr1MessageAreaID";
            this.txtAtr1MessageAreaID.Size = new System.Drawing.Size(100, 19);
            this.txtAtr1MessageAreaID.TabIndex = 5;
            this.txtAtr1MessageAreaID.TextChanged += new System.EventHandler(this.TxtAtr1MessageAreaID_TextChanged);
            this.txtAtr1MessageAreaID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAtr1MessageAreaID_KeyPress);
            // 
            // txtAtr1EventCameraID
            // 
            this.txtAtr1EventCameraID.Location = new System.Drawing.Point(147, 119);
            this.txtAtr1EventCameraID.MaxLength = 4;
            this.txtAtr1EventCameraID.Name = "txtAtr1EventCameraID";
            this.txtAtr1EventCameraID.Size = new System.Drawing.Size(100, 19);
            this.txtAtr1EventCameraID.TabIndex = 4;
            this.txtAtr1EventCameraID.TextChanged += new System.EventHandler(this.TxtAtr1EventCameraID_TextChanged);
            this.txtAtr1EventCameraID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAtr1EventCameraID_KeyPress);
            // 
            // txtAtr1WindowID
            // 
            this.txtAtr1WindowID.Location = new System.Drawing.Point(147, 93);
            this.txtAtr1WindowID.MaxLength = 2;
            this.txtAtr1WindowID.Name = "txtAtr1WindowID";
            this.txtAtr1WindowID.Size = new System.Drawing.Size(100, 19);
            this.txtAtr1WindowID.TabIndex = 3;
            this.txtAtr1WindowID.TextChanged += new System.EventHandler(this.TxtAtr1WindowID_TextChanged);
            this.txtAtr1WindowID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAtr1WindowID_KeyPress);
            // 
            // txtAtr1DialogID
            // 
            this.txtAtr1DialogID.Location = new System.Drawing.Point(147, 68);
            this.txtAtr1DialogID.MaxLength = 2;
            this.txtAtr1DialogID.Name = "txtAtr1DialogID";
            this.txtAtr1DialogID.Size = new System.Drawing.Size(100, 19);
            this.txtAtr1DialogID.TabIndex = 2;
            this.txtAtr1DialogID.TextChanged += new System.EventHandler(this.TxtAtr1DialogID_TextChanged);
            this.txtAtr1DialogID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAtr1DialogID_KeyPress);
            // 
            // txtAtr1SimpleCamID
            // 
            this.txtAtr1SimpleCamID.Location = new System.Drawing.Point(147, 43);
            this.txtAtr1SimpleCamID.MaxLength = 2;
            this.txtAtr1SimpleCamID.Name = "txtAtr1SimpleCamID";
            this.txtAtr1SimpleCamID.Size = new System.Drawing.Size(100, 19);
            this.txtAtr1SimpleCamID.TabIndex = 1;
            this.txtAtr1SimpleCamID.TextChanged += new System.EventHandler(this.TxtAtr1SimpleCamID_TextChanged);
            this.txtAtr1SimpleCamID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAtr1SimpleCamID_KeyPress);
            // 
            // txtAtr1SoundID
            // 
            this.txtAtr1SoundID.Location = new System.Drawing.Point(147, 18);
            this.txtAtr1SoundID.MaxLength = 2;
            this.txtAtr1SoundID.Name = "txtAtr1SoundID";
            this.txtAtr1SoundID.Size = new System.Drawing.Size(100, 19);
            this.txtAtr1SoundID.TabIndex = 0;
            this.txtAtr1SoundID.TextChanged += new System.EventHandler(this.TxtAtr1SoundID_TextChanged);
            this.txtAtr1SoundID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAtr1SoundID_KeyPress);
            // 
            // tbpMsbtTextEdit
            // 
            this.tbpMsbtTextEdit.Controls.Add(this.tabControl2);
            this.tbpMsbtTextEdit.Controls.Add(this.txtMsbtText);
            this.tbpMsbtTextEdit.Location = new System.Drawing.Point(4, 22);
            this.tbpMsbtTextEdit.Name = "tbpMsbtTextEdit";
            this.tbpMsbtTextEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMsbtTextEdit.Size = new System.Drawing.Size(560, 434);
            this.tbpMsbtTextEdit.TabIndex = 1;
            this.tbpMsbtTextEdit.Text = "MSBTテキスト編集";
            this.tbpMsbtTextEdit.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tbpGeneralTag);
            this.tabControl2.Controls.Add(this.tbpValueTag);
            this.tabControl2.Controls.Add(this.tbpSpecialTag);
            this.tabControl2.Controls.Add(this.tbpIconTag);
            this.tabControl2.Controls.Add(this.AdvancedTagTabPage);
            this.tabControl2.Location = new System.Drawing.Point(6, 268);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(548, 167);
            this.tabControl2.TabIndex = 12;
            // 
            // tbpGeneralTag
            // 
            this.tbpGeneralTag.Controls.Add(this.btnInsertColorTag);
            this.tbpGeneralTag.Controls.Add(this.btnInsertPlayerCharacterTag);
            this.tbpGeneralTag.Controls.Add(this.cmbCenterTag);
            this.tbpGeneralTag.Controls.Add(this.btnInsertCenterTag);
            this.tbpGeneralTag.Controls.Add(this.cmbColorTag);
            this.tbpGeneralTag.Controls.Add(this.btnInsertLineControlTag);
            this.tbpGeneralTag.Controls.Add(this.cmbFontSizeTag);
            this.tbpGeneralTag.Controls.Add(this.btnInsertFontSizeTag);
            this.tbpGeneralTag.Controls.Add(this.cmbLineControlTag);
            this.tbpGeneralTag.Location = new System.Drawing.Point(4, 22);
            this.tbpGeneralTag.Name = "tbpGeneralTag";
            this.tbpGeneralTag.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGeneralTag.Size = new System.Drawing.Size(540, 141);
            this.tbpGeneralTag.TabIndex = 0;
            this.tbpGeneralTag.Text = "汎用タグ";
            this.tbpGeneralTag.UseVisualStyleBackColor = true;
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
            // tbpValueTag
            // 
            this.tbpValueTag.Controls.Add(this.gbxTimerTag);
            this.tbpValueTag.Controls.Add(this.gbxRubiTag);
            this.tbpValueTag.Location = new System.Drawing.Point(4, 22);
            this.tbpValueTag.Name = "tbpValueTag";
            this.tbpValueTag.Padding = new System.Windows.Forms.Padding(3);
            this.tbpValueTag.Size = new System.Drawing.Size(540, 141);
            this.tbpValueTag.TabIndex = 1;
            this.tbpValueTag.Text = "数値必要タグ";
            this.tbpValueTag.UseVisualStyleBackColor = true;
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
            this.lblRubiTagDiscription.Text = "例：<Rubi=\"9\" Target=\"5\">しんぎんがていこく新銀河帝国\r\n漢字の数は5文字まで対応（ふりがなの上限は不明）";
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
            // tbpSpecialTag
            // 
            this.tbpSpecialTag.Controls.Add(this.gbxSpecialTag);
            this.tbpSpecialTag.Location = new System.Drawing.Point(4, 22);
            this.tbpSpecialTag.Name = "tbpSpecialTag";
            this.tbpSpecialTag.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSpecialTag.Size = new System.Drawing.Size(540, 141);
            this.tbpSpecialTag.TabIndex = 2;
            this.tbpSpecialTag.Text = "特殊タグ";
            this.tbpSpecialTag.UseVisualStyleBackColor = true;
            // 
            // gbxSpecialTag
            // 
            this.gbxSpecialTag.Controls.Add(this.btnInsertTotalPlayTimeTag);
            this.gbxSpecialTag.Controls.Add(this.btnInsertUserNameTag);
            this.gbxSpecialTag.Controls.Add(this.btnInsertScoreTag);
            this.gbxSpecialTag.Controls.Add(this.btnInsertWorldNoTag);
            this.gbxSpecialTag.Controls.Add(this.btnInsertNumbersBelowDecimalPointTag);
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
            this.btnInsertNumbersBelowDecimalPointTag.Location = new System.Drawing.Point(355, 100);
            this.btnInsertNumbersBelowDecimalPointTag.Name = "btnInsertNumbersBelowDecimalPoint";
            this.btnInsertNumbersBelowDecimalPointTag.Size = new System.Drawing.Size(167, 23);
            this.btnInsertNumbersBelowDecimalPointTag.TabIndex = 9;
            this.btnInsertNumbersBelowDecimalPointTag.Text = "小数点以下";
            this.btnInsertNumbersBelowDecimalPointTag.UseVisualStyleBackColor = true;
            this.btnInsertNumbersBelowDecimalPointTag.Click += new System.EventHandler(this.BtnInsertNumbersBelowDecimalPointTag_Click);
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
            // tbpIconTag
            // 
            this.tbpIconTag.Controls.Add(this.btnInsertOtherIconTag);
            this.tbpIconTag.Controls.Add(this.cmbOtherIconTag);
            this.tbpIconTag.Controls.Add(this.lblOtherIconTag);
            this.tbpIconTag.Controls.Add(this.lblObjectIconTag);
            this.tbpIconTag.Controls.Add(this.btnInsertObjectIconTag);
            this.tbpIconTag.Controls.Add(this.cmbObjectIconTag);
            this.tbpIconTag.Controls.Add(this.lblCharacterIconTag);
            this.tbpIconTag.Controls.Add(this.btnInsertCharacterIconTag);
            this.tbpIconTag.Controls.Add(this.cmbCharacterIconTag);
            this.tbpIconTag.Location = new System.Drawing.Point(4, 22);
            this.tbpIconTag.Name = "tbpIconTag";
            this.tbpIconTag.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIconTag.Size = new System.Drawing.Size(540, 141);
            this.tbpIconTag.TabIndex = 3;
            this.tbpIconTag.Text = "アイコンタグ";
            this.tbpIconTag.UseVisualStyleBackColor = true;
            // 
            // btnInsertOthersIconTag
            // 
            this.btnInsertOtherIconTag.Location = new System.Drawing.Point(135, 100);
            this.btnInsertOtherIconTag.Name = "btnInsertOthersIconTag";
            this.btnInsertOtherIconTag.Size = new System.Drawing.Size(149, 23);
            this.btnInsertOtherIconTag.TabIndex = 8;
            this.btnInsertOtherIconTag.Text = "操作,その他タグ挿入";
            this.btnInsertOtherIconTag.UseVisualStyleBackColor = true;
            this.btnInsertOtherIconTag.Click += new System.EventHandler(this.BtnInsertOtherIconTag_Click);
            // 
            // cmbOthersIconTag
            // 
            this.cmbOtherIconTag.FormattingEnabled = true;
            this.cmbOtherIconTag.Location = new System.Drawing.Point(8, 102);
            this.cmbOtherIconTag.Name = "cmbOthersIconTag";
            this.cmbOtherIconTag.Size = new System.Drawing.Size(121, 20);
            this.cmbOtherIconTag.TabIndex = 7;
            this.cmbOtherIconTag.Text = "ポインター";
            // 
            // lblOthersIconTag
            // 
            this.lblOtherIconTag.AutoSize = true;
            this.lblOtherIconTag.Location = new System.Drawing.Point(6, 87);
            this.lblOtherIconTag.Name = "lblOthersIconTag";
            this.lblOtherIconTag.Size = new System.Drawing.Size(68, 12);
            this.lblOtherIconTag.TabIndex = 6;
            this.lblOtherIconTag.Text = "操作、その他";
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
            // AdvancedTagTabPage
            // 
            this.AdvancedTagTabPage.Controls.Add(this.gbxSoundEffectTag);
            this.AdvancedTagTabPage.Controls.Add(this.gbxCustomIconTag);
            this.AdvancedTagTabPage.Location = new System.Drawing.Point(4, 22);
            this.AdvancedTagTabPage.Name = "AdvancedTagTabPage";
            this.AdvancedTagTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdvancedTagTabPage.Size = new System.Drawing.Size(540, 141);
            this.AdvancedTagTabPage.TabIndex = 4;
            this.AdvancedTagTabPage.Text = "上級者向けタグ";
            this.AdvancedTagTabPage.UseVisualStyleBackColor = true;
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
            this.txtCustomIconHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserIconInsertTextBox_KeyPress);
            // 
            // tbpListEdit
            // 
            this.tbpListEdit.Controls.Add(this.gbxListEditFen1);
            this.tbpListEdit.Controls.Add(this.gbxListEditFlw2);
            this.tbpListEdit.Controls.Add(this.gbxListEditMsbt);
            this.tbpListEdit.Location = new System.Drawing.Point(4, 22);
            this.tbpListEdit.Name = "tbpListEdit";
            this.tbpListEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListEdit.Size = new System.Drawing.Size(560, 434);
            this.tbpListEdit.TabIndex = 2;
            this.tbpListEdit.Text = "リスト編集";
            this.tbpListEdit.UseVisualStyleBackColor = true;
            // 
            // gbxListEditFen1
            // 
            this.gbxListEditFen1.Controls.Add(this.btnDeleteFen1List);
            this.gbxListEditFen1.Controls.Add(this.btnAddFen1List);
            this.gbxListEditFen1.Controls.Add(this.txtFen1ListName);
            this.gbxListEditFen1.Controls.Add(this.lblFen1ListName);
            this.gbxListEditFen1.Location = new System.Drawing.Point(3, 270);
            this.gbxListEditFen1.Name = "gbxListEditFen1";
            this.gbxListEditFen1.Size = new System.Drawing.Size(224, 119);
            this.gbxListEditFen1.TabIndex = 6;
            this.gbxListEditFen1.TabStop = false;
            this.gbxListEditFen1.Text = "FEN1";
            // 
            // btnDeleteFen1List
            // 
            this.btnDeleteFen1List.Location = new System.Drawing.Point(137, 90);
            this.btnDeleteFen1List.Name = "btnDeleteFen1List";
            this.btnDeleteFen1List.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFen1List.TabIndex = 3;
            this.btnDeleteFen1List.Text = "削除";
            this.btnDeleteFen1List.UseVisualStyleBackColor = true;
            this.btnDeleteFen1List.Click += new System.EventHandler(this.BtnDeleteFen1List_Click);
            // 
            // btnAddFen1List
            // 
            this.btnAddFen1List.Location = new System.Drawing.Point(8, 90);
            this.btnAddFen1List.Name = "btnAddFen1List";
            this.btnAddFen1List.Size = new System.Drawing.Size(75, 23);
            this.btnAddFen1List.TabIndex = 2;
            this.btnAddFen1List.Text = "追加";
            this.btnAddFen1List.UseVisualStyleBackColor = true;
            this.btnAddFen1List.Click += new System.EventHandler(this.BtnAddFen1List_Click);
            // 
            // txtFen1ListName
            // 
            this.txtFen1ListName.Location = new System.Drawing.Point(8, 51);
            this.txtFen1ListName.Name = "txtFen1ListName";
            this.txtFen1ListName.Size = new System.Drawing.Size(204, 19);
            this.txtFen1ListName.TabIndex = 1;
            // 
            // lblFen1ListName
            // 
            this.lblFen1ListName.AutoSize = true;
            this.lblFen1ListName.Location = new System.Drawing.Point(6, 19);
            this.lblFen1ListName.Name = "lblFen1ListName";
            this.lblFen1ListName.Size = new System.Drawing.Size(168, 12);
            this.lblFen1ListName.TabIndex = 0;
            this.lblFen1ListName.Text = "名前必須(Flowなどを省いた名前)";
            // 
            // gbxListEditFlw2
            // 
            this.gbxListEditFlw2.Controls.Add(this.btnDeleteFlw2List);
            this.gbxListEditFlw2.Controls.Add(this.btnAddFlw2List);
            this.gbxListEditFlw2.Controls.Add(this.lblFlw2ListEditDiscription);
            this.gbxListEditFlw2.Location = new System.Drawing.Point(3, 164);
            this.gbxListEditFlw2.Name = "gbxListEditFlw2";
            this.gbxListEditFlw2.Size = new System.Drawing.Size(224, 100);
            this.gbxListEditFlw2.TabIndex = 5;
            this.gbxListEditFlw2.TabStop = false;
            this.gbxListEditFlw2.Text = "FLW2";
            // 
            // btnDeleteFlw2List
            // 
            this.btnDeleteFlw2List.Location = new System.Drawing.Point(137, 58);
            this.btnDeleteFlw2List.Name = "btnDeleteFlw2List";
            this.btnDeleteFlw2List.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFlw2List.TabIndex = 3;
            this.btnDeleteFlw2List.Text = "削除";
            this.btnDeleteFlw2List.UseVisualStyleBackColor = true;
            this.btnDeleteFlw2List.Click += new System.EventHandler(this.BtnDeleteFlw2List_Click);
            // 
            // btnAddFlw2List
            // 
            this.btnAddFlw2List.Location = new System.Drawing.Point(8, 58);
            this.btnAddFlw2List.Name = "btnAddFlw2List";
            this.btnAddFlw2List.Size = new System.Drawing.Size(75, 23);
            this.btnAddFlw2List.TabIndex = 2;
            this.btnAddFlw2List.Text = "追加";
            this.btnAddFlw2List.UseVisualStyleBackColor = true;
            this.btnAddFlw2List.Click += new System.EventHandler(this.BtnAddFlw2List_Click);
            // 
            // lblFlw2ListEditDiscription
            // 
            this.lblFlw2ListEditDiscription.AutoSize = true;
            this.lblFlw2ListEditDiscription.Location = new System.Drawing.Point(6, 22);
            this.lblFlw2ListEditDiscription.Name = "lblFlw2ListEditDiscription";
            this.lblFlw2ListEditDiscription.Size = new System.Drawing.Size(135, 12);
            this.lblFlw2ListEditDiscription.TabIndex = 0;
            this.lblFlw2ListEditDiscription.Text = "この項目は名前が不要です";
            // 
            // gbxListEditMsbt
            // 
            this.gbxListEditMsbt.Controls.Add(this.lblMsbtListEditDiscription);
            this.gbxListEditMsbt.Controls.Add(this.lblMsbtListName);
            this.gbxListEditMsbt.Controls.Add(this.txtSelectedMsbtListName);
            this.gbxListEditMsbt.Controls.Add(this.lblMsbtListEditNote);
            this.gbxListEditMsbt.Controls.Add(this.btnDeleteMsbtList);
            this.gbxListEditMsbt.Controls.Add(this.txtMsbtListName);
            this.gbxListEditMsbt.Controls.Add(this.btnAddMsbtList);
            this.gbxListEditMsbt.Location = new System.Drawing.Point(3, 6);
            this.gbxListEditMsbt.Name = "gbxListEditMsbt";
            this.gbxListEditMsbt.Size = new System.Drawing.Size(224, 152);
            this.gbxListEditMsbt.TabIndex = 4;
            this.gbxListEditMsbt.TabStop = false;
            this.gbxListEditMsbt.Text = "MSBT";
            // 
            // lblMsbtListEditDiscription
            // 
            this.lblMsbtListEditDiscription.AutoSize = true;
            this.lblMsbtListEditDiscription.Location = new System.Drawing.Point(6, 39);
            this.lblMsbtListEditDiscription.Name = "lblMsbtListEditDiscription";
            this.lblMsbtListEditDiscription.Size = new System.Drawing.Size(142, 24);
            this.lblMsbtListEditDiscription.TabIndex = 4;
            this.lblMsbtListEditDiscription.Text = "削除は対象のリスト選択後に\r\n右の削除ボタンを押す";
            // 
            // lblMsbtListName
            // 
            this.lblMsbtListName.AutoSize = true;
            this.lblMsbtListName.Location = new System.Drawing.Point(6, 15);
            this.lblMsbtListName.Name = "lblMsbtListName";
            this.lblMsbtListName.Size = new System.Drawing.Size(115, 12);
            this.lblMsbtListName.TabIndex = 3;
            this.lblMsbtListName.Text = "追加するMSBTリスト名";
            // 
            // txtSelectedMsbtListName
            // 
            this.txtSelectedMsbtListName.Location = new System.Drawing.Point(8, 116);
            this.txtSelectedMsbtListName.Name = "txtSelectedMsbtListName";
            this.txtSelectedMsbtListName.ReadOnly = true;
            this.txtSelectedMsbtListName.Size = new System.Drawing.Size(204, 19);
            this.txtSelectedMsbtListName.TabIndex = 1;
            this.txtSelectedMsbtListName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtSelectedMsbtListName_MouseClick);
            // 
            // lblMsbtListEditNote
            // 
            this.lblMsbtListEditNote.AutoSize = true;
            this.lblMsbtListEditNote.ForeColor = System.Drawing.Color.Red;
            this.lblMsbtListEditNote.Location = new System.Drawing.Point(6, 27);
            this.lblMsbtListEditNote.Name = "lblMsbtListEditNote";
            this.lblMsbtListEditNote.Size = new System.Drawing.Size(198, 12);
            this.lblMsbtListEditNote.TabIndex = 5;
            this.lblMsbtListEditNote.Text = "※ゲーム内での命名規則を守ってください";
            // 
            // btnDeleteMsbtList
            // 
            this.btnDeleteMsbtList.Location = new System.Drawing.Point(137, 91);
            this.btnDeleteMsbtList.Name = "btnDeleteMsbtList";
            this.btnDeleteMsbtList.Size = new System.Drawing.Size(75, 19);
            this.btnDeleteMsbtList.TabIndex = 2;
            this.btnDeleteMsbtList.Text = "削除";
            this.btnDeleteMsbtList.UseVisualStyleBackColor = true;
            this.btnDeleteMsbtList.Click += new System.EventHandler(this.BtnDeleteMsbtList_Click);
            // 
            // txtMsbtListName
            // 
            this.txtMsbtListName.Location = new System.Drawing.Point(8, 66);
            this.txtMsbtListName.Name = "txtMsbtListName";
            this.txtMsbtListName.Size = new System.Drawing.Size(204, 19);
            this.txtMsbtListName.TabIndex = 0;
            // 
            // btnAddMsbtList
            // 
            this.btnAddMsbtList.Location = new System.Drawing.Point(8, 91);
            this.btnAddMsbtList.Name = "btnAddMsbtList";
            this.btnAddMsbtList.Size = new System.Drawing.Size(75, 19);
            this.btnAddMsbtList.TabIndex = 1;
            this.btnAddMsbtList.Text = "追加";
            this.btnAddMsbtList.UseVisualStyleBackColor = true;
            this.btnAddMsbtList.Click += new System.EventHandler(this.BtnAddMsbtList_Click);
            // 
            // tbpMsbfSetting
            // 
            this.tbpMsbfSetting.Controls.Add(this.chkShowTvwMsbfFlow);
            this.tbpMsbfSetting.Controls.Add(this.btnReloadTvwMsbfFlow);
            this.tbpMsbfSetting.Controls.Add(this.txtReadOnlyMsbtText);
            this.tbpMsbfSetting.Controls.Add(this.lblMsbfFlow);
            this.tbpMsbfSetting.Controls.Add(this.tvwMsbfFlow);
            this.tbpMsbfSetting.Controls.Add(this.lblMsbfSettingNote);
            this.tbpMsbfSetting.Controls.Add(this.gbxFen1);
            this.tbpMsbfSetting.Controls.Add(this.gbxFlw2);
            this.tbpMsbfSetting.Location = new System.Drawing.Point(4, 22);
            this.tbpMsbfSetting.Name = "tbpMsbfSetting";
            this.tbpMsbfSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMsbfSetting.Size = new System.Drawing.Size(560, 434);
            this.tbpMsbfSetting.TabIndex = 3;
            this.tbpMsbfSetting.Text = "MSBF";
            this.tbpMsbfSetting.UseVisualStyleBackColor = true;
            // 
            // chkShowTvwMsbfFlow
            // 
            this.chkShowTvwMsbfFlow.AutoSize = true;
            this.chkShowTvwMsbfFlow.Location = new System.Drawing.Point(464, 9);
            this.chkShowTvwMsbfFlow.Name = "chkShowTvwMsbfFlow";
            this.chkShowTvwMsbfFlow.Size = new System.Drawing.Size(40, 16);
            this.chkShowTvwMsbfFlow.TabIndex = 19;
            this.chkShowTvwMsbfFlow.Text = "ON";
            this.chkShowTvwMsbfFlow.UseVisualStyleBackColor = true;
            this.chkShowTvwMsbfFlow.CheckedChanged += new System.EventHandler(this.ChkShowTvwMsbfFlow_CheckedChanged);
            // 
            // btnReloadTvwMsbfFlow
            // 
            this.btnReloadTvwMsbfFlow.Location = new System.Drawing.Point(439, 341);
            this.btnReloadTvwMsbfFlow.Name = "btnReloadTvwMsbfFlow";
            this.btnReloadTvwMsbfFlow.Size = new System.Drawing.Size(115, 23);
            this.btnReloadTvwMsbfFlow.TabIndex = 18;
            this.btnReloadTvwMsbfFlow.Text = "アップデート/Reload ";
            this.btnReloadTvwMsbfFlow.UseVisualStyleBackColor = true;
            this.btnReloadTvwMsbfFlow.Click += new System.EventHandler(this.BtnReloadTvwMsbfFlow_Click);
            // 
            // txtReadOnlyMsbtText
            // 
            this.txtReadOnlyMsbtText.Location = new System.Drawing.Point(6, 370);
            this.txtReadOnlyMsbtText.Multiline = true;
            this.txtReadOnlyMsbtText.Name = "txtReadOnlyMsbtText";
            this.txtReadOnlyMsbtText.ReadOnly = true;
            this.txtReadOnlyMsbtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReadOnlyMsbtText.Size = new System.Drawing.Size(548, 58);
            this.txtReadOnlyMsbtText.TabIndex = 17;
            // 
            // lblMsbfFlow
            // 
            this.lblMsbfFlow.AutoSize = true;
            this.lblMsbfFlow.Location = new System.Drawing.Point(329, 10);
            this.lblMsbfFlow.Name = "lblMsbfFlow";
            this.lblMsbfFlow.Size = new System.Drawing.Size(129, 12);
            this.lblMsbfFlow.TabIndex = 16;
            this.lblMsbfFlow.Text = "テスト機能/Test function";
            // 
            // tvwMsbfFlow
            // 
            this.tvwMsbfFlow.Location = new System.Drawing.Point(329, 28);
            this.tvwMsbfFlow.Name = "tvwMsbfFlow";
            this.tvwMsbfFlow.Size = new System.Drawing.Size(225, 304);
            this.tvwMsbfFlow.TabIndex = 15;
            this.tvwMsbfFlow.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvwMsbfFlow_AfterSelect);
            // 
            // lblMsbfSettingNote
            // 
            this.lblMsbfSettingNote.AutoSize = true;
            this.lblMsbfSettingNote.Location = new System.Drawing.Point(6, 335);
            this.lblMsbfSettingNote.Name = "lblMsbfSettingNote";
            this.lblMsbfSettingNote.Size = new System.Drawing.Size(216, 24);
            this.lblMsbfSettingNote.TabIndex = 14;
            this.lblMsbfSettingNote.Text = "※まだすべての機能を解明できていないため、\r\n　不具合が発生する可能性があります";
            // 
            // gbxFen1
            // 
            this.gbxFen1.Controls.Add(this.lblFlw2StartIndex);
            this.gbxFen1.Controls.Add(this.lblFen1Arg0);
            this.gbxFen1.Controls.Add(this.txtFen1StartIndex);
            this.gbxFen1.Controls.Add(this.txtFen1Arg0);
            this.gbxFen1.Location = new System.Drawing.Point(6, 262);
            this.gbxFen1.Name = "gbxFen1";
            this.gbxFen1.Size = new System.Drawing.Size(317, 70);
            this.gbxFen1.TabIndex = 13;
            this.gbxFen1.TabStop = false;
            this.gbxFen1.Text = "FEN1";
            // 
            // lblFlw2StartIndex
            // 
            this.lblFlw2StartIndex.AutoSize = true;
            this.lblFlw2StartIndex.Location = new System.Drawing.Point(6, 42);
            this.lblFlw2StartIndex.Name = "lblFlw2StartIndex";
            this.lblFlw2StartIndex.Size = new System.Drawing.Size(109, 12);
            this.lblFlw2StartIndex.TabIndex = 4;
            this.lblFlw2StartIndex.Text = "FLW2開始インデックス";
            // 
            // lblFen1Arg0
            // 
            this.lblFen1Arg0.AutoSize = true;
            this.lblFen1Arg0.Location = new System.Drawing.Point(6, 18);
            this.lblFen1Arg0.Name = "lblFen1Arg0";
            this.lblFen1Arg0.Size = new System.Drawing.Size(29, 12);
            this.lblFen1Arg0.TabIndex = 3;
            this.lblFen1Arg0.Text = "不明";
            // 
            // txtFen1StartIndex
            // 
            this.txtFen1StartIndex.Location = new System.Drawing.Point(178, 39);
            this.txtFen1StartIndex.Name = "txtFen1StartIndex";
            this.txtFen1StartIndex.Size = new System.Drawing.Size(100, 19);
            this.txtFen1StartIndex.TabIndex = 2;
            this.txtFen1StartIndex.TextChanged += new System.EventHandler(this.TxtFen1StartIndex_TextChanged);
            // 
            // txtFen1Arg0
            // 
            this.txtFen1Arg0.Enabled = false;
            this.txtFen1Arg0.Location = new System.Drawing.Point(178, 15);
            this.txtFen1Arg0.Name = "txtFen1Arg0";
            this.txtFen1Arg0.Size = new System.Drawing.Size(100, 19);
            this.txtFen1Arg0.TabIndex = 1;
            this.txtFen1Arg0.TextChanged += new System.EventHandler(this.TxtFen1Arg0_TextChanged);
            // 
            // gbxFlw2
            // 
            this.gbxFlw2.Controls.Add(this.lblFlw2RightAngleSymbol);
            this.gbxFlw2.Controls.Add(this.gbxFlw2Branch);
            this.gbxFlw2.Controls.Add(this.lblFlw2Arg4);
            this.gbxFlw2.Controls.Add(this.lblFlw2Arg3);
            this.gbxFlw2.Controls.Add(this.lblFlw2Arg2);
            this.gbxFlw2.Controls.Add(this.lblFlw2Arg1);
            this.gbxFlw2.Controls.Add(this.txtFlw2Arg4);
            this.gbxFlw2.Controls.Add(this.txtFlw2Arg3);
            this.gbxFlw2.Controls.Add(this.txtFlw2Arg2);
            this.gbxFlw2.Controls.Add(this.txtFlw2Arg1);
            this.gbxFlw2.Controls.Add(this.txtFlw2Padding);
            this.gbxFlw2.Controls.Add(this.lblFlw2Padding);
            this.gbxFlw2.Controls.Add(this.txtFlw2FlowType);
            this.gbxFlw2.Controls.Add(this.lblFlw2FlowType);
            this.gbxFlw2.Location = new System.Drawing.Point(6, 10);
            this.gbxFlw2.Name = "gbxFlw2";
            this.gbxFlw2.Size = new System.Drawing.Size(317, 246);
            this.gbxFlw2.TabIndex = 1;
            this.gbxFlw2.TabStop = false;
            this.gbxFlw2.Text = "FLW2";
            // 
            // lblFlw2RightAngleSymbol
            // 
            this.lblFlw2RightAngleSymbol.AutoSize = true;
            this.lblFlw2RightAngleSymbol.Location = new System.Drawing.Point(6, 37);
            this.lblFlw2RightAngleSymbol.Name = "lblFlw2RightAngleSymbol";
            this.lblFlw2RightAngleSymbol.Size = new System.Drawing.Size(17, 12);
            this.lblFlw2RightAngleSymbol.TabIndex = 13;
            this.lblFlw2RightAngleSymbol.Text = "∟";
            // 
            // gbxFlw2Branch
            // 
            this.gbxFlw2Branch.Controls.Add(this.txtFlw2BranchFalse);
            this.gbxFlw2Branch.Controls.Add(this.txtFlw2BranchTrue);
            this.gbxFlw2Branch.Controls.Add(this.lblFlw2BranchFalse);
            this.gbxFlw2Branch.Controls.Add(this.lblFlw2BranchTrue);
            this.gbxFlw2Branch.Location = new System.Drawing.Point(28, 37);
            this.gbxFlw2Branch.Name = "gbxFlw2Branch";
            this.gbxFlw2Branch.Size = new System.Drawing.Size(269, 70);
            this.gbxFlw2Branch.TabIndex = 12;
            this.gbxFlw2Branch.TabStop = false;
            this.gbxFlw2Branch.Text = "フロータイプ2の場合のみ";
            // 
            // txtFlw2BranchFalse
            // 
            this.txtFlw2BranchFalse.Location = new System.Drawing.Point(150, 41);
            this.txtFlw2BranchFalse.MaxLength = 4;
            this.txtFlw2BranchFalse.Name = "txtFlw2BranchFalse";
            this.txtFlw2BranchFalse.Size = new System.Drawing.Size(100, 19);
            this.txtFlw2BranchFalse.TabIndex = 3;
            this.txtFlw2BranchFalse.TextChanged += new System.EventHandler(this.TxtFlw2BranchFalse_TextChanged);
            this.txtFlw2BranchFalse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFlw2BranchTrue_KeyPress);
            // 
            // txtFlw2BranchTrue
            // 
            this.txtFlw2BranchTrue.Location = new System.Drawing.Point(150, 16);
            this.txtFlw2BranchTrue.MaxLength = 4;
            this.txtFlw2BranchTrue.Name = "txtFlw2BranchTrue";
            this.txtFlw2BranchTrue.Size = new System.Drawing.Size(100, 19);
            this.txtFlw2BranchTrue.TabIndex = 2;
            this.txtFlw2BranchTrue.TextChanged += new System.EventHandler(this.TxtFlw2BranchTrue_TextChanged);
            this.txtFlw2BranchTrue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFlw2BranchTrue_KeyPress);
            // 
            // lblFlw2BranchFalse
            // 
            this.lblFlw2BranchFalse.AutoSize = true;
            this.lblFlw2BranchFalse.Location = new System.Drawing.Point(6, 44);
            this.lblFlw2BranchFalse.Name = "lblFlw2BranchFalse";
            this.lblFlw2BranchFalse.Size = new System.Drawing.Size(83, 12);
            this.lblFlw2BranchFalse.TabIndex = 1;
            this.lblFlw2BranchFalse.Text = "ジャンプ先2（偽）";
            // 
            // lblFlw2BranchTrue
            // 
            this.lblFlw2BranchTrue.AutoSize = true;
            this.lblFlw2BranchTrue.Location = new System.Drawing.Point(6, 19);
            this.lblFlw2BranchTrue.Name = "lblFlw2BranchTrue";
            this.lblFlw2BranchTrue.Size = new System.Drawing.Size(83, 12);
            this.lblFlw2BranchTrue.TabIndex = 0;
            this.lblFlw2BranchTrue.Text = "ジャンプ先1（真）";
            // 
            // lblFlw2Arg4
            // 
            this.lblFlw2Arg4.AutoSize = true;
            this.lblFlw2Arg4.Location = new System.Drawing.Point(6, 218);
            this.lblFlw2Arg4.Name = "lblFlw2Arg4";
            this.lblFlw2Arg4.Size = new System.Drawing.Size(35, 12);
            this.lblFlw2Arg4.TabIndex = 11;
            this.lblFlw2Arg4.Text = "不明5";
            // 
            // lblFlw2Arg3
            // 
            this.lblFlw2Arg3.AutoSize = true;
            this.lblFlw2Arg3.Location = new System.Drawing.Point(6, 193);
            this.lblFlw2Arg3.Name = "lblFlw2Arg3";
            this.lblFlw2Arg3.Size = new System.Drawing.Size(35, 12);
            this.lblFlw2Arg3.TabIndex = 10;
            this.lblFlw2Arg3.Text = "不明4";
            // 
            // lblFlw2Arg2
            // 
            this.lblFlw2Arg2.AutoSize = true;
            this.lblFlw2Arg2.Location = new System.Drawing.Point(6, 168);
            this.lblFlw2Arg2.Name = "lblFlw2Arg2";
            this.lblFlw2Arg2.Size = new System.Drawing.Size(35, 12);
            this.lblFlw2Arg2.TabIndex = 9;
            this.lblFlw2Arg2.Text = "不明3";
            // 
            // lblFlw2Arg1
            // 
            this.lblFlw2Arg1.AutoSize = true;
            this.lblFlw2Arg1.Location = new System.Drawing.Point(6, 143);
            this.lblFlw2Arg1.Name = "lblFlw2Arg1";
            this.lblFlw2Arg1.Size = new System.Drawing.Size(35, 12);
            this.lblFlw2Arg1.TabIndex = 8;
            this.lblFlw2Arg1.Text = "不明2";
            // 
            // txtFlw2Arg4
            // 
            this.txtFlw2Arg4.Location = new System.Drawing.Point(178, 215);
            this.txtFlw2Arg4.MaxLength = 4;
            this.txtFlw2Arg4.Name = "txtFlw2Arg4";
            this.txtFlw2Arg4.Size = new System.Drawing.Size(100, 19);
            this.txtFlw2Arg4.TabIndex = 7;
            this.txtFlw2Arg4.TextChanged += new System.EventHandler(this.TxtFlw2Arg4_TextChanged);
            this.txtFlw2Arg4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFlw2BranchTrue_KeyPress);
            // 
            // txtFlw2Arg3
            // 
            this.txtFlw2Arg3.Location = new System.Drawing.Point(178, 190);
            this.txtFlw2Arg3.MaxLength = 4;
            this.txtFlw2Arg3.Name = "txtFlw2Arg3";
            this.txtFlw2Arg3.Size = new System.Drawing.Size(100, 19);
            this.txtFlw2Arg3.TabIndex = 6;
            this.txtFlw2Arg3.TextChanged += new System.EventHandler(this.TxtFlw2Arg3_TextChanged);
            this.txtFlw2Arg3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFlw2BranchTrue_KeyPress);
            // 
            // txtFlw2Arg2
            // 
            this.txtFlw2Arg2.Location = new System.Drawing.Point(178, 165);
            this.txtFlw2Arg2.MaxLength = 4;
            this.txtFlw2Arg2.Name = "txtFlw2Arg2";
            this.txtFlw2Arg2.Size = new System.Drawing.Size(100, 19);
            this.txtFlw2Arg2.TabIndex = 5;
            this.txtFlw2Arg2.TextChanged += new System.EventHandler(this.TxtFlw2Arg2_TextChanged);
            this.txtFlw2Arg2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFlw2BranchTrue_KeyPress);
            // 
            // txtFlw2Arg1
            // 
            this.txtFlw2Arg1.Location = new System.Drawing.Point(178, 140);
            this.txtFlw2Arg1.MaxLength = 4;
            this.txtFlw2Arg1.Name = "txtFlw2Arg1";
            this.txtFlw2Arg1.Size = new System.Drawing.Size(100, 19);
            this.txtFlw2Arg1.TabIndex = 4;
            this.txtFlw2Arg1.TextChanged += new System.EventHandler(this.TxtFlw2Arg1_TextChanged);
            this.txtFlw2Arg1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFlw2BranchTrue_KeyPress);
            // 
            // txtFlw2Padding
            // 
            this.txtFlw2Padding.Location = new System.Drawing.Point(178, 115);
            this.txtFlw2Padding.MaxLength = 4;
            this.txtFlw2Padding.Name = "txtFlw2Padding";
            this.txtFlw2Padding.Size = new System.Drawing.Size(100, 19);
            this.txtFlw2Padding.TabIndex = 3;
            this.txtFlw2Padding.TextChanged += new System.EventHandler(this.TxtFlw2Padding_TextChanged);
            this.txtFlw2Padding.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFlw2BranchTrue_KeyPress);
            // 
            // lblFlw2Padding
            // 
            this.lblFlw2Padding.AutoSize = true;
            this.lblFlw2Padding.Location = new System.Drawing.Point(6, 118);
            this.lblFlw2Padding.Name = "lblFlw2Padding";
            this.lblFlw2Padding.Size = new System.Drawing.Size(62, 12);
            this.lblFlw2Padding.TabIndex = 2;
            this.lblFlw2Padding.Text = "パディング？";
            // 
            // txtFlw2FlowType
            // 
            this.txtFlw2FlowType.Location = new System.Drawing.Point(178, 12);
            this.txtFlw2FlowType.MaxLength = 4;
            this.txtFlw2FlowType.Name = "txtFlw2FlowType";
            this.txtFlw2FlowType.Size = new System.Drawing.Size(100, 19);
            this.txtFlw2FlowType.TabIndex = 1;
            this.txtFlw2FlowType.TextChanged += new System.EventHandler(this.TxtFlw2FlowType_TextChanged);
            this.txtFlw2FlowType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFlw2FlowType_KeyPress);
            // 
            // lblFlw2FlowType
            // 
            this.lblFlw2FlowType.AutoSize = true;
            this.lblFlw2FlowType.Location = new System.Drawing.Point(6, 15);
            this.lblFlw2FlowType.Name = "lblFlw2FlowType";
            this.lblFlw2FlowType.Size = new System.Drawing.Size(58, 12);
            this.lblFlw2FlowType.TabIndex = 0;
            this.lblFlw2FlowType.Text = "フロータイプ";
            // 
            // tbpDebugMsbf
            // 
            this.tbpDebugMsbf.Controls.Add(this.lblMsbfHashCalculator);
            this.tbpDebugMsbf.Controls.Add(this.textBox34);
            this.tbpDebugMsbf.Controls.Add(this.button30);
            this.tbpDebugMsbf.Controls.Add(this.textBox33);
            this.tbpDebugMsbf.Controls.Add(this.textBox32);
            this.tbpDebugMsbf.Controls.Add(this.btnCalculateHash);
            this.tbpDebugMsbf.Controls.Add(this.txtListNameToCalculateHash);
            this.tbpDebugMsbf.Controls.Add(this.richTextBox1);
            this.tbpDebugMsbf.Controls.Add(this.txtFlw2DebugHex);
            this.tbpDebugMsbf.Location = new System.Drawing.Point(4, 22);
            this.tbpDebugMsbf.Name = "tbpDebugMsbf";
            this.tbpDebugMsbf.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDebugMsbf.Size = new System.Drawing.Size(560, 434);
            this.tbpDebugMsbf.TabIndex = 4;
            this.tbpDebugMsbf.Text = "MSBFデバッグ";
            this.tbpDebugMsbf.UseVisualStyleBackColor = true;
            // 
            // lblMsbfHashCalculator
            // 
            this.lblMsbfHashCalculator.AutoSize = true;
            this.lblMsbfHashCalculator.Location = new System.Drawing.Point(6, 12);
            this.lblMsbfHashCalculator.Name = "lblMsbfHashCalculator";
            this.lblMsbfHashCalculator.Size = new System.Drawing.Size(107, 12);
            this.lblMsbfHashCalculator.TabIndex = 16;
            this.lblMsbfHashCalculator.Text = "MSBFハッシュ計算機";
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
            this.button30.Click += new System.EventHandler(this.Button30_Click);
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(6, 77);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(133, 19);
            this.textBox33.TabIndex = 11;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(6, 52);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(133, 19);
            this.textBox32.TabIndex = 10;
            this.textBox32.TextChanged += new System.EventHandler(this.TextBox32_TextChanged);
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
            // txtFlw2DebugHex
            // 
            this.txtFlw2DebugHex.Location = new System.Drawing.Point(6, 112);
            this.txtFlw2DebugHex.Multiline = true;
            this.txtFlw2DebugHex.Name = "txtFlw2DebugHex";
            this.txtFlw2DebugHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFlw2DebugHex.Size = new System.Drawing.Size(548, 66);
            this.txtFlw2DebugHex.TabIndex = 7;
            // 
            // tbpDebug
            // 
            this.tbpDebug.Controls.Add(this.textBox1);
            this.tbpDebug.Controls.Add(this.btnTextSort);
            this.tbpDebug.Controls.Add(this.txtUnknownTag);
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
            // btnTextSort
            // 
            this.btnTextSort.Location = new System.Drawing.Point(345, 393);
            this.btnTextSort.Name = "btnTextSort";
            this.btnTextSort.Size = new System.Drawing.Size(209, 35);
            this.btnTextSort.TabIndex = 15;
            this.btnTextSort.Text = "TextSort";
            this.btnTextSort.UseVisualStyleBackColor = true;
            this.btnTextSort.Click += new System.EventHandler(this.BtnTextSort_Click);
            // 
            // txtUnknownTag
            // 
            this.txtUnknownTag.Location = new System.Drawing.Point(6, 265);
            this.txtUnknownTag.Multiline = true;
            this.txtUnknownTag.Name = "txtUnknownTag";
            this.txtUnknownTag.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUnknownTag.Size = new System.Drawing.Size(548, 122);
            this.txtUnknownTag.TabIndex = 14;
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
            this.tbpCredit.Controls.Add(this.gbxCreditLbl1);
            this.tbpCredit.Controls.Add(this.txtAtr1SpecialTextOffset);
            this.tbpCredit.Controls.Add(this.gbxCreditProgrammer);
            this.tbpCredit.Controls.Add(this.lblAtr1SpecialTextOffset);
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
            // gbxCreditLbl1
            // 
            this.gbxCreditLbl1.Controls.Add(this.lblCreditLbl1Note);
            this.gbxCreditLbl1.Controls.Add(this.lblLbl1TagIndex);
            this.gbxCreditLbl1.Controls.Add(this.txtLbl1TagIndex);
            this.gbxCreditLbl1.Location = new System.Drawing.Point(283, 337);
            this.gbxCreditLbl1.Name = "gbxCreditLbl1";
            this.gbxCreditLbl1.Size = new System.Drawing.Size(233, 91);
            this.gbxCreditLbl1.TabIndex = 7;
            this.gbxCreditLbl1.TabStop = false;
            this.gbxCreditLbl1.Text = "LBL1";
            this.gbxCreditLbl1.Visible = false;
            // 
            // lblCreditLbl1Note
            // 
            this.lblCreditLbl1Note.AutoSize = true;
            this.lblCreditLbl1Note.ForeColor = System.Drawing.Color.Red;
            this.lblCreditLbl1Note.Location = new System.Drawing.Point(6, 13);
            this.lblCreditLbl1Note.Name = "lblCreditLbl1Note";
            this.lblCreditLbl1Note.Size = new System.Drawing.Size(162, 24);
            this.lblCreditLbl1Note.TabIndex = 7;
            this.lblCreditLbl1Note.Text = "この項目が　0　の場合\r\nゲームにテキストが認識されません";
            // 
            // lblLbl1TagIndex
            // 
            this.lblLbl1TagIndex.AutoSize = true;
            this.lblLbl1TagIndex.Location = new System.Drawing.Point(6, 47);
            this.lblLbl1TagIndex.Name = "lblLbl1TagIndex";
            this.lblLbl1TagIndex.Size = new System.Drawing.Size(86, 12);
            this.lblLbl1TagIndex.TabIndex = 6;
            this.lblLbl1TagIndex.Text = "タグインデックス？";
            // 
            // txtLbl1TagIndex
            // 
            this.txtLbl1TagIndex.Enabled = false;
            this.txtLbl1TagIndex.Location = new System.Drawing.Point(127, 44);
            this.txtLbl1TagIndex.Name = "txtLbl1TagIndex";
            this.txtLbl1TagIndex.Size = new System.Drawing.Size(100, 19);
            this.txtLbl1TagIndex.TabIndex = 5;
            this.txtLbl1TagIndex.TextChanged += new System.EventHandler(this.TxtLbl1TagIndex_TextChanged);
            // 
            // txtAtr1SpecialTextOffset
            // 
            this.txtAtr1SpecialTextOffset.Enabled = false;
            this.txtAtr1SpecialTextOffset.Location = new System.Drawing.Point(133, 294);
            this.txtAtr1SpecialTextOffset.MaxLength = 2;
            this.txtAtr1SpecialTextOffset.Name = "txtAtr1SpecialTextOffset";
            this.txtAtr1SpecialTextOffset.Size = new System.Drawing.Size(100, 19);
            this.txtAtr1SpecialTextOffset.TabIndex = 7;
            this.txtAtr1SpecialTextOffset.Visible = false;
            // 
            // gbxCreditProgrammer
            // 
            this.gbxCreditProgrammer.Controls.Add(this.lblCreditContributorAcknowledgment);
            this.gbxCreditProgrammer.Controls.Add(this.gbxCreditContributor);
            this.gbxCreditProgrammer.Controls.Add(this.lblCreditPenguin);
            this.gbxCreditProgrammer.Location = new System.Drawing.Point(6, 6);
            this.gbxCreditProgrammer.Name = "gbxCreditProgrammer";
            this.gbxCreditProgrammer.Size = new System.Drawing.Size(255, 100);
            this.gbxCreditProgrammer.TabIndex = 1;
            this.gbxCreditProgrammer.TabStop = false;
            this.gbxCreditProgrammer.Text = "プログラミングとその他全般";
            // 
            // lblCreditContributorAcknowledgment
            // 
            this.lblCreditContributorAcknowledgment.AutoSize = true;
            this.lblCreditContributorAcknowledgment.Location = new System.Drawing.Point(10, 69);
            this.lblCreditContributorAcknowledgment.Name = "lblCreditContributorAcknowledgment";
            this.lblCreditContributorAcknowledgment.Size = new System.Drawing.Size(177, 24);
            this.lblCreditContributorAcknowledgment.TabIndex = 5;
            this.lblCreditContributorAcknowledgment.Text = "ツールの完成に協力して下さった\r\nEvanbowlさんありがとうございました。";
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
            // lblAtr1SpecialTextOffset
            // 
            this.lblAtr1SpecialTextOffset.AutoSize = true;
            this.lblAtr1SpecialTextOffset.Location = new System.Drawing.Point(22, 297);
            this.lblAtr1SpecialTextOffset.Name = "lblAtr1SpecialTextOffset";
            this.lblAtr1SpecialTextOffset.Size = new System.Drawing.Size(105, 12);
            this.lblAtr1SpecialTextOffset.TabIndex = 15;
            this.lblAtr1SpecialTextOffset.Text = "nullオフセット触らない";
            this.lblAtr1SpecialTextOffset.Visible = false;
            // 
            // gbxCreditDebugger
            // 
            this.gbxCreditDebugger.Controls.Add(this.lblDebuggerAcknowledgment);
            this.gbxCreditDebugger.Controls.Add(this.gbxCreditDebuggerVIP);
            this.gbxCreditDebugger.Controls.Add(this.lblCreditPorto);
            this.gbxCreditDebugger.Controls.Add(this.lblCreditHiiragi);
            this.gbxCreditDebugger.Controls.Add(this.lblCreditEigen);
            this.gbxCreditDebugger.Location = new System.Drawing.Point(6, 112);
            this.gbxCreditDebugger.Name = "gbxCreditDebugger";
            this.gbxCreditDebugger.Size = new System.Drawing.Size(255, 116);
            this.gbxCreditDebugger.TabIndex = 0;
            this.gbxCreditDebugger.TabStop = false;
            this.gbxCreditDebugger.Text = "デバッガー";
            // 
            // lblDebuggerAcknowledgment
            // 
            this.lblDebuggerAcknowledgment.AutoSize = true;
            this.lblDebuggerAcknowledgment.Location = new System.Drawing.Point(10, 89);
            this.lblDebuggerAcknowledgment.Name = "lblDebuggerAcknowledgment";
            this.lblDebuggerAcknowledgment.Size = new System.Drawing.Size(149, 24);
            this.lblDebuggerAcknowledgment.TabIndex = 2;
            this.lblDebuggerAcknowledgment.Text = "デバッガーの皆様もご協力頂き\r\nありがとうございました。";
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
            // lblCreditHiiragi
            // 
            this.lblCreditHiiragi.AutoSize = true;
            this.lblCreditHiiragi.Location = new System.Drawing.Point(78, 59);
            this.lblCreditHiiragi.Name = "lblCreditHiiragi";
            this.lblCreditHiiragi.Size = new System.Drawing.Size(47, 12);
            this.lblCreditHiiragi.TabIndex = 3;
            this.lblCreditHiiragi.Text = "柊：貴星";
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
            this.gbxCreditSectionEntrySize.Controls.Add(this.txtAtr1EntrySize);
            this.gbxCreditSectionEntrySize.Controls.Add(this.lblAtr1EntrySize);
            this.gbxCreditSectionEntrySize.Controls.Add(this.lblCreditSectionEntrySize);
            this.gbxCreditSectionEntrySize.Controls.Add(this.txtLbl1EntrySize);
            this.gbxCreditSectionEntrySize.Controls.Add(this.lblLbl1EntrySize);
            this.gbxCreditSectionEntrySize.Location = new System.Drawing.Point(14, 331);
            this.gbxCreditSectionEntrySize.Name = "gbxCreditSectionEntrySize";
            this.gbxCreditSectionEntrySize.Size = new System.Drawing.Size(263, 91);
            this.gbxCreditSectionEntrySize.TabIndex = 8;
            this.gbxCreditSectionEntrySize.TabStop = false;
            this.gbxCreditSectionEntrySize.Text = "各セクションのエントリーサイズ";
            this.gbxCreditSectionEntrySize.Visible = false;
            // 
            // txtAtr1EntrySize
            // 
            this.txtAtr1EntrySize.Enabled = false;
            this.txtAtr1EntrySize.Location = new System.Drawing.Point(147, 68);
            this.txtAtr1EntrySize.Name = "txtAtr1EntrySize";
            this.txtAtr1EntrySize.Size = new System.Drawing.Size(100, 19);
            this.txtAtr1EntrySize.TabIndex = 3;
            this.txtAtr1EntrySize.TextChanged += new System.EventHandler(this.TxtAtr1EntrySize_TextChanged);
            // 
            // lblAtr1EntrySize
            // 
            this.lblAtr1EntrySize.AutoSize = true;
            this.lblAtr1EntrySize.Location = new System.Drawing.Point(6, 71);
            this.lblAtr1EntrySize.Name = "lblAtr1EntrySize";
            this.lblAtr1EntrySize.Size = new System.Drawing.Size(34, 12);
            this.lblAtr1EntrySize.TabIndex = 2;
            this.lblAtr1EntrySize.Text = "ATR1";
            // 
            // lblCreditSectionEntrySize
            // 
            this.lblCreditSectionEntrySize.AutoSize = true;
            this.lblCreditSectionEntrySize.ForeColor = System.Drawing.Color.Red;
            this.lblCreditSectionEntrySize.Location = new System.Drawing.Point(6, 13);
            this.lblCreditSectionEntrySize.Name = "lblCreditSectionEntrySize";
            this.lblCreditSectionEntrySize.Size = new System.Drawing.Size(146, 24);
            this.lblCreditSectionEntrySize.TabIndex = 2;
            this.lblCreditSectionEntrySize.Text = "※初心者は触らないでください\r\nデータが破損する恐れあり";
            // 
            // txtLbl1EntrySize
            // 
            this.txtLbl1EntrySize.Enabled = false;
            this.txtLbl1EntrySize.Location = new System.Drawing.Point(147, 44);
            this.txtLbl1EntrySize.Name = "txtLbl1EntrySize";
            this.txtLbl1EntrySize.Size = new System.Drawing.Size(100, 19);
            this.txtLbl1EntrySize.TabIndex = 1;
            this.txtLbl1EntrySize.TextChanged += new System.EventHandler(this.TxtLbl1EntrySize_TextChanged);
            // 
            // lblLbl1EntrySize
            // 
            this.lblLbl1EntrySize.AutoSize = true;
            this.lblLbl1EntrySize.Location = new System.Drawing.Point(6, 47);
            this.lblLbl1EntrySize.Name = "lblLbl1EntrySize";
            this.lblLbl1EntrySize.Size = new System.Drawing.Size(31, 12);
            this.lblLbl1EntrySize.TabIndex = 0;
            this.lblLbl1EntrySize.Text = "LBL1";
            // 
            // tbpInfomation
            // 
            this.tbpInfomation.Controls.Add(this.gbxCurrentVersion);
            this.tbpInfomation.Controls.Add(this.lblGitHubReleasesUrl);
            this.tbpInfomation.Controls.Add(this.gbxHowToUse);
            this.tbpInfomation.Controls.Add(this.lblGitHubIssuesUrl);
            this.tbpInfomation.Controls.Add(this.llbGitHubRepositoryUrl);
            this.tbpInfomation.Controls.Add(this.llbGitHubReleasesUrl);
            this.tbpInfomation.Controls.Add(this.lblGitHubRepositoryUrl);
            this.tbpInfomation.Controls.Add(this.llbGitHubIssuesUrl);
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
            // lblGitHubReleasesUrl
            // 
            this.lblGitHubReleasesUrl.AutoSize = true;
            this.lblGitHubReleasesUrl.Location = new System.Drawing.Point(16, 62);
            this.lblGitHubReleasesUrl.Name = "lblGitHubReleasesUrl";
            this.lblGitHubReleasesUrl.Size = new System.Drawing.Size(215, 12);
            this.lblGitHubReleasesUrl.TabIndex = 1;
            this.lblGitHubReleasesUrl.Text = "このツールの最新版はこちらからお探しください";
            // 
            // gbxHowToUse
            // 
            this.gbxHowToUse.Controls.Add(this.lblSMG2HackWikiUrl);
            this.gbxHowToUse.Controls.Add(this.llbSMG2HackWikiUrl);
            this.gbxHowToUse.Controls.Add(this.lblSMG2HackDiscordUrl);
            this.gbxHowToUse.Controls.Add(this.llbSMG2HackDiscordUrl);
            this.gbxHowToUse.Location = new System.Drawing.Point(6, 154);
            this.gbxHowToUse.Name = "gbxHowToUse";
            this.gbxHowToUse.Size = new System.Drawing.Size(313, 85);
            this.gbxHowToUse.TabIndex = 6;
            this.gbxHowToUse.TabStop = false;
            this.gbxHowToUse.Text = "ツールの使い方が分からない場合はこちらを参照してください";
            // 
            // lblSMG2HackWikiUrl
            // 
            this.lblSMG2HackWikiUrl.AutoSize = true;
            this.lblSMG2HackWikiUrl.Location = new System.Drawing.Point(10, 15);
            this.lblSMG2HackWikiUrl.Name = "lblSMG2HackWikiUrl";
            this.lblSMG2HackWikiUrl.Size = new System.Drawing.Size(25, 12);
            this.lblSMG2HackWikiUrl.TabIndex = 19;
            this.lblSMG2HackWikiUrl.Text = "wiki";
            // 
            // llbSMG2HackWikiUrl
            // 
            this.llbSMG2HackWikiUrl.AutoSize = true;
            this.llbSMG2HackWikiUrl.Location = new System.Drawing.Point(10, 27);
            this.llbSMG2HackWikiUrl.Name = "llbSMG2HackWikiUrl";
            this.llbSMG2HackWikiUrl.Size = new System.Drawing.Size(290, 12);
            this.llbSMG2HackWikiUrl.TabIndex = 18;
            this.llbSMG2HackWikiUrl.TabStop = true;
            this.llbSMG2HackWikiUrl.Text = "http://mariogalaxy2hack.wiki.fc2.com/wiki/MSBT_Editor";
            this.llbSMG2HackWikiUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbSMG2HackWikiUrl_LinkClicked);
            // 
            // lblSMG2HackDiscordUrl
            // 
            this.lblSMG2HackDiscordUrl.AutoSize = true;
            this.lblSMG2HackDiscordUrl.Location = new System.Drawing.Point(10, 49);
            this.lblSMG2HackDiscordUrl.Name = "lblSMG2HackDiscordUrl";
            this.lblSMG2HackDiscordUrl.Size = new System.Drawing.Size(90, 12);
            this.lblSMG2HackDiscordUrl.TabIndex = 17;
            this.lblSMG2HackDiscordUrl.Text = "Discord招待URL";
            // 
            // llbSMG2HackDiscordUrl
            // 
            this.llbSMG2HackDiscordUrl.AutoSize = true;
            this.llbSMG2HackDiscordUrl.Location = new System.Drawing.Point(10, 61);
            this.llbSMG2HackDiscordUrl.Name = "llbSMG2HackDiscordUrl";
            this.llbSMG2HackDiscordUrl.Size = new System.Drawing.Size(150, 12);
            this.llbSMG2HackDiscordUrl.TabIndex = 16;
            this.llbSMG2HackDiscordUrl.TabStop = true;
            this.llbSMG2HackDiscordUrl.Text = "https://discord.gg/B4EwY7h";
            this.llbSMG2HackDiscordUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbSMG2HackDiscordUrl_LinkClicked);
            // 
            // lblGitHubIssuesUrl
            // 
            this.lblGitHubIssuesUrl.AutoSize = true;
            this.lblGitHubIssuesUrl.Location = new System.Drawing.Point(16, 125);
            this.lblGitHubIssuesUrl.Name = "lblGitHubIssuesUrl";
            this.lblGitHubIssuesUrl.Size = new System.Drawing.Size(83, 12);
            this.lblGitHubIssuesUrl.TabIndex = 5;
            this.lblGitHubIssuesUrl.Text = "バグ報告はこちら";
            // 
            // llbGitHubRepositoryUrl
            // 
            this.llbGitHubRepositoryUrl.AutoSize = true;
            this.llbGitHubRepositoryUrl.Location = new System.Drawing.Point(16, 104);
            this.llbGitHubRepositoryUrl.Name = "llbGitHubRepositoryUrl";
            this.llbGitHubRepositoryUrl.Size = new System.Drawing.Size(251, 12);
            this.llbGitHubRepositoryUrl.TabIndex = 2;
            this.llbGitHubRepositoryUrl.TabStop = true;
            this.llbGitHubRepositoryUrl.Text = "https://github.com/penguin117117/MSBT_Editor";
            this.llbGitHubRepositoryUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbGitHubRepositoryUrl_LinkClicked);
            // 
            // llbGitHubReleasesUrl
            // 
            this.llbGitHubReleasesUrl.AutoSize = true;
            this.llbGitHubReleasesUrl.Location = new System.Drawing.Point(16, 74);
            this.llbGitHubReleasesUrl.Name = "llbGitHubReleasesUrl";
            this.llbGitHubReleasesUrl.Size = new System.Drawing.Size(300, 12);
            this.llbGitHubReleasesUrl.TabIndex = 0;
            this.llbGitHubReleasesUrl.TabStop = true;
            this.llbGitHubReleasesUrl.Text = "https://github.com/penguin117117/MSBT_Editor/releases";
            this.llbGitHubReleasesUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbGitHubReleasesUrl_LinkClicked);
            // 
            // lblGitHubRepositoryUrl
            // 
            this.lblGitHubRepositoryUrl.AutoSize = true;
            this.lblGitHubRepositoryUrl.Location = new System.Drawing.Point(16, 92);
            this.lblGitHubRepositoryUrl.Name = "lblGitHubRepositoryUrl";
            this.lblGitHubRepositoryUrl.Size = new System.Drawing.Size(95, 12);
            this.lblGitHubRepositoryUrl.TabIndex = 3;
            this.lblGitHubRepositoryUrl.Text = "ソースコードはこちら";
            // 
            // llbGitHubIssuesUrl
            // 
            this.llbGitHubIssuesUrl.AutoSize = true;
            this.llbGitHubIssuesUrl.Location = new System.Drawing.Point(16, 137);
            this.llbGitHubIssuesUrl.Name = "llbGitHubIssuesUrl";
            this.llbGitHubIssuesUrl.Size = new System.Drawing.Size(290, 12);
            this.llbGitHubIssuesUrl.TabIndex = 4;
            this.llbGitHubIssuesUrl.TabStop = true;
            this.llbGitHubIssuesUrl.Text = "https://github.com/penguin117117/MSBT_Editor/issues";
            this.llbGitHubIssuesUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbGitHubIssuesUrl_LinkClicked);
            // 
            // lstListsInsideFen1
            // 
            this.lstListsInsideFen1.FormattingEnabled = true;
            this.lstListsInsideFen1.ItemHeight = 12;
            this.lstListsInsideFen1.Location = new System.Drawing.Point(216, 243);
            this.lstListsInsideFen1.Name = "lstListsInsideFen1";
            this.lstListsInsideFen1.ScrollAlwaysVisible = true;
            this.lstListsInsideFen1.Size = new System.Drawing.Size(204, 208);
            this.lstListsInsideFen1.TabIndex = 0;
            this.lstListsInsideFen1.SelectedIndexChanged += new System.EventHandler(this.LstListsInsideFen1_SelectedIndexChanged);
            // 
            // lstListsInsideFlw2
            // 
            this.lstListsInsideFlw2.FormattingEnabled = true;
            this.lstListsInsideFlw2.ItemHeight = 12;
            this.lstListsInsideFlw2.Location = new System.Drawing.Point(218, 27);
            this.lstListsInsideFlw2.Name = "lstListsInsideFlw2";
            this.lstListsInsideFlw2.ScrollAlwaysVisible = true;
            this.lstListsInsideFlw2.Size = new System.Drawing.Size(204, 196);
            this.lstListsInsideFlw2.TabIndex = 0;
            this.lstListsInsideFlw2.SelectedIndexChanged += new System.EventHandler(this.LstListsInsideFlw2_SelectedIndexChanged);
            // 
            // lblMsbt
            // 
            this.lblMsbt.AutoSize = true;
            this.lblMsbt.Location = new System.Drawing.Point(6, 14);
            this.lblMsbt.Name = "lblMsbt";
            this.lblMsbt.Size = new System.Drawing.Size(36, 12);
            this.lblMsbt.TabIndex = 7;
            this.lblMsbt.Text = "MSBT";
            // 
            // lblFlw2
            // 
            this.lblFlw2.AutoSize = true;
            this.lblFlw2.Location = new System.Drawing.Point(218, 14);
            this.lblFlw2.Name = "lblFlw2";
            this.lblFlw2.Size = new System.Drawing.Size(33, 12);
            this.lblFlw2.TabIndex = 8;
            this.lblFlw2.Text = "FLW2";
            // 
            // lblFen1
            // 
            this.lblFen1.AutoSize = true;
            this.lblFen1.Location = new System.Drawing.Point(218, 226);
            this.lblFen1.Name = "lblFen1";
            this.lblFen1.Size = new System.Drawing.Size(33, 12);
            this.lblFen1.TabIndex = 9;
            this.lblFen1.Text = "FEN1";
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
            // lblMsbtListSelectIndex
            // 
            this.lblMsbtListSelectIndex.AutoSize = true;
            this.lblMsbtListSelectIndex.Location = new System.Drawing.Point(187, 14);
            this.lblMsbtListSelectIndex.Name = "lblMsbtListSelectIndex";
            this.lblMsbtListSelectIndex.Size = new System.Drawing.Size(23, 12);
            this.lblMsbtListSelectIndex.TabIndex = 11;
            this.lblMsbtListSelectIndex.Text = "null";
            // 
            // lblFlw2ListSelectIndex
            // 
            this.lblFlw2ListSelectIndex.AutoSize = true;
            this.lblFlw2ListSelectIndex.Location = new System.Drawing.Point(399, 14);
            this.lblFlw2ListSelectIndex.Name = "lblFlw2ListSelectIndex";
            this.lblFlw2ListSelectIndex.Size = new System.Drawing.Size(23, 12);
            this.lblFlw2ListSelectIndex.TabIndex = 12;
            this.lblFlw2ListSelectIndex.Text = "null";
            // 
            // lblFen1ListSelectIndex
            // 
            this.lblFen1ListSelectIndex.AutoSize = true;
            this.lblFen1ListSelectIndex.Location = new System.Drawing.Point(397, 226);
            this.lblFen1ListSelectIndex.Name = "lblFen1ListSelectIndex";
            this.lblFen1ListSelectIndex.Size = new System.Drawing.Size(23, 12);
            this.lblFen1ListSelectIndex.TabIndex = 13;
            this.lblFen1ListSelectIndex.Text = "null";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tbpFilesInsideRarc);
            this.tabControl3.Controls.Add(this.tbpListsInsideMsb);
            this.tabControl3.Location = new System.Drawing.Point(12, 28);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(438, 483);
            this.tabControl3.TabIndex = 14;
            // 
            // tbpFilesInsideRarc
            // 
            this.tbpFilesInsideRarc.Controls.Add(this.chkMsbAutoSave);
            this.tbpFilesInsideRarc.Controls.Add(this.lblSaveSystemDiscription);
            this.tbpFilesInsideRarc.Controls.Add(this.lstFilesInsideRarc);
            this.tbpFilesInsideRarc.Location = new System.Drawing.Point(4, 22);
            this.tbpFilesInsideRarc.Name = "tbpFilesInsideRarc";
            this.tbpFilesInsideRarc.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFilesInsideRarc.Size = new System.Drawing.Size(430, 457);
            this.tbpFilesInsideRarc.TabIndex = 0;
            this.tbpFilesInsideRarc.Text = "ARCファイルの中身";
            this.tbpFilesInsideRarc.UseVisualStyleBackColor = true;
            // 
            // chkMsbAutoSave
            // 
            this.chkMsbAutoSave.AutoSize = true;
            this.chkMsbAutoSave.Location = new System.Drawing.Point(214, 268);
            this.chkMsbAutoSave.Name = "chkMsbAutoSave";
            this.chkMsbAutoSave.Size = new System.Drawing.Size(215, 16);
            this.chkMsbAutoSave.TabIndex = 2;
            this.chkMsbAutoSave.Text = "(MSBT, MSBF) オートセーブ/AutoSave";
            this.chkMsbAutoSave.UseVisualStyleBackColor = true;
            this.chkMsbAutoSave.CheckedChanged += new System.EventHandler(this.ChkMsbAutoSave_CheckedChanged);
            // 
            // lblSaveSystemDiscription
            // 
            this.lblSaveSystemDiscription.AutoSize = true;
            this.lblSaveSystemDiscription.Location = new System.Drawing.Point(6, 287);
            this.lblSaveSystemDiscription.Name = "lblSaveSystemDiscription";
            this.lblSaveSystemDiscription.Size = new System.Drawing.Size(235, 72);
            this.lblSaveSystemDiscription.TabIndex = 1;
            this.lblSaveSystemDiscription.Text = "ARCファイルから開いたMSBTやMSBFの\r\n内容を変更した際は、上書き保存をしてください。\r\n上書き保存してからリストを選択し直さないと、\r\n変更が保存されま" +
    "せん。\r\n全ての変更が終わったらARCを保存してください。\r\n※MSBT, MSBF以外は表示されません";
            // 
            // lstFilesInsideRarc
            // 
            this.lstFilesInsideRarc.FormattingEnabled = true;
            this.lstFilesInsideRarc.ItemHeight = 12;
            this.lstFilesInsideRarc.Location = new System.Drawing.Point(6, 6);
            this.lstFilesInsideRarc.Name = "lstFilesInsideRarc";
            this.lstFilesInsideRarc.Size = new System.Drawing.Size(418, 256);
            this.lstFilesInsideRarc.TabIndex = 0;
            this.lstFilesInsideRarc.SelectedIndexChanged += new System.EventHandler(this.LstFilesInsideRarc_SelectedIndexChanged);
            this.lstFilesInsideRarc.SelectedValueChanged += new System.EventHandler(this.LstFilesInsideRarc_SelectedValueChanged);
            this.lstFilesInsideRarc.CursorChanged += new System.EventHandler(this.LstFilesInsideRarc_CursorChanged);
            this.lstFilesInsideRarc.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.LstFilesInsideRarc_ChangeUICues);
            this.lstFilesInsideRarc.Validating += new System.ComponentModel.CancelEventHandler(this.LstFilesInsideRarc_Validating);
            // 
            // tbpListsInsideMsb
            // 
            this.tbpListsInsideMsb.Controls.Add(this.lblMsbt);
            this.tbpListsInsideMsb.Controls.Add(this.lblFen1ListSelectIndex);
            this.tbpListsInsideMsb.Controls.Add(this.lblFlw2ListSelectIndex);
            this.tbpListsInsideMsb.Controls.Add(this.lstListsInsideMsbt);
            this.tbpListsInsideMsb.Controls.Add(this.lblFen1);
            this.tbpListsInsideMsb.Controls.Add(this.lstListsInsideFlw2);
            this.tbpListsInsideMsb.Controls.Add(this.lblMsbtListSelectIndex);
            this.tbpListsInsideMsb.Controls.Add(this.lstListsInsideFen1);
            this.tbpListsInsideMsb.Controls.Add(this.lblFlw2);
            this.tbpListsInsideMsb.Location = new System.Drawing.Point(4, 22);
            this.tbpListsInsideMsb.Name = "tbpListsInsideMsb";
            this.tbpListsInsideMsb.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListsInsideMsb.Size = new System.Drawing.Size(430, 457);
            this.tbpListsInsideMsb.TabIndex = 1;
            this.tbpListsInsideMsb.Text = "MSBTとMSBF";
            this.tbpListsInsideMsb.UseVisualStyleBackColor = true;
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
            this.stbStatusBar.ResumeLayout(false);
            this.stbStatusBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpMsbtSetting.ResumeLayout(false);
            this.gbxMsbtSettingAtr1.ResumeLayout(false);
            this.gbxMsbtSettingAtr1.PerformLayout();
            this.tbpMsbtTextEdit.ResumeLayout(false);
            this.tbpMsbtTextEdit.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tbpGeneralTag.ResumeLayout(false);
            this.tbpValueTag.ResumeLayout(false);
            this.gbxTimerTag.ResumeLayout(false);
            this.gbxTimerTag.PerformLayout();
            this.gbxRubiTag.ResumeLayout(false);
            this.gbxRubiTag.PerformLayout();
            this.tbpSpecialTag.ResumeLayout(false);
            this.gbxSpecialTag.ResumeLayout(false);
            this.tbpIconTag.ResumeLayout(false);
            this.tbpIconTag.PerformLayout();
            this.AdvancedTagTabPage.ResumeLayout(false);
            this.gbxSoundEffectTag.ResumeLayout(false);
            this.gbxSoundEffectTag.PerformLayout();
            this.gbxCustomIconTag.ResumeLayout(false);
            this.gbxCustomIconTag.PerformLayout();
            this.tbpListEdit.ResumeLayout(false);
            this.gbxListEditFen1.ResumeLayout(false);
            this.gbxListEditFen1.PerformLayout();
            this.gbxListEditFlw2.ResumeLayout(false);
            this.gbxListEditFlw2.PerformLayout();
            this.gbxListEditMsbt.ResumeLayout(false);
            this.gbxListEditMsbt.PerformLayout();
            this.tbpMsbfSetting.ResumeLayout(false);
            this.tbpMsbfSetting.PerformLayout();
            this.gbxFen1.ResumeLayout(false);
            this.gbxFen1.PerformLayout();
            this.gbxFlw2.ResumeLayout(false);
            this.gbxFlw2.PerformLayout();
            this.gbxFlw2Branch.ResumeLayout(false);
            this.gbxFlw2Branch.PerformLayout();
            this.tbpDebugMsbf.ResumeLayout(false);
            this.tbpDebugMsbf.PerformLayout();
            this.tbpDebug.ResumeLayout(false);
            this.tbpDebug.PerformLayout();
            this.tbpCredit.ResumeLayout(false);
            this.tbpCredit.PerformLayout();
            this.gbxCreditLbl1.ResumeLayout(false);
            this.gbxCreditLbl1.PerformLayout();
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
            this.tbpFilesInsideRarc.ResumeLayout(false);
            this.tbpFilesInsideRarc.PerformLayout();
            this.tbpListsInsideMsb.ResumeLayout(false);
            this.tbpListsInsideMsb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stbStatusBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.TextBox txtMsbtText;
        public System.Windows.Forms.ListBox lstListsInsideMsbt;
        public System.Windows.Forms.ToolStripStatusLabel stbOpenedMsbtName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel stbOpenedMsbfName;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtAtr1SpecialTextOffset;
        private System.Windows.Forms.TextBox txtAtr1Unknown6;
        private System.Windows.Forms.TextBox txtAtr1MessageAreaID;
        private System.Windows.Forms.TextBox txtAtr1EventCameraID;
        private System.Windows.Forms.TextBox txtAtr1WindowID;
        private System.Windows.Forms.TextBox txtAtr1DialogID;
        private System.Windows.Forms.TextBox txtAtr1SimpleCamID;
        private System.Windows.Forms.TextBox txtAtr1SoundID;
        private System.Windows.Forms.TextBox txtLbl1TagIndex;
        public System.Windows.Forms.TextBox txtFlw2DebugHex;
        public System.Windows.Forms.TextBox txtAtr1SpecialText;
        public System.Windows.Forms.TextBox MSBT_Debug_Text;
        private System.Windows.Forms.TabPage tbpDebugMsbf;
        private System.Windows.Forms.TextBox txtMsbtListName;
        private System.Windows.Forms.GroupBox gbxCreditLbl1;
        private System.Windows.Forms.Label lblLbl1EntrySize;
        public System.Windows.Forms.TextBox txtLbl1EntrySize;
        private System.Windows.Forms.Label lblAtr1EntrySize;
        public System.Windows.Forms.TextBox txtAtr1EntrySize;
        private System.Windows.Forms.Button btnReleaseDebugTextFile;
        private System.Windows.Forms.TextBox txtFlw2BranchFalse;
        private System.Windows.Forms.TextBox txtFlw2BranchTrue;
        private System.Windows.Forms.GroupBox gbxFlw2;
        public System.Windows.Forms.TextBox txtFlw2Arg4;
        public System.Windows.Forms.TextBox txtFlw2Arg3;
        public System.Windows.Forms.TextBox txtFlw2Arg2;
        public System.Windows.Forms.TextBox txtFlw2Arg1;
        public System.Windows.Forms.TextBox txtFlw2Padding;
        public System.Windows.Forms.TextBox txtFlw2FlowType;
        public System.Windows.Forms.ListBox lstListsInsideFlw2;
        private System.Windows.Forms.TabPage tbpDebug;
        public System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.GroupBox gbxFen1;
        public System.Windows.Forms.ListBox lstListsInsideFen1;
        private System.Windows.Forms.TextBox txtFen1StartIndex;
        private System.Windows.Forms.TextBox txtFen1Arg0;
        private System.Windows.Forms.GroupBox gbxListEditMsbt;
        public System.Windows.Forms.Label lblFlw2Arg4;
        public System.Windows.Forms.Label lblFlw2Arg3;
        public System.Windows.Forms.Label lblFlw2Arg2;
        public System.Windows.Forms.Label lblFlw2Arg1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox gbxListEditFen1;
        private System.Windows.Forms.TextBox txtFen1ListName;
        private System.Windows.Forms.GroupBox gbxListEditFlw2;
        private System.Windows.Forms.TextBox txtSelectedMsbtListName;
        private System.Windows.Forms.Label lblMsbt;
        private System.Windows.Forms.Label lblFlw2;
        private System.Windows.Forms.Label lblFen1;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblLanguage;
        public System.Windows.Forms.ToolStripStatusLabel stbStatusLabel;
        public System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Msbt上書き保存ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Msbt保存ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Msbf開くToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Msbf上書き保存ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Msbf保存ToolStripMenuItem;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tbpMsbtSetting;
        public System.Windows.Forms.TabPage tbpMsbtTextEdit;
        public System.Windows.Forms.TabPage tbpListEdit;
        public System.Windows.Forms.TabPage tbpMsbfSetting;
        public System.Windows.Forms.Label lblAtr1SpecialTextOffset;
        public System.Windows.Forms.Label lblAtr1Unknown6;
        public System.Windows.Forms.Label lblAtr1MessageAreaID;
        public System.Windows.Forms.Label lblAtr1EventCameraID;
        public System.Windows.Forms.Label lblAtr1WindowID;
        public System.Windows.Forms.Label lblAtr1DialogID;
        public System.Windows.Forms.Label lblAtr1SimpleCamID;
        public System.Windows.Forms.Label lblAtr1SoundID;
        public System.Windows.Forms.Label lblAtr1SpecialText;
        public System.Windows.Forms.Label lblLbl1TagIndex;
        public System.Windows.Forms.Label lblCreditLbl1Note;
        public System.Windows.Forms.Label lblFlw2BranchFalse;
        public System.Windows.Forms.Label lblFlw2BranchTrue;
        public System.Windows.Forms.Label lblFlw2Padding;
        public System.Windows.Forms.Label lblFlw2FlowType;
        public System.Windows.Forms.Label lblFlw2StartIndex;
        public System.Windows.Forms.Label lblFen1Arg0;
        public System.Windows.Forms.GroupBox gbxFlw2Branch;
        private System.Windows.Forms.Label lblFlw2RightAngleSymbol;
        public System.Windows.Forms.Label lblCreditSectionEntrySize;
        public System.Windows.Forms.Button btnAddMsbtList;
        public System.Windows.Forms.Button btnDeleteMsbtList;
        public System.Windows.Forms.Label lblMsbtListEditNote;
        public System.Windows.Forms.Label lblMsbtListEditDiscription;
        public System.Windows.Forms.Label lblMsbtListName;
        public System.Windows.Forms.Button btnDeleteFen1List;
        public System.Windows.Forms.Button btnAddFen1List;
        public System.Windows.Forms.Label lblFen1ListName;
        public System.Windows.Forms.Button btnDeleteFlw2List;
        public System.Windows.Forms.Button btnAddFlw2List;
        public System.Windows.Forms.Label lblFlw2ListEditDiscription;
        public System.Windows.Forms.TabControl tabControl2;
        public System.Windows.Forms.TabPage tbpGeneralTag;
        public System.Windows.Forms.TabPage tbpValueTag;
        public System.Windows.Forms.TabPage tbpSpecialTag;
        public System.Windows.Forms.TabPage tbpIconTag;
        public System.Windows.Forms.ComboBox cmbColorTag;
        public System.Windows.Forms.ComboBox cmbLineControlTag;
        public System.Windows.Forms.ComboBox cmbFontSizeTag;
        public System.Windows.Forms.ComboBox cmbCenterTag;
        public System.Windows.Forms.Button btnInsertColorTag;
        public System.Windows.Forms.Button btnInsertLineControlTag;
        public System.Windows.Forms.Button btnInsertFontSizeTag;
        public System.Windows.Forms.Button btnInsertCenterTag;
        private System.Windows.Forms.Label lblMsbtListSelectIndex;
        private System.Windows.Forms.Label lblFlw2ListSelectIndex;
        private System.Windows.Forms.Label lblFen1ListSelectIndex;
        public System.Windows.Forms.GroupBox gbxCreditSectionEntrySize;
        public System.Windows.Forms.Label lblMsbfSettingNote;
        public System.Windows.Forms.TreeView tvwMsbfFlow;
        public System.Windows.Forms.TextBox txtUnknownTag;
        private System.Windows.Forms.Button btnCalculateHash;
        private System.Windows.Forms.TextBox txtListNameToCalculateHash;
        private System.Windows.Forms.Label lblMsbfFlow;
        public System.Windows.Forms.ComboBox cmbCharacterIconTag;
        public System.Windows.Forms.ComboBox cmbObjectIconTag;
        public System.Windows.Forms.ComboBox cmbOtherIconTag;
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
        public System.Windows.Forms.Button btnInsertNumbersBelowDecimalPointTag;
        public System.Windows.Forms.Button btnInsertCharacterIconTag;
        public System.Windows.Forms.Label lblCharacterIconTag;
        public System.Windows.Forms.Button btnInsertObjectIconTag;
        public System.Windows.Forms.Label lblObjectIconTag;
        public System.Windows.Forms.Button btnInsertOtherIconTag;
        public System.Windows.Forms.Label lblOtherIconTag;
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
        private System.Windows.Forms.Label lblCreditHiiragi;
        private System.Windows.Forms.Label lblCreditEigen;
        private System.Windows.Forms.Label lblCreditDossun;
        private System.Windows.Forms.Label lblCreditXenon;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripStatusLabel stbSavedFilePathLabel;
        public System.Windows.Forms.ToolStripStatusLabel stbSavedFilePath;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox txtReadOnlyMsbtText;
        private System.Windows.Forms.Button btnReloadTvwMsbfFlow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.CheckBox chkShowTvwMsbfFlow;
        private System.Windows.Forms.Label lblMsbfHashCalculator;
        private System.Windows.Forms.Label lblDebuggerAcknowledgment;
        private System.Windows.Forms.Label lblCreditContributorAcknowledgment;
        private System.Windows.Forms.TabPage tbpListsInsideMsb;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        public System.Windows.Forms.ToolStripStatusLabel stbOpenedRarcName;
        private System.Windows.Forms.TextBox txtCustomIconHex;
        private System.Windows.Forms.TextBox txtSoundEffectName;
        public System.Windows.Forms.ListBox lstFilesInsideRarc;
        public System.Windows.Forms.Label lblSaveSystemDiscription;
        public System.Windows.Forms.GroupBox gbxMsbtSettingAtr1;
        public System.Windows.Forms.TabPage AdvancedTagTabPage;
        private System.Windows.Forms.GroupBox gbxCreditDebuggerVIP;
        private System.Windows.Forms.GroupBox gbxCreditContributor;
        private System.Windows.Forms.GroupBox gbxHowToUse;
        private System.Windows.Forms.Label lblSMG2HackWikiUrl;
        private System.Windows.Forms.LinkLabel llbSMG2HackWikiUrl;
        private System.Windows.Forms.Label lblSMG2HackDiscordUrl;
        private System.Windows.Forms.LinkLabel llbSMG2HackDiscordUrl;
        private System.Windows.Forms.Label lblGitHubIssuesUrl;
        private System.Windows.Forms.LinkLabel llbGitHubIssuesUrl;
        private System.Windows.Forms.Label lblGitHubRepositoryUrl;
        private System.Windows.Forms.LinkLabel llbGitHubRepositoryUrl;
        private System.Windows.Forms.Label lblGitHubReleasesUrl;
        private System.Windows.Forms.LinkLabel llbGitHubReleasesUrl;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.GroupBox gbxCurrentVersion;
        public System.Windows.Forms.ToolStripMenuItem Arc開くToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Arc上書き保存ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Arc保存ToolStripMenuItem;
        public System.Windows.Forms.TabControl tabControl3;
        public System.Windows.Forms.TabPage tbpFilesInsideRarc;
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
        private System.Windows.Forms.Button btnTextSort;
        private System.Windows.Forms.Label lblRubiTagDiscription;
        private System.Windows.Forms.CheckBox chkMsbAutoSave;
        private System.Windows.Forms.TextBox textBox1;
    }
}

