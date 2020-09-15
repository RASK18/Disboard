using System.Collections.Generic;
using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// The fundamental unit of any GraphQL Schema is the type. There are many kinds of types in GraphQL as represented by the `__TypeKind` enum.Depending on the kind of a type, certain fields describe information about that type. Scalar types provide no information beyond a name and description, while Enum types provide their values. Object and Interface types provide the fields they describe. Abstract types, Union and Interface, provide the Object types possible at runtime. List and NonNull types compose other types.
    /// </summary>
    public class __Type
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public __Type OfType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<__Field> Fields { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<__Type> Interfaces { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<__Type> PossibleTypes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<__EnumValue> EnumValues { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<__InputValue> InputFields { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public __TypeKind Kind { get; set; }
    }
}
