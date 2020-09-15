using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// User statistics sort enum
    /// </summary>
    public enum UserStatisticsSort
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "COUNT")] Count,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "COUNT_DESC")] CountDesc,
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
        [EnumMember(Value = "MEAN_SCORE")] MeanScore,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "MEAN_SCORE_DESC")] MeanScoreDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "PROGRESS")] Progress,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "PROGRESS_DESC")] ProgressDesc,
    }
}
