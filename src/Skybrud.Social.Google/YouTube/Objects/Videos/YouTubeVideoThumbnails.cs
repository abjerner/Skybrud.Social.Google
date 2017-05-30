using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.YouTube.Objects.Videos {

    /// <summary>
    /// Class representing a collection of thumbnails for a YouTube video.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/videos#snippet.thumbnails</cref>
    /// </see>
    public class YouTubeVideoThumbnails : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the default thumbnail image of the video. The thumbnail is 120px wide and 90px tall.
        /// </summary>
        public YouTubeVideoThumbnail Default { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Default"/> property has a value.
        /// </summary>
        public bool HasDefault {
            get { return Default != null; }
        }

        /// <summary>
        /// Gets a higher resolution version of the thumbnail image, which is 320px wide and 180px tall.
        /// </summary>
        public YouTubeVideoThumbnail Medium { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Medium"/> property has a value.
        /// </summary>
        public bool HasMedium {
            get { return Medium != null; }
        }

        /// <summary>
        /// Gets a high resolution version of the thumbnail image, which is 480px wide and 360px tall.
        /// </summary>
        public YouTubeVideoThumbnail High { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="High"/> property has a value.
        /// </summary>
        public bool HasHigh {
            get { return High != null; }
        }

        /// <summary>
        /// Gets an even higher resolution version of the thumbnail image than the high resolution image. This image is
        /// available for some videos. This image is 640px wide and 480px tall.
        /// </summary>
        public YouTubeVideoThumbnail Standard { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="HasStandard"/> property has a value.
        /// </summary>
        public bool HasStandard {
            get { return Standard != null; }
        }

        /// <summary>
        /// Gets the highest resolution version of the thumbnail image. This image size is available for some videos.
        /// This image is 1280px wide and 720px tall.
        /// </summary>
        public YouTubeVideoThumbnail MaxRes { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="MaxRes"/> property has a value.
        /// </summary>
        public bool HasMaxRes {
            get { return MaxRes != null; }
        }

        #endregion

        #region Constructors

        protected YouTubeVideoThumbnails(JObject obj) : base(obj) {
            Default = obj.GetObject("default", YouTubeVideoThumbnail.Parse);
            Medium = obj.GetObject("medium", YouTubeVideoThumbnail.Parse);
            High = obj.GetObject("high", YouTubeVideoThumbnail.Parse);
            Standard = obj.GetObject("standard", YouTubeVideoThumbnail.Parse);
            MaxRes = obj.GetObject("maxres", YouTubeVideoThumbnail.Parse);
        }

        #endregion

        #region Static methods

        public static YouTubeVideoThumbnails Parse(JObject obj) {
            return obj == null ? null : new YouTubeVideoThumbnails(obj);
        }

        #endregion

    }

}