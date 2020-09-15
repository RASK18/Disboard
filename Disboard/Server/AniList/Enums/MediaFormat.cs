using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// The format the media was released in
    /// </summary>
    public enum MediaFormat
    {
        /// <summary>
        /// Professionally published manga with more than one chapter
        /// </summary>
        [EnumMember(Value = "MANGA")] Manga,
        /// <summary>
        /// Anime movies with a theatrical release
        /// </summary>
        [EnumMember(Value = "MOVIE")] Movie,
        /// <summary>
        /// Short anime released as a music video
        /// </summary>
        [EnumMember(Value = "MUSIC")] Music,
        /// <summary>
        /// Written books released as a series of light novels
        /// </summary>
        [EnumMember(Value = "NOVEL")] Novel,
        /// <summary>
        /// (Original Net Animation) Anime that have been originally released online or are only available through streaming services.
        /// </summary>
        [EnumMember(Value = "ONA")] Ona,
        /// <summary>
        /// Manga with just one chapter
        /// </summary>
        [EnumMember(Value = "ONE_SHOT")] OneShot,
        /// <summary>
        /// (Original Video Animation) Anime that have been released directly on DVD/Blu-ray without originally going through a theatrical release or television broadcast
        /// </summary>
        [EnumMember(Value = "OVA")] Ova,
        /// <summary>
        /// Special episodes that have been included in DVD/Blu-ray releases, picture dramas, pilots, etc
        /// </summary>
        [EnumMember(Value = "SPECIAL")] Special,
        /// <summary>
        /// Anime broadcast on television
        /// </summary>
        [EnumMember(Value = "TV")] Tv,
        /// <summary>
        /// Anime which are under 15 minutes in length and broadcast on television
        /// </summary>
        [EnumMember(Value = "TV_SHORT")] TvShort,
    }
}
