using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.YouTube.Models.PlaylistItems {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/playlistItems#contentDetails</cref>
    /// </see>
    public class YouTubePlaylistItemContentDetails : GoogleApiObject {

        #region Properties

        public string VideoId { get; private set; }

        #endregion

        #region Constructor

        protected YouTubePlaylistItemContentDetails(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>YouTubePlaylistItemContentDetails</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static YouTubePlaylistItemContentDetails Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubePlaylistItemContentDetails(obj) {
                VideoId = obj.GetString("videoId")
            };
        }

        #endregion

    }

}