using System.Collections.Generic;

namespace Disboard.Shared
{
    public class ScheduleDto
    {
        public IEnumerable<DayDto> Week { get; set; }
    }
}
