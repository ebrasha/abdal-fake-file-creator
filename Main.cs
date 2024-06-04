using Abdal_Security_Group_App.Core;
using System.Diagnostics;
using System.Reflection;
using Telerik.WinControls.Enumerations;

namespace Abdal_Security_Group_App
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        private bool stop_op_status = false;
        private string abdal_app_name = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0];
        private AbdalSoundPlayer ab_player = new AbdalSoundPlayer();

        private string abdal_app_name_for_url = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0]
            .ToLower().Replace(' ', '-');


        public Main()
        {
            InitializeComponent();
            //change form title
            Version version = Assembly.GetExecutingAssembly().GetName().Version!;
            Text = abdal_app_name + " " + version.Major + "." + version.Minor;

            // Call Global Chilkat Unlock
            ChilkatMng.UnlockChilkat();
        }

        #region Dragable Form Start

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
            for (char drive = 'A'; drive <= 'Z'; drive++)
            {
                drive_list.Items.Add(drive.ToString());
            }
        }

        private void menuItem_github_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.Start(new ProcessStartInfo("https://github.com/ebrasha/" + abdal_app_name_for_url)
            { UseShellExecute = true });
        }

        private void menuItem_gitlab_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.Start(new ProcessStartInfo("https://gitlab.com/Prof.Shafiei/" + abdal_app_name_for_url)
            { UseShellExecute = true });
        }

        private void menuItem_donate_Click(object sender, EventArgs e)
        {
        }

        private void menuItem_about_us_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            about_us about_form = new Abdal_Security_Group_App.about_us();
            about_form.ShowDialog();
            about_form.TopMost = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }

        private void bg_worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            waitingBar.StopWaiting();
            waitingBar.Visible = false;
            if (e.Cancelled == true)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Canceled Process By User!";
                this.desk_alert.Show();
                ab_player.sPlayer("cancel");
            }
            else if (e.Error != null)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = e.Error.Message;
                this.desk_alert.Show();


                ab_player.sPlayer("error");
            }
            else
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Done!";
                this.desk_alert.Show();

                if (stop_op_status)
                {
                    ab_player.sPlayerSync("cancel");
                }
                else
                {
                    ab_player.sPlayerSync("op-com");
                }

                ab_player.sPlayer("done");
            }
        }

        static bool DriveExists(string driveName)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();


            foreach (DriveInfo drive in allDrives)
            {
                if (drive.Name.Equals(driveName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            string driveName = drive_list.Text + ":\\";
            bool driveExists = DriveExists(driveName);

            if (tbFileName.Text == "")
            {
                ab_player.sPlayer("error");
                ShowMessage(
                    "The file name is not specified. Please enter the file name along with the extension first");
            }
            else if (!driveExists)
            {
                ab_player.sPlayer("error");
                ShowMessage($"The drive {driveName} does not exist");
            }
            else
            {
                if (bg_worker.IsBusy != true)
                {
                    waitingBar.StartWaiting();
                    waitingBar.Visible = true;
                    bg_worker.RunWorkerAsync();
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void irDonationBtn_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("coin");
            Process.Start(new ProcessStartInfo("https://alphajet.ir/abdal-donation") { UseShellExecute = true });
        }

        private void EnDonationBtn_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("coin");
            Process.Start(new ProcessStartInfo("https://ebrasha.com/abdal-donation") { UseShellExecute = true });
        }

        public void ShowMessage(string message)
        {
            this.desk_alert.CaptionText = abdal_app_name;
            this.desk_alert.ContentText = message;
            this.desk_alert.Show();
        }

        private void bg_worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            long fileSize = 0;
            if (!string.IsNullOrEmpty(drive_list.Text) && drive_list.Text.Length == 1)
            {
                string driveName = drive_list.Text + ":\\";

                // Check if the drive exists
                if (DriveInfo.GetDrives().Any(d => d.Name.Equals(driveName, StringComparison.OrdinalIgnoreCase)))
                {
                    DriveInfo driveInfo = new DriveInfo(driveName);

                    // Get the available free space in bytes
                    long availableFreeSpace = driveInfo.AvailableFreeSpace;
                    fileSize = availableFreeSpace;

                    // If fileSize is 0 or more than available space, use availableFreeSpace
                    if (fillDriveToggleSwitch.Value)
                    {
                        tbFileSize.Text = availableFreeSpace.ToString();
                        radioBtByteUnit.ToggleState = ToggleState.On;
                    }
                    else
                    {
                        if (radioBtByteUnit.ToggleState == ToggleState.On)
                        {
                            fileSize = Convert.ToInt64(tbFileSize.Text);
                        }

                        if (radioBtMBUnit.ToggleState == ToggleState.On)
                        {
                            fileSize = Convert.ToInt64(tbFileSize.Text) * 1048576;
                        }

                        if (radioBtGBUnit.ToggleState == ToggleState.On)
                        {
                            fileSize = Convert.ToInt64(tbFileSize.Text) * 1073741824;
                        }
                    }

                    // Create a file to fill the free space
                    string filePath = Path.Combine(driveName, tbFileName.Text);

                    ShowMessage($"Creating a file '{tbFileName.Text}' with {fileSize} bytes.");


                    try
                    {
                        // Run the fsutil command to create the file
                        ProcessStartInfo processStartInfo = new ProcessStartInfo("fsutil")
                        {
                            Arguments = $"file createnew {filePath} {fileSize}",
                            RedirectStandardOutput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        using (Process process = Process.Start(processStartInfo))
                        {
                            process.WaitForExit();

                            // Display the output of the command
                            string output = process.StandardOutput.ReadToEnd();
                            ShowMessage(output);
                        }

                        ShowMessage("File created successfully.");
                    }
                    catch (Exception ex)
                    {
                        ab_player.sPlayer("error");
                        ShowMessage($"An error occurred: {ex.Message}");
                    }
                }
                else
                {
                    ab_player.sPlayer("error");
                    ShowMessage("Invalid drive letter or drive does not exist.");
                }
            }
            else
            {
                ab_player.sPlayer("error");
                ShowMessage("Invalid input. Please enter a single drive letter.");
            }
        }

        private void tbFileSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}