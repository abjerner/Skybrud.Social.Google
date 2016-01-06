using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Google.Objects {
    
    /// <summary>
    /// Class representing an object in the Google ecosystem.
    /// </summary>
    public class GoogleApiObject {

        #region Properties

        public JObject JObject { get; private set; }

        #endregion

        #region Constructor

        protected GoogleApiObject(JObject obj) {
            JObject = obj;
        }

        #endregion

    }

}