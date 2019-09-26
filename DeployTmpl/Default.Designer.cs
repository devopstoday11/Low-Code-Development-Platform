namespace Install
{
	partial class Default
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SysUsrLabel = new System.Windows.Forms.Label();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCBrowse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.gbRule = new System.Windows.Forms.GroupBox();
            this.rbRFrwork3 = new System.Windows.Forms.RadioButton();
            this.rbRFrwork4 = new System.Windows.Forms.RadioButton();
            this.lblDbPath = new System.Windows.Forms.Label();
            this.btnRBrowse = new System.Windows.Forms.Button();
            this.txtDbPath = new System.Windows.Forms.TextBox();
            this.txtRuleTier = new System.Windows.Forms.TextBox();
            this.txtClientTier = new System.Windows.Forms.TextBox();
            this.SysPwdLabel = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.cbIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.rbDbProvider14 = new System.Windows.Forms.RadioButton();
            this.cbSingleDeveloper = new System.Windows.Forms.CheckBox();
            this.txtAppPassword = new System.Windows.Forms.TextBox();
            this.txtAppUserName = new System.Windows.Forms.TextBox();
            this.AppUsrLabel = new System.Windows.Forms.Label();
            this.AppPwdLabel = new System.Windows.Forms.Label();
            this.rbDbProvider16 = new System.Windows.Forms.RadioButton();
            this.rbDbProvider12 = new System.Windows.Forms.RadioButton();
            this.rbDbProvider10 = new System.Windows.Forms.RadioButton();
            this.gbBackup = new System.Windows.Forms.GroupBox();
            this.lblBkPath1 = new System.Windows.Forms.Label();
            this.lblBkPath2 = new System.Windows.Forms.Label();
            this.txtBkPath2 = new System.Windows.Forms.TextBox();
            this.txtBkPath1 = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.ProgressInd = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.rbCFrwork3 = new System.Windows.Forms.RadioButton();
            this.rbCFrwork4 = new System.Windows.Forms.RadioButton();
            this.rbPdtUpgrade = new System.Windows.Forms.RadioButton();
            this.rbDevUpgrade = new System.Windows.Forms.RadioButton();
            this.txtNewNS = new System.Windows.Forms.TextBox();
            this.txtOldNS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbPtyUpgrade = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gbUpgrade = new System.Windows.Forms.GroupBox();
            this.cbOverWrite = new System.Windows.Forms.CheckBox();
            this.cb32Bit = new System.Windows.Forms.CheckBox();
            this.cbInstallDB = new System.Windows.Forms.CheckBox();
            this.cbNew = new System.Windows.Forms.CheckBox();
            this.picReadMe = new System.Windows.Forms.PictureBox();
            this.picLog = new System.Windows.Forms.PictureBox();
            this.copyright = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvVersion = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbNmspace = new System.Windows.Forms.GroupBox();
            this.txtWebServer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.gbRptWs = new System.Windows.Forms.GroupBox();
            this.txtWsUrl = new System.Windows.Forms.TextBox();
            this.txtWsTier = new System.Windows.Forms.TextBox();
            this.gbWs = new System.Windows.Forms.GroupBox();
            this.rtfLicense = new System.Windows.Forms.RichTextBox();
            this.gbXls = new System.Windows.Forms.GroupBox();
            this.txtXlsTier = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbRule.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gbBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbClient.SuspendLayout();
            this.gbUpgrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReadMe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).BeginInit();
            this.gbNmspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.gbRptWs.SuspendLayout();
            this.gbWs.SuspendLayout();
            this.gbXls.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(92, 75);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(141, 20);
            this.txtPassword.TabIndex = 100;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(92, 49);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(141, 20);
            this.txtUserName.TabIndex = 90;
            this.txtUserName.MouseHover += new System.EventHandler(this.control_MouseHover);
            // 
            // SysUsrLabel
            // 
            this.SysUsrLabel.AutoSize = true;
            this.SysUsrLabel.Location = new System.Drawing.Point(39, 52);
            this.SysUsrLabel.Name = "SysUsrLabel";
            this.SysUsrLabel.Size = new System.Drawing.Size(52, 13);
            this.SysUsrLabel.TabIndex = 14;
            this.SysUsrLabel.Text = "Sys User:";
            // 
            // btnCBrowse
            // 
            this.btnCBrowse.Location = new System.Drawing.Point(311, 16);
            this.btnCBrowse.Name = "btnCBrowse";
            this.btnCBrowse.Size = new System.Drawing.Size(103, 23);
            this.btnCBrowse.TabIndex = 45;
            this.btnCBrowse.Text = "Browse..";
            this.btnCBrowse.UseVisualStyleBackColor = true;
            this.btnCBrowse.Click += new System.EventHandler(this.btnCBrowse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Server Instance:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(92, 22);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(141, 20);
            this.txtServerName.TabIndex = 80;
            this.txtServerName.MouseHover += new System.EventHandler(this.control_MouseHover);
            // 
            // gbRule
            // 
            this.gbRule.Controls.Add(this.rbRFrwork3);
            this.gbRule.Controls.Add(this.rbRFrwork4);
            this.gbRule.Controls.Add(this.lblDbPath);
            this.gbRule.Controls.Add(this.btnRBrowse);
            this.gbRule.Controls.Add(this.txtDbPath);
            this.gbRule.Controls.Add(this.txtRuleTier);
            this.gbRule.Location = new System.Drawing.Point(5, 327);
            this.gbRule.Name = "gbRule";
            this.gbRule.Size = new System.Drawing.Size(620, 60);
            this.gbRule.TabIndex = 50;
            this.gbRule.TabStop = false;
            this.gbRule.Text = "Rule/Project Root Tier";
            // 
            // rbRFrwork3
            // 
            this.rbRFrwork3.AutoSize = true;
            this.rbRFrwork3.Checked = true;
            this.rbRFrwork3.Enabled = false;
            this.rbRFrwork3.Location = new System.Drawing.Point(530, 17);
            this.rbRFrwork3.Name = "rbRFrwork3";
            this.rbRFrwork3.Size = new System.Drawing.Size(77, 17);
            this.rbRFrwork3.TabIndex = 77;
            this.rbRFrwork3.TabStop = true;
            this.rbRFrwork3.Text = "DotNet 3.5";
            this.rbRFrwork3.UseVisualStyleBackColor = true;
            // 
            // rbRFrwork4
            // 
            this.rbRFrwork4.AutoSize = true;
            this.rbRFrwork4.Enabled = false;
            this.rbRFrwork4.Location = new System.Drawing.Point(437, 17);
            this.rbRFrwork4.Name = "rbRFrwork4";
            this.rbRFrwork4.Size = new System.Drawing.Size(76, 17);
            this.rbRFrwork4.TabIndex = 76;
            this.rbRFrwork4.Text = "DotNet 4.x";
            this.rbRFrwork4.UseVisualStyleBackColor = true;
            // 
            // lblDbPath
            // 
            this.lblDbPath.AutoSize = true;
            this.lblDbPath.Location = new System.Drawing.Point(369, 44);
            this.lblDbPath.Name = "lblDbPath";
            this.lblDbPath.Size = new System.Drawing.Size(47, 13);
            this.lblDbPath.TabIndex = 216;
            this.lblDbPath.Text = "db Path:";
            this.lblDbPath.Visible = false;
            // 
            // btnRBrowse
            // 
            this.btnRBrowse.Location = new System.Drawing.Point(312, 19);
            this.btnRBrowse.Name = "btnRBrowse";
            this.btnRBrowse.Size = new System.Drawing.Size(103, 23);
            this.btnRBrowse.TabIndex = 75;
            this.btnRBrowse.Text = "Browse..";
            this.btnRBrowse.UseVisualStyleBackColor = true;
            this.btnRBrowse.Click += new System.EventHandler(this.btnRBrowse_Click);
            // 
            // txtDbPath
            // 
            this.txtDbPath.Location = new System.Drawing.Point(422, 40);
            this.txtDbPath.Name = "txtDbPath";
            this.txtDbPath.Size = new System.Drawing.Size(193, 20);
            this.txtDbPath.TabIndex = 15;
            this.txtDbPath.Text = "C:\\SQLData";
            this.txtDbPath.Visible = false;
            this.txtDbPath.MouseHover += new System.EventHandler(this.control_MouseHover);
            // 
            // txtRuleTier
            // 
            this.txtRuleTier.Location = new System.Drawing.Point(22, 20);
            this.txtRuleTier.Name = "txtRuleTier";
            this.txtRuleTier.Size = new System.Drawing.Size(274, 20);
            this.txtRuleTier.TabIndex = 70;
            // 
            // txtClientTier
            // 
            this.txtClientTier.Location = new System.Drawing.Point(20, 17);
            this.txtClientTier.Name = "txtClientTier";
            this.txtClientTier.Size = new System.Drawing.Size(275, 20);
            this.txtClientTier.TabIndex = 40;
            // 
            // SysPwdLabel
            // 
            this.SysPwdLabel.AutoSize = true;
            this.SysPwdLabel.Location = new System.Drawing.Point(40, 78);
            this.SysPwdLabel.Name = "SysPwdLabel";
            this.SysPwdLabel.Size = new System.Drawing.Size(51, 13);
            this.SysPwdLabel.TabIndex = 16;
            this.SysPwdLabel.Text = "Sys Pwd:";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.cbIntegratedSecurity);
            this.gbData.Controls.Add(this.rbDbProvider14);
            this.gbData.Controls.Add(this.cbSingleDeveloper);
            this.gbData.Controls.Add(this.txtAppPassword);
            this.gbData.Controls.Add(this.txtAppUserName);
            this.gbData.Controls.Add(this.AppUsrLabel);
            this.gbData.Controls.Add(this.AppPwdLabel);
            this.gbData.Controls.Add(this.rbDbProvider16);
            this.gbData.Controls.Add(this.rbDbProvider12);
            this.gbData.Controls.Add(this.rbDbProvider10);
            this.gbData.Controls.Add(this.label6);
            this.gbData.Controls.Add(this.txtServerName);
            this.gbData.Controls.Add(this.SysUsrLabel);
            this.gbData.Controls.Add(this.txtPassword);
            this.gbData.Controls.Add(this.txtUserName);
            this.gbData.Controls.Add(this.SysPwdLabel);
            this.gbData.Location = new System.Drawing.Point(5, 390);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(620, 116);
            this.gbData.TabIndex = 80;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data Tier";
            // 
            // cbIntegratedSecurity
            // 
            this.cbIntegratedSecurity.AutoSize = true;
            this.cbIntegratedSecurity.Location = new System.Drawing.Point(245, 23);
            this.cbIntegratedSecurity.Name = "cbIntegratedSecurity";
            this.cbIntegratedSecurity.Size = new System.Drawing.Size(141, 17);
            this.cbIntegratedSecurity.TabIndex = 171;
            this.cbIntegratedSecurity.Text = "Windows Authentication";
            this.cbIntegratedSecurity.UseVisualStyleBackColor = true;
            this.cbIntegratedSecurity.CheckedChanged += new System.EventHandler(this.cbIntegratedSecurity_CheckedChanged);
            this.cbIntegratedSecurity.MouseHover += new System.EventHandler(this.control_MouseHover);
            // 
            // rbDbProvider14
            // 
            this.rbDbProvider14.AutoSize = true;
            this.rbDbProvider14.Location = new System.Drawing.Point(530, 64);
            this.rbDbProvider14.Name = "rbDbProvider14";
            this.rbDbProvider14.Size = new System.Drawing.Size(81, 17);
            this.rbDbProvider14.TabIndex = 169;
            this.rbDbProvider14.Text = "MsSql 2014";
            this.rbDbProvider14.UseVisualStyleBackColor = true;
            // 
            // cbSingleDeveloper
            // 
            this.cbSingleDeveloper.AutoSize = true;
            this.cbSingleDeveloper.Location = new System.Drawing.Point(392, 23);
            this.cbSingleDeveloper.Name = "cbSingleDeveloper";
            this.cbSingleDeveloper.Size = new System.Drawing.Size(125, 17);
            this.cbSingleDeveloper.TabIndex = 168;
            this.cbSingleDeveloper.Text = "Sys User is App User";
            this.cbSingleDeveloper.UseVisualStyleBackColor = true;
            this.cbSingleDeveloper.Visible = false;
            this.cbSingleDeveloper.CheckedChanged += new System.EventHandler(this.SingleDeveloper_CheckedChanged);
            this.cbSingleDeveloper.MouseHover += new System.EventHandler(this.control_MouseHover);
            // 
            // txtAppPassword
            // 
            this.txtAppPassword.Location = new System.Drawing.Point(302, 75);
            this.txtAppPassword.Name = "txtAppPassword";
            this.txtAppPassword.Size = new System.Drawing.Size(134, 20);
            this.txtAppPassword.TabIndex = 120;
            this.txtAppPassword.MouseHover += new System.EventHandler(this.control_MouseHover);
            // 
            // txtAppUserName
            // 
            this.txtAppUserName.Location = new System.Drawing.Point(302, 49);
            this.txtAppUserName.Name = "txtAppUserName";
            this.txtAppUserName.Size = new System.Drawing.Size(134, 20);
            this.txtAppUserName.TabIndex = 110;
            this.txtAppUserName.MouseHover += new System.EventHandler(this.control_MouseHover);
            // 
            // AppUsrLabel
            // 
            this.AppUsrLabel.AutoSize = true;
            this.AppUsrLabel.Location = new System.Drawing.Point(242, 51);
            this.AppUsrLabel.Name = "AppUsrLabel";
            this.AppUsrLabel.Size = new System.Drawing.Size(54, 13);
            this.AppUsrLabel.TabIndex = 166;
            this.AppUsrLabel.Text = "App User:";
            // 
            // AppPwdLabel
            // 
            this.AppPwdLabel.AutoSize = true;
            this.AppPwdLabel.Location = new System.Drawing.Point(243, 81);
            this.AppPwdLabel.Name = "AppPwdLabel";
            this.AppPwdLabel.Size = new System.Drawing.Size(53, 13);
            this.AppPwdLabel.TabIndex = 167;
            this.AppPwdLabel.Text = "App Pwd:";
            // 
            // rbDbProvider16
            // 
            this.rbDbProvider16.AutoSize = true;
            this.rbDbProvider16.Location = new System.Drawing.Point(530, 87);
            this.rbDbProvider16.Name = "rbDbProvider16";
            this.rbDbProvider16.Size = new System.Drawing.Size(81, 17);
            this.rbDbProvider16.TabIndex = 170;
            this.rbDbProvider16.Text = "MsSql 2016";
            this.rbDbProvider16.UseVisualStyleBackColor = true;
            // 
            // rbDbProvider12
            // 
            this.rbDbProvider12.AutoSize = true;
            this.rbDbProvider12.Location = new System.Drawing.Point(530, 41);
            this.rbDbProvider12.Name = "rbDbProvider12";
            this.rbDbProvider12.Size = new System.Drawing.Size(81, 17);
            this.rbDbProvider12.TabIndex = 165;
            this.rbDbProvider12.Text = "MsSql 2012";
            this.rbDbProvider12.UseVisualStyleBackColor = true;
            // 
            // rbDbProvider10
            // 
            this.rbDbProvider10.AutoSize = true;
            this.rbDbProvider10.Location = new System.Drawing.Point(530, 18);
            this.rbDbProvider10.Name = "rbDbProvider10";
            this.rbDbProvider10.Size = new System.Drawing.Size(81, 17);
            this.rbDbProvider10.TabIndex = 160;
            this.rbDbProvider10.Text = "MsSql 2008";
            this.rbDbProvider10.UseVisualStyleBackColor = true;
            // 
            // gbBackup
            // 
            this.gbBackup.Controls.Add(this.lblBkPath1);
            this.gbBackup.Controls.Add(this.lblBkPath2);
            this.gbBackup.Controls.Add(this.txtBkPath2);
            this.gbBackup.Controls.Add(this.txtBkPath1);
            this.gbBackup.Controls.Add(this.btnBackup);
            this.gbBackup.Controls.Add(this.lblCurrent);
            this.gbBackup.Location = new System.Drawing.Point(5, 518);
            this.gbBackup.Name = "gbBackup";
            this.gbBackup.Size = new System.Drawing.Size(415, 58);
            this.gbBackup.TabIndex = 100;
            this.gbBackup.TabStop = false;
            // 
            // lblBkPath1
            // 
            this.lblBkPath1.AutoSize = true;
            this.lblBkPath1.Location = new System.Drawing.Point(5, 24);
            this.lblBkPath1.Name = "lblBkPath1";
            this.lblBkPath1.Size = new System.Drawing.Size(36, 13);
            this.lblBkPath1.TabIndex = 215;
            this.lblBkPath1.Text = "Client:";
            // 
            // lblBkPath2
            // 
            this.lblBkPath2.AutoSize = true;
            this.lblBkPath2.Location = new System.Drawing.Point(156, 24);
            this.lblBkPath2.Name = "lblBkPath2";
            this.lblBkPath2.Size = new System.Drawing.Size(41, 13);
            this.lblBkPath2.TabIndex = 214;
            this.lblBkPath2.Text = "Server:";
            // 
            // txtBkPath2
            // 
            this.txtBkPath2.Location = new System.Drawing.Point(199, 20);
            this.txtBkPath2.Name = "txtBkPath2";
            this.txtBkPath2.Size = new System.Drawing.Size(111, 20);
            this.txtBkPath2.TabIndex = 213;
            this.txtBkPath2.Text = "\\\\ComputerName\\C$\\Backup";
            // 
            // txtBkPath1
            // 
            this.txtBkPath1.Location = new System.Drawing.Point(43, 20);
            this.txtBkPath1.Name = "txtBkPath1";
            this.txtBkPath1.Size = new System.Drawing.Size(107, 20);
            this.txtBkPath1.TabIndex = 212;
            this.txtBkPath1.Text = "\\\\ComputerName\\C$\\Backup";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(327, 19);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 250;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Visible = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(18, 26);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(0, 13);
            this.lblCurrent.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(441, 539);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 255;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(525, 539);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 260;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // ProgressInd
            // 
            this.ProgressInd.Location = new System.Drawing.Point(5, 507);
            this.ProgressInd.Name = "ProgressInd";
            this.ProgressInd.Size = new System.Drawing.Size(620, 14);
            this.ProgressInd.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Install.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 53);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.rbCFrwork3);
            this.gbClient.Controls.Add(this.rbCFrwork4);
            this.gbClient.Controls.Add(this.btnCBrowse);
            this.gbClient.Controls.Add(this.txtClientTier);
            this.gbClient.Location = new System.Drawing.Point(6, 162);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(619, 60);
            this.gbClient.TabIndex = 20;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Client Tier";
            // 
            // rbCFrwork3
            // 
            this.rbCFrwork3.AutoSize = true;
            this.rbCFrwork3.Checked = true;
            this.rbCFrwork3.Location = new System.Drawing.Point(529, 16);
            this.rbCFrwork3.Name = "rbCFrwork3";
            this.rbCFrwork3.Size = new System.Drawing.Size(77, 17);
            this.rbCFrwork3.TabIndex = 47;
            this.rbCFrwork3.TabStop = true;
            this.rbCFrwork3.Text = "DotNet 3.5";
            this.rbCFrwork3.UseVisualStyleBackColor = true;
            this.rbCFrwork3.Visible = false;
            // 
            // rbCFrwork4
            // 
            this.rbCFrwork4.AutoSize = true;
            this.rbCFrwork4.Location = new System.Drawing.Point(436, 16);
            this.rbCFrwork4.Name = "rbCFrwork4";
            this.rbCFrwork4.Size = new System.Drawing.Size(77, 17);
            this.rbCFrwork4.TabIndex = 46;
            this.rbCFrwork4.Text = "DotNet 4.5";
            this.rbCFrwork4.UseVisualStyleBackColor = true;
            this.rbCFrwork4.Visible = false;
            // 
            // rbPdtUpgrade
            // 
            this.rbPdtUpgrade.AutoSize = true;
            this.rbPdtUpgrade.Location = new System.Drawing.Point(385, 17);
            this.rbPdtUpgrade.Name = "rbPdtUpgrade";
            this.rbPdtUpgrade.Size = new System.Drawing.Size(76, 17);
            this.rbPdtUpgrade.TabIndex = 20;
            this.rbPdtUpgrade.TabStop = true;
            this.rbPdtUpgrade.Text = "Production";
            this.rbPdtUpgrade.UseVisualStyleBackColor = true;
            this.rbPdtUpgrade.CheckedChanged += new System.EventHandler(this.rbPdtUpgrade_CheckedChanged);
            // 
            // rbDevUpgrade
            // 
            this.rbDevUpgrade.AutoSize = true;
            this.rbDevUpgrade.Location = new System.Drawing.Point(464, 17);
            this.rbDevUpgrade.Name = "rbDevUpgrade";
            this.rbDevUpgrade.Size = new System.Drawing.Size(74, 17);
            this.rbDevUpgrade.TabIndex = 25;
            this.rbDevUpgrade.TabStop = true;
            this.rbDevUpgrade.Text = "Developer";
            this.rbDevUpgrade.UseVisualStyleBackColor = true;
            this.rbDevUpgrade.CheckedChanged += new System.EventHandler(this.rbDevUpgrade_CheckedChanged);
            // 
            // txtNewNS
            // 
            this.txtNewNS.Location = new System.Drawing.Point(182, 16);
            this.txtNewNS.Name = "txtNewNS";
            this.txtNewNS.Size = new System.Drawing.Size(50, 20);
            this.txtNewNS.TabIndex = 38;
            this.txtNewNS.TextChanged += new System.EventHandler(this.txtNewNS_TextChanged);
            // 
            // txtOldNS
            // 
            this.txtOldNS.Enabled = false;
            this.txtOldNS.Location = new System.Drawing.Point(105, 16);
            this.txtOldNS.Name = "txtOldNS";
            this.txtOldNS.Size = new System.Drawing.Size(50, 20);
            this.txtOldNS.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "to:";
            // 
            // rbPtyUpgrade
            // 
            this.rbPtyUpgrade.AutoSize = true;
            this.rbPtyUpgrade.Location = new System.Drawing.Point(540, 17);
            this.rbPtyUpgrade.Name = "rbPtyUpgrade";
            this.rbPtyUpgrade.Size = new System.Drawing.Size(70, 17);
            this.rbPtyUpgrade.TabIndex = 30;
            this.rbPtyUpgrade.TabStop = true;
            this.rbPtyUpgrade.Text = "Prototype";
            this.rbPtyUpgrade.UseVisualStyleBackColor = true;
            this.rbPtyUpgrade.CheckedChanged += new System.EventHandler(this.rbPtyUpgrade_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Namespace from:";
            // 
            // gbUpgrade
            // 
            this.gbUpgrade.Controls.Add(this.cbOverWrite);
            this.gbUpgrade.Controls.Add(this.cb32Bit);
            this.gbUpgrade.Controls.Add(this.cbInstallDB);
            this.gbUpgrade.Controls.Add(this.cbNew);
            this.gbUpgrade.Controls.Add(this.rbPdtUpgrade);
            this.gbUpgrade.Controls.Add(this.rbDevUpgrade);
            this.gbUpgrade.Controls.Add(this.rbPtyUpgrade);
            this.gbUpgrade.Location = new System.Drawing.Point(6, 69);
            this.gbUpgrade.Name = "gbUpgrade";
            this.gbUpgrade.Size = new System.Drawing.Size(619, 45);
            this.gbUpgrade.TabIndex = 10;
            this.gbUpgrade.TabStop = false;
            // 
            // cbOverWrite
            // 
            this.cbOverWrite.AutoSize = true;
            this.cbOverWrite.Location = new System.Drawing.Point(309, 18);
            this.cbOverWrite.Margin = new System.Windows.Forms.Padding(2);
            this.cbOverWrite.Name = "cbOverWrite";
            this.cbOverWrite.Size = new System.Drawing.Size(71, 17);
            this.cbOverWrite.TabIndex = 31;
            this.cbOverWrite.Text = "Overwrite";
            this.cbOverWrite.UseVisualStyleBackColor = true;
            this.cbOverWrite.MouseHover += new System.EventHandler(this.control_MouseHover);
            // 
            // cb32Bit
            // 
            this.cb32Bit.AutoSize = true;
            this.cb32Bit.Location = new System.Drawing.Point(144, 18);
            this.cb32Bit.Name = "cb32Bit";
            this.cb32Bit.Size = new System.Drawing.Size(165, 17);
            this.cb32Bit.TabIndex = 16;
            this.cb32Bit.Text = "32 bit Access/Office Runtime";
            this.cb32Bit.UseVisualStyleBackColor = true;
            this.cb32Bit.Visible = false;
            this.cb32Bit.MouseHover += new System.EventHandler(this.control_MouseHover);
            // 
            // cbInstallDB
            // 
            this.cbInstallDB.AutoSize = true;
            this.cbInstallDB.Checked = true;
            this.cbInstallDB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInstallDB.Location = new System.Drawing.Point(70, 18);
            this.cbInstallDB.Name = "cbInstallDB";
            this.cbInstallDB.Size = new System.Drawing.Size(74, 17);
            this.cbInstallDB.TabIndex = 14;
            this.cbInstallDB.Text = "Install DB ";
            this.cbInstallDB.UseVisualStyleBackColor = true;
            this.cbInstallDB.MouseHover += new System.EventHandler(this.control_MouseHover);
            // 
            // cbNew
            // 
            this.cbNew.AutoSize = true;
            this.cbNew.Location = new System.Drawing.Point(12, 18);
            this.cbNew.Name = "cbNew";
            this.cbNew.Size = new System.Drawing.Size(48, 17);
            this.cbNew.TabIndex = 10;
            this.cbNew.Text = "New";
            this.cbNew.UseVisualStyleBackColor = true;
            this.cbNew.CheckedChanged += new System.EventHandler(this.cbNew_CheckedChanged);
            this.cbNew.MouseHover += new System.EventHandler(this.control_MouseHover);
            // 
            // picReadMe
            // 
            this.picReadMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReadMe.Image = ((System.Drawing.Image)(resources.GetObject("picReadMe.Image")));
            this.picReadMe.Location = new System.Drawing.Point(532, 12);
            this.picReadMe.Name = "picReadMe";
            this.picReadMe.Size = new System.Drawing.Size(21, 26);
            this.picReadMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReadMe.TabIndex = 52;
            this.picReadMe.TabStop = false;
            this.picReadMe.Click += new System.EventHandler(this.picReadMe_Click);
            // 
            // picLog
            // 
            this.picLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLog.Image = ((System.Drawing.Image)(resources.GetObject("picLog.Image")));
            this.picLog.Location = new System.Drawing.Point(562, 12);
            this.picLog.Name = "picLog";
            this.picLog.Size = new System.Drawing.Size(21, 26);
            this.picLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLog.TabIndex = 53;
            this.picLog.TabStop = false;
            this.picLog.Visible = false;
            this.picLog.Click += new System.EventHandler(this.picLog_Click);
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.Location = new System.Drawing.Point(162, 582);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(279, 12);
            this.copyright.TabIndex = 51;
            this.copyright.Text = "V3.0.10221 �1999-2012 robocoder corporation. All rights reserved.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(73, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 14);
            this.label8.TabIndex = 52;
            // 
            // lvVersion
            // 
            this.lvVersion.AutoArrange = false;
            this.lvVersion.BackColor = System.Drawing.SystemColors.Window;
            this.lvVersion.Enabled = false;
            this.lvVersion.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvVersion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lvVersion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvVersion.Location = new System.Drawing.Point(221, 0);
            this.lvVersion.MultiSelect = false;
            this.lvVersion.Name = "lvVersion";
            this.lvVersion.Size = new System.Drawing.Size(404, 69);
            this.lvVersion.TabIndex = 22;
            this.lvVersion.TileSize = new System.Drawing.Size(280, 12);
            this.lvVersion.UseCompatibleStateImageBehavior = false;
            this.lvVersion.View = System.Windows.Forms.View.Tile;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20);
            this.label1.Size = new System.Drawing.Size(520, 69);
            this.label1.TabIndex = 21;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbNmspace
            // 
            this.gbNmspace.Controls.Add(this.txtWebServer);
            this.gbNmspace.Controls.Add(this.label9);
            this.gbNmspace.Controls.Add(this.picHelp);
            this.gbNmspace.Controls.Add(this.picLog);
            this.gbNmspace.Controls.Add(this.txtOldNS);
            this.gbNmspace.Controls.Add(this.picReadMe);
            this.gbNmspace.Controls.Add(this.label3);
            this.gbNmspace.Controls.Add(this.label2);
            this.gbNmspace.Controls.Add(this.txtNewNS);
            this.gbNmspace.Location = new System.Drawing.Point(6, 115);
            this.gbNmspace.Name = "gbNmspace";
            this.gbNmspace.Size = new System.Drawing.Size(619, 45);
            this.gbNmspace.TabIndex = 15;
            this.gbNmspace.TabStop = false;
            // 
            // txtWebServer
            // 
            this.txtWebServer.Location = new System.Drawing.Point(343, 16);
            this.txtWebServer.Name = "txtWebServer";
            this.txtWebServer.Size = new System.Drawing.Size(139, 20);
            this.txtWebServer.TabIndex = 39;
            this.txtWebServer.TextChanged += new System.EventHandler(this.txtWebServer_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Web Server:";
            // 
            // picHelp
            // 
            this.picHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHelp.Image = ((System.Drawing.Image)(resources.GetObject("picHelp.Image")));
            this.picHelp.Location = new System.Drawing.Point(504, 12);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(21, 26);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelp.TabIndex = 54;
            this.picHelp.TabStop = false;
            this.picHelp.Click += new System.EventHandler(this.picHelp_Click);
            // 
            // gbRptWs
            // 
            this.gbRptWs.Controls.Add(this.txtWsUrl);
            this.gbRptWs.Location = new System.Drawing.Point(6, 276);
            this.gbRptWs.Name = "gbRptWs";
            this.gbRptWs.Size = new System.Drawing.Size(619, 48);
            this.gbRptWs.TabIndex = 40;
            this.gbRptWs.TabStop = false;
            this.gbRptWs.Text = "Reporting Service URL";
            // 
            // txtWsUrl
            // 
            this.txtWsUrl.Location = new System.Drawing.Point(20, 20);
            this.txtWsUrl.Name = "txtWsUrl";
            this.txtWsUrl.Size = new System.Drawing.Size(586, 20);
            this.txtWsUrl.TabIndex = 65;
            // 
            // txtWsTier
            // 
            this.txtWsTier.Location = new System.Drawing.Point(21, 19);
            this.txtWsTier.Name = "txtWsTier";
            this.txtWsTier.Size = new System.Drawing.Size(274, 20);
            this.txtWsTier.TabIndex = 48;
            // 
            // gbWs
            // 
            this.gbWs.Controls.Add(this.txtWsTier);
            this.gbWs.Location = new System.Drawing.Point(6, 225);
            this.gbWs.Name = "gbWs";
            this.gbWs.Size = new System.Drawing.Size(308, 48);
            this.gbWs.TabIndex = 30;
            this.gbWs.TabStop = false;
            this.gbWs.Text = "Regular Web Service Tier";
            // 
            // rtfLicense
            // 
            this.rtfLicense.BackColor = System.Drawing.SystemColors.Window;
            this.rtfLicense.Location = new System.Drawing.Point(6, 74);
            this.rtfLicense.Margin = new System.Windows.Forms.Padding(2);
            this.rtfLicense.Name = "rtfLicense";
            this.rtfLicense.ReadOnly = true;
            this.rtfLicense.Size = new System.Drawing.Size(619, 427);
            this.rtfLicense.TabIndex = 101;
            this.rtfLicense.Text = "";
            // 
            // gbXls
            // 
            this.gbXls.Controls.Add(this.txtXlsTier);
            this.gbXls.Location = new System.Drawing.Point(317, 226);
            this.gbXls.Name = "gbXls";
            this.gbXls.Size = new System.Drawing.Size(308, 48);
            this.gbXls.TabIndex = 261;
            this.gbXls.TabStop = false;
            this.gbXls.Text = "XLS Import Web Service Tier";
            // 
            // txtXlsTier
            // 
            this.txtXlsTier.Location = new System.Drawing.Point(21, 19);
            this.txtXlsTier.Name = "txtXlsTier";
            this.txtXlsTier.Size = new System.Drawing.Size(274, 20);
            this.txtXlsTier.TabIndex = 48;
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(632, 597);
            this.Controls.Add(this.gbXls);
            this.Controls.Add(this.gbWs);
            this.Controls.Add(this.gbRptWs);
            this.Controls.Add(this.gbNmspace);
            this.Controls.Add(this.lvVersion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbClient);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProgressInd);
            this.Controls.Add(this.gbRule);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbUpgrade);
            this.Controls.Add(this.gbBackup);
            this.Controls.Add(this.rtfLicense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Default";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RC Installer";
            this.gbRule.ResumeLayout(false);
            this.gbRule.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbBackup.ResumeLayout(false);
            this.gbBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.gbUpgrade.ResumeLayout(false);
            this.gbUpgrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReadMe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).EndInit();
            this.gbNmspace.ResumeLayout(false);
            this.gbNmspace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.gbRptWs.ResumeLayout(false);
            this.gbRptWs.PerformLayout();
            this.gbWs.ResumeLayout(false);
            this.gbWs.PerformLayout();
            this.gbXls.ResumeLayout(false);
            this.gbXls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label SysUsrLabel;
		private System.Windows.Forms.FolderBrowserDialog FolderDialog;
		private System.Windows.Forms.Button btnCBrowse;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtServerName;
		private System.Windows.Forms.GroupBox gbRule;
		private System.Windows.Forms.TextBox txtClientTier;
		private System.Windows.Forms.Button btnRBrowse;
		private System.Windows.Forms.TextBox txtRuleTier;
		private System.Windows.Forms.Label SysPwdLabel;
		private System.Windows.Forms.GroupBox gbData;
		private System.Windows.Forms.GroupBox gbBackup;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnInstall;
		private System.Windows.Forms.ProgressBar ProgressInd;
		private System.Windows.Forms.Label lblCurrent;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox gbClient;
		private System.Windows.Forms.RadioButton rbCFrwork3;
		private System.Windows.Forms.RadioButton rbCFrwork4;
		private System.Windows.Forms.RadioButton rbRFrwork3;
		private System.Windows.Forms.RadioButton rbRFrwork4;
		private System.Windows.Forms.RadioButton rbDbProvider12;
		private System.Windows.Forms.RadioButton rbDbProvider10;
		private System.Windows.Forms.RadioButton rbPdtUpgrade;
		private System.Windows.Forms.RadioButton rbDevUpgrade;
		private System.Windows.Forms.TextBox txtNewNS;
		private System.Windows.Forms.TextBox txtOldNS;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rbPtyUpgrade;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox gbUpgrade;
		private System.Windows.Forms.Label copyright;
		private System.Windows.Forms.PictureBox picReadMe;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ListView lvVersion;
		private System.Windows.Forms.PictureBox picLog;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbDbProvider16;
		private System.Windows.Forms.Button btnBackup;
		private System.Windows.Forms.TextBox txtBkPath1;
		private System.Windows.Forms.TextBox txtBkPath2;
		private System.Windows.Forms.Label lblBkPath1;
		private System.Windows.Forms.Label lblBkPath2;
		private System.Windows.Forms.CheckBox cbNew;
		private System.Windows.Forms.GroupBox gbNmspace;
		private System.Windows.Forms.Label lblDbPath;
		private System.Windows.Forms.TextBox txtDbPath;
        private System.Windows.Forms.GroupBox gbRptWs;
        private System.Windows.Forms.TextBox txtWsUrl;
		private System.Windows.Forms.TextBox txtWsTier;
		private System.Windows.Forms.GroupBox gbWs;
		private System.Windows.Forms.PictureBox picHelp;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtWebServer;
		private System.Windows.Forms.RichTextBox rtfLicense;
		private System.Windows.Forms.GroupBox gbXls;
		private System.Windows.Forms.TextBox txtXlsTier;
        private System.Windows.Forms.TextBox txtAppPassword;
        private System.Windows.Forms.TextBox txtAppUserName;
        private System.Windows.Forms.Label AppUsrLabel;
        private System.Windows.Forms.Label AppPwdLabel;
        private System.Windows.Forms.CheckBox cbSingleDeveloper;
        private System.Windows.Forms.RadioButton rbDbProvider14;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox cbInstallDB;
        private System.Windows.Forms.CheckBox cb32Bit;
        private System.Windows.Forms.CheckBox cbIntegratedSecurity;
        private System.Windows.Forms.CheckBox cbOverWrite;
    }
}