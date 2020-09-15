using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// The primary language of the voice actor
    /// </summary>
    public enum StaffLanguage
    {
        /// <summary>
        /// English
        /// </summary>
        [EnumMember(Value = "ENGLISH")] English,
        /// <summary>
        /// French
        /// </summary>
        [EnumMember(Value = "FRENCH")] French,
        /// <summary>
        /// German
        /// </summary>
        [EnumMember(Value = "GERMAN")] German,
        /// <summary>
        /// Hebrew
        /// </summary>
        [EnumMember(Value = "HEBREW")] Hebrew,
        /// <summary>
        /// Hungarian
        /// </summary>
        [EnumMember(Value = "HUNGARIAN")] Hungarian,
        /// <summary>
        /// Italian
        /// </summary>
        [EnumMember(Value = "ITALIAN")] Italian,
        /// <summary>
        /// Japanese
        /// </summary>
        [EnumMember(Value = "JAPANESE")] Japanese,
        /// <summary>
        /// Korean
        /// </summary>
        [EnumMember(Value = "KOREAN")] Korean,
        /// <summary>
        /// Portuguese
        /// </summary>
        [EnumMember(Value = "PORTUGUESE")] Portuguese,
        /// <summary>
        /// Spanish
        /// </summary>
        [EnumMember(Value = "SPANISH")] Spanish,
    }
}
