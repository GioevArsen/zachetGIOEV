using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static zachetGIOEV.Class1;

namespace zachetGIOEV
{
    class Program
    {
        static void Main(string[] args)
        {
            Lesson lesson1 = new Lesson();
            Lesson lesson2 = new Lesson();
            Lesson lesson3 = new Lesson("Матан", 1, 1, WeekDays.Friday, "23");
            Lesson lesson4 = new Lesson("Прога", 2, 2, WeekDays.Friday, "23");
            Schedule schedule = new Schedule("MathFaculty");
            schedule.Add(lesson1);
            schedule.Add(lesson2);
            schedule.Add(lesson3);
            schedule.Add(lesson4);
            Console.WriteLine(schedule);
        }
    }
}
