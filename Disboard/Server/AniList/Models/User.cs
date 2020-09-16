namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A user
    /// </summary>
    public class User
    {
        /// <summary>
        /// If the authenticated user if following this user
        /// </summary>
        public bool? IsFollowing { get; set; }
        /// <summary>
        /// If this user if following the authenticated user
        /// </summary>
        public bool? IsFollower { get; set; }
        /// <summary>
        /// If the user is blocked by the authenticated user
        /// </summary>
        public bool? IsBlocked { get; set; }
        /// <summary>
        /// The number of unread notifications the user has
        /// </summary>
        public int? UnreadNotificationCount { get; set; }
        /// <summary>
        /// The donation tier of the user
        /// </summary>
        public int? DonatorTier { get; set; }
        /// <summary>
        /// When the user's data was last updated
        /// </summary>
        public int? UpdatedAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Bans { get; set; }
        /// <summary>
        /// The bio written by user (Markdown)
        /// </summary>
        public string About { get; set; }
        /// <summary>
        /// The user's banner images
        /// </summary>
        public string BannerImage { get; set; }
        /// <summary>
        /// The url for the user page on the AniList website
        /// </summary>
        public string SiteUrl { get; set; }
        /// <summary>
        /// Custom donation badge text
        /// </summary>
        public string DonatorBadge { get; set; }
        /// <summary>
        /// If the user is a moderator or data moderator
        /// </summary>
        public string ModeratorStatus { get; set; }
        /// <summary>
        /// The users favourites
        /// </summary>
        public Favourites Favourites { get; set; }
        /// <summary>
        /// The user's media list options
        /// </summary>
        public MediaListOptions MediaListOptions { get; set; }
        /// <summary>
        /// The user's avatar images
        /// </summary>
        public UserAvatar Avatar { get; set; }
        /// <summary>
        /// The user's general options
        /// </summary>
        public UserOptions Options { get; set; }
        /// <summary>
        /// The users anime and manga list statistics
        /// </summary>
        public UserStatisticTypes Statistics { get; set; }
        /// <summary>
        /// The id of the user
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the user
        /// </summary>
        public string Name { get; set; }
    }
}
