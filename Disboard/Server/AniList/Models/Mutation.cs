using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Mutation
    {
        /// <summary>
        /// 
        /// </summary>
        public string UpdateAniChartSettings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UpdateAniChartHighlights { get; set; }
        /// <summary>
        /// Create or update an activity reply
        /// </summary>
        public ActivityReply SaveActivityReply { get; set; }
        /// <summary>
        /// Delete a media list entry
        /// </summary>
        public Deleted DeleteMediaListEntry { get; set; }
        /// <summary>
        /// Delete a custom list and remove the list entries from it
        /// </summary>
        public Deleted DeleteCustomList { get; set; }
        /// <summary>
        /// Delete an activity item of the authenticated users
        /// </summary>
        public Deleted DeleteActivity { get; set; }
        /// <summary>
        /// Delete an activity reply of the authenticated users
        /// </summary>
        public Deleted DeleteActivityReply { get; set; }
        /// <summary>
        /// Delete a review
        /// </summary>
        public Deleted DeleteReview { get; set; }
        /// <summary>
        /// Delete a thread
        /// </summary>
        public Deleted DeleteThread { get; set; }
        /// <summary>
        /// Delete a thread comment
        /// </summary>
        public Deleted DeleteThreadComment { get; set; }
        /// <summary>
        /// Favourite or unfavourite an anime, manga, character, staff member, or studio
        /// </summary>
        public Favourites ToggleFavourite { get; set; }
        /// <summary>
        /// Update the order favourites are displayed in
        /// </summary>
        public Favourites UpdateFavouriteOrder { get; set; }
        /// <summary>
        /// Update list activity (Mod Only)
        /// </summary>
        public ListActivity SaveListActivity { get; set; }
        /// <summary>
        /// Create or update a media list entry
        /// </summary>
        public MediaList SaveMediaListEntry { get; set; }
        /// <summary>
        /// Create or update message activity for the currently authenticated user
        /// </summary>
        public MessageActivity SaveMessageActivity { get; set; }
        /// <summary>
        /// Recommendation a media
        /// </summary>
        public Recommendation SaveRecommendation { get; set; }
        /// <summary>
        /// Create or update a review
        /// </summary>
        public Review SaveReview { get; set; }
        /// <summary>
        /// Rate a review
        /// </summary>
        public Review RateReview { get; set; }
        /// <summary>
        /// Create or update text activity for the currently authenticated user
        /// </summary>
        public TextActivity SaveTextActivity { get; set; }
        /// <summary>
        /// Create or update a forum thread
        /// </summary>
        public Thread SaveThread { get; set; }
        /// <summary>
        /// Toggle the subscription of a forum thread
        /// </summary>
        public Thread ToggleThreadSubscription { get; set; }
        /// <summary>
        /// Create or update a thread comment
        /// </summary>
        public ThreadComment SaveThreadComment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public User UpdateUser { get; set; }
        /// <summary>
        /// Toggle the un/following of a user
        /// </summary>
        public User ToggleFollow { get; set; }
        /// <summary>
        /// Update multiple media list entries to the same values
        /// </summary>
        public IEnumerable<MediaList> UpdateMediaListEntries { get; set; }
        /// <summary>
        /// Add or remove a like from a likeable type.                          Returns all the users who liked the same model
        /// </summary>
        public IEnumerable<User> ToggleLike { get; set; }
    }
}
