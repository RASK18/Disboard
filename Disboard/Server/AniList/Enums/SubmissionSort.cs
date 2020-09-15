using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Submission sort enums
    /// </summary>
    public enum SubmissionSort
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
