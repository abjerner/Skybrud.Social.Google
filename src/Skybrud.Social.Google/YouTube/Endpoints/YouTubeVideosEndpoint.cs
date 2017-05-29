﻿using System;
using Skybrud.Social.Google.YouTube.Endpoints.Raw;
using Skybrud.Social.Google.YouTube.Options.Videos;
using Skybrud.Social.Google.YouTube.Responses.Videos;

namespace Skybrud.Social.Google.YouTube.Endpoints {

    /// <summary>
    /// Class representing the videos endpoint.
    /// </summary>
    public class YouTubeVideosEndpoint {

        #region Properties

        /// <summary>
        /// Gets the parent endpoint of this endpoint.
        /// </summary>
        public YouTubeEndpoint YouTube { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public YouTubeVideosRawEndpoint Raw {
            get { return YouTube.Service.Client.YouTube.Videos; }
        }

        #endregion

        #region Constructors

        internal YouTubeVideosEndpoint(YouTubeEndpoint youTube) {
            YouTube = youTube;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of videos based on the specified <paramref name="videoId"/>.
        /// </summary>
        /// <param name="videoId">The ID of the video to be returned.</param>
        /// <returns>An instance of <see cref="YouTubeGetVideoListResponse"/> representing the response.</returns>
        public YouTubeGetVideoListResponse GetVideos(string videoId) {
            if (String.IsNullOrWhiteSpace(videoId)) throw new ArgumentNullException("videoId");
            return YouTubeGetVideoListResponse.ParseResponse(Raw.GetVideos(videoId));
        }

        /// <summary>
        /// Gets a list of videos based on the specified <paramref name="videoIds"/>.
        /// </summary>
        /// <param name="videoIds">The IDs of videos to be returned.</param>
        /// <returns>An instance of <see cref="YouTubeGetVideoListResponse"/> representing the response.</returns>
        public YouTubeGetVideoListResponse GetVideos(params string[] videoIds) {
            return YouTubeGetVideoListResponse.ParseResponse(Raw.GetVideos(videoIds));
        }

        /// <summary>
        /// Gets a list of videos based on the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="YouTubeGetVideoListResponse"/> representing the response.</returns>
        public YouTubeGetVideoListResponse GetVideos(YouTubeGetVideoListOptions options) {
            return YouTubeGetVideoListResponse.ParseResponse(Raw.GetVideos(options));
        }

        #endregion

    }

}