using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Notification for when a thread comment is liked
    /// </summary>
    public class ThreadCommentLikeNotification
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
        /// The thread comment that was liked
        /// </summary>
        public ThreadComment Comment { get; set; }
        /// <summary>
        /// The user who liked the activity
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
        /// The id of the user who liked to the activity
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// The id of the activity which was liked
        /// </summary>
        public int? CommentId { get; set; }
    }
}
