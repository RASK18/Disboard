namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Score and Watcher stats for airing anime by episode and mid-week
    /// </summary>
    public class AiringProgression
    {
        /// <summary>
        /// The episode the stats were recorded at. .5 is the mid point between 2 episodes airing dates.
        /// </summary>
        public float? Episode { get; set; }
        /// <summary>
        /// The average score for the media
        /// </summary>
        public float? Score { get; set; }
        /// <summary>
        /// The amount of users watching the anime
        /// </summary>
        public int? Watching { get; set; }
    }
}
