using System;
using System.Collections.Generic;
using System.Linq;

namespace Skybrud.Social.Google.Scopes {

    /// <summary>
    /// Class representing a collection of scopes for the Google ecosystem.
    /// </summary>
    public class GoogleScopeCollection {

        #region Private fields

        private readonly List<GoogleScope> _list = new List<GoogleScope>();

        #endregion

        #region Properties

        /// <summary>
        /// Gets an array of all scopes in the collection.
        /// </summary>
        public GoogleScope[] Items {
            get { return _list.ToArray(); }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new collection from the specified <code>scopes</code>.
        /// </summary>
        /// <param name="scopes"></param>
        public GoogleScopeCollection(params GoogleScope[] scopes) {
            _list.AddRange(scopes);
        }

        #endregion

        #region Member methods
        
        /// <summary>
        /// Adds the specified <paramref name="scope"/> to the collection.
        /// </summary>
        /// <param name="scope">The scope to be added.</param>
        public void Add(GoogleScope scope) {
            _list.Add(scope);
        }

        /// <summary>
        /// Removes the specified <paramref name="scope"/> from the collection.
        /// </summary>
        /// <param name="scope">The scope to be removed.</param>
        public void Remove(GoogleScope scope) {
            _list.Remove(scope);
        }

        /// <summary>
        /// Gets whether the specified <paramref name="scope"/> has been added to the collection.
        /// </summary>
        /// <param name="scope">The scope.</param>
        /// <returns>Returns <code>true</code> if <paramref name="scope"/> has been added to the collection, otherwise
        /// <code>false</code>.</returns>
        public bool Contains(GoogleScope scope) {
            return _list.Contains(scope);
        }

        /// <summary>
        /// Gets an array of all scopes in the collection.
        /// </summary>
        /// <returns>An array <see cref="GoogleScope"/>.</returns>
        public GoogleScope[] ToArray() {
            return _list.ToArray();
        }

        /// <summary>
        /// Gets string array of the scopes in the collection.
        /// </summary>
        public string[] ToStringArray() {
            return (from scope in _list select scope.Alias).ToArray();
        }

        /// <summary>
        /// Gets a string representation of the entire collection. The scopes are separated by spaces as according to
        /// the Google authentication flow.
        /// </summary>
        /// <returns>A string representation of the collection.</returns>
        public override string ToString() {
            return String.Join(" ", from scope in _list select scope.Alias);
        }

        #endregion

        #region Operator overloading
        
        /// <summary>
        /// Initializes a new collection based on a single <paramref name="scope"/>.
        /// </summary>
        /// <param name="scope">The scope the collection should be based on.</param>
        /// <returns>A new collection based on a single <paramref name="scope"/>.</returns>
        public static implicit operator GoogleScopeCollection(GoogleScope scope) {
            return new GoogleScopeCollection(scope);
        }

        /// <summary>
        /// Initializes a new collection based on an <paramref name="array"/> of scopes.
        /// </summary>
        /// <param name="array">The array of scopes the collection should be based on.</param>
        /// <returns>A new collection based on an <paramref name="array"/> of scopes.</returns>
        public static implicit operator GoogleScopeCollection(GoogleScope[] array) {
            return new GoogleScopeCollection(array ?? new GoogleScope[0]);
        }

        #endregion

    }

}