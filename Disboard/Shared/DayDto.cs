using JikanDotNet;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Disboard.Shared
{
    public class DayDto
    {
        public bool IsToday { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<AnimeDto> Animes { get; set; }

        public DayDto() { }

        public DayDto(DayOfWeek dayOfWeek, IEnumerable<AnimeSubEntry> animesSub)
        {
            DateTime today = DateTime.Today;
            Name = DayOfWeekName(dayOfWeek);
            IsToday = today.DayOfWeek == dayOfWeek;
            Date = GetNextWeekday(today, dayOfWeek);
            Animes = animesSub.Select(a => new AnimeDto(a)).ToList();
        }

        private static DateTime GetNextWeekday(DateTime start, DayOfWeek dayOfWeek)
        {
            int daysToAdd = ((int)dayOfWeek - (int)start.DayOfWeek + 7) % 7;
            return start.AddDays(daysToAdd);
        }

        private static string DayOfWeekName(DayOfWeek dayOfWeek)
        {
            CultureInfo spanish = new CultureInfo("es-ES");
            return spanish.DateTimeFormat.GetDayName(dayOfWeek);
        }
    }
}
