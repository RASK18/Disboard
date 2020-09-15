using System.Collections.Generic;

namespace AniList.ModelMaker.Introspection
{
    /// <summary>
    /// Object and Interface types are described by a list of Fields,
    /// each of which has a name, potentially a list of arguments, and a return type.
    /// </summary>
    public class FieldQl
    {
        public bool IsDeprecated { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DeprecationReason { get; set; }
        public TypeQl Type { get; set; }
        public IEnumerable<InputValueQl> Args { get; set; }

    }
}
