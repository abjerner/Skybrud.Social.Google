using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Drive.Responses.Files {
    
    public class DriveDownloadFileResponse : DriveResponse {

        #region Properties

        public byte[] Contents { get; private set; }

        #endregion

        #region Constructors

        protected DriveDownloadFileResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Contents = response.BinaryBody;
        
        }

        #endregion

        #region Static methods

        public static DriveDownloadFileResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new DriveDownloadFileResponse(response);
        }

        #endregion

    }

}