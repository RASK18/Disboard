using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class UserStatistics
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<UserFormatStatistic> Formats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<UserStatusStatistic> Statuses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<UserScoreStatistic> Scores { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<UserLengthStatistic> Lengths { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<UserReleaseYearStatistic> ReleaseYears { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<UserStartYearStatistic> StartYears { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<UserGenreStatistic> Genres { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<UserTagStatistic> Tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<UserCountryStatistic> Countries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<UserVoiceActorStatistic> VoiceActors { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<UserStaffStatistic> Staff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<UserStudioStatistic> Studios { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float? MeanScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float? StandardDeviation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? MinutesWatched { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? EpisodesWatched { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? ChaptersRead { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? VolumesRead { get; set; }
    }
}
