using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Disboard.Shared
{
    public class Schedule
    {
        public List<Day> Week { get; set; }

        public Schedule()
        {
            Week = new List<Day>();
            DateTime today = DateTime.UtcNow.Date;

            for (int i = 0; i < 7; i++)
            {
                Day day = new Day(today.AddDays(i));
                Week.Add(day);
            }

            CultureInfo spanish = new CultureInfo("es-ES");
            int firstDay = (int)spanish.DateTimeFormat.FirstDayOfWeek;
            Week = Week.OrderBy(d => ((int)d.Date.DayOfWeek - firstDay + 7) % 7).ToList();
        }
    }
}
