namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Studio connection edge
    /// </summary>
    public class StudioEdge
    {
        /// <summary>
        /// The id of the connection
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// The order the character should be displayed from the users favourites
        /// </summary>
        public int? FavouriteOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Studio Node { get; set; }
        /// <summary>
        /// If the studio is the main animation studio of the anime
        /// </summary>
        public bool? IsMain { get; set; }
    }
}
