using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Thread comments sort enums
    /// </summary>
    public enum ThreadCommentSort
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ID")] Id,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ID_DESC")] IdDesc,
    }
}
