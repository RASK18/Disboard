using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A media's statistics
    /// </summary>
    public class MediaStats
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ScoreDistribution> ScoreDistribution { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<StatusDistribution> StatusDistribution { get; set; }
    }
}
