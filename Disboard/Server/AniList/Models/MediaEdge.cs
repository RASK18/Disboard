using Disboard.Server.AniList.Enums;
using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Media connection edge
    /// </summary>
    public class MediaEdge
    {
        /// <summary>
        /// The id of the connection
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// The order the media should be displayed from the users favourites
        /// </summary>
        public int? FavouriteOrder { get; set; }
        /// <summary>
        /// The role of the staff member in the production of the media
        /// </summary>
        public string StaffRole { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Media Node { get; set; }
        /// <summary>
        /// The characters role in the media
        /// </summary>
        public CharacterRole? CharacterRole { get; set; }
        /// <summary>
        /// The type of relation to the parent model
        /// </summary>
        public MediaRelation? RelationType { get; set; }
        /// <summary>
        /// The characters in the media voiced by the parent actor
        /// </summary>
        public IEnumerable<Character> Characters { get; set; }
        /// <summary>
        /// The voice actors of the character
        /// </summary>
        public IEnumerable<Staff> VoiceActors { get; set; }
        /// <summary>
        /// If the studio is the main animation studio of the media (For Studio->MediaConnection field only)
        /// </summary>
        public bool? IsMainStudio { get; set; }
    }
}
