using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Plus.Objects.People {
    
    /// <summary>
    /// Class representing the name of a person in the Google+ API.
    /// </summary>
    public class PlusPersonName : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the family name (last name) of the person.
        /// </summary>
        public string FamilyName { get; private set; }

        /// <summary>
        /// Gets the given name (first name) of the person.
        /// </summary>
        public string GivenName { get; private set; }

        #endregion

        #region Constructors

        private PlusPersonName(JObject obj) : base(obj) {
            FamilyName = obj.GetString("familyName");
            GivenName = obj.GetString("givenName");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <code>PlusPersonName</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to be parsed.</param>
        public static PlusPersonName Parse(JObject obj) {
            return obj == null ? null : new PlusPersonName(obj);
        }

        #endregion

    }

}