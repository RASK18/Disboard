namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// AiringSchedule connection edge
    /// </summary>
    public class AiringScheduleEdge
    {
        /// <summary>
        /// The id of the connection
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public AiringSchedule Node { get; set; }
    }
}
