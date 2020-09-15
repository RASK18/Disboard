namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Media Airing Schedule
    /// </summary>
    public class AiringSchedule
    {
        /// <summary>
        /// The associate media of the airing episode
        /// </summary>
        public Media Media { get; set; }
        /// <summary>
        /// The id of the airing schedule item
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// The time the episode airs at
        /// </summary>
        public int? AiringAt { get; set; }
        /// <summary>
        /// Seconds until episode starts airing
        /// </summary>
        public int? TimeUntilAiring { get; set; }
        /// <summary>
        /// The airing episode number
        /// </summary>
        public int? Episode { get; set; }
        /// <summary>
        /// The associate media id of the airing episode
        /// </summary>
        public int? MediaId { get; set; }
    }
}
