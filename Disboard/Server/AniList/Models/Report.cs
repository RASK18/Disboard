namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Report
    {
        /// <summary>
        /// When the entry data was created
        /// </summary>
        public int? CreatedAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public User Reporter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public User Reported { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Id { get; set; }
    }
}
