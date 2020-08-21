using System;
using System.Collections.Generic;
using System.Globalization;

namespace Disboard.Shared
{
    public class Day
    {
        public bool IsToday => Date == DateTimeOffset.Now.Date;
        public string Name => DayOfWeekName();
        public DateTime Date { get; set; }
        public IEnumerable<Episode> Episodes { get; set; }

        public Day()
        {

        }

        public Day(DateTime date, IEnumerable<Episode> episodes)
        {
            Date = date;
            Episodes = episodes;
        }

        private string DayOfWeekName()
        {
            CultureInfo spanish = new CultureInfo("es-ES");
            string name = spanish.DateTimeFormat.GetDayName(Date.DayOfWeek);
            return name;
        }
    }
}
