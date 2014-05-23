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
            this.cbComPorts = new System.Windows.Forms.ComboBox();
            this.atmoWakeNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseToTray
            // 
            this.btnCloseToTray.Location = new System.Drawing.Point(125, 19);
            this.btnCloseToTray.Name = "btnCloseToTray";
            this.btnCloseToTray.Size = new System.Drawing.Size(101, 38);
            this.btnCloseToTray.TabIndex = 1;
            this.btnCloseToTray.Text = "Close to tray";
            this.btnCloseToTray.UseVisualStyleBackColor = true;
            this.btnCloseToTray.Click += new System.EventHandler(this.btnCloseToTray_Click);
            // 
            // cbComPorts
            // 
            this.cbComPorts.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AtmoWakeHelper.Properties.Settings.Default, "comPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbComPorts.FormattingEnabled = true;
            this.cbComPorts.Location = new System.Drawing.Point(13, 29);
            this.cbComPorts.Name = "cbComPorts";
            this.cbComPorts.Size = new System.Drawing.Size(106, 21);
            this.cbComPorts.TabIndex = 0;
            this.cbComPorts.Text = global::AtmoWakeHelper.Properties.Settings.Default.comPort;
            this.cbComPorts.TextChanged += new System.EventHandler(this.cbComPorts_TextChanged);
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
            this.btnExitProgram.Location = new System.Drawing.Point(236, 61);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(91, 23);
            this.btnExitProgram.TabIndex = 2;
            this.btnExitProgram.Text = "Exit program";
            this.btnExitProgram.UseVisualStyleBackColor = true;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 91);
            this.Controls.Add(this.btnExitProgram);
            this.Controls.Add(this.btnCloseToTray);
            this.Controls.Add(this.cbComPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Atmo Wake Helper Service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbComPorts;
        private System.Windows.Forms.Button btnCloseToTray;
        private System.Windows.Forms.NotifyIcon atmoWakeNotifyIcon;
        private System.Windows.Forms.Button btnExitProgram;

    }
}

