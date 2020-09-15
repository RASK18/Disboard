using Disboard.Server.AniList.Enums;
using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A user's general options
    /// </summary>
    public class UserOptions
    {
        /// <summary>
        /// Whether the user has enabled viewing of 18+ content
        /// </summary>
        public bool? DisplayAdultContent { get; set; }
        /// <summary>
        /// Whether the user receives notifications when a show they are watching aires
        /// </summary>
        public bool? AiringNotifications { get; set; }
        /// <summary>
        /// Profile highlight color (blue, purple, pink, orange, red, green, gray)
        /// </summary>
        public string ProfileColor { get; set; }
        /// <summary>
        /// The language the user wants to see media titles in
        /// </summary>
        public UserTitleLanguage? TitleLanguage { get; set; }
        /// <summary>
        /// Notification options
        /// </summary>
        public IEnumerable<NotificationOption> NotificationOptions { get; set; }
    }
}
