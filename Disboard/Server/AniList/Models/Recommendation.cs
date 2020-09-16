using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Media recommendation
    /// </summary>
    public class Recommendation
    {
        /// <summary>
        /// Users rating of the recommendation
        /// </summary>
        public int? Rating { get; set; }
        /// <summary>
        /// The media the recommendation is from
        /// </summary>
        public Media Media { get; set; }
        /// <summary>
        /// The recommended media
        /// </summary>
        public Media MediaRecommendation { get; set; }
        /// <summary>
        /// The user that first created the recommendation
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// The rating of the recommendation by currently authenticated user
        /// </summary>
        public RecommendationRating? UserRating { get; set; }
        /// <summary>
        /// The id of the recommendation
        /// </summary>
        public int Id { get; set; }
    }
}
