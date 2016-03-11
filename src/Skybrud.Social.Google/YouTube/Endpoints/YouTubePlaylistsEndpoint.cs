using System;
using Skybrud.Social.Google.YouTube.Endpoints.Raw;
using Skybrud.Social.Google.YouTube.Options;
using Skybrud.Social.Google.YouTube.Options.Playlists;
using Skybrud.Social.Google.YouTube.Responses.Playlist;

namespace Skybrud.Social.Google.YouTube.Endpoints {

    /// <summary>
    /// Class representing the playlists endpoint.
    /// </summary>
    public class YouTubePlaylistsEndpoint {

        #region Properties

        /// <summary>
        /// Gets the parent endpoint of this endpoint.
        /// </summary>
        public YouTubeEndpoint YouTube { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public YouTubePlaylistsRawEndpoint Raw {
            get { return YouTube.Service.Client.YouTube.Playlists; }
        }

        #endregion

        #region Constructors

        internal YouTubePlaylistsEndpoint(YouTubeEndpoint youTube) {
            YouTube = youTube;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of playlists for the authenticated user.
        /// </summary>
        /// <returns>Returns an instance of <see cref="YouTubeGetPlaylistListResponse"/> representing the response.</returns>
        public YouTubeGetPlaylistListResponse GetPlaylists() {
            return YouTubeGetPlaylistListResponse.ParseResponse(Raw.GetPlaylists());
        }

        /// <summary>
        /// Gets a list of playlists for the specified <code>channelId</code>.
        /// </summary>
        /// <param name="channelId">The ID of the channel.</param>
        /// <returns>Returns an instance of <see cref="YouTubeGetPlaylistListResponse"/> representing the response.</returns>
        public YouTubeGetPlaylistListResponse GetPlaylists(string channelId) {
            return YouTubeGetPlaylistListResponse.ParseResponse(Raw.GetPlaylists(channelId));
        }

        /// <summary>
        /// Gets a list of playlists based on the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="YouTubeGetPlaylistListResponse"/> representing the response.</returns>
        public YouTubeGetPlaylistListResponse GetPlaylists(YouTubeGetPlaylistListOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return YouTubeGetPlaylistListResponse.ParseResponse(Raw.GetPlaylists(options));
        }

        #endregion

    }

}