using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Revision history actions
    /// </summary>
    public enum RevisionHistoryAction
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "CREATE")] Create,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "EDIT")] Edit,
    }
}
