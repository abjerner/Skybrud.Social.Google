using System;
using Skybrud.Social.Google.Common.OAuth;
using Skybrud.Social.Google.Drive.Options.Files;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Drive.Endpoints.Raw {
    
    public class DriveFilesRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Google OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal DriveFilesRawEndpoint(GoogleOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods


        /// <summary>
        /// Gets the contents of the file with the specified <paramref name="fileId"/>.
        /// </summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse DownloadFile(string fileId) {
            if (String.IsNullOrWhiteSpace(fileId)) throw new ArgumentNullException("fileId");
            return Client.DoHttpGetRequest("https://www.googleapis.com/drive/v3/files/" + fileId + "?alt=media");
        }

        public SocialHttpResponse GetFiles() {
            return GetFiles(new DriveGetFilesOptions());
        }

        public SocialHttpResponse GetFiles(int pageSize) {
            return GetFiles(new DriveGetFilesOptions(pageSize));
        }

        public SocialHttpResponse GetFiles(int pageSize, string pageToken) {
            return GetFiles(new DriveGetFilesOptions(pageSize, pageToken));
        }

        public SocialHttpResponse GetFiles(DriveGetFilesOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("https://www.googleapis.com/drive/v3/files", options);
        }

        #endregion

    }

}