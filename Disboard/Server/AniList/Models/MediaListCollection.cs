using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// List of anime or manga
    /// </summary>
    public class MediaListCollection
    {
        /// <summary>
        /// If there is another chunk
        /// </summary>
        public bool? HasNextChunk { get; set; }
        /// <summary>
        /// The owner of the list
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Grouped media list entries
        /// </summary>
        public IEnumerable<MediaListGroup> Lists { get; set; }
    }
}
