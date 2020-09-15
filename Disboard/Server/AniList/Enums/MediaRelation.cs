using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// Type of relation media has to its parent.
    /// </summary>
    public enum MediaRelation
    {
        /// <summary>
        /// An adaption of this media into a different format
        /// </summary>
        [EnumMember(Value = "ADAPTATION")] Adaptation,
        /// <summary>
        /// An alternative version of the same media
        /// </summary>
        [EnumMember(Value = "ALTERNATIVE")] Alternative,
        /// <summary>
        /// Shares at least 1 character
        /// </summary>
        [EnumMember(Value = "CHARACTER")] Character,
        /// <summary>
        /// Version 2 only.
        /// </summary>
        [EnumMember(Value = "COMPILATION")] Compilation,
        /// <summary>
        /// Version 2 only.
        /// </summary>
        [EnumMember(Value = "CONTAINS")] Contains,
        /// <summary>
        /// Other
        /// </summary>
        [EnumMember(Value = "OTHER")] Other,
        /// <summary>
        /// The media a side story is from
        /// </summary>
        [EnumMember(Value = "PARENT")] Parent,
        /// <summary>
        /// Released before the relation
        /// </summary>
        [EnumMember(Value = "PREQUEL")] Prequel,
        /// <summary>
        /// Released after the relation
        /// </summary>
        [EnumMember(Value = "SEQUEL")] Sequel,
        /// <summary>
        /// A side story of the parent media
        /// </summary>
        [EnumMember(Value = "SIDE_STORY")] SideStory,
        /// <summary>
        /// Version 2 only. The source material the media was adapted from
        /// </summary>
        [EnumMember(Value = "SOURCE")] Source,
        /// <summary>
        /// An alternative version of the media with a different primary focus
        /// </summary>
        [EnumMember(Value = "SPIN_OFF")] SpinOff,
        /// <summary>
        /// A shortened and summarized version
        /// </summary>
        [EnumMember(Value = "SUMMARY")] Summary,
    }
}
