namespace v2rayN.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lvServers = new v2rayN.Base.ListViewFlickerFree();
            this.cmsLv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStartNewServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStopServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCopyServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemoveServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemMove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveTop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRemoveDuplicateServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemTest = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPingServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTcpingServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRealPingServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSpeedServer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbTestMe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClearServerStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport2ClientConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport2ServerConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport2ShareUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport2SubContent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemShare = new System.Windows.Forms.ToolStripMenuItem();
            this.qrCodeControl = new v2rayN.Forms.QRCodeControl();
            this.tsbServer = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuAddVmessLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddVlessLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddShadowsocksLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddSocksLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddTrojanLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddCustomLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBulkAddLines = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScanScreenAddLines = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbMsgTitle = new System.Windows.Forms.GroupBox();
            this.txtMsgBox = new System.Windows.Forms.TextBox();
            this.cmsMsgBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuMsgBoxSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMsgBoxCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMsgBoxCopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMsgBoxAddRoutingRule = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMsgBoxFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssServerStateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslBlank2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslServerSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslBlank4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSysAgentMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKeepClear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGlobal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKeepNothing = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRoutings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServers2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAddServers2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScanScreen2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdateSubscriptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwScan = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSub = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbSubSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbSubUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSetting = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuItemRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOptionSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRoutingSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBackupGuiNConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUpdateCore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemGeoSite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGeoIP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbV2rayWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLanguageDef = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbLanguageZhHans = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.cmsLv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbMsgTitle.SuspendLayout();
            this.cmsMsgBox.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.cmsMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            resources.ApplyResources(this.scMain, "scMain");
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.lvServers);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.qrCodeControl);
            this.scMain.TabStop = false;
            // 
            // lvServers
            // 
            this.lvServers.ContextMenuStrip = this.cmsLv;
            resources.ApplyResources(this.lvServers, "lvServers");
            this.lvServers.FullRowSelect = true;
            this.lvServers.GridLines = true;
            this.lvServers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvServers.HideSelection = false;
            this.lvServers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvServers.Items")))});
            this.lvServers.MultiSelect = false;
            this.lvServers.Name = "lvServers";
            this.lvServers.UseCompatibleStateImageBehavior = false;
            this.lvServers.View = System.Windows.Forms.View.Details;
            this.lvServers.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvServers_ColumnClick);
            this.lvServers.SelectedIndexChanged += new System.EventHandler(this.lvServers_SelectedIndexChanged);
            this.lvServers.Click += new System.EventHandler(this.lvServers_Click);
            this.lvServers.DoubleClick += new System.EventHandler(this.lvServers_DoubleClick);
            this.lvServers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvServers_KeyDown);
            // 
            // cmsLv
            // 
            this.cmsLv.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStartNewServer,
            this.menuStopServer,
            this.toolStripSeparator1,
            this.menuCopyServer,
            this.menuRemoveServer,
            this.toolStripSeparator10,
            this.menuItemMove,
            this.toolStripSeparator3,
            this.menuRemoveDuplicateServer,
            this.menuSelectAll,
            this.toolStripSeparator9,
            this.menuItemTest,
            this.menuClearServerStatistics,
            this.toolStripSeparator6,
            this.menuItemExport,
            this.menuItemShare});
            this.cmsLv.Name = "cmsLv";
            resources.ApplyResources(this.cmsLv, "cmsLv");
            // 
            // menuStartNewServer
            // 
            this.menuStartNewServer.Name = "menuStartNewServer";
            resources.ApplyResources(this.menuStartNewServer, "menuStartNewServer");
            this.menuStartNewServer.Click += new System.EventHandler(this.menuStartNewServer_Click);
            // 
            // menuStopServer
            // 
            this.menuStopServer.Name = "menuStopServer";
            resources.ApplyResources(this.menuStopServer, "menuStopServer");
            this.menuStopServer.Click += new System.EventHandler(this.menuStopServer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // menuCopyServer
            // 
            this.menuCopyServer.Name = "menuCopyServer";
            resources.ApplyResources(this.menuCopyServer, "menuCopyServer");
            this.menuCopyServer.Click += new System.EventHandler(this.menuCopyServer_Click);
            // 
            // menuRemoveServer
            // 
            this.menuRemoveServer.Name = "menuRemoveServer";
            resources.ApplyResources(this.menuRemoveServer, "menuRemoveServer");
            this.menuRemoveServer.Click += new System.EventHandler(this.menuRemoveServer_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            // 
            // menuItemMove
            // 
            this.menuItemMove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMoveTop,
            this.menuMoveUp,
            this.menuMoveDown,
            this.menuMoveBottom});
            this.menuItemMove.Name = "menuItemMove";
            resources.ApplyResources(this.menuItemMove, "menuItemMove");
            // 
            // menuMoveTop
            // 
            this.menuMoveTop.Name = "menuMoveTop";
            resources.ApplyResources(this.menuMoveTop, "menuMoveTop");
            this.menuMoveTop.Click += new System.EventHandler(this.menuMoveTop_Click);
            // 
            // menuMoveUp
            // 
            this.menuMoveUp.Name = "menuMoveUp";
            resources.ApplyResources(this.menuMoveUp, "menuMoveUp");
            this.menuMoveUp.Click += new System.EventHandler(this.menuMoveUp_Click);
            // 
            // menuMoveDown
            // 
            this.menuMoveDown.Name = "menuMoveDown";
            resources.ApplyResources(this.menuMoveDown, "menuMoveDown");
            this.menuMoveDown.Click += new System.EventHandler(this.menuMoveDown_Click);
            // 
            // menuMoveBottom
            // 
            this.menuMoveBottom.Name = "menuMoveBottom";
            resources.ApplyResources(this.menuMoveBottom, "menuMoveBottom");
            this.menuMoveBottom.Click += new System.EventHandler(this.menuMoveBottom_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // menuRemoveDuplicateServer
            // 
            this.menuRemoveDuplicateServer.Name = "menuRemoveDuplicateServer";
            resources.ApplyResources(this.menuRemoveDuplicateServer, "menuRemoveDuplicateServer");
            this.menuRemoveDuplicateServer.Click += new System.EventHandler(this.menuRemoveDuplicateServer_Click);
            // 
            // menuSelectAll
            // 
            this.menuSelectAll.Name = "menuSelectAll";
            resources.ApplyResources(this.menuSelectAll, "menuSelectAll");
            this.menuSelectAll.Click += new System.EventHandler(this.menuSelectAll_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // menuItemTest
            // 
            this.menuItemTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPingServer,
            this.menuTcpingServer,
            this.menuRealPingServer,
            this.menuSpeedServer,
            this.tsbTestMe});
            this.menuItemTest.Name = "menuItemTest";
            resources.ApplyResources(this.menuItemTest, "menuItemTest");
            // 
            // menuPingServer
            // 
            this.menuPingServer.Name = "menuPingServer";
            resources.ApplyResources(this.menuPingServer, "menuPingServer");
            this.menuPingServer.Click += new System.EventHandler(this.menuPingServer_Click);
            // 
            // menuTcpingServer
            // 
            this.menuTcpingServer.Name = "menuTcpingServer";
            resources.ApplyResources(this.menuTcpingServer, "menuTcpingServer");
            this.menuTcpingServer.Click += new System.EventHandler(this.menuTcpingServer_Click);
            // 
            // menuRealPingServer
            // 
            this.menuRealPingServer.Name = "menuRealPingServer";
            resources.ApplyResources(this.menuRealPingServer, "menuRealPingServer");
            this.menuRealPingServer.Click += new System.EventHandler(this.menuRealPingServer_Click);
            // 
            // menuSpeedServer
            // 
            this.menuSpeedServer.Name = "menuSpeedServer";
            resources.ApplyResources(this.menuSpeedServer, "menuSpeedServer");
            this.menuSpeedServer.Click += new System.EventHandler(this.menuSpeedServer_Click);
            // 
            // tsbTestMe
            // 
            this.tsbTestMe.Name = "tsbTestMe";
            resources.ApplyResources(this.tsbTestMe, "tsbTestMe");
            this.tsbTestMe.Click += new System.EventHandler(this.tsbTestMe_Click);
            // 
            // menuClearServerStatistics
            // 
            this.menuClearServerStatistics.Name = "menuClearServerStatistics";
            resources.ApplyResources(this.menuClearServerStatistics, "menuClearServerStatistics");
            this.menuClearServerStatistics.Click += new System.EventHandler(this.menuClearStatistic_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // menuItemExport
            // 
            this.menuItemExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExport2ClientConfig,
            this.menuExport2ServerConfig,
            this.menuExport2ShareUrl,
            this.menuExport2SubContent});
            this.menuItemExport.Name = "menuItemExport";
            resources.ApplyResources(this.menuItemExport, "menuItemExport");
            // 
            // menuExport2ClientConfig
            // 
            this.menuExport2ClientConfig.Name = "menuExport2ClientConfig";
            resources.ApplyResources(this.menuExport2ClientConfig, "menuExport2ClientConfig");
            this.menuExport2ClientConfig.Click += new System.EventHandler(this.menuExport2ClientConfig_Click);
            // 
            // menuExport2ServerConfig
            // 
            this.menuExport2ServerConfig.Name = "menuExport2ServerConfig";
            resources.ApplyResources(this.menuExport2ServerConfig, "menuExport2ServerConfig");
            this.menuExport2ServerConfig.Click += new System.EventHandler(this.menuExport2ServerConfig_Click);
            // 
            // menuExport2ShareUrl
            // 
            this.menuExport2ShareUrl.Name = "menuExport2ShareUrl";
            resources.ApplyResources(this.menuExport2ShareUrl, "menuExport2ShareUrl");
            this.menuExport2ShareUrl.Click += new System.EventHandler(this.menuExport2ShareUrl_Click);
            // 
            // menuExport2SubContent
            // 
            this.menuExport2SubContent.Name = "menuExport2SubContent";
            resources.ApplyResources(this.menuExport2SubContent, "menuExport2SubContent");
            this.menuExport2SubContent.Click += new System.EventHandler(this.menuExport2SubContent_Click);
            // 
            // menuItemShare
            // 
            this.menuItemShare.Image = global::v2rayN.Properties.Resources.share;
            this.menuItemShare.Name = "menuItemShare";
            resources.ApplyResources(this.menuItemShare, "menuItemShare");
            this.menuItemShare.Click += new System.EventHandler(this.menuItemShare_Click);
            // 
            // qrCodeControl
            // 
            resources.ApplyResources(this.qrCodeControl, "qrCodeControl");
            this.qrCodeControl.Name = "qrCodeControl";
            // 
            // tsbServer
            // 
            this.tsbServer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddVmessLine,
            this.menuAddVlessLine,
            this.menuAddShadowsocksLine,
            this.menuAddSocksLine,
            this.menuAddTrojanLine,
            this.menuAddCustomLine,
            this.menuBulkAddLines,
            this.menuScanScreenAddLines});
            this.tsbServer.Image = global::v2rayN.Properties.Resources.server;
            resources.ApplyResources(this.tsbServer, "tsbServer");
            this.tsbServer.Name = "tsbServer";
            // 
            // menuAddVmessLine
            // 
            this.menuAddVmessLine.Name = "menuAddVmessLine";
            resources.ApplyResources(this.menuAddVmessLine, "menuAddVmessLine");
            this.menuAddVmessLine.Click += new System.EventHandler(this.menuAddVmessLine_Click);
            // 
            // menuAddVlessLine
            // 
            this.menuAddVlessLine.Name = "menuAddVlessLine";
            resources.ApplyResources(this.menuAddVlessLine, "menuAddVlessLine");
            this.menuAddVlessLine.Click += new System.EventHandler(this.menuAddVlessLine_Click);
            // 
            // menuAddShadowsocksLine
            // 
            this.menuAddShadowsocksLine.Name = "menuAddShadowsocksLine";
            resources.ApplyResources(this.menuAddShadowsocksLine, "menuAddShadowsocksLine");
            this.menuAddShadowsocksLine.Click += new System.EventHandler(this.menuAddShadowsocksLine_Click);
            // 
            // menuAddSocksLine
            // 
            this.menuAddSocksLine.Name = "menuAddSocksLine";
            resources.ApplyResources(this.menuAddSocksLine, "menuAddSocksLine");
            this.menuAddSocksLine.Click += new System.EventHandler(this.menuAddSocksLine_Click);
            // 
            // menuAddTrojanLine
            // 
            this.menuAddTrojanLine.Name = "menuAddTrojanLine";
            resources.ApplyResources(this.menuAddTrojanLine, "menuAddTrojanLine");
            this.menuAddTrojanLine.Click += new System.EventHandler(this.menuAddTrojanLine_Click);
            // 
            // menuAddCustomLine
            // 
            this.menuAddCustomLine.Name = "menuAddCustomLine";
            resources.ApplyResources(this.menuAddCustomLine, "menuAddCustomLine");
            this.menuAddCustomLine.Click += new System.EventHandler(this.menuAddCustomLine_Click);
            // 
            // menuBulkAddLines
            // 
            this.menuBulkAddLines.Name = "menuBulkAddLines";
            resources.ApplyResources(this.menuBulkAddLines, "menuBulkAddLines");
            this.menuBulkAddLines.Click += new System.EventHandler(this.menuBulkAddLines_Click);
            // 
            // menuScanScreenAddLines
            // 
            this.menuScanScreenAddLines.Name = "menuScanScreenAddLines";
            resources.ApplyResources(this.menuScanScreenAddLines, "menuScanScreenAddLines");
            this.menuScanScreenAddLines.Click += new System.EventHandler(this.menuScanScreenAddLines_Click);
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbMsgTitle);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scMain);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // gbMsgTitle
            // 
            this.gbMsgTitle.Controls.Add(this.txtMsgBox);
            this.gbMsgTitle.Controls.Add(this.ssMain);
            resources.ApplyResources(this.gbMsgTitle, "gbMsgTitle");
            this.gbMsgTitle.Name = "gbMsgTitle";
            this.gbMsgTitle.TabStop = false;
            // 
            // txtMsgBox
            // 
            this.txtMsgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtMsgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsgBox.ContextMenuStrip = this.cmsMsgBox;
            resources.ApplyResources(this.txtMsgBox, "txtMsgBox");
            this.txtMsgBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.txtMsgBox.Name = "txtMsgBox";
            this.txtMsgBox.ReadOnly = true;
            this.txtMsgBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMsgBox_KeyDown);
            // 
            // cmsMsgBox
            // 
            this.cmsMsgBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMsgBoxSelectAll,
            this.menuMsgBoxCopy,
            this.menuMsgBoxCopyAll,
            this.menuMsgBoxAddRoutingRule,
            this.menuMsgBoxFilter});
            this.cmsMsgBox.Name = "cmsMsgBox";
            resources.ApplyResources(this.cmsMsgBox, "cmsMsgBox");
            // 
            // menuMsgBoxSelectAll
            // 
            this.menuMsgBoxSelectAll.Name = "menuMsgBoxSelectAll";
            resources.ApplyResources(this.menuMsgBoxSelectAll, "menuMsgBoxSelectAll");
            this.menuMsgBoxSelectAll.Click += new System.EventHandler(this.menuMsgBoxSelectAll_Click);
            // 
            // menuMsgBoxCopy
            // 
            this.menuMsgBoxCopy.Name = "menuMsgBoxCopy";
            resources.ApplyResources(this.menuMsgBoxCopy, "menuMsgBoxCopy");
            this.menuMsgBoxCopy.Click += new System.EventHandler(this.menuMsgBoxCopy_Click);
            // 
            // menuMsgBoxCopyAll
            // 
            this.menuMsgBoxCopyAll.Name = "menuMsgBoxCopyAll";
            resources.ApplyResources(this.menuMsgBoxCopyAll, "menuMsgBoxCopyAll");
            this.menuMsgBoxCopyAll.Click += new System.EventHandler(this.menuMsgBoxCopyAll_Click);
            // 
            // menuMsgBoxAddRoutingRule
            // 
            this.menuMsgBoxAddRoutingRule.Name = "menuMsgBoxAddRoutingRule";
            resources.ApplyResources(this.menuMsgBoxAddRoutingRule, "menuMsgBoxAddRoutingRule");
            this.menuMsgBoxAddRoutingRule.Click += new System.EventHandler(this.menuMsgBoxAddRoutingRule_Click);
            // 
            // menuMsgBoxFilter
            // 
            this.menuMsgBoxFilter.Name = "menuMsgBoxFilter";
            resources.ApplyResources(this.menuMsgBoxFilter, "menuMsgBoxFilter");
            this.menuMsgBoxFilter.Click += new System.EventHandler(this.menuMsgBoxFilter_Click);
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssServerStateLabel,
            this.toolSslBlank2,
            this.toolSslServerSpeed,
            this.toolSslBlank4});
            resources.ApplyResources(this.ssMain, "ssMain");
            this.ssMain.Name = "ssMain";
            this.ssMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ssMain_ItemClicked);
            // 
            // tssServerStateLabel
            // 
            this.tssServerStateLabel.Name = "tssServerStateLabel";
            resources.ApplyResources(this.tssServerStateLabel, "tssServerStateLabel");
            // 
            // toolSslBlank2
            // 
            this.toolSslBlank2.Name = "toolSslBlank2";
            resources.ApplyResources(this.toolSslBlank2, "toolSslBlank2");
            this.toolSslBlank2.Spring = true;
            // 
            // toolSslServerSpeed
            // 
            resources.ApplyResources(this.toolSslServerSpeed, "toolSslServerSpeed");
            this.toolSslServerSpeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSslServerSpeed.Name = "toolSslServerSpeed";
            // 
            // toolSslBlank4
            // 
            this.toolSslBlank4.Name = "toolSslBlank4";
            resources.ApplyResources(this.toolSslBlank4, "toolSslBlank4");
            // 
            // notifyMain
            // 
            this.notifyMain.ContextMenuStrip = this.cmsMain;
            resources.ApplyResources(this.notifyMain, "notifyMain");
            this.notifyMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyMain_MouseClick);
            // 
            // cmsMain
            // 
            this.cmsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            resources.ApplyResources(this.cmsMain, "cmsMain");
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSysAgentMode,
            this.menuRoutings,
            this.menuServers,
            this.menuServers2,
            this.toolStripSeparator13,
            this.menuAddServers2,
            this.menuScanScreen2,
            this.menuUpdateSubscriptions,
            this.toolStripSeparator2,
            this.menuExit});
            this.cmsMain.Name = "contextMenuStrip1";
            this.cmsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsMain.ShowCheckMargin = true;
            this.cmsMain.ShowImageMargin = false;
            // 
            // menuSysAgentMode
            // 
            this.menuSysAgentMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKeepClear,
            this.menuGlobal,
            this.menuKeepNothing});
            this.menuSysAgentMode.Name = "menuSysAgentMode";
            resources.ApplyResources(this.menuSysAgentMode, "menuSysAgentMode");
            // 
            // menuKeepClear
            // 
            this.menuKeepClear.Name = "menuKeepClear";
            resources.ApplyResources(this.menuKeepClear, "menuKeepClear");
            this.menuKeepClear.Click += new System.EventHandler(this.menuKeepClear_Click);
            // 
            // menuGlobal
            // 
            this.menuGlobal.Name = "menuGlobal";
            resources.ApplyResources(this.menuGlobal, "menuGlobal");
            this.menuGlobal.Click += new System.EventHandler(this.menuGlobal_Click);
            // 
            // menuKeepNothing
            // 
            this.menuKeepNothing.Name = "menuKeepNothing";
            resources.ApplyResources(this.menuKeepNothing, "menuKeepNothing");
            this.menuKeepNothing.Click += new System.EventHandler(this.menuKeepNothing_Click);
            // 
            // menuRoutings
            // 
            this.menuRoutings.Name = "menuRoutings";
            resources.ApplyResources(this.menuRoutings, "menuRoutings");
            // 
            // menuServers
            // 
            this.menuServers.Name = "menuServers";
            resources.ApplyResources(this.menuServers, "menuServers");
            // 
            // menuServers2
            // 
            this.menuServers2.BackColor = System.Drawing.SystemColors.Window;
            this.menuServers2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuServers2.DropDownWidth = 500;
            resources.ApplyResources(this.menuServers2, "menuServers2");
            this.menuServers2.Name = "menuServers2";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            resources.ApplyResources(this.toolStripSeparator13, "toolStripSeparator13");
            // 
            // menuAddServers2
            // 
            this.menuAddServers2.Name = "menuAddServers2";
            resources.ApplyResources(this.menuAddServers2, "menuAddServers2");
            this.menuAddServers2.Click += new System.EventHandler(this.menuBulkAddLines_Click);
            // 
            // menuScanScreen2
            // 
            this.menuScanScreen2.Name = "menuScanScreen2";
            resources.ApplyResources(this.menuScanScreen2, "menuScanScreen2");
            this.menuScanScreen2.Click += new System.EventHandler(this.menuScanScreenAddLines_Click);
            // 
            // menuUpdateSubscriptions
            // 
            this.menuUpdateSubscriptions.Name = "menuUpdateSubscriptions";
            resources.ApplyResources(this.menuUpdateSubscriptions, "menuUpdateSubscriptions");
            this.menuUpdateSubscriptions.Click += new System.EventHandler(this.menuUpdateSubscriptions_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            resources.ApplyResources(this.menuExit, "menuExit");
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // bgwScan
            // 
            this.bgwScan.WorkerReportsProgress = true;
            this.bgwScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwScan_DoWork);
            this.bgwScan.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwScan_ProgressChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbServer,
            this.toolStripSeparator4,
            this.tsbSub,
            this.toolStripSeparator8,
            this.tsbSetting,
            this.toolStripSeparator5,
            this.tsbHelp});
            resources.ApplyResources(this.tsMain, "tsMain");
            this.tsMain.Name = "tsMain";
            this.tsMain.TabStop = true;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // tsbSub
            // 
            this.tsbSub.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSubSetting,
            this.tsbSubUpdate});
            this.tsbSub.Image = global::v2rayN.Properties.Resources.sub;
            resources.ApplyResources(this.tsbSub, "tsbSub");
            this.tsbSub.Name = "tsbSub";
            // 
            // tsbSubSetting
            // 
            this.tsbSubSetting.Name = "tsbSubSetting";
            resources.ApplyResources(this.tsbSubSetting, "tsbSubSetting");
            this.tsbSubSetting.Click += new System.EventHandler(this.tsbSubSetting_Click);
            // 
            // tsbSubUpdate
            // 
            this.tsbSubUpdate.Name = "tsbSubUpdate";
            resources.ApplyResources(this.tsbSubUpdate, "tsbSubUpdate");
            this.tsbSubUpdate.Click += new System.EventHandler(this.tsbSubUpdate_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // tsbSetting
            // 
            this.tsbSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRestart,
            this.toolStripSeparator16,
            this.tsbOptionSetting,
            this.tsbRoutingSetting,
            this.toolStripSeparator14,
            this.tsbBackupGuiNConfig,
            this.toolStripSeparator7,
            this.menuItemUpdate});
            this.tsbSetting.Image = global::v2rayN.Properties.Resources.option;
            resources.ApplyResources(this.tsbSetting, "tsbSetting");
            this.tsbSetting.Name = "tsbSetting";
            // 
            // menuItemRestart
            // 
            this.menuItemRestart.Name = "menuItemRestart";
            resources.ApplyResources(this.menuItemRestart, "menuItemRestart");
            this.menuItemRestart.Click += new System.EventHandler(this.menuItemRestart_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            resources.ApplyResources(this.toolStripSeparator16, "toolStripSeparator16");
            // 
            // tsbOptionSetting
            // 
            this.tsbOptionSetting.Name = "tsbOptionSetting";
            resources.ApplyResources(this.tsbOptionSetting, "tsbOptionSetting");
            this.tsbOptionSetting.Click += new System.EventHandler(this.tsbOptionSetting_Click);
            // 
            // tsbRoutingSetting
            // 
            this.tsbRoutingSetting.Name = "tsbRoutingSetting";
            resources.ApplyResources(this.tsbRoutingSetting, "tsbRoutingSetting");
            this.tsbRoutingSetting.Click += new System.EventHandler(this.tsbRoutingSetting_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            resources.ApplyResources(this.toolStripSeparator14, "toolStripSeparator14");
            // 
            // tsbBackupGuiNConfig
            // 
            this.tsbBackupGuiNConfig.Name = "tsbBackupGuiNConfig";
            resources.ApplyResources(this.tsbBackupGuiNConfig, "tsbBackupGuiNConfig");
            this.tsbBackupGuiNConfig.Click += new System.EventHandler(this.tsbBackupGuiNConfig_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // menuItemUpdate
            // 
            this.menuItemUpdate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUpdateCore,
            this.toolStripSeparator17,
            this.menuItemGeoSite,
            this.menuItemGeoIP});
            this.menuItemUpdate.Name = "menuItemUpdate";
            resources.ApplyResources(this.menuItemUpdate, "menuItemUpdate");
            // 
            // menuItemUpdateCore
            // 
            this.menuItemUpdateCore.Name = "menuItemUpdateCore";
            resources.ApplyResources(this.menuItemUpdateCore, "menuItemUpdateCore");
            this.menuItemUpdateCore.Click += new System.EventHandler(this.menuItemUpdateCore_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            resources.ApplyResources(this.toolStripSeparator17, "toolStripSeparator17");
            // 
            // menuItemGeoSite
            // 
            this.menuItemGeoSite.Name = "menuItemGeoSite";
            resources.ApplyResources(this.menuItemGeoSite, "menuItemGeoSite");
            this.menuItemGeoSite.Click += new System.EventHandler(this.menuItemGeoSite_Click);
            // 
            // menuItemGeoIP
            // 
            this.menuItemGeoIP.Name = "menuItemGeoIP";
            resources.ApplyResources(this.menuItemGeoIP, "menuItemGeoIP");
            this.menuItemGeoIP.Click += new System.EventHandler(this.menuItemGeoIP_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // tsbHelp
            // 
            this.tsbHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbV2rayWebsite,
            this.toolStripSeparator12,
            this.tsbLanguageDef,
            this.tsbLanguageZhHans});
            this.tsbHelp.Image = global::v2rayN.Properties.Resources.help;
            resources.ApplyResources(this.tsbHelp, "tsbHelp");
            this.tsbHelp.Name = "tsbHelp";
            // 
            // tsbV2rayWebsite
            // 
            this.tsbV2rayWebsite.Name = "tsbV2rayWebsite";
            resources.ApplyResources(this.tsbV2rayWebsite, "tsbV2rayWebsite");
            this.tsbV2rayWebsite.Click += new System.EventHandler(this.tsbV2rayWebsite_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            resources.ApplyResources(this.toolStripSeparator12, "toolStripSeparator12");
            // 
            // tsbLanguageDef
            // 
            this.tsbLanguageDef.Name = "tsbLanguageDef";
            resources.ApplyResources(this.tsbLanguageDef, "tsbLanguageDef");
            this.tsbLanguageDef.Click += new System.EventHandler(this.tsbLanguageDef_Click);
            // 
            // tsbLanguageZhHans
            // 
            this.tsbLanguageZhHans.Name = "tsbLanguageZhHans";
            resources.ApplyResources(this.tsbLanguageZhHans, "tsbLanguageZhHans");
            this.tsbLanguageZhHans.Click += new System.EventHandler(this.tsbLanguageZhHans_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsMain);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.cmsLv.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbMsgTitle.ResumeLayout(false);
            this.gbMsgTitle.PerformLayout();
            this.cmsMsgBox.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.cmsMain.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbMsgTitle;
        private System.Windows.Forms.TextBox txtMsgBox;
        private v2rayN.Base.ListViewFlickerFree lvServers;
        private System.Windows.Forms.NotifyIcon notifyMain;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem menuServers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip cmsLv;
        private System.Windows.Forms.ToolStripMenuItem menuRemoveServer;
        private System.Windows.Forms.ToolStripMenuItem menuCopyServer;
        private System.Windows.Forms.ToolStripMenuItem menuPingServer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuExport2ClientConfig;
        private System.Windows.Forms.ToolStripMenuItem menuExport2ServerConfig;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripDropDownButton tsbServer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem menuMoveTop;
        private System.Windows.Forms.ToolStripMenuItem menuMoveUp;
        private System.Windows.Forms.ToolStripMenuItem menuMoveDown;
        private System.Windows.Forms.ToolStripMenuItem menuMoveBottom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem menuSysAgentMode;
        private System.Windows.Forms.ToolStripMenuItem menuGlobal;
        private System.Windows.Forms.ToolStripMenuItem menuKeepClear;
        private System.Windows.Forms.SplitContainer scMain;
        private QRCodeControl qrCodeControl;
        private System.Windows.Forms.ToolStripMenuItem menuExport2ShareUrl;
        private System.Windows.Forms.ToolStripMenuItem menuSpeedServer;
        private System.Windows.Forms.ToolStripDropDownButton tsbHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAddServers2;
        private System.ComponentModel.BackgroundWorker bgwScan;
        private System.Windows.Forms.ToolStripMenuItem menuScanScreen2;
        private System.Windows.Forms.ToolStripDropDownButton tsbSub;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsbSubSetting;
        private System.Windows.Forms.ToolStripMenuItem tsbSubUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuExport2SubContent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem tsbLanguageDef;
        private System.Windows.Forms.ToolStripMenuItem tsbLanguageZhHans;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel toolSslServerSpeed;
        private System.Windows.Forms.ToolStripStatusLabel toolSslBlank4;
        private System.Windows.Forms.ToolStripMenuItem menuRemoveDuplicateServer;
        private System.Windows.Forms.ToolStripMenuItem menuTcpingServer;
        private System.Windows.Forms.ToolStripMenuItem menuRealPingServer;
        private System.Windows.Forms.ToolStripMenuItem menuUpdateSubscriptions;
        private System.Windows.Forms.ToolStripMenuItem tsbV2rayWebsite;
        private System.Windows.Forms.ToolStripMenuItem menuKeepNothing;
        private System.Windows.Forms.ToolStripMenuItem tsbTestMe;
        private System.Windows.Forms.ToolStripDropDownButton tsbSetting;
        private System.Windows.Forms.ToolStripMenuItem tsbOptionSetting;
        private System.Windows.Forms.ToolStripMenuItem tsbRoutingSetting;
        private System.Windows.Forms.ToolStripMenuItem menuClearServerStatistics;
        private System.Windows.Forms.ToolStripMenuItem menuRoutings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ContextMenuStrip cmsMsgBox;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxCopy;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxAddRoutingRule;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxCopyAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem tsbBackupGuiNConfig;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxFilter;
        private System.Windows.Forms.ToolStripComboBox menuServers2;
        private System.Windows.Forms.ToolStripMenuItem menuItemShare;
        private System.Windows.Forms.ToolStripMenuItem menuItemRestart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem menuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuItemUpdateCore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem menuItemGeoSite;
        private System.Windows.Forms.ToolStripMenuItem menuItemGeoIP;
        private System.Windows.Forms.ToolStripMenuItem menuAddVmessLine;
        private System.Windows.Forms.ToolStripMenuItem menuAddVlessLine;
        private System.Windows.Forms.ToolStripMenuItem menuAddShadowsocksLine;
        private System.Windows.Forms.ToolStripMenuItem menuAddSocksLine;
        private System.Windows.Forms.ToolStripMenuItem menuAddTrojanLine;
        private System.Windows.Forms.ToolStripMenuItem menuAddCustomLine;
        private System.Windows.Forms.ToolStripMenuItem menuBulkAddLines;
        private System.Windows.Forms.ToolStripMenuItem menuScanScreenAddLines;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem menuItemMove;
        private System.Windows.Forms.ToolStripMenuItem menuItemTest;
        private System.Windows.Forms.ToolStripMenuItem menuItemExport;
        private System.Windows.Forms.ToolStripMenuItem menuStartNewServer;
        private System.Windows.Forms.ToolStripMenuItem menuStopServer;
        private System.Windows.Forms.ToolStripStatusLabel toolSslBlank2;
        private System.Windows.Forms.ToolStripStatusLabel tssServerStateLabel;
    }
}

