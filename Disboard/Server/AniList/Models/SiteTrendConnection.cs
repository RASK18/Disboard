using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class SiteTrendConnection
    {
        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo PageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<SiteTrendEdge> Edges { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<SiteTrend> Nodes { get; set; }
    }
}
