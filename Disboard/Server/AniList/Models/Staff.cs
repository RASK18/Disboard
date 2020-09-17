using Disboard.Server.AniList.Enums;
using Newtonsoft.Json;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Voice actors or production staff
    /// </summary>
    public class Staff
    {
        /// <summary>
        /// Status of the submission
        /// </summary>
        public int? SubmissionStatus { get; set; }
        /// <summary>
        /// The amount of user's who have favourited the staff member
        /// </summary>
        public int? Favourites { get; set; }
        /// <summary>
        /// A general description of the staff member
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The url for the staff page on the AniList website
        /// </summary>
        public string SiteUrl { get; set; }
        /// <summary>
        /// Inner details of submission status
        /// </summary>
        public string SubmissionNotes { get; set; }
        /// <summary>
        /// Notes for site moderators
        /// </summary>
        public string ModNotes { get; set; }
        /// <summary>
        /// Characters voiced by the actor
        /// </summary>
        public CharacterConnection Characters { get; set; }
        /// <summary>
        /// Media where the staff member has a production role
        /// </summary>
        public MediaConnection StaffMedia { get; set; }
        /// <summary>
        /// Staff member that the submission is referencing
        /// </summary>
        [JsonProperty("staff")]
        public Staff Staff2 { get; set; }
        /// <summary>
        /// The staff images
        /// </summary>
        public StaffImage Image { get; set; }
        /// <summary>
        /// The names of the staff member
        /// </summary>
        public StaffName Name { get; set; }
        /// <summary>
        /// Submitter for the submission
        /// </summary>
        public User Submitter { get; set; }
        /// <summary>
        /// The primary language of the staff member
        /// </summary>
        public StaffLanguage? Language { get; set; }
        /// <summary>
        /// The id of the staff member
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// If the staff member is marked as favourite by the currently authenticated user
        /// </summary>
        public bool IsFavourite { get; set; }
    }
}
