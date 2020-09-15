using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class MediaConnection
    {
        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo PageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<MediaEdge> Edges { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Media> Nodes { get; set; }
    }
}
