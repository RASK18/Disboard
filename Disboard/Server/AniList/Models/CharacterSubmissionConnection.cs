using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CharacterSubmissionConnection
    {
        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo PageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<CharacterSubmissionEdge> Edges { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<CharacterSubmission> Nodes { get; set; }
    }
}
