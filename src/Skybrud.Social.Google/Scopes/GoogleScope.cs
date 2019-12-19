using Newtonsoft.Json;

namespace Skybrud.Social.Google.Scopes {
    
    /// <summary>
    /// Class representing a scope in the Google ecosystem.
    /// </summary>
    public class GoogleScope {

        #region Properties

        /// <summary>
        /// Gets the alias of the scope.
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; }

        /// <summary>
        /// Gets the name of the scope.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the description of the scope.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new scope with the specified <paramref name="alias"/>.
        /// </summary>
        /// <param name="alias">The name of the scope.</param>
        internal GoogleScope(string alias) {
            Alias = alias;
        }
        
        /// <summary>
        /// Initializes a new scope with the specified <paramref name="alias"/>, <paramref name="title"/> and
        /// <paramref name="description"/>.
        /// </summary>
        /// <param name="alias">The name of the scope.</param>
        /// <param name="title">The title of the scope.</param>
        /// <param name="description">The description of the scope.</param>
        public GoogleScope(string alias, string title, string description) {
            Alias = alias;
            Name = title ?? alias;
            Description = description;
        }

        #endregion
        
        #region Member methods

        /// <inheritdoc />
        public override string ToString() {
            return Alias;
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