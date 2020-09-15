using System.Collections.Generic;

namespace Disboard.Shared
{
    public class EpisodeDto
    {
        public bool? HasBeenReleased { get; set; }
        public long Number { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> OtherNames { get; set; }
    }
}
