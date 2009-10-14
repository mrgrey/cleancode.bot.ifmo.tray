using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cleancode.bot.schedule.tray.DataSourceAnswer;
using System.Diagnostics;

namespace cleancode.bot.schedule.tray
{
    public partial class TrayPopupForm : Form
    {
        private const int _trayFormWidth = 473;
        private const int _trayFormHeight = 60;
        private const int _lessonControlHeight = 25;

        private const int _popupFormBorderWidth = 3;
        private readonly Pen _popupFormBorderPen = new Pen(Color.Black, _popupFormBorderWidth);

        private Rectangle _tempBorderRectangle = new Rectangle(0, 0, 0, 0);

        NotifyIcon _trayIcon;
        Settings _settings;

        Communicator _communicator;

        public TrayPopupForm()
        {
            InitializeComponent();

            this.Width = _trayFormWidth;
            this.Height = _trayFormHeight;

            this._settings = Settings.Deserialize(Constants.SaveSettingsFileName);
            groupLinkLabel.Text = this._settings.GroupId;
            _communicator = new Communicator(this._settings);

            this.MouseEnter += new EventHandler(delegate(object sender, EventArgs e) { this.hideTimer.Enabled = false; });
            this.MouseLeave += new EventHandler(delegate(object sender, EventArgs e)
            {
                Point cursorPosition = Cursor.Position;
                if (
                    (cursorPosition.X < this.Location.X || cursorPosition.X > this.Location.X + this.Width) ||
                    (cursorPosition.Y < this.Location.Y || cursorPosition.Y > this.Location.Y + this.Height)
                    )
                {
                    this.hideTimer.Enabled = true;
                }
            });
            hideTimer.Tick += new EventHandler(hideTimer_Tick);

            _setPopupFormLocation();
            _initTrayIcon();

            this.Paint += new PaintEventHandler(TrayPopupForm_Paint);
            this.Shown += new EventHandler(TrayPopupForm_Shown);
        }

        void TrayPopupForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.DrawRectangle(_popupFormBorderPen, 0, 0, this.Width - _popupFormBorderWidth, this.Height - _popupFormBorderWidth);
        }

        void TrayPopupForm_Shown(object sender, EventArgs e)
        {
            _getAndRenderSchedule(DateTime.Today);
            Point cursorPosition = Cursor.Position;
            if (
                (cursorPosition.X < this.Location.X || cursorPosition.X > this.Location.X + this.Width) ||
                (cursorPosition.Y < this.Location.Y || cursorPosition.Y > this.Location.Y + this.Height)
                )
            {
                this.hideTimer.Enabled = true;
            }
        }

        private void _setPopupFormLocation()
        {
            Point location = new Point();
            switch (_settings.PopupFormPosition)
            {
                case PopupFormPosition.TopLeft:
                    location.X = 0;
                    location.Y = 0;
                    break;
                case PopupFormPosition.BottomLeft:
                    location.X = 0;
                    location.Y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
                    break;
                case PopupFormPosition.TopRight:
                    location.X = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
                    location.Y = 0;
                    break;
                case PopupFormPosition.BottomRight:
                default:
                    location.X = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
                    location.Y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
                    break;
                case PopupFormPosition.MiddleCenter:
                    location.X = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
                    location.Y = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
                    break;
            }
            this.Location = location;
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
                    groupLinkLabel.Text = settings.GroupId;
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
            if (MessageBox.Show("Вы действительно желаете выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
        #endregion

        #region Методы, отвечающие за отрисовку расписания
        private void _renderSchedule(AnswerData schedule)
        {
            _clearLessons();
            foreach (Lesson lesson in schedule.Lessons)
            {
                _renderLesson(lesson);
            }
            _showForm();
        }

        private void _clearLessons()
        {
            mainSchedulePanel.Height -= mainSchedulePanel.Controls.Count * _lessonControlHeight;
            mainSchedulePanel.Controls.Clear();
            this.Height = _trayFormHeight;
            _setPopupFormLocation();
        }

        private void _renderLesson(Lesson lesson)
        {
            Panel lessonPanel = new Panel();
            lessonPanel.Width = mainSchedulePanel.Width;
            lessonPanel.Height = _lessonControlHeight;
            //Time
            Label timeLabel = new Label();
            timeLabel.Location = new Point(0, 0);
            timeLabel.Width = lessonPanel.Width / 5;
            timeLabel.Height = lessonPanel.Height;
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            timeLabel.BorderStyle = BorderStyle.Fixed3D;
            timeLabel.BackColor = Color.White;
            timeLabel.Text = lesson.Time;
            lessonPanel.Controls.Add(timeLabel);
            //Place
            Label placeLabel = new Label();
            placeLabel.Location = new Point(lessonPanel.Width / 5, 0);
            placeLabel.Width = lessonPanel.Width / 5;
            placeLabel.Height = lessonPanel.Height;
            placeLabel.TextAlign = ContentAlignment.MiddleCenter;
            placeLabel.BorderStyle = BorderStyle.Fixed3D;
            placeLabel.BackColor = Color.White;
            placeLabel.Text = lesson.Place;
            lessonPanel.Controls.Add(placeLabel);
            //Subject
            TextBox subjectTextBox = new TextBox();
            subjectTextBox.Multiline = true;
            subjectTextBox.ScrollBars = ScrollBars.Vertical;
            subjectTextBox.Location = new Point(lessonPanel.Width * 2 / 5, 0);
            subjectTextBox.Width = lessonPanel.Width * 2 / 5;
            subjectTextBox.Height = lessonPanel.Height;
            subjectTextBox.TextAlign = HorizontalAlignment.Left;
            subjectTextBox.Text = lesson.Subject;
            lessonPanel.Controls.Add(subjectTextBox);
            //Person
            Label personLabel = new Label();
            personLabel.Location = new Point(lessonPanel.Width * 4 / 5, 0);
            personLabel.Width = lessonPanel.Width / 5;
            personLabel.Height = lessonPanel.Height;
            personLabel.TextAlign = ContentAlignment.MiddleCenter;
            personLabel.BorderStyle = BorderStyle.Fixed3D;
            personLabel.BackColor = Color.White;
            personLabel.Text = lesson.PersonName;
            lessonPanel.Controls.Add(personLabel);
            //Render panel
            lessonPanel.Location = new Point(0, lessonPanel.Height * mainSchedulePanel.Controls.Count);
            this.Height += lessonPanel.Height;
            _setPopupFormLocation();
            mainSchedulePanel.Height += lessonPanel.Height;
            mainSchedulePanel.Controls.Add(lessonPanel);
        }
        #endregion

        #region Методы, отвечающие за скрытие и показ формы
        private void closeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _hideForm();
        }

        private void hideTimer_Tick(object sender, EventArgs e)
        {
            _hideForm();
        }

        private void _hideForm()
        {
            hideTimer.Enabled = false;
            this.Hide();
        }

        private void _showForm()
        {
            this.Show();
            this.Focus();
            hideTimer.Enabled = true;
        }
        #endregion

        private void _getAndRenderSchedule(DateTime date)
        {
            if (this._settings.IsEmpty())
                _showSettingsEvent(null, EventArgs.Empty);

            _renderSchedule(_communicator.GetSchedule(date));

            _showForm();
        }

        void _trayIcon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _getAndRenderSchedule(DateTime.Today);
            }
        }

        private void groupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string detailFormScheduleUrl = String.Format("{0}?gr={1}", Constants.DefaultPrintFormBaseUrl, _settings.GroupId);
            Process.Start(detailFormScheduleUrl);
        }

        private void tomorrowLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _getAndRenderSchedule(DateTime.Today.AddDays(1));
        }
    }
}