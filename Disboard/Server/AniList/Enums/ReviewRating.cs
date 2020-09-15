using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Review rating enums
    /// </summary>
    public enum ReviewRating
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "DOWN_VOTE")] DownVote,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "NO_VOTE")] NoVote,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "UP_VOTE")] UpVote,
    }
}
