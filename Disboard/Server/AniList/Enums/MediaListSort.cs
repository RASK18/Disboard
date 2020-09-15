using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Media list sort enums
    /// </summary>
    public enum MediaListSort
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ADDED_TIME")] AddedTime,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ADDED_TIME_DESC")] AddedTimeDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "FINISHED_ON")] FinishedOn,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "FINISHED_ON_DESC")] FinishedOnDesc,
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
        [EnumMember(Value = "MEDIA_POPULARITY")] MediaPopularity,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "MEDIA_POPULARITY_DESC")] MediaPopularityDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "MEDIA_TITLE_ENGLISH")] MediaTitleEnglish,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "MEDIA_TITLE_ENGLISH_DESC")] MediaTitleEnglishDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "MEDIA_TITLE_NATIVE")] MediaTitleNative,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "MEDIA_TITLE_NATIVE_DESC")] MediaTitleNativeDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "MEDIA_TITLE_ROMAJI")] MediaTitleRomaji,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "MEDIA_TITLE_ROMAJI_DESC")] MediaTitleRomajiDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "PRIORITY")] Priority,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "PRIORITY_DESC")] PriorityDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "PROGRESS")] Progress,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "PROGRESS_DESC")] ProgressDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "PROGRESS_VOLUMES")] ProgressVolumes,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "PROGRESS_VOLUMES_DESC")] ProgressVolumesDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "REPEAT")] Repeat,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "REPEAT_DESC")] RepeatDesc,
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
        [EnumMember(Value = "STARTED_ON")] StartedOn,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "STARTED_ON_DESC")] StartedOnDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "STATUS")] Status,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "STATUS_DESC")] StatusDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "UPDATED_TIME")] UpdatedTime,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "UPDATED_TIME_DESC")] UpdatedTimeDesc,
    }
}
