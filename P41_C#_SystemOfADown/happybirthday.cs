using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C__SystemOfADown
{
    internal class happybirthday
    {
        DateTime birthday;
        public happybirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }

        public void PrintBirthday()
        {
            Console.WriteLine($"Happy Birthday! Your birthday is on {birthday.ToShortDateString()}");
        }

        public void setBirthday(DateTime Birthday)
        {
            this.birthday = Birthday;
        }

        public int getWeekBirth()
        {
            return (int)birthday.DayOfYear / 7;
        }
        public DayOfWeek getDayOfWeekBirth()
        {
            return birthday.DayOfWeek;
        }
        public int getDaysTillNextBirthday()
        {
            DateTime today = DateTime.Now;
            if ((birthday.DayOfYear - today.DayOfYear) < 0)
            {
                return (new DateTime(today.Year + 1, birthday.Month, birthday.Day) - today).Days + 1;
            }
            else
            {
                return (new DateTime(today.Year, birthday.Month, birthday.Day) - today).Days + 1;
            }
        }
        public DayOfWeek getBirthdayInYear(int year)
        {
            int days = birthday.DayOfYear;
            DateTime yer = new DateTime(year, 1, 1);
            yer = yer.AddDays(days - 1);
            return yer.DayOfWeek;

        }

    }
}
