using System.Collections.Generic;

namespace Disboard.Shared
{
    public class Anime
    {
        public bool HasBeenReleased { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public IEnumerable<Episode> Episodes { get; set; }
    }
}
