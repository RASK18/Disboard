namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A user's activity history stats.
    /// </summary>
    public class UserActivityHistory
    {
        /// <summary>
        /// The day the activity took place (Unix timestamp)
        /// </summary>
        public int? Date { get; set; }
        /// <summary>
        /// The amount of activity on the day
        /// </summary>
        public int? Amount { get; set; }
        /// <summary>
        /// The level of activity represented on a 1-10 scale
        /// </summary>
        public int? Level { get; set; }
    }
}
