using System.Collections.Generic;

namespace AniList.ModelMaker
{
    public class AniError
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public IEnumerable<Location> Locations { get; set; }
    }

    public class Location
    {
        public int Line { get; set; }
        public int Column { get; set; }
    }
}
