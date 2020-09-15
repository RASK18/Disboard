using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Internal - Media characters separated
    /// </summary>
    public class MediaCharacter
    {
        /// <summary>
        /// The id of the connection
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// The characters in the media voiced by the parent actor
        /// </summary>
        public Character Character { get; set; }
        /// <summary>
        /// The voice actor of the character
        /// </summary>
        public Staff VoiceActor { get; set; }
        /// <summary>
        /// The characters role in the media
        /// </summary>
        public CharacterRole? Role { get; set; }
    }
}
