using System.ComponentModel;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// The type of ranking
    /// </summary>
    public enum MediaRankType
    {
        /// <summary>
        /// Ranking is based on the media's ratings/score
        /// </summary>
        [Description("RATED")] Rated,
        /// <summary>
        /// Ranking is based on the media's popularity
        /// </summary>
        [Description("POPULAR")] Popular,
    }
}
