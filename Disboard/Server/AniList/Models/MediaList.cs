using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// List of anime or manga
    /// </summary>
    public class MediaList
    {
        /// <summary>
        /// If the entry should only be visible to authenticated user
        /// </summary>
        public bool? Private { get; set; }
        /// <summary>
        /// If the entry shown be hidden from non-custom lists
        /// </summary>
        public bool? HiddenFromStatusLists { get; set; }
        /// <summary>
        /// The score of the entry
        /// </summary>
        public float? Score { get; set; }
        /// <summary>
        /// The amount of episodes/chapters consumed by the user
        /// </summary>
        public int? Progress { get; set; }
        /// <summary>
        /// The amount of volumes read by the user
        /// </summary>
        public int? ProgressVolumes { get; set; }
        /// <summary>
        /// The amount of times the user has rewatched/read the media
        /// </summary>
        public int? Repeat { get; set; }
        /// <summary>
        /// Priority of planning
        /// </summary>
        public int? Priority { get; set; }
        /// <summary>
        /// When the entry data was last updated
        /// </summary>
        public int? UpdatedAt { get; set; }
        /// <summary>
        /// When the entry data was created
        /// </summary>
        public int? CreatedAt { get; set; }
        /// <summary>
        /// Map of booleans for which custom lists the entry are in
        /// </summary>
        public string CustomLists { get; set; }
        /// <summary>
        /// Map of advanced scores with name keys
        /// </summary>
        public string AdvancedScores { get; set; }
        /// <summary>
        /// Text notes
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// When the entry was started by the user
        /// </summary>
        public FuzzyDate StartedAt { get; set; }
        /// <summary>
        /// When the entry was completed by the user
        /// </summary>
        public FuzzyDate CompletedAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Media Media { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// The watching/reading status
        /// </summary>
        public MediaListStatus? Status { get; set; }
        /// <summary>
        /// The id of the list entry
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The id of the user owner of the list entry
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// The id of the media
        /// </summary>
        public int MediaId { get; set; }
    }
}
