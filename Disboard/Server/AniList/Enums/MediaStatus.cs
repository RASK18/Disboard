using System.ComponentModel;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// The current releasing status of the media
    /// </summary>
    public enum MediaStatus
    {
        /// <summary>
        /// Has completed and is no longer being released
        /// </summary>
        [Description("FINISHED")] Finished,
        /// <summary>
        /// Currently releasing
        /// </summary>
        [Description("RELEASING")] Releasing,
        /// <summary>
        /// To be released at a later date
        /// </summary>
        [Description("NOT_YET_RELEASED")] NotYetReleased,
        /// <summary>
        /// Ended before the work could be finished
        /// </summary>
        [Description("CANCELLED")] Cancelled,
    }
}
