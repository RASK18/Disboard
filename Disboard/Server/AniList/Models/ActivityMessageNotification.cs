using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Notification for when a user is send an activity message
    /// </summary>
    public class ActivityMessageNotification
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
        /// The message activity
        /// </summary>
        public MessageActivity Message { get; set; }
        /// <summary>
        /// The user who sent the message
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
        /// The if of the user who send the message
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// The id of the activity message
        /// </summary>
        public int? ActivityId { get; set; }
    }
}
