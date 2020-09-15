using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Source type the media was adapted from
    /// </summary>
    public enum MediaSource
    {
        /// <summary>
        /// Version 2 only. Japanese Anime
        /// </summary>
        [EnumMember(Value = "ANIME")] Anime,
        /// <summary>
        /// Version 2 only. Self-published works
        /// </summary>
        [EnumMember(Value = "DOUJINSHI")] Doujinshi,
        /// <summary>
        /// Written work published in volumes
        /// </summary>
        [EnumMember(Value = "LIGHT_NOVEL")] LightNovel,
        /// <summary>
        /// Asian comic book
        /// </summary>
        [EnumMember(Value = "MANGA")] Manga,
        /// <summary>
        /// Version 2 only. Written works not published in volumes
        /// </summary>
        [EnumMember(Value = "NOVEL")] Novel,
        /// <summary>
        /// An original production not based of another work
        /// </summary>
        [EnumMember(Value = "ORIGINAL")] Original,
        /// <summary>
        /// Other
        /// </summary>
        [EnumMember(Value = "OTHER")] Other,
        /// <summary>
        /// Video game
        /// </summary>
        [EnumMember(Value = "VIDEO_GAME")] VideoGame,
        /// <summary>
        /// Video game driven primary by text and narrative
        /// </summary>
        [EnumMember(Value = "VISUAL_NOVEL")] VisualNovel,
    }
}
