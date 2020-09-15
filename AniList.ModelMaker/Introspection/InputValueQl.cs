namespace AniList.ModelMaker.Introspection
{
    /// <summary>
    /// Arguments provided to Fields or Directives and the input fields of an InputObject are
    /// represented as Input Values which describe their type and optionally a default value.
    /// </summary>
    public class InputValueQl
    {
        public string Name { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// A GraphQL-formatted string representing the default value for this input value.
        /// </summary>
        public string DefaultValue { get; set; }
        public TypeQl Type { get; set; }
    }
}
