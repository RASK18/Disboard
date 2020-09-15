using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Notification for when authenticated user is @ mentioned in a forum thread comment
    /// </summary>
    public class ThreadCommentMentionNotification
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
        /// The thread that the relevant comment belongs to
        /// </summary>
        public Thread Thread { get; set; }
        /// <summary>
        /// The thread comment that included the @ mention
        /// </summary>
        public ThreadComment Comment { get; set; }
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
        /// The id of the comment where mentioned
        /// </summary>
        public int? CommentId { get; set; }
    }
}
