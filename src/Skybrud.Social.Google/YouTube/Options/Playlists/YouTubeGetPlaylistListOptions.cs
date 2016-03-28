﻿using System;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces;

namespace Skybrud.Social.Google.YouTube.Options.Playlists {

    /// <summary>
    /// Clas representing the options for getting a list of playlists from the YouTube API.
    /// </summary>
    public class YouTubeGetPlaylistListOptions : IGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets which properties that should be returned.
        /// </summary>
        public YouTubePlaylistPartsCollection Part { get; set; }

        /// <summary>
        /// Gets or sets a channel ID if only playlists for a specific channel should be returned.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Gets or sets a list of IDs for the playlists to be returned.
        /// </summary>
        public string[] Ids { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount of playlists to be returned on each page (maximum is <code>50</code>).
        /// </summary>
        public int MaxResults { get; set; }

        /// <summary>
        /// Gets or sets whether only playlists by the authenticated user should be returned.
        /// </summary>
        public bool Mine { get; set; }

        /// <summary>
        /// Gets or sets the page token.
        /// </summary>
        public string PageToken { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public YouTubeGetPlaylistListOptions() {
            Part = YouTubePlaylistParts.Snippet;
        }

        #endregion

        #region Member methods

        public SocialQueryString GetQueryString() {
            SocialQueryString query = new SocialQueryString();
            if (Part != null) query.Add("part", Part.ToString());
            if (!String.IsNullOrWhiteSpace(ChannelId)) query.Add("channelId", ChannelId);
            if (Ids != null && Ids.Length > 0) query.Add("id", String.Join(",", Ids));
            if (MaxResults > 0) query.Add("maxResults", MaxResults);
            if (Mine) query.Add("mine", "true");
            if (!String.IsNullOrWhiteSpace(PageToken)) query.Add("pageToken", PageToken);
            return query;
        }

        #endregion

    }

}