using System;
using Skybrud.Social.Google.Drive.Options.Files;
using Skybrud.Social.Google.OAuth;
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

        public SocialHttpResponse GetFiles() {
            return GetFiles(new DriveGetFilesOptions());
        }

        public SocialHttpResponse GetFiles(DriveGetFilesOptions options) {

            // A bit of validation
            if (options == null) throw new ArgumentNullException("options");

            // Make the call to the API
            return Client.DoHttpGetRequest("https://www.googleapis.com/drive/v2/files", options);
        
        }

        #endregion

    }

}