using System;
using System.Collections.Generic;
using System.Globalization;

namespace Disboard.Shared
{
    public class Day
    {
        public bool IsToday => Date == DateTime.UtcNow.Date;
        public string Name => DayOfWeekName();
        public DateTime Date { get; }
        public List<Episode> Episodes { get; set; } = new List<Episode>();

        public Day(DateTime date) => Date = date;

        private string DayOfWeekName()
        {
            CultureInfo spanish = new CultureInfo("es-ES");
            string name = spanish.DateTimeFormat.GetDayName(Date.DayOfWeek);
            return name;
        }
    }
}
