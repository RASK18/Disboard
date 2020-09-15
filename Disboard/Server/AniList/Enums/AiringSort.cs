using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Airing schedule sort enums
    /// </summary>
    public enum AiringSort
    {
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
        [EnumMember(Value = "TIME")] Time,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "TIME_DESC")] TimeDesc,
    }
}
