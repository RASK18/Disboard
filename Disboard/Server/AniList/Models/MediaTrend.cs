namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Daily media statistics
    /// </summary>
    public class MediaTrend
    {
        /// <summary>
        /// A weighted average score of all the user's scores of the media
        /// </summary>
        public int? AverageScore { get; set; }
        /// <summary>
        /// The number of users with the media on their list
        /// </summary>
        public int? Popularity { get; set; }
        /// <summary>
        /// The number of users with watching/reading the media
        /// </summary>
        public int? InProgress { get; set; }
        /// <summary>
        /// The episode number of the anime released on this day
        /// </summary>
        public int? Episode { get; set; }
        /// <summary>
        /// The related media
        /// </summary>
        public Media Media { get; set; }
        /// <summary>
        /// The id of the tag
        /// </summary>
        public int? MediaId { get; set; }
        /// <summary>
        /// The day the data was recorded (timestamp)
        /// </summary>
        public int? Date { get; set; }
        /// <summary>
        /// The amount of media activity on the day
        /// </summary>
        public int? Trending { get; set; }
        /// <summary>
        /// If the media was being released at this time
        /// </summary>
        public bool? Releasing { get; set; }
    }
}
