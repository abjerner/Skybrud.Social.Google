using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Drive.Objects.Files {

    public class DriveFileList : GoogleApiResource {

        #region Properties

        public string SelfLink { get; private set; }
        
        public string NextPageToken { get; private set; }
        
        public string NextLink { get; private set; }

        #endregion

        #region Constructors

        protected DriveFileList(JObject obj) : base(obj) {
            SelfLink = obj.GetString("selfLink");
            NextPageToken = obj.GetString("nextPageToken");
            NextLink = obj.GetString("nextLink");
        }

        #endregion

        #region Static methods

        public static DriveFileList Parse(JObject obj) {
            return obj == null ? null : new DriveFileList(obj);
        }

        #endregion
    
    }

}