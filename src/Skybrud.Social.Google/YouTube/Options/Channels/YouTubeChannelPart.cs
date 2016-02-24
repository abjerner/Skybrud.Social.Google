using System;

namespace Skybrud.Social.Google.YouTube.Options.Channels {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/channels/list#part</cref>
    /// </see>
    public class YouTubeChannelPart {

        #region Properties
        
        /// <summary>
        /// Gets the name of the part.
        /// </summary>
        public string Name { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new part with the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        public YouTubeChannelPart(string name) {
            Name = name;
        }

        #endregion

        #region Static methods

        public static YouTubeChannelPart Parse(string str) {
            YouTubeChannelPart part;
            if (TryParse(str, out part)) return part;
            throw new Exception("Invalid part '" + str + "'");
        }

        public static bool TryParse(string str, out YouTubeChannelPart part) {
            part = Values.FirstOrDefault(temp => temp.Name == str);
            return part != null;
        }

        #endregion

        #region Operator overloading

        /// <summary>
        /// Initializes a new part with the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        public static implicit operator YouTubeChannelPart(string name) {
            return Parse(name);
        }

        /// <summary>
        /// Initializes a new collection based on <code>left</code> and <code>right</code>.
        /// </summary>
        /// <param name="left">The part to the left of the operator.</param>
        /// <param name="right">The part to the right of the operator.</param>
        public static YouTubeChannelPartsCollection operator +(YouTubeChannelPart left, YouTubeChannelPart right) {
            return new YouTubeChannelPartsCollection(left, right);
        }

        #endregion
    
    }

}