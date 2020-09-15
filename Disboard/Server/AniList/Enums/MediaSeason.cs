using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum MediaSeason
    {
        /// <summary>
        /// Months September to November
        /// </summary>
        [EnumMember(Value = "FALL")] Fall,
        /// <summary>
        /// Months March to May
        /// </summary>
        [EnumMember(Value = "SPRING")] Spring,
        /// <summary>
        /// Months June to August
        /// </summary>
        [EnumMember(Value = "SUMMER")] Summer,
        /// <summary>
        /// Months December to February
        /// </summary>
        [EnumMember(Value = "WINTER")] Winter,
    }
}
