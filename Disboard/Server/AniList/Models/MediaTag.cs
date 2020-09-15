namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A tag that describes a theme or element of the media
    /// </summary>
    public class MediaTag
    {
        /// <summary>
        /// If the tag could be a spoiler for any media
        /// </summary>
        public bool? IsGeneralSpoiler { get; set; }
        /// <summary>
        /// If the tag is a spoiler for this media
        /// </summary>
        public bool? IsMediaSpoiler { get; set; }
        /// <summary>
        /// If the tag is only for adult 18+ media
        /// </summary>
        public bool? IsAdult { get; set; }
        /// <summary>
        /// The relevance ranking of the tag out of the 100 for this media
        /// </summary>
        public int? Rank { get; set; }
        /// <summary>
        /// A general description of the tag
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The categories of tags this tag belongs to
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// The id of the tag
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// The name of the tag
        /// </summary>
        public string Name { get; set; }
    }
}
