using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class UserScoreStatistic
    {
        /// <summary>
        /// 
        /// </summary>
        public int? Score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float MeanScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MinutesWatched { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ChaptersRead { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<int?> MediaIds { get; set; }
    }
}
