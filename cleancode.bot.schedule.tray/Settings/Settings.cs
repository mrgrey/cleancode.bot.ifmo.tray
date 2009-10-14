using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace cleancode.bot.schedule.tray
{
    public class Settings
    {
        public string GroupId;
        public int SceduleId;
        public string DatasourceUrl;
        public PopupFormPosition PopupFormPosition;

        public Settings() { }

        #region Методы сериализации/десериализации
        public void Serialize(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                serializer.Serialize(fs, this);
            }
        }

        public static Settings Deserialize(string fileName)
        {
            if(File.Exists(fileName))
            {
                using(FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                    return (Settings)serializer.Deserialize(fs);
                }
            }
            return new Settings();
        }
        #endregion

        public bool IsEmpty()
        {
            return (string.IsNullOrEmpty(this.DatasourceUrl) || string.IsNullOrEmpty(this.GroupId) || this.SceduleId == 0);
        }
    }
}
