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
            this._settings = Settings.Deserialize(Constants.SaveSettingsFileName);
            _communicator = new Communicator(this._settings);
            this.hideTimer.Tick += new EventHandler(hideTimer_Tick);

            this.Location = new Point(
                Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            _initTrayIcon();
        }

        #region Инициалзизация иконки в трее
        private void _initTrayIcon()
        {
            _trayIcon = new NotifyIcon();
            _trayIcon.Icon = new System.Drawing.Icon("icon.ico");
            _trayIcon.MouseDown += new MouseEventHandler(_trayIcon_MouseDown);
            #region Инициализация контекстного меню
            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add(new MenuItem("Настройки", new EventHandler(_showSettingsEvent)));
            menu.MenuItems.Add(new MenuItem("О программе", new EventHandler(_showAboutEvent)));
            menu.MenuItems.Add(new MenuItem("Выход", new EventHandler(_exitEvent)));
            _trayIcon.ContextMenu = menu;
            #endregion
            _trayIcon.Visible = true;
        }

        private void _showSettingsEvent(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(_settings,
                delegate(Settings settings)
                {
                    _settings = settings;
                    _communicator.Settings = settings;
                });
            settingsForm.ShowDialog();
        }

        private void _showAboutEvent(object sender, EventArgs e)
        {
            string url = "http://cleancode.ru";
            System.Diagnostics.Process.Start(url);
        }

        private void _exitEvent(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы действительно желаете выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
        #endregion

        void _trayIcon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this._settings.IsEmpty())
                    _showSettingsEvent(null, EventArgs.Empty);

                //listBox1.Items.Add(_communicator.GetSchedule());

                this.WindowState = FormWindowState.Normal;
                this.Show();
                this.Focus();
                hideTimer.Enabled = true;
            }
        }

        #region Методы, отвечающие за скрытие формы
        private void closeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _hideForm();
        }

        void hideTimer_Tick(object sender, EventArgs e)
        {
            _hideForm();
            this.hideTimer.Enabled = false;
        }

        void _hideForm()
        {
            this.hideTimer.Enabled = false;
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }
        #endregion
    }
}