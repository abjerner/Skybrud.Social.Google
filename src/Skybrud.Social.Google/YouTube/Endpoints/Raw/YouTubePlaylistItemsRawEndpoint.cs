﻿using System;
using Skybrud.Social.Google.Common.OAuth;
using Skybrud.Social.Google.YouTube.Options.PlaylistItems;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.YouTube.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw playlist items endpoint.
    /// </summary>
    public class YouTubePlaylistItemsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal YouTubePlaylistItemsRawEndpoint(GoogleOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of playlist items for the specified <paramref name="playlistId"/>.
        /// </summary>
        /// <param name="playlistId">The ID of the playlist.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPlaylistItems(string playlistId) {
            if (String.IsNullOrWhiteSpace(playlistId)) throw new ArgumentNullException("playlistId");
            return GetPlaylistItems(new YouTubeGetPlaylistItemListOptions(playlistId));
        }

        /// <summary>
        /// Gets a list of playlist items based on the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPlaylistItems(YouTubeGetPlaylistItemListOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("https://www.googleapis.com/youtube/v3/playlistItems", options);
        }

        #endregion

    }

}