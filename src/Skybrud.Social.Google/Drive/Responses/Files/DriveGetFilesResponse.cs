using Skybrud.Social.Google.Drive.Models.Files;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Drive.Responses.Files {
    
    public class DriveGetFilesResponse : DriveResponse<DriveFileList> {

        #region Constructors

        protected DriveGetFilesResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, DriveFileList.Parse);
        
        }

        #endregion

        #region Static methods

        public static DriveGetFilesResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new DriveGetFilesResponse(response);
        }

        #endregion

    }

}