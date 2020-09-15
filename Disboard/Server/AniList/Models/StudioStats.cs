namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// User's studio statistics
    /// </summary>
    public class StudioStats
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
        /// The amount of time in minutes the studio's works have been watched by the user
        /// </summary>
        public int? TimeWatched { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Studio Studio { get; set; }
    }
}
