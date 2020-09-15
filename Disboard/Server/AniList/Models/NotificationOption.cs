using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Notification option
    /// </summary>
    public class NotificationOption
    {
        /// <summary>
        /// Whether this type of notification is enabled
        /// </summary>
        public bool? Enabled { get; set; }
        /// <summary>
        /// The type of notification
        /// </summary>
        public NotificationType? Type { get; set; }
    }
}
