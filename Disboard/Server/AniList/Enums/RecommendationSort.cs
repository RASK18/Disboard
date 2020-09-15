using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Recommendation sort enums
    /// </summary>
    public enum RecommendationSort
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ID")] Id,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ID_DESC")] IdDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "RATING")] Rating,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "RATING_DESC")] RatingDesc,
    }
}
