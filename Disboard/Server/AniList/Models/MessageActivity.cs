using Disboard.Server.AniList.Enums;
using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// User message activity
    /// </summary>
    public class MessageActivity
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
        /// If the message is private and only viewable to the sender and recipients
        /// </summary>
        public bool? IsPrivate { get; set; }
        /// <summary>
        /// The user id of the activity's recipient
        /// </summary>
        public int? RecipientId { get; set; }
        /// <summary>
        /// The user id of the activity's sender
        /// </summary>
        public int? MessengerId { get; set; }
        /// <summary>
        /// The message text (Markdown)
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// The url for the activity page on the AniList website
        /// </summary>
        public string SiteUrl { get; set; }
        /// <summary>
        /// The user who the activity message was sent to
        /// </summary>
        public User Recipient { get; set; }
        /// <summary>
        /// The user who sent the activity message
        /// </summary>
        public User Messenger { get; set; }
        /// <summary>
        /// The type of the activity
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
