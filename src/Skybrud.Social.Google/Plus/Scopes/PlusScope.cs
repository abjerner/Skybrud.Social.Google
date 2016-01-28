using Skybrud.Social.Google.Common.Scopes;

namespace Skybrud.Social.Google.Plus.Scopes {
    
    /// <summary>
    /// Class representing a scope in the Google+ API.
    /// </summary>
    public class PlusScope : GoogleScope {
        
        #region Constructors

        /// <summary>
        /// Initializes a new scope with the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        public PlusScope(string name) : base(name) { }

        /// <summary>
        /// Initializes a new scope with the specified <code>name</code> and <code>description</code>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        /// <param name="description">The description of the scope.</param>
        public PlusScope(string name, string description) : base(name, description) { }

        #endregion

    }

}