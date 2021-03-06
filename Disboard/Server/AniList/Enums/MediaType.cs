using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Media type enum, anime or manga.
    /// </summary>
    public enum MediaType
    {
        /// <summary>
        /// Japanese Anime
        /// </summary>
        [EnumMember(Value = "ANIME")] Anime,
        /// <summary>
        /// Asian comic
        /// </summary>
        [EnumMember(Value = "MANGA")] Manga,
    }
}
