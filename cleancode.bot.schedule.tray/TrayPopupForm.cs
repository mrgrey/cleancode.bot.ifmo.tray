using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cleancode.bot.schedule.tray
{
    public partial class TrayPopupForm : Form
    {
        NotifyIcon _trayIcon;
        Settings _settings;

        Communicator _communicator;

        public TrayPopupForm()
        {
            InitializeComponent();
            this.Location = new Point(
                Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            this.LostFocus += new EventHandler(TrayPopupForm_LostFocus);
            _initTrayIcon();
        }

        void TrayPopupForm_LostFocus(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void _initTrayIcon()
        {
            _trayIcon = new NotifyIcon();
            _trayIcon.Icon = new System.Drawing.Icon("icon.ico");
            _trayIcon.MouseDown += new MouseEventHandler(_trayIcon_MouseDown);
            _trayIcon.Visible = true;
        }

        private void _tryLoadSettings()
        {
            _settings = Settings.Deserialize(Constants.SaveSettingsFileName);
        }

        void _trayIcon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Load and show schedule
                this.WindowState = FormWindowState.Normal;
                this.Show();
                this.Focus();
                //_trayIcon.ShowBalloonTip(1000, "Schedule", "Hello world!", ToolTipIcon.Info);
            }
            else if (e.Button == MouseButtons.Right)
            {

            }
        }

        private void _showSettings()
        {
            SettingsForm settingsForm = new SettingsForm(_settings, delegate(Settings settings) { _settings = settings; });
        }
    }
}