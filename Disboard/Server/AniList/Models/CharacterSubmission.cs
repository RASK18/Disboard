using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A submission for a character that features in an anime or manga
    /// </summary>
    public class CharacterSubmission
    {
        /// <summary>
        /// 
        /// </summary>
        public int? CreatedAt { get; set; }
        /// <summary>
        /// Inner details of submission status
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// Character that the submission is referencing
        /// </summary>
        public Character Character { get; set; }
        /// <summary>
        /// The character submission changes
        /// </summary>
        public Character Submission { get; set; }
        /// <summary>
        /// Submitter for the submission
        /// </summary>
        public User Submitter { get; set; }
        /// <summary>
        /// Status of the submission
        /// </summary>
        public SubmissionStatus? Status { get; set; }
        /// <summary>
        /// The id of the submission
        /// </summary>
        public int Id { get; set; }
    }
}
