namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// No Description
    /// </summary>
    public class MediaCoverImage
    {
        /// <summary>
        /// The cover image url of the media at its largest size. If this size isn't available, large will be provided instead.
        /// </summary>
        public string ExtraLarge { get; set; }
        /// <summary>
        /// The cover image url of the media at a large size
        /// </summary>
        public string Large { get; set; }
        /// <summary>
        /// The cover image url of the media at medium size
        /// </summary>
        public string Medium { get; set; }
        /// <summary>
        /// Average #hex color of cover image
        /// </summary>
        public string Color { get; set; }
    }
}
