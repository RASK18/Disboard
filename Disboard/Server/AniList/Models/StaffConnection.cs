using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class StaffConnection
    {
        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo PageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<StaffEdge> Edges { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Staff> Nodes { get; set; }
    }
}
