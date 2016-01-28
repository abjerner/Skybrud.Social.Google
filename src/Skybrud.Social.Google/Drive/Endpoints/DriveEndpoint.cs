using Skybrud.Social.Google.Common;
using Skybrud.Social.Google.Drive.Endpoints.Raw;

namespace Skybrud.Social.Google.Drive.Endpoints {
    
    public class DriveEndpoint {

        #region Properties

        public GoogleService Service { get; private set; }

        public DriveRawEndpoint Raw { get; private set; }

        public DriveFilesEndpoint Files { get; private set; }

        #endregion

        #region Constructors

        public DriveEndpoint(GoogleService service) {
            Service = service;
            Raw = new DriveRawEndpoint(Service.Client);
            Files = new DriveFilesEndpoint(this);
        }

        #endregion

    }

}