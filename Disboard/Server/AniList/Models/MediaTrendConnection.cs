using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class MediaTrendConnection
    {
        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo PageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<MediaTrendEdge> Edges { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<MediaTrend> Nodes { get; set; }
    }
}
