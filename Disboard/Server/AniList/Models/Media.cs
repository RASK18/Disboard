using Disboard.Server.AniList.Enums;
using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Anime or Manga
    /// </summary>
    public class Media
    {
        /// <summary>
        /// If the media is officially licensed or a self-published doujin release
        /// </summary>
        public bool? IsLicensed { get; set; }
        /// <summary>
        /// Locked media may not be added to lists our favorited. This may be due to the entry pending for deletion or other reasons.
        /// </summary>
        public bool? IsLocked { get; set; }
        /// <summary>
        /// If the media is intended only for 18+ adult audiences
        /// </summary>
        public bool? IsAdult { get; set; }
        /// <summary>
        /// If the media should have forum thread automatically created for it on airing episode release
        /// </summary>
        public bool? AutoCreateForumThread { get; set; }
        /// <summary>
        /// If the media is blocked from being recommended to/from
        /// </summary>
        public bool? IsRecommendationBlocked { get; set; }
        /// <summary>
        /// Where the media was created. (ISO 3166-1 alpha-2)
        /// </summary>
        public string CountryOfOrigin { get; set; }
        /// <summary>
        /// The mal id of the media
        /// </summary>
        public int? IdMal { get; set; }
        /// <summary>
        /// The season year the media was initially released in
        /// </summary>
        public int? SeasonYear { get; set; }
        /// <summary>
        /// The year and season the media was initially released in
        /// </summary>
        public int? SeasonInt { get; set; }
        /// <summary>
        /// The amount of episodes the anime has when complete
        /// </summary>
        public int? Episodes { get; set; }
        /// <summary>
        /// The general length of each anime episode in minutes
        /// </summary>
        public int? Duration { get; set; }
        /// <summary>
        /// The amount of chapters the manga has when complete
        /// </summary>
        public int? Chapters { get; set; }
        /// <summary>
        /// The amount of volumes the manga has when complete
        /// </summary>
        public int? Volumes { get; set; }
        /// <summary>
        /// When the media's data was last updated
        /// </summary>
        public int? UpdatedAt { get; set; }
        /// <summary>
        /// A weighted average score of all the user's scores of the media
        /// </summary>
        public int? AverageScore { get; set; }
        /// <summary>
        /// Mean score of all the user's scores of the media
        /// </summary>
        public int? MeanScore { get; set; }
        /// <summary>
        /// The number of users with the media on their list
        /// </summary>
        public int? Popularity { get; set; }
        /// <summary>
        /// The amount of related activity in the past hour
        /// </summary>
        public int? Trending { get; set; }
        /// <summary>
        /// The amount of user's who have favourited the media
        /// </summary>
        public int? Favourites { get; set; }
        /// <summary>
        /// Short description of the media's story and characters
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Official Twitter hashtags for the media
        /// </summary>
        public string Hashtag { get; set; }
        /// <summary>
        /// The banner image of the media
        /// </summary>
        public string BannerImage { get; set; }
        /// <summary>
        /// The url for the media page on the AniList website
        /// </summary>
        public string SiteUrl { get; set; }
        /// <summary>
        /// Notes for site moderators
        /// </summary>
        public string ModNotes { get; set; }
        /// <summary>
        /// The media's next episode airing schedule
        /// </summary>
        public AiringSchedule NextAiringEpisode { get; set; }
        /// <summary>
        /// The media's entire airing schedule
        /// </summary>
        public AiringScheduleConnection AiringSchedule { get; set; }
        /// <summary>
        /// The characters in the media
        /// </summary>
        public CharacterConnection Characters { get; set; }
        /// <summary>
        /// The first official release date of the media
        /// </summary>
        public FuzzyDate StartDate { get; set; }
        /// <summary>
        /// The last official release date of the media
        /// </summary>
        public FuzzyDate EndDate { get; set; }
        /// <summary>
        /// Other media in the same or connecting franchise
        /// </summary>
        public MediaConnection Relations { get; set; }
        /// <summary>
        /// The cover images of the media
        /// </summary>
        public MediaCoverImage CoverImage { get; set; }
        /// <summary>
        /// The authenticated user's media list entry for the media
        /// </summary>
        public MediaList MediaListEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public MediaStats Stats { get; set; }
        /// <summary>
        /// The official titles of the media in various languages
        /// </summary>
        public MediaTitle Title { get; set; }
        /// <summary>
        /// Media trailer or advertisement
        /// </summary>
        public MediaTrailer Trailer { get; set; }
        /// <summary>
        /// The media's daily trend stats
        /// </summary>
        public MediaTrendConnection Trends { get; set; }
        /// <summary>
        /// User recommendations for similar media
        /// </summary>
        public RecommendationConnection Recommendations { get; set; }
        /// <summary>
        /// User reviews of the media
        /// </summary>
        public ReviewConnection Reviews { get; set; }
        /// <summary>
        /// The staff who produced the media
        /// </summary>
        public StaffConnection Staff { get; set; }
        /// <summary>
        /// The companies who produced the media
        /// </summary>
        public StudioConnection Studios { get; set; }
        /// <summary>
        /// The format the media was released in
        /// </summary>
        public MediaFormat? Format { get; set; }
        /// <summary>
        /// The season the media was initially released in
        /// </summary>
        public MediaSeason? Season { get; set; }
        /// <summary>
        /// Source type the media was adapted from.
        /// </summary>
        public MediaSource? Source { get; set; }
        /// <summary>
        /// The current releasing status of the media
        /// </summary>
        public MediaStatus? Status { get; set; }
        /// <summary>
        /// The type of the media; anime or manga
        /// </summary>
        public MediaType? Type { get; set; }
        /// <summary>
        /// The genres of the media
        /// </summary>
        public IEnumerable<string> Genres { get; set; }
        /// <summary>
        /// Alternative titles of the media
        /// </summary>
        public IEnumerable<string> Synonyms { get; set; }
        /// <summary>
        /// List of tags that describes elements and themes of the media
        /// </summary>
        public IEnumerable<MediaTag> Tags { get; set; }
        /// <summary>
        /// External links to another site related to the media
        /// </summary>
        public IEnumerable<MediaExternalLink> ExternalLinks { get; set; }
        /// <summary>
        /// Data and links to legal streaming episodes on external sites
        /// </summary>
        public IEnumerable<MediaStreamingEpisode> StreamingEpisodes { get; set; }
        /// <summary>
        /// The ranking of the media in a particular time span and format compared to other media
        /// </summary>
        public IEnumerable<MediaRank> Rankings { get; set; }
        /// <summary>
        /// The id of the media
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// If the media is marked as favourite by the current authenticated user
        /// </summary>
        public bool IsFavourite { get; set; }
    }
}
