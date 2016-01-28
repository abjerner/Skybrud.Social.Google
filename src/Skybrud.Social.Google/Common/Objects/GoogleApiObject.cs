using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Google.Common.Objects {
    
    /// <summary>
    /// Class representing an object in the Google ecosystem.
    /// </summary>
    public class GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying instance of <code>JObject</code>.
        /// </summary>
        [JsonIgnore]
        public JObject JObject { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes instance from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> representing the object.</param>
        protected GoogleApiObject(JObject obj) {
            JObject = obj;
        }

        #endregion

    }

}