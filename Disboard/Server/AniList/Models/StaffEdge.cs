namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Staff connection edge
    /// </summary>
    public class StaffEdge
    {
        /// <summary>
        /// The id of the connection
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// The order the staff should be displayed from the users favourites
        /// </summary>
        public int? FavouriteOrder { get; set; }
        /// <summary>
        /// The role of the staff member in the production of the media
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Staff Node { get; set; }
    }
}
