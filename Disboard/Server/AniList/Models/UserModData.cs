using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// User data for moderators
    /// </summary>
    public class UserModData
    {
        /// <summary>
        /// 
        /// </summary>
        public string Bans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Counts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<User> Alts { get; set; }
    }
}
