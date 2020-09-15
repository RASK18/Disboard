using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Media list watching/reading status enum.
    /// </summary>
    public enum MediaListStatus
    {
        /// <summary>
        /// Finished watching/reading
        /// </summary>
        [EnumMember(Value = "COMPLETED")] Completed,
        /// <summary>
        /// Currently watching/reading
        /// </summary>
        [EnumMember(Value = "CURRENT")] Current,
        /// <summary>
        /// Stopped watching/reading before completing
        /// </summary>
        [EnumMember(Value = "DROPPED")] Dropped,
        /// <summary>
        /// Paused watching/reading
        /// </summary>
        [EnumMember(Value = "PAUSED")] Paused,
        /// <summary>
        /// Planning to watch/read
        /// </summary>
        [EnumMember(Value = "PLANNING")] Planning,
        /// <summary>
        /// Re-watching/reading
        /// </summary>
        [EnumMember(Value = "REPEATING")] Repeating,
    }
}
