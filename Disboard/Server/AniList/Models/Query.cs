using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Query
    {
        /// <summary>
        /// Activity reply query
        /// </summary>
        public ActivityReply ActivityReply { get; set; }
        /// <summary>
        /// Airing schedule query
        /// </summary>
        public AiringSchedule AiringSchedule { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public AniChartUser AniChartUser { get; set; }
        /// <summary>
        /// Character query
        /// </summary>
        public Character Character { get; set; }
        /// <summary>
        /// Media query
        /// </summary>
        public Media Media { get; set; }
        /// <summary>
        /// Media list query
        /// </summary>
        public MediaList MediaList { get; set; }
        /// <summary>
        /// Media list collection query, provides list pre-grouped by status & custom lists. User ID and Media Type arguments required.
        /// </summary>
        public MediaListCollection MediaListCollection { get; set; }
        /// <summary>
        /// Media Trend query
        /// </summary>
        public MediaTrend MediaTrend { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Page Page { get; set; }
        /// <summary>
        /// Provide AniList markdown to be converted to html (Requires auth)
        /// </summary>
        public ParsedMarkdown Markdown { get; set; }
        /// <summary>
        /// Recommendation query
        /// </summary>
        public Recommendation Recommendation { get; set; }
        /// <summary>
        /// Review query
        /// </summary>
        public Review Review { get; set; }
        /// <summary>
        /// Site statistics query
        /// </summary>
        public SiteStatistics SiteStatistics { get; set; }
        /// <summary>
        /// Staff query
        /// </summary>
        public Staff Staff { get; set; }
        /// <summary>
        /// Studio query
        /// </summary>
        public Studio Studio { get; set; }
        /// <summary>
        /// Thread query
        /// </summary>
        public Thread Thread { get; set; }
        /// <summary>
        /// User query
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Get the currently authenticated user
        /// </summary>
        public User Viewer { get; set; }
        /// <summary>
        /// Follow query
        /// </summary>
        public User Following { get; set; }
        /// <summary>
        /// Follow query
        /// </summary>
        public User Follower { get; set; }
        /// <summary>
        /// Like query
        /// </summary>
        public User Like { get; set; }
        /// <summary>
        /// Collection of all the possible media genres
        /// </summary>
        public IEnumerable<string> GenreCollection { get; set; }
        /// <summary>
        /// Collection of all the possible media tags
        /// </summary>
        public IEnumerable<MediaTag> MediaTagCollection { get; set; }
        /// <summary>
        /// Comment query
        /// </summary>
        public IEnumerable<ThreadComment> ThreadComment { get; set; }
    }
}
