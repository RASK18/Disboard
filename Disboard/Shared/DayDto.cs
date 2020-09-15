using System;
using System.Collections.Generic;

namespace Disboard.Shared
{
    public class DayDto
    {
        public bool IsToday { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<AnimeDto> Animes { get; set; }
    }
}
