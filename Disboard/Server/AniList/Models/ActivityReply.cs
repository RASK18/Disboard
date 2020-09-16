using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Replay to an activity item
    /// </summary>
    public class ActivityReply
    {
        /// <summary>
        /// If the currently authenticated user liked the reply
        /// </summary>
        public bool? IsLiked { get; set; }
        /// <summary>
        /// The id of the replies creator
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// The id of the parent activity
        /// </summary>
        public int? ActivityId { get; set; }
        /// <summary>
        /// The reply text
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// The user who created reply
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// The users who liked the reply
        /// </summary>
        public IEnumerable<User> Likes { get; set; }
        /// <summary>
        /// The id of the reply
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The amount of likes the reply has
        /// </summary>
        public int LikeCount { get; set; }
        /// <summary>
        /// The time the reply was created at
        /// </summary>
        public int CreatedAt { get; set; }
    }
}
