namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// User's staff statistics
    /// </summary>
    public class StaffStats
    {
        /// <summary>
        /// 
        /// </summary>
        public int? Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? MeanScore { get; set; }
        /// <summary>
        /// The amount of time in minutes the staff member has been watched by the user
        /// </summary>
        public int? TimeWatched { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Staff Staff { get; set; }
    }
}
