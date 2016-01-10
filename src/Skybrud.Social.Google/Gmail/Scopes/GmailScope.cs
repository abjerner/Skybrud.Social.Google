using Skybrud.Social.Google.Scopes;

namespace Skybrud.Social.Google.Gmail.Scopes {
    
    /// <summary>
    /// Class representing a scope in the Gmail API.
    /// </summary>
    public class GmailScope : GoogleScope {
        
        #region Constructors

        /// <summary>
        /// Initializes a new scope with the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        public GmailScope(string name) : base(name) { }

        /// <summary>
        /// Initializes a new scope with the specified <code>name</code> and <code>description</code>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        /// <param name="description">The description of the scope.</param>
        public GmailScope(string name, string description) : base(name, description) { }

        #endregion

    }

}