namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Media submission with comparison to current data
    /// </summary>
    public class MediaSubmissionComparison
    {
        /// <summary>
        /// 
        /// </summary>
        public MediaCharacter Character { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public MediaSubmissionEdge Submission { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public StaffEdge Staff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public StudioEdge Studio { get; set; }
    }
}
