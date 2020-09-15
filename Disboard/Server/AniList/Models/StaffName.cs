using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// The names of the staff member
    /// </summary>
    public class StaffName
    {
        /// <summary>
        /// The person's given name
        /// </summary>
        public string First { get; set; }
        /// <summary>
        /// The person's surname
        /// </summary>
        public string Last { get; set; }
        /// <summary>
        /// The person's full name
        /// </summary>
        public string Full { get; set; }
        /// <summary>
        /// The person's full name in their native language
        /// </summary>
        public string Native { get; set; }
        /// <summary>
        /// Other names the staff member might be referred to as (pen names)
        /// </summary>
        public IEnumerable<string> Alternative { get; set; }
    }
}
