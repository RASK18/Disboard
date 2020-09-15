namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Data and links to legal streaming episodes on external sites
    /// </summary>
    public class MediaStreamingEpisode
    {
        /// <summary>
        /// Title of the episode
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Url of episode image thumbnail
        /// </summary>
        public string Thumbnail { get; set; }
        /// <summary>
        /// The url of the episode
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// The site location of the streaming episodes
        /// </summary>
        public string Site { get; set; }
    }
}
