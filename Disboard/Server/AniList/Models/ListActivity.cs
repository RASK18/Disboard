using Disboard.Server.AniList.Enums;
using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// User list activity (anime and manga updates)
    /// </summary>
    public class ListActivity
    {
        /// <summary>
        /// If the activity is locked and can receive replies
        /// </summary>
        public bool? IsLocked { get; set; }
        /// <summary>
        /// If the currently authenticated user is subscribed to the activity
        /// </summary>
        public bool? IsSubscribed { get; set; }
        /// <summary>
        /// If the currently authenticated user liked the activity
        /// </summary>
        public bool? IsLiked { get; set; }
        /// <summary>
        /// The user id of the activity's creator
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// The list item's textual status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// The list progress made
        /// </summary>
        public string Progress { get; set; }
        /// <summary>
        /// The url for the activity page on the AniList website
        /// </summary>
        public string SiteUrl { get; set; }
        /// <summary>
        /// The associated media to the activity update
        /// </summary>
        public Media Media { get; set; }
        /// <summary>
        /// The owner of the activity
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// The type of activity
        /// </summary>
        public ActivityType? Type { get; set; }
        /// <summary>
        /// The written replies to the activity
        /// </summary>
        public IEnumerable<ActivityReply> Replies { get; set; }
        /// <summary>
        /// The users who liked the activity
        /// </summary>
        public IEnumerable<User> Likes { get; set; }
        /// <summary>
        /// The id of the activity
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The number of activity replies
        /// </summary>
        public int ReplyCount { get; set; }
        /// <summary>
        /// The amount of likes the activity has
        /// </summary>
        public int LikeCount { get; set; }
        /// <summary>
        /// The time the activity was created at
        /// </summary>
        public int CreatedAt { get; set; }
    }
}
