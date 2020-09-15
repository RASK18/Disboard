using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Site trend sort enums
    /// </summary>
    public enum SiteTrendSort
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "CHANGE")] Change,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "CHANGE_DESC")] ChangeDesc,
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
        [EnumMember(Value = "DATE")] Date,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "DATE_DESC")] DateDesc,
    }
}
