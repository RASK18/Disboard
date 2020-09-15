namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Media trailer or advertisement
    /// </summary>
    public class MediaTrailer
    {
        /// <summary>
        /// The trailer video id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The site the video is hosted by (Currently either youtube or dailymotion)
        /// </summary>
        public string Site { get; set; }
        /// <summary>
        /// The url for the thumbnail image of the video
        /// </summary>
        public string Thumbnail { get; set; }
    }
}
