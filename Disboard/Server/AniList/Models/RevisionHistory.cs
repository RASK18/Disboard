using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Feed of mod edit activity
    /// </summary>
    public class RevisionHistory
    {
        /// <summary>
        /// When the mod feed entry was created
        /// </summary>
        public int? CreatedAt { get; set; }
        /// <summary>
        /// A JSON object of the fields that changed
        /// </summary>
        public string Changes { get; set; }
        /// <summary>
        /// The character the mod feed entry references
        /// </summary>
        public Character Character { get; set; }
        /// <summary>
        /// The media the mod feed entry references
        /// </summary>
        public Media Media { get; set; }
        /// <summary>
        /// The staff member the mod feed entry references
        /// </summary>
        public Staff Staff { get; set; }
        /// <summary>
        /// The studio the mod feed entry references
        /// </summary>
        public Studio Studio { get; set; }
        /// <summary>
        /// The user who made the edit to the object
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// The action taken on the objects
        /// </summary>
        public RevisionHistoryAction? Action { get; set; }
        /// <summary>
        /// The id of the media
        /// </summary>
        public int? Id { get; set; }
    }
}
