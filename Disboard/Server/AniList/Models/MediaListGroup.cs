using Disboard.Server.AniList.Enums;
using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// List group of anime or manga entries
    /// </summary>
    public class MediaListGroup
    {
        /// <summary>
        /// 
        /// </summary>
        public bool? IsCustomList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsSplitCompletedList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public MediaListStatus? Status { get; set; }
        /// <summary>
        /// Media list entries
        /// </summary>
        public IEnumerable<MediaList> Entries { get; set; }
    }
}
