using JikanDotNet;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public AnimeDto() { }
        public AnimeDto(Anime anime)
        {
            Id = anime.MalId;
            Name = anime.Title;
            OtherNames = new List<string> { anime.TitleEnglish, anime.TitleJapanese };
            OtherNames.AddRange(anime.TitleSynonyms);
            ImgUrl = anime.ImageURL;
            Type = anime.Type;
            Total = Convert.ToInt32(anime.Episodes);
            IsCompleted = !anime.Airing;
            HasBeenReleased = anime.Aired.From < DateTime.Now;
            Score = anime.Score;
            ScoredBy = anime.ScoredBy;
            Synopsis = anime.Synopsis;
            Genres = anime.Genres.Select(g => new GenreDto(g));
        }

        public AnimeDto(AnimeSubEntry animeSub)
        {
            Id = animeSub.MalId;
            Name = animeSub.Title;
            ImgUrl = animeSub.ImageURL;
            Type = animeSub.Type;
            Total = Convert.ToInt32(animeSub.Episodes);
            Synopsis = animeSub.Synopsis;
            Genres = animeSub.Genres.Select(g => new GenreDto(g));
            HasBeenReleased = animeSub.AiringStart < DateTime.Now;
            Score = animeSub.Score;
        }

        public AnimeDto(AnimeTopEntry animeTop)
        {
            Id = animeTop.MalId;
            ImgUrl = animeTop.ImageURL;
            Name = animeTop.Title;
            Type = animeTop.Type;
            Score = animeTop.Score;
            HasBeenReleased = !string.IsNullOrWhiteSpace(animeTop.AiringStart);
            IsCompleted = !string.IsNullOrWhiteSpace(animeTop.AiringEnd);
            Total = animeTop.Episodes;
        }
    }
}
