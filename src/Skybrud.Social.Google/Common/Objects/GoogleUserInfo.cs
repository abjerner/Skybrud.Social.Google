using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Google.Common.Objects {
    
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
        /// Gets the URL to the Google+ profile of the user, or <code>null</code> if the user doesn't have a Google+
        /// profile.
        /// </summary>
        public string Profile { get; private set; }

        /// <summary>
        /// Gets the URL to the profile picture of the user, or <code>null</code> if the user doesn't have a profile
        /// picture.
        /// </summary>
        public string Picture { get; private set; }

        /// <summary>
        /// Gets the email address of the user. The underlying <code>email</code> property is only part of the response
        /// if the <code>email</code> scope has been granted by the user.
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Gets whether the email address of the user has been verified. The underlying <code>email_verified</code>
        /// property is only part of the response if the <code>email</code> scope has been granted by the user.
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

        /// <summary>
        /// Gets the hosted Google Apps domain of the user, or <code>null</code> if the user is not a part of a hosted
        /// domain.
        /// </summary>
        public string HostedDomain { get; private set; }

        /// <summary>
        /// Gets whether the user is part of a hosted Google Apps domain. The underlying <code>hd</code> property is
        /// only part of the response if the <code>email</code> scope has been granted by the user.
        /// </summary>
        public bool HasHostedDomain {
            get { return !String.IsNullOrWhiteSpace(HostedDomain); }
        }

        /// <summary>
        /// Gets whether the email of the user was part of the properties returned in the response.
        /// </summary>
        public bool HasEmail {
            get { return !String.IsNullOrWhiteSpace(Email); }
        }

        #endregion

        #region Constructors

        private GoogleUserInfo(JObject obj) : base(obj) {
            Id = obj.GetString("id");
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
            HostedDomain = obj.GetString("hd");
        }

        #endregion
        
        #region Static methods
        
        /// <summary>
        /// Gets a user from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        /// <returns>Returns an instance of <code>GoogleUserInfo</code> representing the user.</returns>
        public static GoogleUserInfo Parse(JObject obj) {
            return obj == null ? null : new GoogleUserInfo(obj);
        }

        #endregion

    }

}