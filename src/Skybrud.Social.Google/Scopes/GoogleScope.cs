using Newtonsoft.Json;

namespace Skybrud.Social.Google.Scopes;

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
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; }

    #endregion

    #region Constructor

    /// <summary>
    /// Initializes a new scope with the specified <paramref name="alias"/>.
    /// </summary>
    /// <param name="alias">The name of the scope.</param>
    internal GoogleScope(string alias) {
        Alias = alias;
        Name = alias;
    }

    /// <summary>
    /// Initializes a new scope with the specified <paramref name="alias"/>, <paramref name="name"/> and
    /// <paramref name="description"/>.
    /// </summary>
    /// <param name="alias">The name of the scope.</param>
    /// <param name="name">The title of the scope.</param>
    /// <param name="description">The description of the scope.</param>
    public GoogleScope(string alias, string? name, string description) {
        Alias = alias;
        Name = name ?? alias;
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
    /// <see cref="GoogleScopeList"/> containing both scopes.
    /// </summary>
    /// <param name="left">The left scope.</param>
    /// <param name="right">The right scope.</param>
    /// <returns>An instance of <see cref="GoogleScopeList"/> containing both scopes.</returns>
    public static GoogleScopeList operator +(GoogleScope left, GoogleScope right) {
        return new GoogleScopeList(left, right);
    }

    #endregion

}