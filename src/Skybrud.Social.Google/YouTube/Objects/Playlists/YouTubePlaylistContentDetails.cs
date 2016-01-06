using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.YouTube.Objects.Playlists {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/playlists#contentDetails</cref>
    /// </see>
    public class YouTubePlaylistContentDetails : GoogleApiObject {

        #region Properties

        public int ItemCount { get; private set; }

        #endregion

        #region Constructor

        protected YouTubePlaylistContentDetails(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>YouTubePlaylistContentDetails</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static YouTubePlaylistContentDetails Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubePlaylistContentDetails(obj) {
                ItemCount = obj.GetInt32("itemCount")
            };
        }

        #endregion

    }

}