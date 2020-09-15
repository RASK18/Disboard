using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// The language the user wants to see media titles in
    /// </summary>
    public enum UserTitleLanguage
    {
        /// <summary>
        /// The official english title
        /// </summary>
        [EnumMember(Value = "ENGLISH")] English,
        /// <summary>
        /// The official english title, stylised by media creator
        /// </summary>
        [EnumMember(Value = "ENGLISH_STYLISED")] EnglishStylised,
        /// <summary>
        /// Official title in it's native language
        /// </summary>
        [EnumMember(Value = "NATIVE")] Native,
        /// <summary>
        /// Official title in it's native language, stylised by media creator
        /// </summary>
        [EnumMember(Value = "NATIVE_STYLISED")] NativeStylised,
        /// <summary>
        /// The romanization of the native language title
        /// </summary>
        [EnumMember(Value = "ROMAJI")] Romaji,
        /// <summary>
        /// The romanization of the native language title, stylised by media creator
        /// </summary>
        [EnumMember(Value = "ROMAJI_STYLISED")] RomajiStylised,
    }
}
