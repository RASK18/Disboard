namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Animation or production company
    /// </summary>
    public class Studio
    {
        /// <summary>
        /// The amount of user's who have favourited the studio
        /// </summary>
        public int? Favourites { get; set; }
        /// <summary>
        /// The url for the studio page on the AniList website
        /// </summary>
        public string SiteUrl { get; set; }
        /// <summary>
        /// The media the studio has worked on
        /// </summary>
        public MediaConnection Media { get; set; }
        /// <summary>
        /// The id of the studio
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the studio
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// If the studio is an animation studio or a different kind of company
        /// </summary>
        public bool IsAnimationStudio { get; set; }
        /// <summary>
        /// If the studio is marked as favourite by the currently authenticated user
        /// </summary>
        public bool IsFavourite { get; set; }
    }
}
