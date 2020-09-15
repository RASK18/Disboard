using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// User sort enums
    /// </summary>
    public enum UserSort
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "CHAPTERS_READ")] ChaptersRead,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "CHAPTERS_READ_DESC")] ChaptersReadDesc,
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
        [EnumMember(Value = "SEARCH_MATCH")] SearchMatch,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "USERNAME")] Username,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "USERNAME_DESC")] UsernameDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "WATCHED_TIME")] WatchedTime,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "WATCHED_TIME_DESC")] WatchedTimeDesc,
    }
}
