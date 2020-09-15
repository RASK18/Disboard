using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ReviewConnection
    {
        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo PageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ReviewEdge> Edges { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Review> Nodes { get; set; }
    }
}
