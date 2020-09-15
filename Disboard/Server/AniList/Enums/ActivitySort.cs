using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Activity sort enums
    /// </summary>
    public enum ActivitySort
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
