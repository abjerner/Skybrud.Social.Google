namespace Skybrud.Social.Google.Common.Scopes {
    
    /// <summary>
    /// Class representing a scope in the Google ecosystem.
    /// </summary>
    public class GoogleScope {
        
        #region Properties

        /// <summary>
        /// Gets the name of the scope.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the description of the scope.
        /// </summary>
        public string Description { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new scope with the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        public GoogleScope(string name) {
            Name = name;
        }

        /// <summary>
        /// Initializes a new scope with the specified <code>name</code> and <code>description</code>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        /// <param name="description">The description of the scope.</param>
        public GoogleScope(string name, string description) {
            Name = name;
            Description = description;
        }

        #endregion
        
        #region Member methods

        public override string ToString() {
            return Name;
        }

        #endregion
        
        #region Operators

        /// <summary>
        /// Adding two instance of <code>GoogleScope</code> will result in a <code>GoogleScopeCollection</code>
        /// containing both scopes.
        /// </summary>
        /// <param name="left">The left scope.</param>
        /// <param name="right">The right scope.</param>
        public static GoogleScopeCollection operator +(GoogleScope left, GoogleScope right) {
            return new GoogleScopeCollection(left, right);
        }

        #endregion

    }

}