namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A user's list score distribution.
    /// </summary>
    public class ScoreDistribution
    {
        /// <summary>
        /// 
        /// </summary>
        public int? Score { get; set; }
        /// <summary>
        /// The amount of list entries with this score
        /// </summary>
        public int? Amount { get; set; }
    }
}
