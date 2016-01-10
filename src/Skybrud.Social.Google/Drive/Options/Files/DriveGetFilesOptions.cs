using Skybrud.Social.Http;
using Skybrud.Social.Interfaces;

namespace Skybrud.Social.Google.Drive.Options.Files {

    public class DriveGetFilesOptions : IGetOptions {

        #region Properties

        #endregion

        #region Constructors

        public DriveGetFilesOptions() { }

        #endregion

        public SocialQueryString GetQueryString() {

            SocialQueryString query = new SocialQueryString();

            return query;

        }

    }

}