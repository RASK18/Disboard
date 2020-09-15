using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A user's list options for anime or manga lists
    /// </summary>
    public class MediaListTypeOptions
    {
        /// <summary>
        /// If the completed sections of the list should be separated by format
        /// </summary>
        public bool? SplitCompletedSectionByFormat { get; set; }
        /// <summary>
        /// If advanced scoring is enabled
        /// </summary>
        public bool? AdvancedScoringEnabled { get; set; }
        /// <summary>
        /// The order each list should be displayed in
        /// </summary>
        public IEnumerable<string> SectionOrder { get; set; }
        /// <summary>
        /// The names of the user's custom lists
        /// </summary>
        public IEnumerable<string> CustomLists { get; set; }
        /// <summary>
        /// The names of the user's advanced scoring sections
        /// </summary>
        public IEnumerable<string> AdvancedScoring { get; set; }
    }
}
