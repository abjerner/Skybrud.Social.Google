using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Objects {
    
    /// <summary>
    /// Class representing a Google account/user. Not all properties may be present since it both
    /// depends on the scope of the application as well as what information the user has specified
    /// and is sharing.
    /// </summary>
    public class GoogleUserInfo : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the user.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the full name of the user.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the given name (first name) of the user.
        /// </summary>
        public string GivenName { get; private set; }

        /// <summary>
        /// Gets the family name (last name) of the user.
        /// </summary>
        public string FamilyName { get; private set; }

        /// <summary>
        /// Gets the link to the user's Google+ profile (if the user is on Google+).
        /// </summary>
        public string Profile { get; private set; }

        /// <summary>
        /// Gets the URL for the user's profile picture if present.
        /// </summary>
        public string Picture { get; private set; }

        /// <summary>
        /// Gets the email address of the user.
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Gets whether the email address of the user has been verified.
        /// </summary>
        public bool IsEmailVerified { get; private set; }

        /// <summary>
        /// Gets the gender of the user.
        /// </summary>
        public string Gender { get; private set; }

        /// <summary>
        /// Gets the birth date of the user.
        /// </summary>
        public string Birthdate { get; private set; }

        /// <summary>
        /// Gets the locale of the user.
        /// </summary>
        public string Locale { get; private set; }

        #endregion

        #region Constructors

        private GoogleUserInfo(JObject obj) : base(obj) {
            Id = obj.GetString("sub");
            Name = obj.GetString("name");
            GivenName = obj.GetString("given_name");
            FamilyName = obj.GetString("family_name");
            Profile = obj.GetString("profile");
            Picture = obj.GetString("picture");
            Email = obj.GetString("email");
            IsEmailVerified = obj.GetBoolean("email_verified");
            Gender = obj.GetString("gender");
            Birthdate = obj.GetString("birthdate");
            Locale = obj.GetString("locale");
        }

        #endregion
        
        #region Static methods
        
        /// <summary>
        /// Gets a user from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static GoogleUserInfo Parse(JObject obj) {
            return obj == null ? null : new GoogleUserInfo(obj);
        }

        #endregion

    }

}