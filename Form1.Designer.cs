namespace AtmoWakeHelper
{
    partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.btnCloseToTray = new System.Windows.Forms.Button();
      this.atmoWakeNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.btnExitProgram = new System.Windows.Forms.Button();
      this.lblAtmoWinFolder = new System.Windows.Forms.Label();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.btnBrowseAtmoWinFolder = new System.Windows.Forms.Button();
      this.tbAtmoWinFolder = new System.Windows.Forms.TextBox();
      this.cbstartAtmowin = new System.Windows.Forms.CheckBox();
      this.cbComPorts = new System.Windows.Forms.ComboBox();
      this.btnBrowseAtmoWakeHelperFolder = new System.Windows.Forms.Button();
      this.lblAtmoWakeHelperFolder = new System.Windows.Forms.Label();
      this.tbAtmoWakeHelperFolder = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnCloseToTray
      // 
      this.btnCloseToTray.Location = new System.Drawing.Point(160, 12);
      this.btnCloseToTray.Name = "btnCloseToTray";
      this.btnCloseToTray.Size = new System.Drawing.Size(167, 38);
      this.btnCloseToTray.TabIndex = 1;
      this.btnCloseToTray.Text = "Close to tray";
      this.btnCloseToTray.UseVisualStyleBackColor = true;
      this.btnCloseToTray.Click += new System.EventHandler(this.btnCloseToTray_Click);
      // 
      // atmoWakeNotifyIcon
      // 
      this.atmoWakeNotifyIcon.BalloonTipText = "Atmo Wake Helper Service";
      this.atmoWakeNotifyIcon.BalloonTipTitle = "Atmo Wake Helper Service";
      this.atmoWakeNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("atmoWakeNotifyIcon.Icon")));
      this.atmoWakeNotifyIcon.Text = "Atmowin Wake Helper";
      this.atmoWakeNotifyIcon.Visible = true;
      this.atmoWakeNotifyIcon.Click += new System.EventHandler(this.atmoWakeNotifyIcon_Click);
      // 
      // btnExitProgram
      // 
      this.btnExitProgram.Location = new System.Drawing.Point(236, 219);
      this.btnExitProgram.Name = "btnExitProgram";
      this.btnExitProgram.Size = new System.Drawing.Size(91, 23);
      this.btnExitProgram.TabIndex = 2;
      this.btnExitProgram.Text = "Exit program";
      this.btnExitProgram.UseVisualStyleBackColor = true;
      this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
      // 
      // lblAtmoWinFolder
      // 
      this.lblAtmoWinFolder.AutoSize = true;
      this.lblAtmoWinFolder.Location = new System.Drawing.Point(9, 68);
      this.lblAtmoWinFolder.Name = "lblAtmoWinFolder";
      this.lblAtmoWinFolder.Size = new System.Drawing.Size(206, 13);
      this.lblAtmoWinFolder.TabIndex = 5;
      this.lblAtmoWinFolder.Text = "Manually specify AtmoWin folder (optional)";
      // 
      // btnBrowseAtmoWinFolder
      // 
      this.btnBrowseAtmoWinFolder.Location = new System.Drawing.Point(251, 91);
      this.btnBrowseAtmoWinFolder.Name = "btnBrowseAtmoWinFolder";
      this.btnBrowseAtmoWinFolder.Size = new System.Drawing.Size(75, 23);
      this.btnBrowseAtmoWinFolder.TabIndex = 6;
      this.btnBrowseAtmoWinFolder.Text = "Browse";
      this.btnBrowseAtmoWinFolder.UseVisualStyleBackColor = true;
      this.btnBrowseAtmoWinFolder.Click += new System.EventHandler(this.btnBrowseAtmoWinFolder_Click);
      // 
      // tbAtmoWinFolder
      // 
      this.tbAtmoWinFolder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.tbAtmoWinFolder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
      this.tbAtmoWinFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AtmoWakeHelper.Properties.Settings.Default, "AtmoWinFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbAtmoWinFolder.Location = new System.Drawing.Point(12, 91);
      this.tbAtmoWinFolder.Name = "tbAtmoWinFolder";
      this.tbAtmoWinFolder.Size = new System.Drawing.Size(232, 20);
      this.tbAtmoWinFolder.TabIndex = 4;
      this.tbAtmoWinFolder.Text = global::AtmoWakeHelper.Properties.Settings.Default.AtmoWinFolder;
      this.tbAtmoWinFolder.Validating += new System.ComponentModel.CancelEventHandler(this.tbAtmoWinFolder_Validating);
      // 
      // cbstartAtmowin
      // 
      this.cbstartAtmowin.AutoSize = true;
      this.cbstartAtmowin.Checked = global::AtmoWakeHelper.Properties.Settings.Default.enabledAtmowinStart;
      this.cbstartAtmowin.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbstartAtmowin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AtmoWakeHelper.Properties.Settings.Default, "enabledAtmowinStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.cbstartAtmowin.Location = new System.Drawing.Point(13, 223);
      this.cbstartAtmowin.Name = "cbstartAtmowin";
      this.cbstartAtmowin.Size = new System.Drawing.Size(152, 17);
      this.cbstartAtmowin.TabIndex = 3;
      this.cbstartAtmowin.Text = "Start Atmowin after resume";
      this.cbstartAtmowin.UseVisualStyleBackColor = true;
      // 
      // cbComPorts
      // 
      this.cbComPorts.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AtmoWakeHelper.Properties.Settings.Default, "comPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.cbComPorts.FormattingEnabled = true;
      this.cbComPorts.Location = new System.Drawing.Point(13, 12);
      this.cbComPorts.Name = "cbComPorts";
      this.cbComPorts.Size = new System.Drawing.Size(120, 21);
      this.cbComPorts.TabIndex = 0;
      this.cbComPorts.Text = global::AtmoWakeHelper.Properties.Settings.Default.comPort;
      this.cbComPorts.TextChanged += new System.EventHandler(this.cbComPorts_TextChanged);
      // 
      // btnBrowseAtmoWakeHelperFolder
      // 
      this.btnBrowseAtmoWakeHelperFolder.Location = new System.Drawing.Point(251, 162);
      this.btnBrowseAtmoWakeHelperFolder.Name = "btnBrowseAtmoWakeHelperFolder";
      this.btnBrowseAtmoWakeHelperFolder.Size = new System.Drawing.Size(75, 23);
      this.btnBrowseAtmoWakeHelperFolder.TabIndex = 9;
      this.btnBrowseAtmoWakeHelperFolder.Text = "Browse";
      this.btnBrowseAtmoWakeHelperFolder.UseVisualStyleBackColor = true;
      this.btnBrowseAtmoWakeHelperFolder.Click += new System.EventHandler(this.btnBrowseAtmoWakeHelperFolder_Click);
      // 
      // lblAtmoWakeHelperFolder
      // 
      this.lblAtmoWakeHelperFolder.AutoSize = true;
      this.lblAtmoWakeHelperFolder.Location = new System.Drawing.Point(9, 139);
      this.lblAtmoWakeHelperFolder.Name = "lblAtmoWakeHelperFolder";
      this.lblAtmoWakeHelperFolder.Size = new System.Drawing.Size(247, 13);
      this.lblAtmoWakeHelperFolder.TabIndex = 8;
      this.lblAtmoWakeHelperFolder.Text = "Manually specify AtmoWakeHelper folder (optional)";
      // 
      // tbAtmoWakeHelperFolder
      // 
      this.tbAtmoWakeHelperFolder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.tbAtmoWakeHelperFolder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
      this.tbAtmoWakeHelperFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AtmoWakeHelper.Properties.Settings.Default, "AtmoWakeHelperFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbAtmoWakeHelperFolder.Location = new System.Drawing.Point(12, 162);
      this.tbAtmoWakeHelperFolder.Name = "tbAtmoWakeHelperFolder";
      this.tbAtmoWakeHelperFolder.Size = new System.Drawing.Size(232, 20);
      this.tbAtmoWakeHelperFolder.TabIndex = 7;
      this.tbAtmoWakeHelperFolder.Text = global::AtmoWakeHelper.Properties.Settings.Default.AtmoWakeHelperFolder;
      this.tbAtmoWakeHelperFolder.Validating += new System.ComponentModel.CancelEventHandler(this.tbAtmoWakeHelperFolder_Validating);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(335, 254);
      this.Controls.Add(this.btnBrowseAtmoWakeHelperFolder);
      this.Controls.Add(this.lblAtmoWakeHelperFolder);
      this.Controls.Add(this.tbAtmoWakeHelperFolder);
      this.Controls.Add(this.btnBrowseAtmoWinFolder);
      this.Controls.Add(this.lblAtmoWinFolder);
      this.Controls.Add(this.tbAtmoWinFolder);
      this.Controls.Add(this.cbstartAtmowin);
      this.Controls.Add(this.btnExitProgram);
      this.Controls.Add(this.btnCloseToTray);
      this.Controls.Add(this.cbComPorts);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "AtmoWakeHelper";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.Resize += new System.EventHandler(this.Form1_Resize);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbComPorts;
        private System.Windows.Forms.Button btnCloseToTray;
        private System.Windows.Forms.NotifyIcon atmoWakeNotifyIcon;
        private System.Windows.Forms.Button btnExitProgram;
        private System.Windows.Forms.CheckBox cbstartAtmowin;
        private System.Windows.Forms.TextBox tbAtmoWinFolder;
        private System.Windows.Forms.Label lblAtmoWinFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnBrowseAtmoWinFolder;
        private System.Windows.Forms.Button btnBrowseAtmoWakeHelperFolder;
        private System.Windows.Forms.Label lblAtmoWakeHelperFolder;
        private System.Windows.Forms.TextBox tbAtmoWakeHelperFolder;

    }
}

