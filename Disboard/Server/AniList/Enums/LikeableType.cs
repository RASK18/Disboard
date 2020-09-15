using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Types that can be liked
    /// </summary>
    public enum LikeableType
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ACTIVITY")] Activity,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ACTIVITY_REPLY")] ActivityReply,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "THREAD")] Thread,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "THREAD_COMMENT")] ThreadComment,
    }
}
