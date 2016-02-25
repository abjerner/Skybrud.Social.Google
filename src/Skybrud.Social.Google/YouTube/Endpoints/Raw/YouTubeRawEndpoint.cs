using Skybrud.Social.Google.Common.OAuth;

namespace Skybrud.Social.Google.YouTube.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw YouTube endpoint / API implementation.
    /// </summary>
    public class YouTubeRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; private set; }

        /// <summary>
        /// Gets a reference to raw channels endpoint.
        /// </summary>
        public YouTubeChannelsRawEndpoint Channels { get; private set; }

        /// <summary>
        /// Gets a reference to raw playlists endpoint.
        /// </summary>
        public YouTubePlaylistsRawEndpoint Playlists { get; private set; }

        /// <summary>
        /// Gets a reference to raw playlist items endpoint.
        /// </summary>
        public YouTubePlaylistItemsRawEndpoint PlaylistItems { get; private set; }

        /// <summary>
        /// Gets a reference to raw videos endpoint.
        /// </summary>
        public YouTubeVideosRawEndpoint Videos { get; private set; }

        #endregion

        #region Constructors

        internal YouTubeRawEndpoint(GoogleOAuthClient client) {
            Client = client;
            Channels = new YouTubeChannelsRawEndpoint(client);
            Playlists = new YouTubePlaylistsRawEndpoint(client);
            PlaylistItems = new YouTubePlaylistItemsRawEndpoint(client);
            Videos = new YouTubeVideosRawEndpoint(client);
        }

        #endregion

    }

}