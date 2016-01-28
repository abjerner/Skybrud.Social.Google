using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Common.Objects.Authentication {
    
    /// <summary>
    /// Class representing information about an access token.
    /// </summary>
    public class GoogleToken : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the token of the authenticated user.
        /// </summary>
        public string AccessToken { get; private set; }

        /// <summary>
        /// Gets a refresh token that can be used to obtain a new access tokens. Refresh tokens are valid until the
        /// user revokes access. This field is only present if offline access is requested during the authorization.
        /// </summary>
        public string RefreshToken { get; private set; }

        /// <summary>
        /// Gets the remaining lifetime on the access token.
        /// </summary>
        public TimeSpan ExpiresIn { get; private set; }

        /// <summary>
        /// Gets the type of the access token.
        /// </summary>
        public string TokenType { get; private set; }

        #endregion

        #region Constructors

        private GoogleToken(JObject obj) : base(obj) {
            AccessToken = obj.GetString("access_token");
            RefreshToken = obj.GetString("refresh_token");
            ExpiresIn = obj.GetDouble("expires_in", TimeSpan.FromSeconds);
            TokenType = obj.GetString("token_type");
        }

        #endregion

        #region Static methods

        public static GoogleToken Parse(JObject obj) {
            return obj == null ? null : new GoogleToken(obj);
        }

        #endregion

    }

}