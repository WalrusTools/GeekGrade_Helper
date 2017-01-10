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
            this.latestFirmware = new System.Windows.Forms.CheckBox();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.openIPSW = new System.Windows.Forms.OpenFileDialog();
            this.runButton = new System.Windows.Forms.Button();
            this.selectIPSWButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // latestFirmware
            // 
            this.latestFirmware.AutoSize = true;
            this.latestFirmware.Location = new System.Drawing.Point(223, 234);
            this.latestFirmware.Name = "latestFirmware";
            this.latestFirmware.Size = new System.Drawing.Size(146, 17);
            this.latestFirmware.TabIndex = 5;
            this.latestFirmware.Text = "Download latest iOS ipsw";
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
            this.runButton.Location = new System.Drawing.Point(164, 261);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(295, 51);
            this.runButton.TabIndex = 12;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // selectIPSWButton
            // 
            this.selectIPSWButton.Location = new System.Drawing.Point(168, 110);
            this.selectIPSWButton.Name = "selectIPSWButton";
            this.selectIPSWButton.Size = new System.Drawing.Size(295, 51);
            this.selectIPSWButton.TabIndex = 13;
            this.selectIPSWButton.Text = "Select IPSW";
            this.selectIPSWButton.UseVisualStyleBackColor = true;
            this.selectIPSWButton.Click += new System.EventHandler(this.selectIPSWButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(179, 153);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(289, 52);
            this.instructionLabel.TabIndex = 14;
            this.instructionLabel.Text = "This program will help you restore your device back to stock\r\niOS in a couple eas" +
    "y steps!\r\n\r\nSelect \"Step 1\" to get started";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome to iDeviceRestore GUI!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 341);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.instructionLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Welcome";
            // 
            // tabPage2
            // 
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
            this.tabPage3.Controls.Add(this.runButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(647, 315);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Step 2";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 378);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.githubLink);
            this.Name = "MainWindow";
            this.Text = "idevicerestore gui";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox latestFirmware;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.OpenFileDialog openIPSW;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button selectIPSWButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

