using System;
using Skybrud.Social.Google.YouTube.Endpoints.Raw;
using Skybrud.Social.Google.YouTube.Options;
using Skybrud.Social.Google.YouTube.Responses;
using Skybrud.Social.Google.YouTube.Responses.PlaylistItems;

namespace Skybrud.Social.Google.YouTube.Endpoints {

    /// <summary>
    /// Class representing the raw playlist items endpoint.
    /// </summary>
    public class YouTubePlaylistItemsEndpoint {

        #region Properties

        /// <summary>
        /// Gets the parent endpoint of this endpoint.
        /// </summary>
        public YouTubeEndpoint YouTube { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public YouTubePlaylistItemsRawEndpoint Raw {
            get { return YouTube.Service.Client.YouTube.PlaylistItems; }
        }

        #endregion

        #region Constructors

        internal YouTubePlaylistItemsEndpoint(YouTubeEndpoint youTube) {
            YouTube = youTube;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of playlist items for the specified <code>playlistId</code>.
        /// </summary>
        /// <param name="playlistId">The ID of the playlist.</param>
        /// <returns>Returns an instance of <see cref="YouTubePlaylistItemListResponse"/> representing the response.</returns>
        public YouTubePlaylistItemListResponse GetPlaylistItems(string playlistId) {
            if (String.IsNullOrWhiteSpace(playlistId)) throw new ArgumentNullException("playlistId");
            return YouTubePlaylistItemListResponse.ParseResponse(Raw.GetPlaylistItems(playlistId));
        }

        /// <summary>
        /// Gets a list of playlist items based on the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="YouTubePlaylistItemListResponse"/> representing the response.</returns>
        public YouTubePlaylistItemListResponse GetPlaylistItems(YouTubePlaylistItemListOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return YouTubePlaylistItemListResponse.ParseResponse(Raw.GetPlaylistItems(options));
        }

        #endregion

    }

}