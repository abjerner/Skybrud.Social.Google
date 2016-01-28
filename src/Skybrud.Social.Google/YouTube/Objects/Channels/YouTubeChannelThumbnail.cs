﻿using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.YouTube.Objects.Channels {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/channels#snippet.thumbnails</cref>
    /// </see>
    public class YouTubeChannelThumbnail : GoogleApiObject {

        #region Properties

        public string Url { get; private set; }

        #endregion

        #region Constructors

        protected YouTubeChannelThumbnail(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        public static YouTubeChannelThumbnail Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubeChannelThumbnail(obj) {
                Url = obj.GetString("url")
            };
        }

        #endregion

    }

}