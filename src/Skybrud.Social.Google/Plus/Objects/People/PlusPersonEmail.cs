using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Plus.Objects.People {
    
    /// <summary>
    /// Class representing an email address of a person in the Google+ API.
    /// </summary>
    public class PlusPersonEmail : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the email address.
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// Gets the type of the email address.
        /// </summary>
        public string Type { get; private set; }

        #endregion

        #region Constructors

        private PlusPersonEmail(JObject obj) : base(obj) {
            Value = obj.GetString("value");
            Type = obj.GetString("type");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <code>PlusPersonEmail</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to be parsed.</param>
        public static PlusPersonEmail Parse(JObject obj) {
            return obj == null ? null : new PlusPersonEmail(obj);
        }

        #endregion

    }

}