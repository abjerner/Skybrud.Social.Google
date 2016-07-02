using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Google.Drive.Options.Files {

    public class DriveGetFilesOptions : IHttpGetOptions {

        #region Properties

        #endregion

        #region Constructors

        public DriveGetFilesOptions() { }

        #endregion

        public IHttpQueryString GetQueryString() {
            return new SocialHttpQueryString();
        }

    }

}