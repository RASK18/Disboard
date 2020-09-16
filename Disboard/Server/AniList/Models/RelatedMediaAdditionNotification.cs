using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Notification for when new media is added to the site
    /// </summary>
    public class RelatedMediaAdditionNotification
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
        /// The associated media of the airing schedule
        /// </summary>
        public Media Media { get; set; }
        /// <summary>
        /// The type of notification
        /// </summary>
        public NotificationType? Type { get; set; }
        /// <summary>
        /// The id of the Notification
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The id of the new media
        /// </summary>
        public int MediaId { get; set; }
    }
}
