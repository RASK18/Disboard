using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Media list scoring type
    /// </summary>
    public enum ScoreFormat
    {
        /// <summary>
        /// An integer from 0-10
        /// </summary>
        [EnumMember(Value = "POINT_10")] Point10,
        /// <summary>
        /// A float from 0-10 with 1 decimal place
        /// </summary>
        [EnumMember(Value = "POINT_10_DECIMAL")] Point10Decimal,
        /// <summary>
        /// An integer from 0-100
        /// </summary>
        [EnumMember(Value = "POINT_100")] Point100,
        /// <summary>
        /// An integer from 0-3. Should be represented in Smileys. 0 => No Score, 1 => :(, 2 => :|, 3 => :)
        /// </summary>
        [EnumMember(Value = "POINT_3")] Point3,
        /// <summary>
        /// An integer from 0-5. Should be represented in Stars
        /// </summary>
        [EnumMember(Value = "POINT_5")] Point5,
    }
}
