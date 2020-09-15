using System.Collections.Generic;

namespace Disboard.Server.AniList.Models
{
    /// <summary>
    /// Object and Interface types are described by a list of Fields, each of which has a name, potentially a list of arguments, and a return type.
    /// </summary>
    public class __Field
    {
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeprecationReason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<__InputValue> Args { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public __Type Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsDeprecated { get; set; }
    }
}
