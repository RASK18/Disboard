using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// A GraphQL Schema defines the capabilities of a GraphQL server. It exposes all available types and directives on the server, as well as the entry points for query, mutation, and subscription operations.
    /// </summary>
    public class __Schema
    {
        /// <summary>
        /// If this server supports mutation, the type that mutation operations will be rooted at.
        /// </summary>
        public __Type MutationType { get; set; }
        /// <summary>
        /// If this server support subscription, the type that subscription operations will be rooted at.
        /// </summary>
        public __Type SubscriptionType { get; set; }
        /// <summary>
        /// A list of all types supported by this server.
        /// </summary>
        public IEnumerable<__Type> Types { get; set; }
        /// <summary>
        /// The type that query operations will be rooted at.
        /// </summary>
        public __Type QueryType { get; set; }
        /// <summary>
        /// A list of all directives supported by this server.
        /// </summary>
        public IEnumerable<__Directive> Directives { get; set; }
    }
}
