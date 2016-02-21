using Skybrud.Social.Google.Common.Scopes;

namespace Skybrud.Social.Google.Gmail.Scopes {
    
    /// <summary>
    /// Class representing a scope in the Gmail API.
    /// </summary>
    public class GmailScope : GoogleScope {
        
        #region Constructors
        
        /// <summary>
        /// Initializes a new scope with the specified <code>name</code>, <code>title</code> and <code>description</code>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        /// <param name="title">The title of the scope.</param>
        /// <param name="description">The description of the scope.</param>
        public GmailScope(string name, string title, string description) : base(name, title, description) { }

        #endregion

    }

}