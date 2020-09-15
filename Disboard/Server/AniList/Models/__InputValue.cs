namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Arguments provided to Fields or Directives and the input fields of an InputObject are represented as Input Values which describe their type and optionally a default value.
    /// </summary>
    public class __InputValue
    {
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// A GraphQL-formatted string representing the default value for this input value.
        /// </summary>
        public string DefaultValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public __Type Type { get; set; }
    }
}
