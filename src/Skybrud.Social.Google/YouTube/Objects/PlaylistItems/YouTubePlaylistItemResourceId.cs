using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Google.YouTube.Objects.PlaylistItems {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/playlistItems#snippet.resourceId</cref>
    /// </see>
    public class YouTubePlaylistItemResourceId : GoogleApiObject {

        #region Properties
        
        public string Kind { get; private set; }
        
        public string VideoId { get; private set; }

        #endregion
        
        #region Constructors

        private YouTubePlaylistItemResourceId(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>YouTubePlaylistItemResourceId</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static YouTubePlaylistItemResourceId Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubePlaylistItemResourceId(obj) {
                Kind = obj.GetString("kind"),
                VideoId = obj.GetString("videoId")
            };
        }

        #endregion

    }

}