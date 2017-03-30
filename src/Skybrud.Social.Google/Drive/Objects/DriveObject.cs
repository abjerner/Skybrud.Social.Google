using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Drive.Objects {
    
    /// <summary>
    /// Class representing a basic object from the Google Drive API derived from an instance of <see cref="JObject"/>.
    /// </summary>
    public class DriveObject : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the string value representing the kind of the object.
        /// </summary>
        public string Kind { get; private set; }

        #endregion

        #region Constructors

        protected DriveObject(JObject obj) : base(obj) {
            Kind = obj.GetString("kind");
        }

        #endregion

    }

}