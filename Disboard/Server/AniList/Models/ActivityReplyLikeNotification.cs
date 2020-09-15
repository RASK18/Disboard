using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Notification for when a activity reply is liked
    /// </summary>
    public class ActivityReplyLikeNotification
    {
        /// <summary>
        /// The time the notification was created at
        /// </summary>
        public int? CreatedAt { get; set; }
        /// <summary>
        /// The notification context text
        /// </summary>
        public string Context { get; set; }
        /// <summary>
        /// The user who liked the activity reply
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// The type of notification
        /// </summary>
        public NotificationType? Type { get; set; }
        /// <summary>
        /// The id of the Notification
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// The id of the user who liked to the activity reply
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// The id of the activity where the reply which was liked
        /// </summary>
        public int? ActivityId { get; set; }
    }
}
