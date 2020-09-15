using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Thread sort enums
    /// </summary>
    public enum ThreadSort
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "CREATED_AT")] CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "CREATED_AT_DESC")] CreatedAtDesc,
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
        [EnumMember(Value = "IS_STICKY")] IsSticky,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "REPLIED_AT")] RepliedAt,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "REPLIED_AT_DESC")] RepliedAtDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "REPLY_COUNT")] ReplyCount,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "REPLY_COUNT_DESC")] ReplyCountDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "SEARCH_MATCH")] SearchMatch,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "TITLE")] Title,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "TITLE_DESC")] TitleDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "UPDATED_AT")] UpdatedAt,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "UPDATED_AT_DESC")] UpdatedAtDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "VIEW_COUNT")] ViewCount,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "VIEW_COUNT_DESC")] ViewCountDesc,
    }
}
