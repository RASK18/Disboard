using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModActionType
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ANON")] Anon,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "BAN")] Ban,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "DELETE")] Delete,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "EDIT")] Edit,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "EXPIRE")] Expire,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "NOTE")] Note,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "REPORT")] Report,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "RESET")] Reset,
    }
}
