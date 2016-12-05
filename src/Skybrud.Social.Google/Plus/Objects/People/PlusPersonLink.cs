using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Plus.Objects.People {
    
    /// <summary>
    /// Class representing a link of a person in the Google+ API.
    /// </summary>
    public class PlusPersonLink : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the URL of the link.
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// Gets the type of the link.
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// Gets the label of the link.
        /// </summary>
        public string Label { get; private set; }

        #endregion

        #region Constructors

        private PlusPersonLink(JObject obj) : base(obj) {
            Value = obj.GetString("value");
            Type = obj.GetString("type");
            Label = obj.GetString("label");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <code>PlusPersonLink</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to be parsed.</param>
        public static PlusPersonLink Parse(JObject obj) {
            return obj == null ? null : new PlusPersonLink(obj);
        }

        #endregion

    }

}