using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A user's statistics
    /// </summary>
    public class UserStats
    {
        /// <summary>
        /// The amount of anime the user has watched in minutes
        /// </summary>
        public int? WatchedTime { get; set; }
        /// <summary>
        /// The amount of manga chapters the user has read
        /// </summary>
        public int? ChaptersRead { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ListScoreStats AnimeListScores { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ListScoreStats MangaListScores { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<UserActivityHistory> ActivityHistory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<StatusDistribution> AnimeStatusDistribution { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<StatusDistribution> MangaStatusDistribution { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ScoreDistribution> AnimeScoreDistribution { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ScoreDistribution> MangaScoreDistribution { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<GenreStats> FavouredGenresOverview { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<GenreStats> FavouredGenres { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<TagStats> FavouredTags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<StaffStats> FavouredActors { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<StaffStats> FavouredStaff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<StudioStats> FavouredStudios { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<YearStats> FavouredYears { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<FormatStats> FavouredFormats { get; set; }
    }
}
