using Disboard.Server.AniList.Enums;
using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Media submission
    /// </summary>
    public class MediaSubmission
    {
        /// <summary>
        /// 
        /// </summary>
        public int? CreatedAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SubmitterStats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Media Media { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Media Submission { get; set; }
        /// <summary>
        /// User submitter of the submission
        /// </summary>
        public User Submitter { get; set; }
        /// <summary>
        /// Status of the submission
        /// </summary>
        public SubmissionStatus? Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<string> Changes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<MediaSubmissionComparison> Characters { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<MediaSubmissionComparison> Staff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<MediaSubmissionComparison> Studios { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<MediaEdge> Relations { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<MediaExternalLink> ExternalLinks { get; set; }
        /// <summary>
        /// The id of the submission
        /// </summary>
        public int? Id { get; set; }
    }
}
