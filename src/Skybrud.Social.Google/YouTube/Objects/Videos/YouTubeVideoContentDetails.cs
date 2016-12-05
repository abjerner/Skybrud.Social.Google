using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.YouTube.Objects.Videos {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/videos#contentDetails</cref>
    /// </see>
    public class YouTubeVideoContentDetails : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the length of the video.
        /// </summary>
        public YouTubeVideoDuration Duration { get; private set; }
        
        /// <summary>
        /// Gets the dimension of the video. Can either be in <code>3D</code> or in <code>2D</code>.
        /// </summary>
        public string Dimension { get; private set; }
        
        /// <summary>
        /// Gets whether the video is available in high definition (HD) or only standard definition (SD).
        /// Can be either <code>hd</code> or <code>sd</code>.
        /// </summary>
        public string Definition { get; private set; }
        
        /// <summary>
        /// Gets whether the video has captions. Can be either <code>true</code> or <code>false</code>.
        /// </summary>
        public string Caption { get; private set; }
        
        /// <summary>
        /// Gets whether the video represents licensed content, which means that the content has been claimed by a
        /// YouTube content partner.
        /// </summary>
        public bool IsLicensedContent { get; private set; }

        #endregion
        
        #region Constructors

        private YouTubeVideoContentDetails(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>YouTubeVideoContentDetails</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static YouTubeVideoContentDetails Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubeVideoContentDetails(obj) {
                Duration = YouTubeVideoDuration.Parse(obj.GetString("duration")),
                Dimension = obj.GetString("dimension"),
                Definition = obj.GetString("definition"),
                Caption = obj.GetString("caption"),
                IsLicensedContent = obj.GetBoolean("licensedContent")
            };
        }

        #endregion

    }

}