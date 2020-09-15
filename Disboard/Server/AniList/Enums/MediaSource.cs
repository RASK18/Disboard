using System.ComponentModel;
using Newtonsoft.Json;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Source type the media was adapted from
    /// </summary>
    public enum MediaSource
    {
        /// <summary>
        /// An original production not based of another work
        /// </summary>
        [Description("ORIGINAL")] Original,
        /// <summary>
        /// Asian comic book
        /// </summary>
        [Description("MANGA")] Manga,
        /// <summary>
        /// Written work published in volumes
        /// </summary>
        [JsonProperty("LIGHT_NOVEL")] LIGHT_NOVEL,
        /// <summary>
        /// Video game driven primary by text and narrative
        /// </summary>
        [Description("VISUAL_NOVEL")] VisualNovel,
        /// <summary>
        /// Video game
        /// </summary>
        [Description("VIDEO_GAME")] VideoGame,
        /// <summary>
        /// Other
        /// </summary>
        [Description("OTHER")] Other,
        /// <summary>
        /// Version 2 only. Written works not published in volumes
        /// </summary>
        [Description("NOVEL")] Novel,
        /// <summary>
        /// Version 2 only. Self-published works
        /// </summary>
        [Description("DOUJINSHI")] Doujinshi,
        /// <summary>
        /// Version 2 only. Japanese Anime
        /// </summary>
        [Description("ANIME")] Anime,
    }
}
