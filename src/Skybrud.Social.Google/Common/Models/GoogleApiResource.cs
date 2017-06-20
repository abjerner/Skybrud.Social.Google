using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Common.Models {
    
    /// <summary>
    /// Class representing a resource in the Google ecosystem. A resource can be described as an object that can be
    /// requested through one of the various APIs, and holds properties for <code>kind</code> and <code>etag</code>.
    /// </summary>
    public class GoogleApiResource : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the <code>kind</code> of the resource.
        /// </summary>
        public string Kind { get; private set; }

        /// <summary>
        /// Gets the <code>etag</code> of the resource.
        /// </summary>
        public string ETag { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        protected GoogleApiResource(JObject obj) : base(obj) {
            Kind = obj.GetString("kind");
            ETag = obj.GetString("etag");
        }

        #endregion

    }

}