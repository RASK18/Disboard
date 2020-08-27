using JikanDotNet;
using System;
using System.Collections.Generic;

namespace Disboard.Shared
{
    public class EpisodeDto
    {
        public bool? HasBeenReleased { get; set; }
        public long Number { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> OtherNames { get; set; }

        public EpisodeDto() { }

        public EpisodeDto(AnimeEpisode episode)
        {
            Number = episode.Id;
            Name = episode.Title;
            OtherNames = new List<string> { episode.TitleEnglish, episode.TitleJapanese };
            HasBeenReleased = episode.Aired < DateTime.Now;
        }
    }
}
