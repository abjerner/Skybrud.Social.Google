using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;

namespace Skybrud.Social.Google.Common.Objects {
    
    /// <summary>
    /// Class representing an object in the Google ecosystem.
    /// </summary>
    public class GoogleApiObject : JsonObjectBase {

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        protected GoogleApiObject(JObject obj) : base(obj) { }

        #endregion

    }

}