using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// The ranking of a media in a particular time span and format compared to other media
    /// </summary>
    public class MediaRank
    {
        /// <summary>
        /// If the ranking is based on all time instead of a season/year
        /// </summary>
        public bool? AllTime { get; set; }
        /// <summary>
        /// The year the media is ranked within
        /// </summary>
        public int? Year { get; set; }
        /// <summary>
        /// The season the media is ranked within
        /// </summary>
        public MediaSeason? Season { get; set; }
        /// <summary>
        /// The id of the rank
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The numerical rank of the media
        /// </summary>
        public int Rank { get; set; }
        /// <summary>
        /// The type of ranking
        /// </summary>
        public MediaRankType Type { get; set; }
        /// <summary>
        /// The format the media is ranked within
        /// </summary>
        public MediaFormat Format { get; set; }
        /// <summary>
        /// String that gives context to the ranking type and time span
        /// </summary>
        public string Context { get; set; }
    }
}
