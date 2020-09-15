using Disboard.Server.AniList.Enums;
using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// CharacterSubmission connection edge
    /// </summary>
    public class CharacterSubmissionEdge
    {
        /// <summary>
        /// 
        /// </summary>
        public CharacterSubmission Node { get; set; }
        /// <summary>
        /// The characters role in the media
        /// </summary>
        public CharacterRole? Role { get; set; }
        /// <summary>
        /// The voice actors of the character
        /// </summary>
        public IEnumerable<Staff> VoiceActors { get; set; }
        /// <summary>
        /// The submitted voice actors of the character
        /// </summary>
        public IEnumerable<StaffSubmission> SubmittedVoiceActors { get; set; }
    }
}
