using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Notification for when a user replies to activity the authenticated user has replied to
    /// </summary>
    public class ActivityReplySubscribedNotification
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
        /// The user who replied to the activity
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
        /// The id of the user who replied to the activity
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// The id of the activity which was replied too
        /// </summary>
        public int? ActivityId { get; set; }
    }
}
