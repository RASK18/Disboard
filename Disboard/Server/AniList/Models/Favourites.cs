namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// User's favourite anime, manga, characters, staff and studios
    /// </summary>
    public class Favourites
    {
        /// <summary>
        /// Favourite characters
        /// </summary>
        public CharacterConnection Characters { get; set; }
        /// <summary>
        /// Favourite anime
        /// </summary>
        public MediaConnection Anime { get; set; }
        /// <summary>
        /// Favourite manga
        /// </summary>
        public MediaConnection Manga { get; set; }
        /// <summary>
        /// Favourite staff
        /// </summary>
        public StaffConnection Staff { get; set; }
        /// <summary>
        /// Favourite studios
        /// </summary>
        public StudioConnection Studios { get; set; }
    }
}
