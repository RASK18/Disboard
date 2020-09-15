using System.ComponentModel;

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
        [Description("ANIME")] Anime,
        /// <summary>
        /// Asian comic
        /// </summary>
        [Description("MANGA")] Manga,
    }
}
