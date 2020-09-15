namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class SiteStatistics
    {
        /// <summary>
        /// 
        /// </summary>
        public SiteTrendConnection Users { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SiteTrendConnection Anime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SiteTrendConnection Manga { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SiteTrendConnection Characters { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SiteTrendConnection Staff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SiteTrendConnection Studios { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SiteTrendConnection Reviews { get; set; }
    }
}
