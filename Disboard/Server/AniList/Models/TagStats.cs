namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// User's tag statistics
    /// </summary>
    public class TagStats
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
        /// The amount of time in minutes the tag has been watched by the user
        /// </summary>
        public int? TimeWatched { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public MediaTag Tag { get; set; }
    }
}
