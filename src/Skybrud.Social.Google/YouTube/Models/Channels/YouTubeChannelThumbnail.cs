using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.YouTube.Models.Channels {

    /// <summary>
    /// Class representing a thumbnail image of a YouTube channel.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/channels#snippet.thumbnails</cref>
    /// </see>
    public class YouTubeChannelThumbnail : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the URL of the thumbnail image.
        /// </summary>
        public string Url { get; private set; }

        // The YouTube API reference specifies "width" and "height" properties as well, but I haven't yet found
        // examples where they are actually specified, so I'll skip implementing them for now

        #endregion

        #region Constructors

        private YouTubeChannelThumbnail(JObject obj) : base(obj) {
            Url = obj.GetString("url");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="YouTubeChannelThumbnail"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns the instance of <see cref="YouTubeChannelThumbnail"/>.</returns>
        public static YouTubeChannelThumbnail Parse(JObject obj) {
            return obj == null ? null : new YouTubeChannelThumbnail(obj);
        }

        #endregion

    }

}