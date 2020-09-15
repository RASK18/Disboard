using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Character sort enums
    /// </summary>
    public enum CharacterSort
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "FAVOURITES")] Favourites,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "FAVOURITES_DESC")] FavouritesDesc,
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
        [EnumMember(Value = "ROLE")] Role,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ROLE_DESC")] RoleDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "SEARCH_MATCH")] SearchMatch,
    }
}
