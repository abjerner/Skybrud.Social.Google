﻿using Skybrud.Social.Google.YouTube.Endpoints.Raw;
using Skybrud.Social.Google.YouTube.Options.Channels;
using Skybrud.Social.Google.YouTube.Responses.Channels;

namespace Skybrud.Social.Google.YouTube.Endpoints {

    /// <summary>
    /// Class representing the channels endpoint.
    /// </summary>
    public class YouTubeChannelsEndpoint {

        #region Properties

        /// <summary>
        /// Gets the parent endpoint of this endpoint.
        /// </summary>
        public YouTubeEndpoint YouTube { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public YouTubeChannelsRawEndpoint Raw {
            get { return YouTube.Service.Client.YouTube.Channels; }
        }

        #endregion

        #region Constructors

        internal YouTubeChannelsEndpoint(YouTubeEndpoint youTube) {
            YouTube = youTube;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of channels for the authenticated user.
        /// </summary>
        /// <returns>An instance of <see cref="YouTubeGetChannelListResponse"/> representing the response.</returns>
        public YouTubeGetChannelListResponse GetChannels() {
            return YouTubeGetChannelListResponse.ParseResponse(Raw.GetChannels());
        }

        /// <summary>
        /// Gets a list of channels for the specified <paramref name="username"/>.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>An instance of <see cref="YouTubeGetChannelListResponse"/> representing the response.</returns>
        public YouTubeGetChannelListResponse GetChannels(string username) {
            return YouTubeGetChannelListResponse.ParseResponse(Raw.GetChannels(username));
        }

        /// <summary>
        /// Gets a list of channels based on the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="YouTubeGetChannelListResponse"/> representing the response.</returns>
        public YouTubeGetChannelListResponse GetChannels(YouTubeGetChannelListOptions options) {
            return YouTubeGetChannelListResponse.ParseResponse(Raw.GetChannels(options));
        }

        #endregion

    }

}