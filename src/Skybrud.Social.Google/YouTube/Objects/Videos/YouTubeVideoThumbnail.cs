using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.YouTube.Objects.Videos {

    /// <summary>
    /// Class with information about a thumbnail of a YouTube video.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/videos#snippet.thumbnails</cref>
    /// </see>
    public class YouTubeVideoThumbnail : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the URL of the thumbnail image.
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// Gets the width of the thumbnail image.
        /// </summary>
        public int Width { get; private set; }

        /// <summary>
        /// Gets the height of the thumbnail image.
        /// </summary>
        public int Height { get; private set; }

        #endregion

        #region Constructors

        protected YouTubeVideoThumbnail(JObject obj) : base(obj) {
            Url = obj.GetString("url");
            Width = obj.GetInt32("width");
            Height = obj.GetInt32("height");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="YouTubeVideoThumbnail"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="YouTubeVideoThumbnail"/>.</returns>
        public static YouTubeVideoThumbnail Parse(JObject obj) {
            return obj == null ? null : new YouTubeVideoThumbnail(obj);
        }

        #endregion

    }

}