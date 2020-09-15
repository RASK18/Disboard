using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// The names of the character
    /// </summary>
    public class CharacterName
    {
        /// <summary>
        /// The character's given name
        /// </summary>
        public string First { get; set; }
        /// <summary>
        /// The character's surname
        /// </summary>
        public string Last { get; set; }
        /// <summary>
        /// The character's full name
        /// </summary>
        public string Full { get; set; }
        /// <summary>
        /// The character's full name in their native language
        /// </summary>
        public string Native { get; set; }
        /// <summary>
        /// Other names the character might be referred to as
        /// </summary>
        public IEnumerable<string> Alternative { get; set; }
    }
}
