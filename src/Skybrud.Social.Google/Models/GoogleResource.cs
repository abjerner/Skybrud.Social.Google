using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Models {
    
    /// <summary>
    /// Class representing a resource in the Google ecosystem. A resource can be described as an object that can be
    /// requested through one of the various APIs, and holds properties for <c>kind</c> and <c>etag</c>.
    /// </summary>
    public class GoogleResource : GoogleObject {

        #region Properties

        /// <summary>
        /// Gets the <c>kind</c> of the resource.
        /// </summary>
        public string Kind { get; private set; }

        /// <summary>
        /// Gets the <c>etag</c> of the resource.
        /// </summary>
        public string ETag { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> representing the object.</param>
        protected GoogleResource(JObject json) : base(json) {
            Kind = json.GetString("kind");
            ETag = json.GetString("etag");
        }

        #endregion

    }

}