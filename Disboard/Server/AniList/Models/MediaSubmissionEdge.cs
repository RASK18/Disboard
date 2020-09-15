using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class MediaSubmissionEdge
    {
        /// <summary>
        /// 
        /// </summary>
        public bool? IsMain { get; set; }
        /// <summary>
        /// The id of the direct submission
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string StaffRole { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Character Character { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Character CharacterSubmission { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Media Media { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Staff VoiceActor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Staff VoiceActorSubmission { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Staff Staff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Staff StaffSubmission { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Studio Studio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public CharacterRole? CharacterRole { get; set; }
    }
}
