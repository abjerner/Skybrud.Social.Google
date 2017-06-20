using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.YouTube.Models.Playlists {

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
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="YouTubePlaylist"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="YouTubePlaylist"/>.</returns>
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