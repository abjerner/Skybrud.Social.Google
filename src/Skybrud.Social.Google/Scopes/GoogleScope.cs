namespace Skybrud.Social.Google.Scopes {
    
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
        /// Gets the title of the scope.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the description of the scope.
        /// </summary>
        public string Description { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new scope with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        internal GoogleScope(string name) {
            Name = name;
        }
        
        /// <summary>
        /// Initializes a new scope with the specified <paramref name="name"/>, <paramref name="title"/> and
        /// <paramref name="description"/>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        /// <param name="title">The title of the scope.</param>
        /// <param name="description">The description of the scope.</param>
        public GoogleScope(string name, string title, string description) {
            Name = name;
            Title = title ?? name;
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
        /// Adds two instances of <see cref="GoogleScope"/>, resulting in an instance
        /// <see cref="GoogleScopeCollection"/> containing both scopes.
        /// </summary>
        /// <param name="left">The left scope.</param>
        /// <param name="right">The right scope.</param>
        /// <returns>An instance of <see cref="GoogleScopeCollection"/> containing both scopes.</returns>
        public static GoogleScopeCollection operator +(GoogleScope left, GoogleScope right) {
            return new GoogleScopeCollection(left, right);
        }

        #endregion

    }

}