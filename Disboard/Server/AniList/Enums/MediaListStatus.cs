using System.ComponentModel;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Media list watching/reading status enum.
    /// </summary>
    public enum MediaListStatus
    {
        /// <summary>
        /// Currently watching/reading
        /// </summary>
        [Description("CURRENT")] Current,
        /// <summary>
        /// Planning to watch/read
        /// </summary>
        [Description("PLANNING")] Planning,
        /// <summary>
        /// Finished watching/reading
        /// </summary>
        [Description("COMPLETED")] Completed,
        /// <summary>
        /// Stopped watching/reading before completing
        /// </summary>
        [Description("DROPPED")] Dropped,
        /// <summary>
        /// Paused watching/reading
        /// </summary>
        [Description("PAUSED")] Paused,
        /// <summary>
        /// Re-watching/reading
        /// </summary>
        [Description("REPEATING")] Repeating,
    }
}
