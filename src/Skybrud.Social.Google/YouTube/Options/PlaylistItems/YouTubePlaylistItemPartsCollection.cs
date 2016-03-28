using System;
using System.Collections.Generic;
using System.Linq;

namespace Skybrud.Social.Google.YouTube.Options.PlaylistItems {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/playlistItems/list#part</cref>
    /// </see>
    public class YouTubePlaylistItemPartsCollection {

        #region Private fields

        private readonly List<YouTubePlaylistItemPart> _list = new List<YouTubePlaylistItemPart>();

        #endregion

        #region Properties

        /// <summary>
        /// Gets the amount of parts currently in the collection.
        /// </summary>
        public int Count {
            get { return _list.Count; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an empty collection.
        /// </summary>
        public YouTubePlaylistItemPartsCollection() { }

        /// <summary>
        /// Initializes a collection containing the specified parts.
        /// </summary>
        /// <param name="parts">The parts to add.</param>
        public YouTubePlaylistItemPartsCollection(params YouTubePlaylistItemPart[] parts) {
            _list.AddRange(parts);
        }

        /// <summary>
        /// Initializes a collection containing the specified parts.
        /// </summary>
        /// <param name="parts">The parts to add.</param>
        public YouTubePlaylistItemPartsCollection(IEnumerable<YouTubePlaylistItemPart> parts) {
            _list.AddRange(parts);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds the specified part to the collection.
        /// </summary>
        /// <param name="part">The part to add.</param>
        public void Add(YouTubePlaylistItemPart part) {
            _list.Add(part);
        }

        /// <summary>
        /// Adds the specified range of parts to the collection.
        /// </summary>
        /// <param name="parts">The dimensions to add.</param>
        public void AddRange(IEnumerable<YouTubePlaylistItemPart> parts) {
            _list.AddRange(parts);
        }

        /// <summary>
        /// Gets an array of the parts currently in the collection.
        /// </summary>
        public YouTubePlaylistItemPart[] ToArray() {
            return _list.ToArray();
        }

        /// <summary>
        /// Gets a string array of the parts currently in the collection.
        /// </summary>
        public string[] ToStringArray() {
            return (from part in _list select part.Name).ToArray();
        }

        /// <summary>
        /// Gets a string representation if the parts currently in the collection.
        /// </summary>
        public override string ToString() {
            return String.Join(",", from part in _list select part.Name);
        }

        #endregion

        #region Operator overloading

        /// <summary>
        /// Initializes a new collection from the specified <code>part</code>.
        /// </summary>
        /// <param name="part">The instance of <see cref="YouTubePlaylistItemPart"/> representing the part.</param>
        /// <returns>Returns an instance of <see cref="YouTubePlaylistItemPartsCollection"/>.</returns>
        public static implicit operator YouTubePlaylistItemPartsCollection(YouTubePlaylistItemPart part) {
            return new YouTubePlaylistItemPartsCollection(part);
        }

        /// <summary>
        /// Initializes a new collection from the specified <code>array</code> of <see cref="YouTubePlaylistItemPart"/>.
        /// </summary>
        /// <param name="parts">An array of <see cref="YouTubePlaylistItemPart"/> representing the parts.</param>
        /// <returns>Returns an instance of <see cref="YouTubePlaylistItemPartsCollection"/>.</returns>
        public static implicit operator YouTubePlaylistItemPartsCollection(YouTubePlaylistItemPart[] parts) {
            return new YouTubePlaylistItemPartsCollection(parts);
        }

        /// <summary>
        /// Adds the specified <code>part</code> to <code>collection</code>.
        /// </summary>
        /// <param name="collection">The collection to which the part should be added.</param>
        /// <param name="part">The part to be added to the collection.</param>
        /// <returns>Returns an instance of <see cref="YouTubePlaylistItemPartsCollection"/>.</returns>
        public static YouTubePlaylistItemPartsCollection operator +(YouTubePlaylistItemPartsCollection collection, YouTubePlaylistItemPart part) {
            collection.Add(part);
            return collection;
        }

        /// <summary>
        /// Initializes a new collection from the specified string array of <code>parts</code>.
        /// </summary>
        /// <param name="parts">A string array of the parts that should make up the collection.</param>
        /// <returns>Returns an instance of <see cref="YouTubePlaylistItemPartsCollection"/>.</returns>
        public static implicit operator YouTubePlaylistItemPartsCollection(string[] parts) {
            return new YouTubePlaylistItemPartsCollection(from YouTubePlaylistItemPart part in parts select part);
        }

        #endregion

    }

}