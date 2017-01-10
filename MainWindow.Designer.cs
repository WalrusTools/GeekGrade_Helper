namespace IPSW_Restorer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.latestFirmware = new System.Windows.Forms.CheckBox();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.openIPSW = new System.Windows.Forms.OpenFileDialog();
            this.runButton = new System.Windows.Forms.Button();
            this.selectIPSWButton = new System.Windows.Forms.Button();
            this.welcomeInfoLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.stepGUI = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.step1InfoLabel = new System.Windows.Forms.Label();
            this.step1TitleLabel = new System.Windows.Forms.Label();
            this.step2TitleLabel = new System.Windows.Forms.Label();
            this.step2InfoLabel = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.step2OverviewLabel = new System.Windows.Forms.Label();
            this.overviewInfo = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.stepGUI.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // latestFirmware
            // 
            this.latestFirmware.AutoSize = true;
            this.latestFirmware.Location = new System.Drawing.Point(247, 226);
            this.latestFirmware.Name = "latestFirmware";
            this.latestFirmware.Size = new System.Drawing.Size(153, 17);
            this.latestFirmware.TabIndex = 5;
            this.latestFirmware.Text = "Download latest iOS IPSW";
            this.latestFirmware.UseVisualStyleBackColor = true;
            this.latestFirmware.CheckedChanged += new System.EventHandler(this.latestFirmware_CheckedChanged);
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Location = new System.Drawing.Point(585, 356);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(82, 13);
            this.githubLink.TabIndex = 11;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "View on Github!";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // runButton
            // 
            this.runButton.Enabled = false;
            this.runButton.Location = new System.Drawing.Point(178, 247);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(295, 51);
            this.runButton.TabIndex = 12;
            this.runButton.Text = "Restore!";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // selectIPSWButton
            // 
            this.selectIPSWButton.Location = new System.Drawing.Point(176, 169);
            this.selectIPSWButton.Name = "selectIPSWButton";
            this.selectIPSWButton.Size = new System.Drawing.Size(295, 51);
            this.selectIPSWButton.TabIndex = 13;
            this.selectIPSWButton.Text = "Select IPSW";
            this.selectIPSWButton.UseVisualStyleBackColor = true;
            this.selectIPSWButton.Click += new System.EventHandler(this.selectIPSWButton_Click);
            // 
            // welcomeInfoLabel
            // 
            this.welcomeInfoLabel.AutoSize = true;
            this.welcomeInfoLabel.Location = new System.Drawing.Point(179, 153);
            this.welcomeInfoLabel.Name = "welcomeInfoLabel";
            this.welcomeInfoLabel.Size = new System.Drawing.Size(289, 52);
            this.welcomeInfoLabel.TabIndex = 14;
            this.welcomeInfoLabel.Text = "This program will help you restore your device back to stock\r\niOS in a couple eas" +
    "y steps!\r\n\r\nSelect \"Step 1\" to get started";
            this.welcomeInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(187, 109);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(273, 20);
            this.welcomeLabel.TabIndex = 15;
            this.welcomeLabel.Text = "Welcome to iDeviceRestore GUI!";
            // 
            // stepGUI
            // 
            this.stepGUI.Controls.Add(this.tabPage1);
            this.stepGUI.Controls.Add(this.tabPage2);
            this.stepGUI.Controls.Add(this.tabPage3);
            this.stepGUI.Controls.Add(this.tabPage4);
            this.stepGUI.Location = new System.Drawing.Point(12, 12);
            this.stepGUI.Name = "stepGUI";
            this.stepGUI.SelectedIndex = 0;
            this.stepGUI.Size = new System.Drawing.Size(655, 341);
            this.stepGUI.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.welcomeInfoLabel);
            this.tabPage1.Controls.Add(this.welcomeLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Welcome";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.step1TitleLabel);
            this.tabPage2.Controls.Add(this.step1InfoLabel);
            this.tabPage2.Controls.Add(this.selectIPSWButton);
            this.tabPage2.Controls.Add(this.latestFirmware);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(647, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Step 1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.step2InfoLabel);
            this.tabPage3.Controls.Add(this.step2TitleLabel);
            this.tabPage3.Controls.Add(this.runButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(647, 315);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Final step";
            // 
            // step1InfoLabel
            // 
            this.step1InfoLabel.AutoSize = true;
            this.step1InfoLabel.Location = new System.Drawing.Point(193, 38);
            this.step1InfoLabel.Name = "step1InfoLabel";
            this.step1InfoLabel.Size = new System.Drawing.Size(261, 104);
            this.step1InfoLabel.TabIndex = 14;
            this.step1InfoLabel.Text = resources.GetString("step1InfoLabel.Text");
            this.step1InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // step1TitleLabel
            // 
            this.step1TitleLabel.AutoSize = true;
            this.step1TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step1TitleLabel.Location = new System.Drawing.Point(179, 12);
            this.step1TitleLabel.Name = "step1TitleLabel";
            this.step1TitleLabel.Size = new System.Drawing.Size(289, 20);
            this.step1TitleLabel.TabIndex = 15;
            this.step1TitleLabel.Text = "Selecting an IPSW - Which option?";
            this.step1TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // step2TitleLabel
            // 
            this.step2TitleLabel.AutoSize = true;
            this.step2TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step2TitleLabel.Location = new System.Drawing.Point(237, 12);
            this.step2TitleLabel.Name = "step2TitleLabel";
            this.step2TitleLabel.Size = new System.Drawing.Size(173, 20);
            this.step2TitleLabel.TabIndex = 13;
            this.step2TitleLabel.Text = "Begin device restore";
            // 
            // step2InfoLabel
            // 
            this.step2InfoLabel.AutoSize = true;
            this.step2InfoLabel.Location = new System.Drawing.Point(188, 42);
            this.step2InfoLabel.Name = "step2InfoLabel";
            this.step2InfoLabel.Size = new System.Drawing.Size(270, 78);
            this.step2InfoLabel.TabIndex = 14;
            this.step2InfoLabel.Text = resources.GetString("step2InfoLabel.Text");
            this.step2InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkedListBox1);
            this.tabPage4.Controls.Add(this.overviewInfo);
            this.tabPage4.Controls.Add(this.step2OverviewLabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(647, 315);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Overview";
            // 
            // step2OverviewLabel
            // 
            this.step2OverviewLabel.AutoSize = true;
            this.step2OverviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step2OverviewLabel.Location = new System.Drawing.Point(283, 12);
            this.step2OverviewLabel.Name = "step2OverviewLabel";
            this.step2OverviewLabel.Size = new System.Drawing.Size(80, 20);
            this.step2OverviewLabel.TabIndex = 17;
            this.step2OverviewLabel.Text = "Overview";
            // 
            // overviewInfo
            // 
            this.overviewInfo.AutoSize = true;
            this.overviewInfo.Location = new System.Drawing.Point(185, 43);
            this.overviewInfo.Name = "overviewInfo";
            this.overviewInfo.Size = new System.Drawing.Size(276, 65);
            this.overviewInfo.TabIndex = 18;
            this.overviewInfo.Text = resources.GetString("overviewInfo.Text");
            this.overviewInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "IPSW to use: None selected!"});
            this.checkedListBox1.Location = new System.Drawing.Point(188, 154);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(273, 124);
            this.checkedListBox1.TabIndex = 19;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 378);
            this.Controls.Add(this.stepGUI);
            this.Controls.Add(this.githubLink);
            this.Name = "MainWindow";
            this.Text = "idevicerestore gui";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.stepGUI.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox latestFirmware;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.OpenFileDialog openIPSW;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button selectIPSWButton;
        private System.Windows.Forms.Label welcomeInfoLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TabControl stepGUI;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label step1InfoLabel;
        private System.Windows.Forms.Label step1TitleLabel;
        private System.Windows.Forms.Label step2InfoLabel;
        private System.Windows.Forms.Label step2TitleLabel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label overviewInfo;
        private System.Windows.Forms.Label step2OverviewLabel;
    }
}

