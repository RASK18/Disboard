using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// The distribution of the watching/reading status of media or a user's list
    /// </summary>
    public class StatusDistribution
    {
        /// <summary>
        /// The day the activity took place (Unix timestamp)
        /// </summary>
        public MediaListStatus? Status { get; set; }
        /// <summary>
        /// The amount of entries with this status
        /// </summary>
        public int? Amount { get; set; }
    }
}
