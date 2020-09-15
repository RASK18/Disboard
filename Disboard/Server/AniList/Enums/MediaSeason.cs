using System.ComponentModel;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// No Description
    /// </summary>
    public enum MediaSeason
    {
        /// <summary>
        /// Months December to February
        /// </summary>
        [Description("WINTER")] Winter,
        /// <summary>
        /// Months March to May
        /// </summary>
        [Description("SPRING")] Spring,
        /// <summary>
        /// Months June to August
        /// </summary>
        [Description("SUMMER")] Summer,
        /// <summary>
        /// Months September to November
        /// </summary>
        [Description("FALL")] Fall,
    }
}
