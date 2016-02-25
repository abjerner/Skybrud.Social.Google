using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.YouTube.Objects.Channels {

    /// <summary>
    /// Class representing a collection of thumbnail images for the channel.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/channels#snippet.thumbnails</cref>
    /// </see>
    public class YouTubeChannelThumbnails : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets a reference to the default thumbnail of the channel. The default thumbnail for a channel is
        /// <code>88px</code> wide and <code>88px</code> tall.
        /// </summary>
        public YouTubeChannelThumbnail Default { get; private set; }

        /// <summary>
        /// Gets a reference to a higher resolution version of the thumbnail image. For a channel, this image is
        /// <code>240px</code> wide and <code>240px</code> tall.
        /// </summary>
        public YouTubeChannelThumbnail Medium { get; private set; }

        /// <summary>
        /// Gets a reference to a high resolution version of the thumbnail image. For a channel, this image is
        /// <code>800px</code> wide and <code>800px</code> tall.
        /// </summary>
        public YouTubeChannelThumbnail High { get; private set; }

        #endregion

        #region Constructors

        private YouTubeChannelThumbnails(JObject obj) : base(obj) {
            Default = obj.GetObject("default", YouTubeChannelThumbnail.Parse);
            Medium = obj.GetObject("medium", YouTubeChannelThumbnail.Parse);
            High = obj.GetObject("high", YouTubeChannelThumbnail.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="YouTubeChannelThumbnails"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns the instance of <see cref="YouTubeChannelThumbnails"/>.</returns>
        public static YouTubeChannelThumbnails Parse(JObject obj) {
            return obj == null ? null : new YouTubeChannelThumbnails(obj);
        }

        #endregion

    }

}