using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A user's list options
    /// </summary>
    public class MediaListOptions
    {
        /// <summary>
        /// (Site only) If the user should be using legacy css-supporting list versions
        /// </summary>
        public bool? UseLegacyLists { get; set; }
        /// <summary>
        /// The default order list rows should be displayed in
        /// </summary>
        public string RowOrder { get; set; }
        /// <summary>
        /// The user's anime list options
        /// </summary>
        public MediaListTypeOptions AnimeList { get; set; }
        /// <summary>
        /// The user's manga list options
        /// </summary>
        public MediaListTypeOptions MangaList { get; set; }
        /// <summary>
        /// The score format the user is using for media lists
        /// </summary>
        public ScoreFormat? ScoreFormat { get; set; }
    }
}
