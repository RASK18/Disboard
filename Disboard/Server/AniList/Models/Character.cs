namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A character that features in an anime or manga
    /// </summary>
    public class Character
    {
        /// <summary>
        /// The amount of user's who have favourited the character
        /// </summary>
        public int? Favourites { get; set; }
        /// <summary>
        /// A general description of the character
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The url for the character page on the AniList website
        /// </summary>
        public string SiteUrl { get; set; }
        /// <summary>
        /// Notes for site moderators
        /// </summary>
        public string ModNotes { get; set; }
        /// <summary>
        /// Character images
        /// </summary>
        public CharacterImage Image { get; set; }
        /// <summary>
        /// The names of the character
        /// </summary>
        public CharacterName Name { get; set; }
        /// <summary>
        /// Media that includes the character
        /// </summary>
        public MediaConnection Media { get; set; }
        /// <summary>
        /// The id of the character
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// If the character is marked as favourite by the currently authenticated user
        /// </summary>
        public bool? IsFavourite { get; set; }
    }
}
