namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Daily site statistics
    /// </summary>
    public class SiteTrend
    {
        /// <summary>
        /// The day the data was recorded (timestamp)
        /// </summary>
        public int? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// The change from yesterday
        /// </summary>
        public int? Change { get; set; }
    }
}
