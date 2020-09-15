using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// The current releasing status of the media
    /// </summary>
    public enum MediaStatus
    {
        /// <summary>
        /// Ended before the work could be finished
        /// </summary>
        [EnumMember(Value = "CANCELLED")] Cancelled,
        /// <summary>
        /// Has completed and is no longer being released
        /// </summary>
        [EnumMember(Value = "FINISHED")] Finished,
        /// <summary>
        /// To be released at a later date
        /// </summary>
        [EnumMember(Value = "NOT_YET_RELEASED")] NotYetReleased,
        /// <summary>
        /// Currently releasing
        /// </summary>
        [EnumMember(Value = "RELEASING")] Releasing,
    }
}
