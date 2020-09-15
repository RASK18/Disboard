using AniList.ModelMaker.Introspection.Enums;
using System.Collections.Generic;

namespace AniList.ModelMaker.Introspection
{
    /// <summary>
    /// A Directive provides a way to describe alternate runtime execution and type validation behavior in a GraphQL document.
    /// In some cases, you need to provide options to alter GraphQL execution behavior in ways field arguments will not suffice,
    /// such as conditionally including or skipping a field. Directives provide this by describing additional information to the executor.
    /// </summary>
    public class DirectiveQl
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<DirectiveLocationQl> Locations { get; set; }
        public IEnumerable<InputValueQl> Args { get; set; }
    }
}
