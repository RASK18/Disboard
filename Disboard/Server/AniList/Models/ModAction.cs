using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ModAction
    {
        /// <summary>
        /// 
        /// </summary>
        public int? ObjectId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ObjectType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public User Mod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ModActionType? Type { get; set; }
        /// <summary>
        /// The id of the action
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CreatedAt { get; set; }
    }
}
