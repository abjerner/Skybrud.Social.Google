﻿using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.YouTube.Models.Channels {

    /// <summary>
    /// Class representing a list of <see cref="YouTubeChannel"/>.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/channels/list</cref>
    /// </see>
    public class YouTubeChannelList : GoogleApiResource {

        #region Properties

        /// <summary>
        /// Gets pagination information about the list.
        /// </summary>
        public YouTubePageInfo PageInfo { get; private set; }

        /// <summary>
        /// Gets an array of the items in the list.
        /// </summary>
        public YouTubeChannel[] Items { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="YouTubeChannelList"/> to be parsed.</param>
        protected YouTubeChannelList(JObject obj) : base(obj) {
            PageInfo = obj.GetObject("pageInfo", YouTubePageInfo.Parse);
            Items = obj.GetArray("items", YouTubeChannel.Parse);
        }

        #endregion
        
        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="YouTubeChannelList"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns the instance of <see cref="YouTubeChannelList"/>.</returns>
        public static YouTubeChannelList Parse(JObject obj) {
            return obj == null ? null : new YouTubeChannelList(obj);
        }

        #endregion

    }

}