﻿using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.YouTube.Objects.Videos {

    /// <summary>
    /// Class representing a list of <see cref="YouTubeVideo"/> items.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/videos/list</cref>
    /// </see>
    public class YouTubeVideoList : GoogleApiResource {

        #region Properties

        public string NextPageToken { get; private set; }

        public string PrevPageToken { get; private set; }

        public YouTubePageInfo PageInfo { get; private set; }

        public YouTubeVideo[] Items { get; private set; }

        #endregion

        #region Constructors

        protected YouTubeVideoList(JObject obj) : base(obj) {
            NextPageToken = obj.GetString("nextPageToken");
            PrevPageToken = obj.GetString("prevPageToken");
            PageInfo = obj.GetObject("pageInfo", YouTubePageInfo.Parse);
            Items = obj.GetArray("items", YouTubeVideo.Parse);
        }

        #endregion
        
        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="YouTubeVideoList"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="YouTubeVideoList"/>.</returns>
        public static YouTubeVideoList Parse(JObject obj) {
            return obj == null ? null : new YouTubeVideoList(obj);
        }

        #endregion

    }

}