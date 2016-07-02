using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Google.Drive.Objects.Files {

    public class DriveFile : GoogleApiObject {

        #region Properties

        public string Kind { get; private set; }

        public string Id { get; private set; }

        public string ETag { get; private set; }

        public string SelfLink { get; private set; }

        public string AlternateLink { get; private set; }

        public string EmbedLink { get; private set; }

        // openWithLinks

        public string DefaultOpenWithLink { get; private set; }

        public string IconLink { get; private set; }

        public string ThumbnailLink { get; private set; }

        public string Title { get; private set; }

        public string MimeType { get; private set; }

        #endregion

        #region Constructors

        protected DriveFile(JObject obj) : base(obj) {
            Kind = obj.GetString("kind");
            Id = obj.GetString("id");
            ETag = obj.GetString("etag");
            SelfLink = obj.GetString("selfLink");
            AlternateLink = obj.GetString("alternateLink");
            EmbedLink = obj.GetString("embedLink");
            // openWithLinks
            DefaultOpenWithLink = obj.GetString("defaultOpenWithLink");
            IconLink = obj.GetString("iconLink");
            ThumbnailLink = obj.GetString("thumbnailLink");
            Title = obj.GetString("title");
            MimeType = obj.GetString("mimeType");
        }

        #endregion

        #region Static methods

        public static DriveFile Parse(JObject obj) {
            return obj == null ? null : new DriveFile(obj);
        }

        #endregion

    }

}