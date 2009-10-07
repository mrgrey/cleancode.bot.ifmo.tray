using System;
using System.Collections.Generic;
using System.Text;

namespace cleancode.bot.schedule.tray.DataSourceAnswer
{
    public class Lesson
    {
        public string Time;
        public string Place;
        public string Subject;
        public string PersonName;

        public Lesson() { }
        public Lesson(string time, string place, string subject, string personName)
        {
            this.Time = time;
            this.Place = place;
            this.Subject = subject;
            this.PersonName = personName;
        }
    }
}
