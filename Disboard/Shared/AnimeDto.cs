using System.Collections.Generic;

namespace Disboard.Shared
{
    public class AnimeDto
    {
        public bool? HasBeenReleased { get; set; }
        public bool? IsCompleted { get; set; }
        public int? Total { get; set; }
        public long Id { get; set; }
        public float? Score { get; set; }
        public float? ScoredBy { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string Type { get; set; }
        public string Synopsis { get; set; }
        public List<string> OtherNames { get; set; }
        public IEnumerable<GenreDto> Genres { get; set; }
        public IEnumerable<EpisodeDto> Episodes { get; set; }
    }
}
