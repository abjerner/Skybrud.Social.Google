using Skybrud.Social.Google.Scopes;

namespace Skybrud.Social.Google.Drive.Scopes {
    
    /// <summary>
    /// Class representing a scope in the Google Drive API.
    /// </summary>
    public class DriveScope : GoogleScope {
        
        #region Constructors

        /// <summary>
        /// Initializes a new scope with the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        public DriveScope(string name) : base(name) { }

        /// <summary>
        /// Initializes a new scope with the specified <code>name</code> and <code>description</code>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        /// <param name="description">The description of the scope.</param>
        public DriveScope(string name, string description) : base(name, description) { }

        #endregion

    }

}