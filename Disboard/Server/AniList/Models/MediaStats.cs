using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A media's statistics
    /// </summary>
    public class MediaStats
    {
        /// <summary>
        /// No Description
        /// </summary>
        public IEnumerable<ScoreDistribution> ScoreDistribution { get; set; }
        /// <summary>
        /// No Description
        /// </summary>
        public IEnumerable<StatusDistribution> StatusDistribution { get; set; }
    }
}
