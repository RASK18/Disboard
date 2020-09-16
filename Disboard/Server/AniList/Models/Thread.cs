using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Forum Thread
    /// </summary>
    public class Thread
    {
        /// <summary>
        /// If the thread is locked and can receive comments
        /// </summary>
        public bool? IsLocked { get; set; }
        /// <summary>
        /// If the thread is stickied and should be displayed at the top of the page
        /// </summary>
        public bool? IsSticky { get; set; }
        /// <summary>
        /// If the currently authenticated user is subscribed to the thread
        /// </summary>
        public bool? IsSubscribed { get; set; }
        /// <summary>
        /// If the currently authenticated user liked the thread
        /// </summary>
        public bool? IsLiked { get; set; }
        /// <summary>
        /// The id of the user who most recently commented on the thread
        /// </summary>
        public int? ReplyUserId { get; set; }
        /// <summary>
        /// The id of the most recent comment on the thread
        /// </summary>
        public int? ReplyCommentId { get; set; }
        /// <summary>
        /// The number of comments on the thread
        /// </summary>
        public int? ReplyCount { get; set; }
        /// <summary>
        /// The number of times users have viewed the thread
        /// </summary>
        public int? ViewCount { get; set; }
        /// <summary>
        /// The time of the last reply
        /// </summary>
        public int? RepliedAt { get; set; }
        /// <summary>
        /// The title of the thread
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The text body of the thread (Markdown)
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The url for the thread page on the AniList website
        /// </summary>
        public string SiteUrl { get; set; }
        /// <summary>
        /// The owner of the thread
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// The user to last reply to the thread
        /// </summary>
        public User ReplyUser { get; set; }
        /// <summary>
        /// The users who liked the thread
        /// </summary>
        public IEnumerable<User> Likes { get; set; }
        /// <summary>
        /// The categories of the thread
        /// </summary>
        public IEnumerable<ThreadCategory> Categories { get; set; }
        /// <summary>
        /// The media categories of the thread
        /// </summary>
        public IEnumerable<Media> MediaCategories { get; set; }
        /// <summary>
        /// The id of the thread
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The id of the thread owner user
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// The amount of likes the thread has
        /// </summary>
        public int LikeCount { get; set; }
        /// <summary>
        /// The time of the thread creation
        /// </summary>
        public int CreatedAt { get; set; }
        /// <summary>
        /// The time of the thread last update
        /// </summary>
        public int UpdatedAt { get; set; }
    }
}
