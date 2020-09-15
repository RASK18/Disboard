using Disboard.Server.AniList.Enums;
using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Character connection edge
    /// </summary>
    public class CharacterEdge
    {
        /// <summary>
        /// The id of the connection
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// The order the character should be displayed from the users favourites
        /// </summary>
        public int? FavouriteOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Character Node { get; set; }
        /// <summary>
        /// The characters role in the media
        /// </summary>
        public CharacterRole? Role { get; set; }
        /// <summary>
        /// The voice actors of the character
        /// </summary>
        public IEnumerable<Staff> VoiceActors { get; set; }
        /// <summary>
        /// The media the character is in
        /// </summary>
        public IEnumerable<Media> Media { get; set; }
    }
}
