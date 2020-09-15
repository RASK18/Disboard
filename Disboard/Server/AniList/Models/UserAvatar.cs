namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A user's avatars
    /// </summary>
    public class UserAvatar
    {
        /// <summary>
        /// The avatar of user at its largest size
        /// </summary>
        public string Large { get; set; }
        /// <summary>
        /// The avatar of user at medium size
        /// </summary>
        public string Medium { get; set; }
    }
}
