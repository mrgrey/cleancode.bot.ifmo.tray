using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cleancode.bot.schedule.tray
{
    public partial class SettingsForm : Form
    {
        Settings _settings;
        cleancode.bot.schedule.tray.Constants.SettingsTransferEventArgs _settingsTransferAction;

        public SettingsForm(Settings settings, cleancode.bot.schedule.tray.Constants.SettingsTransferEventArgs e)
        {
            InitializeComponent();
            this._settings = settings;
            this._settingsTransferAction = e;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (this._settings != null)
            {
                this.groupTextBox.Text = _settings.GroupId;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Set settings fields
            this._settings.SceduleId = Constants.DefaultScheduleId;
            this._settings.DatasourceUrl = Constants.DefaultDatasourceUrl;
            this._settings.GroupId = this.groupTextBox.Text;

            this._settings.Serialize(Constants.SaveSettingsFileName);
            this._settingsTransferAction.Invoke(this._settings);
            this.Close();
        }
    }
}