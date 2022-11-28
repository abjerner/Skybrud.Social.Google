using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft;

namespace Skybrud.Social.Google.Models {

    /// <summary>
    /// Class representing an object in the Google ecosystem.
    /// </summary>
    public class GoogleObject : JsonObjectBase {

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> representing the object.</param>
        protected GoogleObject(JObject json) : base(json) { }

        #endregion

    }

}