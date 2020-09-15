using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Submission status
    /// </summary>
    public enum SubmissionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ACCEPTED")] Accepted,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "PARTIALLY_ACCEPTED")] PartiallyAccepted,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "PENDING")] Pending,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "REJECTED")] Rejected,
    }
}
