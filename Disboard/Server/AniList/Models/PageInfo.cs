namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class PageInfo
    {
        /// <summary>
        /// If there is another page
        /// </summary>
        public bool? HasNextPage { get; set; }
        /// <summary>
        /// The total number of items
        /// </summary>
        public int? Total { get; set; }
        /// <summary>
        /// The count on a page
        /// </summary>
        public int? PerPage { get; set; }
        /// <summary>
        /// The current page
        /// </summary>
        public int? CurrentPage { get; set; }
        /// <summary>
        /// The last page
        /// </summary>
        public int? LastPage { get; set; }
    }
}
