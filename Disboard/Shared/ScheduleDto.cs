using JikanDotNet;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Disboard.Shared
{
    public class ScheduleDto
    {
        public IEnumerable<DayDto> Week { get; set; }

        public ScheduleDto() { }
        public ScheduleDto(Schedule schedule)
        {
            Week = new List<DayDto>
            {
                new DayDto(DayOfWeek.Monday, Filter(schedule.Monday)),
                new DayDto(DayOfWeek.Tuesday, Filter(schedule.Tuesday)),
                new DayDto(DayOfWeek.Wednesday, Filter(schedule.Wednesday)),
                new DayDto(DayOfWeek.Thursday, Filter(schedule.Thursday)),
                new DayDto(DayOfWeek.Friday, Filter(schedule.Friday)),
                new DayDto(DayOfWeek.Saturday, Filter(schedule.Saturday)),
                new DayDto(DayOfWeek.Sunday, Filter(schedule.Sunday))
            };
        }

        private static IEnumerable<AnimeSubEntry> Filter(IEnumerable<AnimeSubEntry> animesSub) => animesSub.Where(a => a.Episodes != null);
    }
}
