using Newtonsoft.Json;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Deleted data type
    /// </summary>
    public class Deleted
    {
        /// <summary>
        /// If an item has been successfully deleted
        /// </summary>
        [JsonProperty("deleted")]
        public bool? Deleted2 { get; set; }
    }
}
