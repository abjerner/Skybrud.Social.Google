using System;
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

        public DriveDownloadFileResponse DownloadFile(string fileId) {
            return DriveDownloadFileResponse.ParseResponse(Raw.DownloadFile(fileId));
        }

        public DriveGetFilesResponse GetFiles() {
            return DriveGetFilesResponse.ParseResponse(Raw.GetFiles());
        }

        public DriveGetFilesResponse GetFiles(int pageSize) {
            return DriveGetFilesResponse.ParseResponse(Raw.GetFiles(pageSize));
        }

        public DriveGetFilesResponse GetFiles(int pageSize, string pageToken) {
            return DriveGetFilesResponse.ParseResponse(Raw.GetFiles(pageSize, pageToken));
        }

        public DriveGetFilesResponse GetFiles(DriveGetFilesOptions options) {
            return DriveGetFilesResponse.ParseResponse(Raw.GetFiles(options));
        }

        #endregion

    }

}