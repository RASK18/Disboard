using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Media trend sort enums
    /// </summary>
    public enum MediaTrendSort
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "DATE")] Date,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "DATE_DESC")] DateDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "EPISODE")] Episode,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "EPISODE_DESC")] EpisodeDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ID")] Id,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ID_DESC")] IdDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "MEDIA_ID")] MediaId,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "MEDIA_ID_DESC")] MediaIdDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "POPULARITY")] Popularity,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "POPULARITY_DESC")] PopularityDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "SCORE")] Score,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "SCORE_DESC")] ScoreDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "TRENDING")] Trending,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "TRENDING_DESC")] TrendingDesc,
    }
}
