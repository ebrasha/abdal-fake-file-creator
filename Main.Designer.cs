namespace Abdal_Security_Group_App
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            visualStudio2022DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2022DarkTheme();
            radMenu1 = new Telerik.WinControls.UI.RadMenu();
            menuItem_about_us = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_donate = new Telerik.WinControls.UI.RadMenuItem();
            irDonationBtn = new Telerik.WinControls.UI.RadMenuItem();
            EnDonationBtn = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_github = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_gitlab = new Telerik.WinControls.UI.RadMenuItem();
            desk_alert = new Telerik.WinControls.UI.RadDesktopAlert(components);
            bg_worker = new System.ComponentModel.BackgroundWorker();
            btn_start = new Telerik.WinControls.UI.RadButton();
            btn_exit = new PictureBox();
            btn_minimize = new PictureBox();
            drive_list = new Telerik.WinControls.UI.RadDropDownList();
            tbFileSize = new Telerik.WinControls.UI.RadTextBox();
            fillDriveToggleSwitch = new Telerik.WinControls.UI.RadToggleSwitch();
            radioBtByteUnit = new Telerik.WinControls.UI.RadRadioButton();
            radioBtGBUnit = new Telerik.WinControls.UI.RadRadioButton();
            radioBtMBUnit = new Telerik.WinControls.UI.RadRadioButton();
            radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            waitingBarIndicatorElement1 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            waitingBarIndicatorElement2 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            tbFileName = new Telerik.WinControls.UI.RadTextBox();
            waitingBar = new Telerik.WinControls.UI.RadWaitingBar();
            ((System.ComponentModel.ISupportInitialize)radMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)drive_list).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbFileSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fillDriveToggleSwitch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radioBtByteUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radioBtGBUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radioBtMBUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbFileName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)waitingBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radMenu1
            // 
            radMenu1.Dock = DockStyle.Bottom;
            radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] { menuItem_about_us, menuItem_donate, radMenuItem3 });
            radMenu1.Location = new Point(0, 552);
            radMenu1.Name = "radMenu1";
            radMenu1.Size = new Size(390, 28);
            radMenu1.TabIndex = 0;
            radMenu1.ThemeName = "VisualStudio2022Dark";
            // 
            // menuItem_about_us
            // 
            menuItem_about_us.Image = Properties.Resources.user_16x16;
            menuItem_about_us.Name = "menuItem_about_us";
            menuItem_about_us.Text = "About Us";
            menuItem_about_us.Click += menuItem_about_us_Click;
            // 
            // menuItem_donate
            // 
            menuItem_donate.Image = Properties.Resources.dollar16x16;
            menuItem_donate.Items.AddRange(new Telerik.WinControls.RadItem[] { irDonationBtn, EnDonationBtn });
            menuItem_donate.Name = "menuItem_donate";
            menuItem_donate.Text = "Donate";
            // 
            // irDonationBtn
            // 
            irDonationBtn.Image = Properties.Resources.iran_16x16;
            irDonationBtn.Name = "irDonationBtn";
            irDonationBtn.Text = "Persian speaker";
            irDonationBtn.Click += irDonationBtn_Click;
            // 
            // EnDonationBtn
            // 
            EnDonationBtn.Image = Properties.Resources.United_Kingdom16x16;
            EnDonationBtn.Name = "EnDonationBtn";
            EnDonationBtn.Text = "English speaker";
            EnDonationBtn.Click += EnDonationBtn_Click;
            // 
            // radMenuItem3
            // 
            radMenuItem3.Image = Properties.Resources.git_pull_request16x16;
            radMenuItem3.Items.AddRange(new Telerik.WinControls.RadItem[] { menuItem_github, menuItem_gitlab });
            radMenuItem3.Name = "radMenuItem3";
            radMenuItem3.Text = "Source Code";
            // 
            // menuItem_github
            // 
            menuItem_github.Image = Properties.Resources.github;
            menuItem_github.Name = "menuItem_github";
            menuItem_github.Text = "Github";
            menuItem_github.Click += menuItem_github_Click;
            // 
            // menuItem_gitlab
            // 
            menuItem_gitlab.Image = Properties.Resources.gitlab_icon_rgb;
            menuItem_gitlab.Name = "menuItem_gitlab";
            menuItem_gitlab.Text = "Gitlab";
            menuItem_gitlab.Click += menuItem_gitlab_Click;
            // 
            // bg_worker
            // 
            bg_worker.DoWork += bg_worker_DoWork;
            bg_worker.RunWorkerCompleted += bg_worker_RunWorkerCompleted;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(46, 483);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(110, 24);
            btn_start.TabIndex = 1;
            btn_start.Text = "Start";
            btn_start.ThemeName = "VisualStudio2022Dark";
            btn_start.Click += btn_start_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Transparent;
            btn_exit.BackgroundImage = Properties.Resources.x_circle_21x21;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Location = new Point(7, 10);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(21, 21);
            btn_exit.TabIndex = 2;
            btn_exit.TabStop = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_minimize
            // 
            btn_minimize.BackColor = Color.Transparent;
            btn_minimize.BackgroundImage = Properties.Resources.minus_circle_21x21;
            btn_minimize.Cursor = Cursors.Hand;
            btn_minimize.Location = new Point(34, 10);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(21, 21);
            btn_minimize.TabIndex = 3;
            btn_minimize.TabStop = false;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // drive_list
            // 
            drive_list.DropDownAnimationEnabled = true;
            drive_list.Location = new Point(46, 297);
            drive_list.Name = "drive_list";
            drive_list.Size = new Size(177, 22);
            drive_list.TabIndex = 5;
            drive_list.Text = "C";
            drive_list.ThemeName = "VisualStudio2022Dark";
            // 
            // tbFileSize
            // 
            tbFileSize.Location = new Point(46, 366);
            tbFileSize.Name = "tbFileSize";
            tbFileSize.NullText = "Enter the required file size";
            tbFileSize.Size = new Size(158, 22);
            tbFileSize.TabIndex = 6;
            tbFileSize.ThemeName = "VisualStudio2022Dark";
            tbFileSize.KeyPress += tbFileSize_KeyPress;
            // 
            // fillDriveToggleSwitch
            // 
            fillDriveToggleSwitch.Location = new Point(229, 297);
            fillDriveToggleSwitch.Name = "fillDriveToggleSwitch";
            fillDriveToggleSwitch.OffText = "Fill Full Drive OFF";
            fillDriveToggleSwitch.OnText = "Fill Full Drive ON";
            fillDriveToggleSwitch.Size = new Size(123, 20);
            fillDriveToggleSwitch.TabIndex = 7;
            fillDriveToggleSwitch.ThemeName = "VisualStudio2022Dark";
            fillDriveToggleSwitch.ThumbTickness = 16;
            fillDriveToggleSwitch.Value = false;
            // 
            // radioBtByteUnit
            // 
            radioBtByteUnit.CheckState = CheckState.Checked;
            radioBtByteUnit.Location = new Point(224, 369);
            radioBtByteUnit.Name = "radioBtByteUnit";
            radioBtByteUnit.Size = new Size(42, 19);
            radioBtByteUnit.TabIndex = 8;
            radioBtByteUnit.Text = "byte";
            radioBtByteUnit.ThemeName = "VisualStudio2022Dark";
            radioBtByteUnit.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radioBtGBUnit
            // 
            radioBtGBUnit.Location = new Point(318, 369);
            radioBtGBUnit.Name = "radioBtGBUnit";
            radioBtGBUnit.Size = new Size(34, 19);
            radioBtGBUnit.TabIndex = 9;
            radioBtGBUnit.TabStop = false;
            radioBtGBUnit.Text = "GB";
            radioBtGBUnit.ThemeName = "VisualStudio2022Dark";
            // 
            // radioBtMBUnit
            // 
            radioBtMBUnit.Location = new Point(271, 369);
            radioBtMBUnit.Name = "radioBtMBUnit";
            radioBtMBUnit.Size = new Size(37, 19);
            radioBtMBUnit.TabIndex = 9;
            radioBtMBUnit.TabStop = false;
            radioBtMBUnit.Text = "MB";
            radioBtMBUnit.ThemeName = "VisualStudio2022Dark";
            // 
            // waitingBarIndicatorElement1
            // 
            waitingBarIndicatorElement1.Name = "waitingBarIndicatorElement1";
            waitingBarIndicatorElement1.StretchHorizontally = false;
            // 
            // waitingBarIndicatorElement2
            // 
            waitingBarIndicatorElement2.Name = "waitingBarIndicatorElement2";
            waitingBarIndicatorElement2.StretchHorizontally = false;
            // 
            // tbFileName
            // 
            tbFileName.Location = new Point(46, 331);
            tbFileName.Name = "tbFileName";
            tbFileName.NullText = "Please enter the file name with the extension";
            tbFileName.Size = new Size(306, 22);
            tbFileName.TabIndex = 7;
            tbFileName.ThemeName = "VisualStudio2022Dark";
            // 
            // waitingBar
            // 
            waitingBar.BackColor = Color.Transparent;
            waitingBar.Location = new Point(25, 423);
            waitingBar.Name = "waitingBar";
            waitingBar.Size = new Size(338, 24);
            waitingBar.TabIndex = 10;
            waitingBar.Text = "radWaitingBar1";
            waitingBar.ThemeName = "VisualStudio2022Dark";
            waitingBar.Visible = false;
            // 
            // 
            // 
            waitingBar.WaitingBarElement.BackColor = Color.Transparent;
            waitingBar.WaitingBarElement.BackColor3 = Color.Transparent;
            waitingBar.WaitingBarElement.BorderBottomColor = Color.Transparent;
            waitingBar.WaitingBarElement.BorderColor = Color.Transparent;
            waitingBar.WaitingBarElement.BorderColor2 = Color.Transparent;
            waitingBar.WaitingBarElement.BorderColor3 = Color.Transparent;
            waitingBar.WaitingBarElement.BorderColor4 = Color.Transparent;
            // 
            // 
            // 
            waitingBar.WaitingBarElement.SeparatorElement.BorderColor = Color.Transparent;
            waitingBar.WaitingBarElement.SeparatorElement.BorderInnerColor4 = Color.Transparent;
            waitingBar.WaitingBarElement.WaitingIndicatorSize = new Size(100, 14);
            waitingBar.WaitingIndicators.Add(waitingBarIndicatorElement1);
            waitingBar.WaitingIndicators.Add(waitingBarIndicatorElement2);
            waitingBar.WaitingIndicatorSize = new Size(100, 14);
            waitingBar.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash;
            ((Telerik.WinControls.UI.RadWaitingBarElement)waitingBar.GetChildAt(0)).WaitingIndicatorSize = new Size(100, 14);
            ((Telerik.WinControls.UI.RadWaitingBarElement)waitingBar.GetChildAt(0)).BorderColor = Color.Transparent;
            ((Telerik.WinControls.UI.RadWaitingBarElement)waitingBar.GetChildAt(0)).BorderColor2 = Color.Transparent;
            ((Telerik.WinControls.UI.RadWaitingBarElement)waitingBar.GetChildAt(0)).BorderColor3 = Color.Transparent;
            ((Telerik.WinControls.UI.RadWaitingBarElement)waitingBar.GetChildAt(0)).BorderColor4 = Color.Transparent;
            ((Telerik.WinControls.UI.RadWaitingBarElement)waitingBar.GetChildAt(0)).BackColor3 = Color.Transparent;
            ((Telerik.WinControls.UI.RadWaitingBarElement)waitingBar.GetChildAt(0)).BorderBottomColor = Color.Transparent;
            ((Telerik.WinControls.UI.RadWaitingBarElement)waitingBar.GetChildAt(0)).BackColor = Color.Transparent;
            ((Telerik.WinControls.UI.WaitingBarContentElement)waitingBar.GetChildAt(0).GetChildAt(0)).WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash;
            ((Telerik.WinControls.UI.WaitingBarSeparatorElement)waitingBar.GetChildAt(0).GetChildAt(0).GetChildAt(0)).BorderColor = Color.Transparent;
            ((Telerik.WinControls.UI.WaitingBarSeparatorElement)waitingBar.GetChildAt(0).GetChildAt(0).GetChildAt(0)).BorderInnerColor4 = Color.Transparent;
            ((Telerik.WinControls.UI.WaitingBarTextElement)waitingBar.GetChildAt(0).GetChildAt(0).GetChildAt(1)).BorderColor = Color.Transparent;
            ((Telerik.WinControls.UI.WaitingBarTextElement)waitingBar.GetChildAt(0).GetChildAt(0).GetChildAt(1)).BorderInnerColor4 = Color.Transparent;
            ((Telerik.WinControls.UI.WaitingBarTextElement)waitingBar.GetChildAt(0).GetChildAt(0).GetChildAt(1)).BackColor3 = Color.Transparent;
            ((Telerik.WinControls.UI.WaitingBarTextElement)waitingBar.GetChildAt(0).GetChildAt(0).GetChildAt(1)).Text = "radWaitingBar1";
            // 
            // Main
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wobg2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(390, 580);
            Controls.Add(tbFileName);
            Controls.Add(waitingBar);
            Controls.Add(radioBtGBUnit);
            Controls.Add(radioBtMBUnit);
            Controls.Add(radioBtByteUnit);
            Controls.Add(fillDriveToggleSwitch);
            Controls.Add(tbFileSize);
            Controls.Add(drive_list);
            Controls.Add(btn_minimize);
            Controls.Add(btn_exit);
            Controls.Add(btn_start);
            Controls.Add(radMenu1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ThemeName = "VisualStudio2022Dark";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)radMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)drive_list).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbFileSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)fillDriveToggleSwitch).EndInit();
            ((System.ComponentModel.ISupportInitialize)radioBtByteUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)radioBtGBUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)radioBtMBUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbFileName).EndInit();
            ((System.ComponentModel.ISupportInitialize)waitingBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2022DarkTheme visualStudio2022DarkTheme1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem menuItem_about_us;
        private Telerik.WinControls.UI.RadMenuItem menuItem_donate;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem menuItem_github;
        private Telerik.WinControls.UI.RadMenuItem menuItem_gitlab;
        private Telerik.WinControls.UI.RadDesktopAlert desk_alert;
        private System.ComponentModel.BackgroundWorker bg_worker;
        private Telerik.WinControls.UI.RadButton btn_start;
        private PictureBox btn_exit;
        private PictureBox btn_minimize;
        private Telerik.WinControls.UI.RadMenuItem irDonationBtn;
        private Telerik.WinControls.UI.RadMenuItem EnDonationBtn;
        private Telerik.WinControls.UI.RadDropDownList drive_list;
        private Telerik.WinControls.UI.RadTextBox tbFileSize;
        private Telerik.WinControls.UI.RadToggleSwitch fillDriveToggleSwitch;
        private Telerik.WinControls.UI.RadRadioButton radioBtByteUnit;
        private Telerik.WinControls.UI.RadRadioButton radioBtGBUnit;
        private Telerik.WinControls.UI.RadRadioButton radioBtMBUnit;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadWaitingBar waitingBar;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement1;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement2;
        private Telerik.WinControls.UI.RadTextBox tbFileName;
    }
}
