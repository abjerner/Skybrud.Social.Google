using Skybrud.Social.Google.Common.OAuth;

namespace Skybrud.Social.Google.Drive.Endpoints.Raw {

    public class DriveRawEndpoint {

        #region Properties

        public GoogleOAuthClient Client { get; private set; }

        public DriveFilesRawEndpoint Files { get; private set; }

        #endregion

        #region Constructors

        internal DriveRawEndpoint(GoogleOAuthClient client) {
            Client = client;
            Files = new DriveFilesRawEndpoint(client);
        }

        #endregion

    }

}