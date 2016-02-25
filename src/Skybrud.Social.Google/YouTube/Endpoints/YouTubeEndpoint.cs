using Skybrud.Social.Google.Common;
using Skybrud.Social.Google.YouTube.Endpoints.Raw;

namespace Skybrud.Social.Google.YouTube.Endpoints {

    /// <summary>
    /// Class representing the YouTube endpoint / API implementation.
    /// </summary>
    public class YouTubeEndpoint {
        
        #region Properties

        /// <summary>
        /// Gets the parent service of this endpoint.
        /// </summary>
        public GoogleService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the raw YouTube endpoint.
        /// </summary>
        public YouTubeRawEndpoint Raw {
            get { return Service.Client.YouTube; }
        }

        /// <summary>
        /// Gets a reference to the channels endpoint.
        /// </summary>
        public YouTubeChannelsEndpoint Channels { get; private set; }

        /// <summary>
        /// Gets a reference to the playlists endpoint.
        /// </summary>
        public YouTubePlaylistsEndpoint Playlists { get; private set; }

        /// <summary>
        /// Gets a reference to the playlists items endpoint.
        /// </summary>
        public YouTubePlaylistItemsEndpoint PlaylistItems { get; private set; }

        /// <summary>
        /// Gets a reference to the videos endpoint.
        /// </summary>
        public YouTubeVideosEndpoint Videos { get; private set; }

        #endregion

        #region Constructors

        internal YouTubeEndpoint(GoogleService service) {
            Service = service;
            Channels = new YouTubeChannelsEndpoint(this);
            Playlists = new YouTubePlaylistsEndpoint(this);
            PlaylistItems = new YouTubePlaylistItemsEndpoint(this);
            Videos = new YouTubeVideosEndpoint(this);
        }

        #endregion

    }

}