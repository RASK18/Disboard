namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// An external link to another site related to the media
    /// </summary>
    public class MediaExternalLink
    {
        /// <summary>
        /// The id of the external link
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The url of the external link
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// The site location of the external link
        /// </summary>
        public string Site { get; set; }
    }
}
