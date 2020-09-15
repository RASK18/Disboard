using System.Collections.Generic;
using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class UserStatusStatistic
    {
        /// <summary>
        /// 
        /// </summary>
        public MediaListStatus? Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float? MeanScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? MinutesWatched { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? ChaptersRead { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<int?> MediaIds { get; set; }
    }
}
