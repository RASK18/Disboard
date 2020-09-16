using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Activity type enum.
    /// </summary>
    public enum ActivityType
    {
        /// <summary>
        /// A anime list update activity
        /// </summary>
        [EnumMember(Value = "ANIME_LIST")] AnimeList,
        /// <summary>
        /// A manga list update activity
        /// </summary>
        [EnumMember(Value = "MANGA_LIST")] MangaList,
        /// <summary>
        /// Anime and Manga list update, only used in query arguments
        /// </summary>
        [EnumMember(Value = "MEDIA_LIST")] MediaList,
        /// <summary>
        /// A text message activity sent to another user
        /// </summary>
        [EnumMember(Value = "MESSAGE")] Message,
        /// <summary>
        /// A text activity
        /// </summary>
        [EnumMember(Value = "TEXT")] Text,
    }
}
