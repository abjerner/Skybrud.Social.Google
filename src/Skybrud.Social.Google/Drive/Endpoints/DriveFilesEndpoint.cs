using Skybrud.Social.Google.Drive.Endpoints.Raw;
using Skybrud.Social.Google.Drive.Options.Files;
using Skybrud.Social.Google.Drive.Responses.Files;

namespace Skybrud.Social.Google.Drive.Endpoints {

    public class DriveFilesEndpoint {

        #region Properties

        /// <summary>
        /// Gets the parent endpoint of this endpoint.
        /// </summary>
        public DriveEndpoint Drive { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public DriveFilesRawEndpoint Raw {
            get { return Drive.Service.Client.Drive.Files; }
        }

        #endregion

        #region Constructors

        internal DriveFilesEndpoint(DriveEndpoint drive) {
            Drive = drive;
        }

        #endregion

        #region Member methods

        public DriveGetFilesResponse GetFiles() {
            return DriveGetFilesResponse.ParseResponse(Raw.GetFiles());
        }

        public DriveGetFilesResponse GetFiles(DriveGetFilesOptions options) {
            return DriveGetFilesResponse.ParseResponse(Raw.GetFiles(options));
        }

        #endregion

    }

}