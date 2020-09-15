using System.Runtime.Serialization;

namespace Disboard.Server.AniList.Enums
{
    /// <summary>
    /// An enum describing what kind of type a given `__Type` is.
    /// </summary>
    public enum __TypeKind
    {
        /// <summary>
        /// Indicates this type is an enum. `enumValues` is a valid field.
        /// </summary>
        [EnumMember(Value = "ENUM")] Enum,
        /// <summary>
        /// Indicates this type is an input object. `inputFields` is a valid field.
        /// </summary>
        [EnumMember(Value = "INPUT_OBJECT")] InputObject,
        /// <summary>
        /// Indicates this type is an interface. `fields` and `possibleTypes` are valid fields.
        /// </summary>
        [EnumMember(Value = "INTERFACE")] Interface,
        /// <summary>
        /// Indicates this type is a list. `ofType` is a valid field.
        /// </summary>
        [EnumMember(Value = "LIST")] List,
        /// <summary>
        /// Indicates this type is a non-null. `ofType` is a valid field.
        /// </summary>
        [EnumMember(Value = "NON_NULL")] NonNull,
        /// <summary>
        /// Indicates this type is an object. `fields` and `interfaces` are valid fields.
        /// </summary>
        [EnumMember(Value = "OBJECT")] Object,
        /// <summary>
        /// Indicates this type is a scalar.
        /// </summary>
        [EnumMember(Value = "SCALAR")] Scalar,
        /// <summary>
        /// Indicates this type is a union. `possibleTypes` is a valid field.
        /// </summary>
        [EnumMember(Value = "UNION")] Union,
    }
}
