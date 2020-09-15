using System.Collections.Generic;
using Disboard.Server.AniList.Enums;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A Directive provides a way to describe alternate runtime execution and type validation behavior in a GraphQL document.In some cases, you need to provide options to alter GraphQL's execution behavior in ways field arguments will not suffice, such as conditionally including or skipping a field. Directives provide this by describing additional information to the executor.
    /// </summary>
    public class __Directive
    {
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<__DirectiveLocation> Locations { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<__InputValue> Args { get; set; }
    }
}
