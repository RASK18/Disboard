namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Date object that allows for incomplete date values (fuzzy)
    /// </summary>
    public class FuzzyDate
    {
        /// <summary>
        /// Numeric Year (2017)
        /// </summary>
        public int? Year { get; set; }
        /// <summary>
        /// Numeric Month (3)
        /// </summary>
        public int? Month { get; set; }
        /// <summary>
        /// Numeric Day (24)
        /// </summary>
        public int? Day { get; set; }
    }
}
