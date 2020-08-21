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

        public Anime()
        {

        }

        public Anime(bool hasBeenReleased, int id, string name, string imgUrl, IEnumerable<Episode> episodes)
        {
            HasBeenReleased = hasBeenReleased;
            Id = id;
            Name = name;
            ImgUrl = imgUrl;
            Episodes = episodes;
        }
    }
}
