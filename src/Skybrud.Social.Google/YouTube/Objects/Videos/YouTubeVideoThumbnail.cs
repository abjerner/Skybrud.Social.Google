using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.YouTube.Objects.Videos {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/videos#snippet.thumbnails</cref>
    /// </see>
    public class YouTubeVideoThumbnail : GoogleApiObject {

        #region Properties

        public string Url { get; private set; }

        public int Width { get; private set; }

        public int Height { get; private set; }

        #endregion

        #region Constructors

        protected YouTubeVideoThumbnail(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        public static YouTubeVideoThumbnail Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubeVideoThumbnail(obj) {
                Url = obj.GetString("url"),
                Width = obj.GetInt32("width"),
                Height = obj.GetInt32("height")
            };
        }

        #endregion

    }

}