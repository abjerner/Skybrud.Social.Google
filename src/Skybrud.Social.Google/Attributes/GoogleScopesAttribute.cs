using System;

namespace Skybrud.Social.Google.Attributes {

    /// <summary>
    /// Attribute used for identifying static classes with scopes and declaring groups of scopes.
    /// </summary>
    public class GoogleScopesAttribute : Attribute {

        /// <summary>
        /// Gets the name of the group the scopes should belong to.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the weight of the group the scopes should be added to. Default weight is <c>10</c>.
        ///
        /// Groups with the same weight will be sorted alphabetically.
        /// </summary>
        public int Weight { get; }

        /// <summary>
        /// Initializes a new attribute with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the group the scopes should belong to.</param>
        public GoogleScopesAttribute(string name) : this(name, 10) {
            Name = name;
        }

        /// <summary>
        /// Initializes a new attribute with the specified <paramref name="name"/> and <paramref name="weight"/>.
        /// </summary>
        /// <param name="name">The name of the group the scopes should belong to.</param>
        /// <param name="weight">The weight of the group the scopes should be added to.</param>
        public GoogleScopesAttribute(string name, int weight) {
            Name = name;
            Weight = weight;
        }

    }

}