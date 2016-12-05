using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Plus.Objects.People {
    
    /// <summary>
    /// Class representing the image of a person in the Google+ API.
    /// </summary>
    public class PlusPersonImage : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the URL of the image.
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// Gets whether the image is the default image of the person.
        /// </summary>
        public bool IsDefault { get; private set; }

        #endregion

        #region Constructors

        private PlusPersonImage(JObject obj) : base(obj) {
            Url = obj.GetString("url");
            IsDefault = obj.GetBoolean("isDefault");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <code>PlusPersonImage</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to be parsed.</param>
        public static PlusPersonImage Parse(JObject obj) {
            return obj == null ? null : new PlusPersonImage(obj);
        }

        #endregion

    }

}