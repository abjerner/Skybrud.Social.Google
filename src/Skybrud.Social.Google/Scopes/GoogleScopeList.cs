using System.Collections.Generic;
using System.Linq;
using Skybrud.Essentials.Collections;

namespace Skybrud.Social.Google.Scopes;

/// <summary>
/// Class representing a collection of scopes for the Google ecosystem.
/// </summary>
public class GoogleScopeList : List<GoogleScope> {

    #region Constructors

    /// <summary>
    /// Initializes a new collection from the specified <paramref name="scopes"/>.
    /// </summary>
    /// <param name="scopes">The scopes that should initially make up the list.</param>
    public GoogleScopeList(params GoogleScope[] scopes) {
        AddRange(scopes);
    }

    /// <summary>
    /// Initializes a new collection from the specified <paramref name="scopes"/>.
    /// </summary>
    /// <param name="scopes">The scopes that should initially make up the list.</param>
    public GoogleScopeList(IEnumerable<GoogleScope> scopes) {
        AddRange(scopes);
    }

    #endregion

    #region Member methods

    /// <summary>
    /// Gets a string representation of the entire collection. The scopes are separated by spaces as according to
    /// the Google authentication flow.
    /// </summary>
    /// <returns>A string representation of the collection.</returns>
    public override string ToString() {
        return string.Join(" ", from scope in this select scope.Alias);
    }

    /// <summary>
    /// Gets string array of the scopes in the collection.
    /// </summary>
    public string[] ToStringArray() {
        return (from scope in this select scope.Alias).ToArray();
    }

    #endregion

    #region Operator overloading

    /// <summary>
    /// Initializes a new collection based on a single <paramref name="scope"/>.
    /// </summary>
    /// <param name="scope">The scope the collection should be based on.</param>
    /// <returns>A new collection based on a single <paramref name="scope"/>.</returns>
    public static implicit operator GoogleScopeList(GoogleScope scope) {
        return new GoogleScopeList(scope);
    }

    /// <summary>
    /// Initializes a new collection based on an <paramref name="array"/> of scopes.
    /// </summary>
    /// <param name="array">The array of scopes the collection should be based on.</param>
    /// <returns>A new collection based on an <paramref name="array"/> of scopes.</returns>
    public static implicit operator GoogleScopeList(GoogleScope[]? array) {
        return new GoogleScopeList(array ?? ArrayUtils.Empty<GoogleScope>());
    }

    #endregion

}