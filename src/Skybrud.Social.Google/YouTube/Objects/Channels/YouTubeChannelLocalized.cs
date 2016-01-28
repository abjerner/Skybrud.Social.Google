using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.YouTube.Objects.Channels {

    public class YouTubeChannelLocalized : GoogleApiObject {

        #region Properties

        public string Title { get; private set; }

        public string Description { get; private set; }

        #endregion

        #region Constructors

        protected YouTubeChannelLocalized(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        public static YouTubeChannelLocalized Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubeChannelLocalized(obj) {
                Title = obj.GetString("title"),
                Description = obj.GetString("description")
            };
        }

        #endregion

    }

}