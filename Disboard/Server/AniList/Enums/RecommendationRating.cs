using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Recommendation rating enums
    /// </summary>
    public enum RecommendationRating
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "NO_RATING")] NoRating,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "RATE_DOWN")] RateDown,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "RATE_UP")] RateUp,
    }
}
