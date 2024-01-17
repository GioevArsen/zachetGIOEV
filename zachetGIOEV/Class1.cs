using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachetGIOEV
{
    class Class1
    {
        public enum WeekDays
        {
            Monday,
            Thuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public class Lesson
        {
            public string Label { get; set; }
            static char labelLetter = 'A';
            public int Number { get; set; }
            public int weekNumber { get; set; }
            public WeekDays weekDay { get; set; }
            public string groupNumber { get; set; }
            public string[] groups = { "11", "12", "13", "21", "22", "23", "31" };
            static Random rnd = new Random();

            public Lesson()
            {
                Label = labelLetter.ToString();
                labelLetter++;
                Number = 1;
                weekNumber = GetRndWeekNumber();
                weekDay = GetRndWeekDay();
                groupNumber = GetrndGroupNumber();
            }

            int GetRndWeekNumber()
            {
                return rnd.Next(0, 2);
            }

            WeekDays GetRndWeekDay()
            {
                WeekDays[] days = (WeekDays[])Enum.GetValues(typeof(WeekDays));
                int rndINDEX = rnd.Next(0, days.Length - 2);
                return days[rndINDEX];
            }

            string GetrndGroupNumber()
            {
                int rndINDEX = rnd.Next(0, groups.Length);
                return groups[rndINDEX];
            }

            public Lesson(string label, int number, int weeknumber, WeekDays weekday, string group)
            {
                Label = label;
                Number = number;
                weekNumber = weeknumber;
                weekDay = weekday;
                groupNumber = group;
            }

            public override string ToString()
            {
                string weekday = "";
                switch (weekDay)
                {
                    case WeekDays.Monday:
                        weekday = "понедельник";
                        break;
                    case WeekDays.Thuesday:
                        weekday = "вторник";
                        break;
                    case WeekDays.Wednesday:
                        weekday = "среда";
                        break;
                    case WeekDays.Thursday:
                        weekday = "четверг";
                        break;
                    case WeekDays.Friday:
                        weekday = "пятница";
                        break;
                    case WeekDays.Saturday:
                        weekday = "суббота";
                        break;
                    case WeekDays.Sunday:
                        weekday = "воскресенье";
                        break;
                }
                string weekInfo = "";
                switch (weekNumber)
                {
                    case (0):
                        weekInfo = "каждую неделю";
                        break;
                    case (1):
                        weekInfo = "первая неделя";
                        break;
                    case (2):
                        weekInfo = "вторая неделя";
                        break;

                }
                return $"{Label}., {Number} пара {weekday}, {groupNumber} группа, {weekInfo}";
            }
        }

        public class Schedule
        {
            public string Name { get; set; }
            public List<Lesson> listLesson = new List<Lesson>();

            public Schedule(string name)
            {
                Name = name;
            }

            public void Add(Lesson lesson)
            {
                listLesson.Add(lesson);
            }

            public override string ToString()
            {
                int numb = 1;
                string result = "";
                //foreach (var lesson in listLesson)
                //{
                //    if (lesson.weekDay != )
                //        result += ($"{numb}. {lesson.ToString()}\n");
                //    numb++;
                //}
                for (int i = 0; i < listLesson.Count(); i++)
                {
                    Lesson curLesson = listLesson[i];
                    if (i > 0)
                    {
                        Lesson prevLesson = listLesson[i - 1];
                        if (curLesson.weekDay != prevLesson.weekDay)
                        {
                            numb = 1;
                        }
                    }
                    result += ($"{numb}. {listLesson[i].ToString()}\n");
                    numb++;
                }
                return result;
            }
        }
    }
}
