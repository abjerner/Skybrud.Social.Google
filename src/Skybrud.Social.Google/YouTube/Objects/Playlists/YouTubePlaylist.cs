using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.YouTube.Objects.Playlists {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/playlists#resource</cref>
    /// </see>
    public class YouTubePlaylist : GoogleApiResource {

        #region Properties

        public string Id { get; private set; }

        public YouTubePlaylistSnippet Snippet { get; private set; }

        public YouTubePlaylistStatus Status { get; private set; }

        public YouTubePlaylistContentDetails ContentDetails { get; private set; }
        
        #endregion
        
        #region Constructors

        private YouTubePlaylist(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>YouTubePlaylist</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static YouTubePlaylist Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubePlaylist(obj) {
                Id = obj.GetString("id"),
                Snippet = obj.GetObject("snippet", YouTubePlaylistSnippet.Parse),
                Status = obj.GetObject("status", YouTubePlaylistStatus.Parse),
                ContentDetails = obj.GetObject("contentDetails", YouTubePlaylistContentDetails.Parse)
            };
        }

        #endregion

    }

}