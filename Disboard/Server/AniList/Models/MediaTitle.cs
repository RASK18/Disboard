namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// The official titles of the media in various languages
    /// </summary>
    public class MediaTitle
    {
        /// <summary>
        /// The romanization of the native language title
        /// </summary>
        public string Romaji { get; set; }
        /// <summary>
        /// The official english title
        /// </summary>
        public string English { get; set; }
        /// <summary>
        /// Official title in it's native language
        /// </summary>
        public string Native { get; set; }
        /// <summary>
        /// The currently authenticated users preferred title language. Default romaji for non-authenticated
        /// </summary>
        public string UserPreferred { get; set; }
    }
}
