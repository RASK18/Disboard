using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Review sort enums
    /// </summary>
    public enum ReviewSort
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "CREATED_AT")] CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "CREATED_AT_DESC")] CreatedAtDesc,
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
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "SCORE")] Score,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "SCORE_DESC")] ScoreDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "UPDATED_AT")] UpdatedAt,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "UPDATED_AT_DESC")] UpdatedAtDesc,
    }
}
