using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.YouTube.Objects.Channels {

    /// <summary>
    /// Class representing the <code>snippet.localized</code> property of a YouTubeChannel, which contains a localized
    /// title and description for the channel or it contains the channel's title and description in the default
    /// language for the channel's metadata.
    /// </summary>
    public class YouTubeChannelLocalized : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the localized title.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the localized description.
        /// </summary>
        public string Description { get; private set; }

        #endregion

        #region Constructors

        private YouTubeChannelLocalized(JObject obj) : base(obj) {
            Title = obj.GetString("title");
            Description = obj.GetString("description");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="YouTubeChannelLocalized"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns the instance of <see cref="YouTubeChannelLocalized"/>.</returns>
        public static YouTubeChannelLocalized Parse(JObject obj) {
            return obj == null ? null : new YouTubeChannelLocalized(obj);
        }

        #endregion

    }

}