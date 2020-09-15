using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Studio sort enums
    /// </summary>
    public enum StudioSort
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
        [EnumMember(Value = "NAME")] Name,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "NAME_DESC")] NameDesc,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "SEARCH_MATCH")] SearchMatch,
    }
}
