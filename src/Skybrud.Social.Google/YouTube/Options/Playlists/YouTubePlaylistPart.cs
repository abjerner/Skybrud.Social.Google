using System.Linq;
using Skybrud.Social.Google.YouTube.Exceptions;
using Skybrud.Social.Google.YouTube.Options.Common;

namespace Skybrud.Social.Google.YouTube.Options.Playlists {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/playlists/list#part</cref>
    /// </see>
    public class YouTubePlaylistPart : YouTubePart {

        #region Constructors

        /// <summary>
        /// Initializes a new part with the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        public YouTubePlaylistPart(string name) : base(name) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>str</code> into an instance of <see cref="YouTubePlaylistPart"/>.
        /// </summary>
        /// <param name="str">The string with the name of the part.</param>
        /// <returns>Returns an instance of <see cref="YouTubePlaylistPart"/> representing the part.</returns>
        public static YouTubePlaylistPart Parse(string str) {
            YouTubePlaylistPart part;
            if (TryParse(str, out part)) return part;
            throw new YouTubeUnknownPartException(str);
        }

        /// <summary>
        /// Attempts to parse the specified <code>str</code> into an instance of <see cref="YouTubePlaylistPart"/>.
        /// </summary>
        /// <param name="str">The string with the name of the part.</param>
        /// <param name="part">The parsed part.</param>
        /// <returns>Returns <code>true</code> if <code>str</code> matches a known part, otherwise <code>false</code>.</returns>
        public static bool TryParse(string str, out YouTubePlaylistPart part) {
            part = YouTubePlaylistParts.Values.FirstOrDefault(temp => temp.Name == str);
            return part != null;
        }

        #endregion

        #region Operator overloading

        /// <summary>
        /// Initializes a new part with the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        public static implicit operator YouTubePlaylistPart(string name) {
            return Parse(name);
        }

        /// <summary>
        /// Initializes a new collection based on <code>left</code> and <code>right</code>.
        /// </summary>
        /// <param name="left">The part to the left of the operator.</param>
        /// <param name="right">The part to the right of the operator.</param>
        public static YouTubePlaylistPartsCollection operator +(YouTubePlaylistPart left, YouTubePlaylistPart right) {
            return new YouTubePlaylistPartsCollection(left, right);
        }

        #endregion

    }

}