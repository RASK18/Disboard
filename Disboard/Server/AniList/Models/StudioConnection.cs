using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class StudioConnection
    {
        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo PageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<StudioEdge> Edges { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Studio> Nodes { get; set; }
    }
}
