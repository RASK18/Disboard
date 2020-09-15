using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Notification type enum
    /// </summary>
    public enum NotificationType
    {
        /// <summary>
        /// A user has liked your activity
        /// </summary>
        [EnumMember(Value = "ACTIVITY_LIKE")] ActivityLike,
        /// <summary>
        /// A user has mentioned you in their activity
        /// </summary>
        [EnumMember(Value = "ACTIVITY_MENTION")] ActivityMention,
        /// <summary>
        /// A user has sent you message
        /// </summary>
        [EnumMember(Value = "ACTIVITY_MESSAGE")] ActivityMessage,
        /// <summary>
        /// A user has replied to your activity
        /// </summary>
        [EnumMember(Value = "ACTIVITY_REPLY")] ActivityReply,
        /// <summary>
        /// A user has liked your activity reply
        /// </summary>
        [EnumMember(Value = "ACTIVITY_REPLY_LIKE")] ActivityReplyLike,
        /// <summary>
        /// A user has replied to activity you have also replied to
        /// </summary>
        [EnumMember(Value = "ACTIVITY_REPLY_SUBSCRIBED")] ActivityReplySubscribed,
        /// <summary>
        /// An anime you are currently watching has aired
        /// </summary>
        [EnumMember(Value = "AIRING")] Airing,
        /// <summary>
        /// A user has followed you
        /// </summary>
        [EnumMember(Value = "FOLLOWING")] Following,
        /// <summary>
        /// A new anime or manga has been added to the site where its related media is on the user's list
        /// </summary>
        [EnumMember(Value = "RELATED_MEDIA_ADDITION")] RelatedMediaAddition,
        /// <summary>
        /// A user has liked your forum comment
        /// </summary>
        [EnumMember(Value = "THREAD_COMMENT_LIKE")] ThreadCommentLike,
        /// <summary>
        /// A user has mentioned you in a forum comment
        /// </summary>
        [EnumMember(Value = "THREAD_COMMENT_MENTION")] ThreadCommentMention,
        /// <summary>
        /// A user has replied to your forum comment
        /// </summary>
        [EnumMember(Value = "THREAD_COMMENT_REPLY")] ThreadCommentReply,
        /// <summary>
        /// A user has liked your forum thread
        /// </summary>
        [EnumMember(Value = "THREAD_LIKE")] ThreadLike,
        /// <summary>
        /// A user has commented in one of your subscribed forum threads
        /// </summary>
        [EnumMember(Value = "THREAD_SUBSCRIBED")] ThreadSubscribed,
    }
}
