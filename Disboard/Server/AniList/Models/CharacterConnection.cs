using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CharacterConnection
    {
        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo PageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<CharacterEdge> Edges { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Character> Nodes { get; set; }
    }
}
