namespace subte.cc
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.domain1 = new System.Windows.Forms.TextBox();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.domain5 = new System.Windows.Forms.TextBox();
            this.domain4 = new System.Windows.Forms.TextBox();
            this.domain3 = new System.Windows.Forms.TextBox();
            this.domain2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.notificationsBox = new System.Windows.Forms.CheckBox();
            this.updateInterval = new System.Windows.Forms.NumericUpDown();
            this.timeLabel = new System.Windows.Forms.Label();
            this.autoupdateLabel = new System.Windows.Forms.Label();
            this.updateBox = new System.Windows.Forms.CheckBox();
            this.autostartBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.codeLabel = new System.Windows.Forms.Label();
            this.licenseLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateInterval)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Subte.cc is now running in the background";
            this.notifyIcon1.BalloonTipTitle = "Subte.cc";
            this.notifyIcon1.ContextMenuStrip = this.contextMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "subte.cc";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(93, 26);
            this.contextMenu.Text = "subte.cc";
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(92, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // domain1
            // 
            this.domain1.Location = new System.Drawing.Point(38, 46);
            this.domain1.Name = "domain1";
            this.domain1.Size = new System.Drawing.Size(188, 20);
            this.domain1.TabIndex = 0;
            this.domain1.TextChanged += new System.EventHandler(this.domains_TextChanged);
            // 
            // tokenBox
            // 
            this.tokenBox.Location = new System.Drawing.Point(31, 35);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(188, 20);
            this.tokenBox.TabIndex = 0;
            this.tokenBox.TextChanged += new System.EventHandler(this.tokenBox_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 247);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.domain5);
            this.tabPage1.Controls.Add(this.domain4);
            this.tabPage1.Controls.Add(this.domain3);
            this.tabPage1.Controls.Add(this.domain2);
            this.tabPage1.Controls.Add(this.domain1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(352, 221);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Domains";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Update Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 117);
            this.label2.TabIndex = 10;
            this.label2.Text = "1\r\n\r\n2\r\n\r\n3\r\n\r\n4\r\n\r\n5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Domain List";
            // 
            // domain5
            // 
            this.domain5.Location = new System.Drawing.Point(38, 150);
            this.domain5.Name = "domain5";
            this.domain5.Size = new System.Drawing.Size(188, 20);
            this.domain5.TabIndex = 8;
            this.domain5.TextChanged += new System.EventHandler(this.domains_TextChanged);
            // 
            // domain4
            // 
            this.domain4.Location = new System.Drawing.Point(38, 124);
            this.domain4.Name = "domain4";
            this.domain4.Size = new System.Drawing.Size(188, 20);
            this.domain4.TabIndex = 6;
            this.domain4.TextChanged += new System.EventHandler(this.domains_TextChanged);
            // 
            // domain3
            // 
            this.domain3.Location = new System.Drawing.Point(38, 98);
            this.domain3.Name = "domain3";
            this.domain3.Size = new System.Drawing.Size(188, 20);
            this.domain3.TabIndex = 4;
            this.domain3.TextChanged += new System.EventHandler(this.domains_TextChanged);
            // 
            // domain2
            // 
            this.domain2.Location = new System.Drawing.Point(38, 72);
            this.domain2.Name = "domain2";
            this.domain2.Size = new System.Drawing.Size(188, 20);
            this.domain2.TabIndex = 2;
            this.domain2.TextChanged += new System.EventHandler(this.domains_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.notificationsBox);
            this.tabPage2.Controls.Add(this.updateInterval);
            this.tabPage2.Controls.Add(this.timeLabel);
            this.tabPage2.Controls.Add(this.autoupdateLabel);
            this.tabPage2.Controls.Add(this.updateBox);
            this.tabPage2.Controls.Add(this.autostartBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tokenBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(352, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // notificationsBox
            // 
            this.notificationsBox.AutoSize = true;
            this.notificationsBox.Checked = true;
            this.notificationsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notificationsBox.Location = new System.Drawing.Point(31, 157);
            this.notificationsBox.Name = "notificationsBox";
            this.notificationsBox.Size = new System.Drawing.Size(84, 17);
            this.notificationsBox.TabIndex = 10;
            this.notificationsBox.Text = "Notifications";
            this.notificationsBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.notificationsBox.UseVisualStyleBackColor = true;
            this.notificationsBox.CheckedChanged += new System.EventHandler(this.notificationsBox_CheckedChanged);
            // 
            // updateInterval
            // 
            this.updateInterval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.updateInterval.Location = new System.Drawing.Point(31, 131);
            this.updateInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updateInterval.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.updateInterval.Name = "updateInterval";
            this.updateInterval.Size = new System.Drawing.Size(112, 20);
            this.updateInterval.TabIndex = 9;
            this.updateInterval.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.updateInterval.ValueChanged += new System.EventHandler(this.updateInterval_ValueChanged);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Enabled = false;
            this.timeLabel.Location = new System.Drawing.Point(149, 133);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(43, 13);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "minutes";
            // 
            // autoupdateLabel
            // 
            this.autoupdateLabel.AutoSize = true;
            this.autoupdateLabel.Enabled = false;
            this.autoupdateLabel.Location = new System.Drawing.Point(28, 112);
            this.autoupdateLabel.Name = "autoupdateLabel";
            this.autoupdateLabel.Size = new System.Drawing.Size(96, 13);
            this.autoupdateLabel.TabIndex = 7;
            this.autoupdateLabel.Text = "Auto-Update every";
            // 
            // updateBox
            // 
            this.updateBox.AutoSize = true;
            this.updateBox.Location = new System.Drawing.Point(31, 88);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(86, 17);
            this.updateBox.TabIndex = 5;
            this.updateBox.Text = "Auto-Update";
            this.updateBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.updateBox.UseVisualStyleBackColor = true;
            this.updateBox.CheckedChanged += new System.EventHandler(this.updateBox_CheckedChanged);
            // 
            // autostartBox
            // 
            this.autostartBox.AutoSize = true;
            this.autostartBox.Location = new System.Drawing.Point(31, 65);
            this.autostartBox.Name = "autostartBox";
            this.autostartBox.Size = new System.Drawing.Size(68, 17);
            this.autostartBox.TabIndex = 4;
            this.autostartBox.Text = "Autostart";
            this.autostartBox.UseVisualStyleBackColor = true;
            this.autostartBox.CheckedChanged += new System.EventHandler(this.autostartBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Token";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.linkLabel);
            this.tabPage3.Controls.Add(this.codeLabel);
            this.tabPage3.Controls.Add(this.licenseLabel);
            this.tabPage3.Controls.Add(this.titleLabel);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(352, 221);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(158, 139);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(152, 26);
            this.linkLabel.TabIndex = 4;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "https://codeberg.org/subte-cc\r\n/subteccwindows";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(157, 123);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(112, 13);
            this.codeLabel.TabIndex = 3;
            this.codeLabel.Text = "Code can be found in:";
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Location = new System.Drawing.Point(157, 106);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(176, 13);
            this.licenseLabel.TabIndex = 2;
            this.licenseLabel.Text = "Licensed under the GPL-2.0 license";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(156, 52);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(181, 48);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "subte.cc Standalone\r\nWindows Client";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::subte.cc.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 271);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 310);
            this.MinimumSize = new System.Drawing.Size(400, 310);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "subte.cc";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateInterval)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox domain1;
        private System.Windows.Forms.TextBox tokenBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox domain5;
        private System.Windows.Forms.TextBox domain4;
        private System.Windows.Forms.TextBox domain3;
        private System.Windows.Forms.TextBox domain2;
        private System.Windows.Forms.CheckBox updateBox;
        private System.Windows.Forms.CheckBox autostartBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label autoupdateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown updateInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox notificationsBox;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label licenseLabel;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label codeLabel;
    }
}

