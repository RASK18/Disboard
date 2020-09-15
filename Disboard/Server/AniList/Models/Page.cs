using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Page of data
    /// </summary>
    public class Page
    {
        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo PageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<User> Users { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Media> Media { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Character> Characters { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Staff> Staff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Studio> Studios { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<MediaList> MediaList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<AiringSchedule> AiringSchedules { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<MediaTrend> MediaTrends { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<User> Followers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<User> Following { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ActivityReply> ActivityReplies { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Thread> Threads { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ThreadComment> ThreadComments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Review> Reviews { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Recommendation> Recommendations { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<User> Likes { get; set; }
    }
}
