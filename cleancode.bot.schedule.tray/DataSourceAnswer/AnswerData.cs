using System;
using System.Collections.Generic;
using System.Text;

namespace cleancode.bot.schedule.tray.DataSourceAnswer
{
    public class AnswerData
    {
        public Status Status;
        public int WeekNumber;
        public string Day;
        public List<Lesson> Lessons;

        public AnswerData()
        {
            Lessons = new List<Lesson>();
        }

        public AnswerData(Status status, int weekNumber, string day) : this()
        {
            this.Status = status;
            this.WeekNumber = weekNumber;
            this.Day = day;
        }

        public AnswerData(Status status, int weekNumber, string day, IEnumerable<Lesson> lessons) : this(status, weekNumber, day)
        {
            this.Lessons.AddRange(lessons);
        }
    }
}
