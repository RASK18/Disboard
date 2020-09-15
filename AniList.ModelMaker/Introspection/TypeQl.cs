using System.Collections.Generic;

namespace AniList.ModelMaker.Introspection
{
    /// <summary>
    /// The fundamental unit of any GraphQL Schema is the type.
    /// There are many kinds of types in GraphQL as represented by the __TypeKind enum.
    /// Depending on the kind of a type, certain fields describe information about that type.
    /// Scalar types provide no information beyond a name and description, while Enum types provide their values.
    /// Object and Interface types provide the fields they describe. Abstract types, Union and Interface,
    /// provide the Object types possible at runtime. List and NonNull types compose other types.
    /// </summary>
    public class TypeQl
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TypeKindQl Kind { get; set; }
        public TypeQl OfType { get; set; }
        public IEnumerable<FieldQl> Fields { get; set; }
        public IEnumerable<TypeQl> Interfaces { get; set; }
        public IEnumerable<TypeQl> PossibleTypes { get; set; }
        public IEnumerable<EnumValueQl> EnumValues { get; set; }
        public IEnumerable<InputValueQl> InputFields { get; set; }
    }
}
