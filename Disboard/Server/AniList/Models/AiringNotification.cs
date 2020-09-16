using Disboard.Server.AniList.Enums;
using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Notification for when an episode of anime airs
    /// </summary>
    public class AiringNotification
    {
        /// <summary>
        /// The time the notification was created at
        /// </summary>
        public int? CreatedAt { get; set; }
        /// <summary>
        /// The associated media of the airing schedule
        /// </summary>
        public Media Media { get; set; }
        /// <summary>
        /// The type of notification
        /// </summary>
        public NotificationType? Type { get; set; }
        /// <summary>
        /// The notification context text
        /// </summary>
        public IEnumerable<string> Contexts { get; set; }
        /// <summary>
        /// The id of the Notification
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The id of the aired anime
        /// </summary>
        public int AnimeId { get; set; }
        /// <summary>
        /// The episode number that just aired
        /// </summary>
        public int Episode { get; set; }
    }
}
