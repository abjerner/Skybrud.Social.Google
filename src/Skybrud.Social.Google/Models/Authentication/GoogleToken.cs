using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Models.Authentication {

    /// <summary>
    /// Class representing information about an access token.
    /// </summary>
    public class GoogleToken : GoogleObject {

        #region Properties

        /// <summary>
        /// Gets the token of the authenticated user.
        /// </summary>
        public string AccessToken { get; }

        /// <summary>
        /// Gets a refresh token that can be used to obtain a new access tokens. Refresh tokens are valid until the
        /// user revokes access. This field is only present if offline access is requested during the authorization.
        /// </summary>
        public string RefreshToken { get; }

        /// <summary>
        /// Gets the remaining lifetime on the access token.
        /// </summary>
        public TimeSpan ExpiresIn { get; }

        /// <summary>
        /// Gets the type of the access token.
        /// </summary>
        public string TokenType { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> representing the object.</param>
        protected GoogleToken(JObject json) : base(json) {
            AccessToken = json.GetString("access_token")!;
            RefreshToken = json.GetString("refresh_token")!;
            ExpiresIn = json.GetDouble("expires_in", TimeSpan.FromSeconds);
            TokenType = json.GetString("token_type")!;
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="GoogleToken"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="GoogleToken"/>.</returns>
        [return: NotNullIfNotNull("json")]
        public static GoogleToken? Parse(JObject? json) {
            return json == null ? null : new GoogleToken(json);
        }

        #endregion

    }

}