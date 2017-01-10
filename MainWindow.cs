using System;
using System.Text;
using System.Diagnostics;

using System.Windows.Forms;

namespace GeekGradeHelper
{
    public partial class MainWindow : Form
    {
        private string ipswFilePath;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            StringBuilder information = new StringBuilder();
            information.AppendLine("- iOS 10<= support.");
            information.AppendLine("- No iTunes needed.");
            information.AppendLine("- Using a precompiled version for Windows! / https://github.com/ryanguy426/idevicerestore-gui");
            information.AppendLine("- Using libimobiledevice, libirecovery & idevicerestore.");

            MessageBox.Show(information.ToString(), "IPSW Restore about", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void selectIPSWButton_Click(object sender, EventArgs e)
        {
            openIPSW.Filter = "IPSW files|*.ipsw";
            if (openIPSW.ShowDialog() == DialogResult.OK)
            {
                ipswFilePath = openIPSW.FileName;

                var items = checkedListBox1.Items;
                items[0] = "IPSW to use: " + "'" + openIPSW.FileName + "'";
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            StringBuilder cmd = new StringBuilder();
            // cmd.Append("idevicrestore.exe ");

            // Step 1
            if (latestFirmware.Checked)
            {
                // Automatically download latest iOS version for connected device from Apple
                cmd.Append("-l ");
            }
            else if (ipswFilePath == null)
            {
                MessageBox.Show("Please either specify an IPSW, or download one from Apple!", "No IPSW selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 2

            // Fully restore. AKA "Format iDevice"
            cmd.Append("-e ");


            if (ipswFilePath != null)
            {
                cmd.Append(" \"" + ipswFilePath + "\" ");
            }

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "idevicerestore.exe",
                    Arguments = cmd.ToString()
                }
            };
            process.Start();
            process.WaitForExit();

            MessageBox.Show("Device should now be restored!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ryanguy426/idevicerestore-gui");
        }

        private void latestFirmware_CheckedChanged(object sender, EventArgs e)
        {

            if (latestFirmware.Checked == true)
            {
                // Checkbox is checked (true)

                // Change button text to make more sense to the current situation
                selectIPSWButton.Text = "Will use latest available from Apple";
                // We checked this box, disable the "Select IPSW" button
                selectIPSWButton.Enabled = false;
                var items = checkedListBox1.Items;

                items[0] = "IPSW file to use: Latest version from Apple";
            }

            if(latestFirmware.Checked == false)
            {
                // Checkbox is checked (false)

                // Change button text to "Select IPSW" as we aren't downloading it
                selectIPSWButton.Text = "Select IPSW";
                // We unchecked this box, enable the "Select IPSW" button
                selectIPSWButton.Enabled = true;

                if(ipswFilePath != null)
                {
                    var items = checkedListBox1.Items;
                    items[0] = "IPSW file to use: " + ipswFilePath;
                }
                if(ipswFilePath == null)
                {
                    var items = checkedListBox1.Items;

                    items[0] = "IPSW file to use: None selected!";
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == checkedListBox1.Items.Count)
            {
                // If all checkboxes are checked and an IPSW option is selected, feel free to enable the restore button

                if(ipswFilePath != null || latestFirmware.Checked == true)
                {
                    runButton.Enabled = true;
                }
            }
            else
            {
                runButton.Enabled = false;
            }
        }
    }
}
