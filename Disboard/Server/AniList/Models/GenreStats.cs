namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// User's genre statistics
    /// </summary>
    public class GenreStats
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
        /// The amount of time in minutes the genre has been watched by the user
        /// </summary>
        public int? TimeWatched { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Genre { get; set; }
    }
}
