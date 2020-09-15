using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Forum Thread Comment
    /// </summary>
    public class ThreadComment
    {
        /// <summary>
        /// If the currently authenticated user liked the comment
        /// </summary>
        public bool? IsLiked { get; set; }
        /// <summary>
        /// The user id of the comment's owner
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// The id of thread the comment belongs to
        /// </summary>
        public int? ThreadId { get; set; }
        /// <summary>
        /// The comment's child reply comments
        /// </summary>
        public string ChildComments { get; set; }
        /// <summary>
        /// The text content of the comment (Markdown)
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// The url for the comment page on the AniList website
        /// </summary>
        public string SiteUrl { get; set; }
        /// <summary>
        /// The thread the comment belongs to
        /// </summary>
        public Thread Thread { get; set; }
        /// <summary>
        /// The user who created the comment
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// The users who liked the comment
        /// </summary>
        public IEnumerable<User> Likes { get; set; }
        /// <summary>
        /// The id of the comment
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// The amount of likes the comment has
        /// </summary>
        public int? LikeCount { get; set; }
        /// <summary>
        /// The time of the comments creation
        /// </summary>
        public int? CreatedAt { get; set; }
        /// <summary>
        /// The time of the comments last update
        /// </summary>
        public int? UpdatedAt { get; set; }
    }
}
