using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class AiringScheduleConnection
    {
        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo PageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<AiringScheduleEdge> Edges { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<AiringSchedule> Nodes { get; set; }
    }
}
