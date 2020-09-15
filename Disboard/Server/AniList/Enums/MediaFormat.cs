using System.ComponentModel;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// The format the media was released in
    /// </summary>
    public enum MediaFormat
    {
        /// <summary>
        /// Anime broadcast on television
        /// </summary>
        [Description("TV")] Tv,
        /// <summary>
        /// Anime which are under 15 minutes in length and broadcast on television
        /// </summary>
        [Description("TV_SHORT")] TvShort,
        /// <summary>
        /// Anime movies with a theatrical release
        /// </summary>
        [Description("MOVIE")] Movie,
        /// <summary>
        /// Special episodes that have been included in DVD/Blu-ray releases, picture dramas, pilots, etc
        /// </summary>
        [Description("SPECIAL")] Special,
        /// <summary>
        /// (Original Video Animation) Anime that have been released directly on DVD/Blu-ray without originally going through a theatrical release or television broadcast
        /// </summary>
        [Description("OVA")] Ova,
        /// <summary>
        /// (Original Net Animation) Anime that have been originally released online or are only available through streaming services.
        /// </summary>
        [Description("ONA")] Ona,
        /// <summary>
        /// Short anime released as a music video
        /// </summary>
        [Description("MUSIC")] Music,
        /// <summary>
        /// Professionally published manga with more than one chapter
        /// </summary>
        [Description("MANGA")] Manga,
        /// <summary>
        /// Written books released as a series of light novels
        /// </summary>
        [Description("NOVEL")] Novel,
        /// <summary>
        /// Manga with just one chapter
        /// </summary>
        [Description("ONE_SHOT")] OneShot,
    }
}
