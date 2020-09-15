using System.Collections.Generic;

namespace AniList.ModelMaker.Introspection
{
    /// <summary>
    /// A GraphQL Schema defines the capabilities of a GraphQL server.
    /// It exposes all available types and directives on the server,
    /// as well as the entry points for query, mutation, and subscription operations.
    /// </summary>
    public class SchemaQl
    {
        /// <summary>
        /// The type that query operations will be rooted at.
        /// </summary>
        public TypeQl QueryType { get; set; }
        /// <summary>
        /// If this server supports mutation, the type that mutation operations will be rooted at.
        /// </summary>
        public TypeQl MutationType { get; set; }
        /// <summary>
        /// If this server support subscription, the type that subscription operations will be rooted at.
        /// </summary>
        public TypeQl SubscriptionType { get; set; }
        /// <summary>
        /// A list of all types supported by this server.
        /// </summary>
        public IEnumerable<TypeQl> Types { get; set; }
        /// <summary>
        /// A list of all directives supported by this server.
        /// </summary>
        public IEnumerable<DirectiveQl> Directives { get; set; }
    }
}
