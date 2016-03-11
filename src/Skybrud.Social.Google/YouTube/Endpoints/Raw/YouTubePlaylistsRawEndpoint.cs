﻿using System;
using Skybrud.Social.Google.Common.OAuth;
using Skybrud.Social.Google.YouTube.Objects.Playlists;
using Skybrud.Social.Google.YouTube.Options;
using Skybrud.Social.Google.YouTube.Options.Playlists;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.YouTube.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw playlists endpoint.
    /// </summary>
    public class YouTubePlaylistsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal YouTubePlaylistsRawEndpoint(GoogleOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of playlists for the authenticated user.
        /// </summary>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPlaylists() {
            return GetPlaylists(new YouTubeGetPlaylistListOptions {
                Part = YouTubePlaylistPart.Basic,
                Mine = true
            });
        }

        /// <summary>
        /// Gets a list of playlists for the specified <code>channelId</code>.
        /// </summary>
        /// <param name="channelId">The ID of the channel.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPlaylists(string channelId) {
            if (String.IsNullOrWhiteSpace(channelId)) throw new ArgumentNullException("channelId");
            return GetPlaylists(new YouTubeGetPlaylistListOptions {
                Part = YouTubePlaylistPart.Basic,
                ChannelId = channelId
            });
        }

        /// <summary>
        /// Gets a list of playlists based on the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPlaylists(YouTubeGetPlaylistListOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("https://www.googleapis.com/youtube/v3/playlists", options);
        }

        #endregion

    }

}