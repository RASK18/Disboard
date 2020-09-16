using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A Review that features in an anime or manga
    /// </summary>
    public class Review
    {
        /// <summary>
        /// If the review is not yet publicly published and is only viewable by creator
        /// </summary>
        public bool? Private { get; set; }
        /// <summary>
        /// The total user rating of the review
        /// </summary>
        public int? Rating { get; set; }
        /// <summary>
        /// The amount of user ratings of the review
        /// </summary>
        public int? RatingAmount { get; set; }
        /// <summary>
        /// The review score of the media
        /// </summary>
        public int? Score { get; set; }
        /// <summary>
        /// A short summary of the review
        /// </summary>
        public string Summary { get; set; }
        /// <summary>
        /// The main review body text
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The url for the review page on the AniList website
        /// </summary>
        public string SiteUrl { get; set; }
        /// <summary>
        /// The media the review is of
        /// </summary>
        public Media Media { get; set; }
        /// <summary>
        /// The creator of the review
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// For which type of media the review is for
        /// </summary>
        public MediaType? MediaType { get; set; }
        /// <summary>
        /// The rating of the review by currently authenticated user
        /// </summary>
        public ReviewRating? UserRating { get; set; }
        /// <summary>
        /// The id of the review
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The id of the review's creator
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// The id of the review's media
        /// </summary>
        public int MediaId { get; set; }
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
