using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// The type of ranking
    /// </summary>
    public enum MediaRankType
    {
        /// <summary>
        /// Ranking is based on the media's popularity
        /// </summary>
        [EnumMember(Value = "POPULAR")] Popular,
        /// <summary>
        /// Ranking is based on the media's ratings/score
        /// </summary>
        [EnumMember(Value = "RATED")] Rated,
    }
}
