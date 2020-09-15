using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Notification for when authenticated user is @ mentioned in activity or reply
    /// </summary>
    public class ActivityMentionNotification
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
        /// The user who mentioned the authenticated user
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
        /// The id of the user who mentioned the authenticated user
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// The id of the activity where mentioned
        /// </summary>
        public int? ActivityId { get; set; }
    }
}
