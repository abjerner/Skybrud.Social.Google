using System;
using Skybrud.Essentials.Common;
using Skybrud.Social.Google.Models.Authentication;
using Skybrud.Social.Google.Responses.Authentication;
using Skybrud.Social.Google.Scopes;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Google.OAuth {
    
    /// <summary>
    /// A client for handling the communication with the Google APIs using OAuth 2.0. The client is also responsible
    /// for the raw communication with the various Google APIs.
    /// </summary>
    public class GoogleOAuthClient : SocialHttpClient {
        
        #region Properties

        /// <summary>
        /// Gets or sets the ID of the client/application.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the the secret of the client/application. Guard this with your life!
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the redirect URL. Must be specified in Google's APIs console.
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the server key.
        /// </summary>
        public string ServerKey { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public GoogleOAuthClient() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accessToken"/>.
        /// </summary>
        /// <param name="accessToken">The access token of the user.</param>
        public GoogleOAuthClient(string accessToken) {
            AccessToken = accessToken;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="clientId"/>, <paramref name="clientSecret"/> and <paramref name="redirectUri"/>.
        /// </summary>
        /// <param name="clientId">The ID of the client/application.</param>
        /// <param name="clientSecret">The secret of the client/application.</param>
        /// <param name="redirectUri">The redirect URI of the client/application.</param>
        public GoogleOAuthClient(string clientId, string clientSecret, string redirectUri) {
            ClientId = clientId;
            ClientSecret = clientSecret;
            RedirectUri = redirectUri;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the authorization URL at accounts.google.com for your application.
        /// </summary>
        /// <param name="state">The state of the application.</param>
        /// <param name="scope">The scope of the application.</param>
        /// <param name="offline">Whether the application should be enabled for offline access. Default is false.</param>
        public string GetAuthorizationUrl(string state, string scope, bool offline = false) {
            return GetAuthorizationUrl(state, new GoogleScope(scope), offline ? GoogleAccessType.Offline : GoogleAccessType.Online);
        }
        
        /// <summary>
        /// Gets the authorization URL at accounts.google.com for your application.
        /// </summary>
        /// <param name="state">The state of the application.</param>
        /// <param name="scope">The scope of the application.</param>
        /// <param name="offline">Whether the application should be enabled for offline access. Default is false.</param>
        public string GetAuthorizationUrl(string state, GoogleScopeCollection scope, bool offline = false) {
            return GetAuthorizationUrl(state, scope, offline ? GoogleAccessType.Offline : GoogleAccessType.Online);
        }

        /// <summary>
        /// Gets the authorization URL at accounts.google.com for your application.
        /// </summary>
        /// <param name="state">The state of the application.</param>
        /// <param name="scope">The scope of the application.</param>
        /// <param name="accessType">Whether the application should be enabled for offline access. Default is online.</param>
        /// <param name="approvalPrompt">Whether the user should be re-prompted for scopes that he/she already has approved.</param>
        public string GetAuthorizationUrl(string state, string scope, GoogleAccessType accessType = GoogleAccessType.Online, GoogleApprovalPrompt approvalPrompt = GoogleApprovalPrompt.Auto) {
            return GetAuthorizationUrl(state, new GoogleScope(scope), accessType, approvalPrompt);
        }

        /// <summary>
        /// Gets the authorization URL at accounts.google.com for your application.
        /// </summary>
        /// <param name="state">The state of the application.</param>
        /// <param name="scope">The scope of the application.</param>
        /// <param name="accessType">Whether the application should be enabled for offline access. Default is online.</param>
        /// <param name="approvalPrompt">Whether the user should be re-prompted for scopes that he/she already has approved.</param>
        public string GetAuthorizationUrl(string state, GoogleScopeCollection scope, GoogleAccessType accessType = GoogleAccessType.Online, GoogleApprovalPrompt approvalPrompt = GoogleApprovalPrompt.Auto) {

            // Validate the required properties
            if (String.IsNullOrWhiteSpace(state)) throw new ArgumentNullException(nameof(state));
            if (String.IsNullOrWhiteSpace(ClientId)) throw new PropertyNotSetException(nameof(ClientId));

            // Generate the query string
            IHttpQueryString query = new SocialHttpQueryString();

            query.Add("response_type", "code");
            query.Add("client_id", ClientId);
            query.Add("access_type", accessType.ToString().ToLower());
            query.Add("approval_prompt", approvalPrompt.ToString().ToLower());
            query.Add("scope", scope + "");
            query.Add("redirect_uri", RedirectUri);
            query.Add("state", state);

            // Construct the authorization URL
            return "https://accounts.google.com/o/oauth2/auth?" + query;
        
        }

        public GoogleTokenResponse GetAccessTokenFromAuthorizationCode(string code) {

            // Validate the required parameters and properties
            if (String.IsNullOrWhiteSpace(code)) throw new ArgumentNullException(nameof(code));
            if (String.IsNullOrWhiteSpace(ClientId)) throw new PropertyNotSetException(nameof(ClientId));
            if (String.IsNullOrWhiteSpace(ClientSecret)) throw new PropertyNotSetException(nameof(ClientSecret));
            if (String.IsNullOrWhiteSpace(RedirectUri)) throw new PropertyNotSetException(nameof(RedirectUri));

            // Declare the POST data
            IHttpPostData postData = new SocialHttpPostData();
            postData.Add("code", code);
            postData.Add("client_id", ClientId);
            postData.Add("client_secret", ClientSecret);
            postData.Add("redirect_uri", RedirectUri);
            postData.Add("grant_type", "authorization_code");

            // Initialize the request
            SocialHttpRequest request = new SocialHttpRequest {
                Method = SocialHttpMethod.Post,
                Url = "https://accounts.google.com/o/oauth2/token",
                PostData = postData
            };

            // Make a call to the server
            SocialHttpResponse response = request.GetResponse();

            // Parse the JSON response
            return GoogleTokenResponse.ParseResponse(response);

        }

        public GoogleTokenResponse GetAccessTokenFromRefreshToken(string refreshToken) {

            // Validate the required parameters and properties
            if (String.IsNullOrWhiteSpace(refreshToken)) throw new ArgumentNullException(nameof(refreshToken));
            if (String.IsNullOrWhiteSpace(ClientId)) throw new PropertyNotSetException(nameof(ClientId));
            if (String.IsNullOrWhiteSpace(ClientSecret)) throw new PropertyNotSetException(nameof(ClientSecret));

            // Declare the POST data
            IHttpPostData postData = new SocialHttpPostData();
            postData.Add("client_id", ClientId);
            postData.Add("client_secret", ClientSecret);
            postData.Add("refresh_token", refreshToken);
            postData.Add("grant_type", "refresh_token");

            // Initialize the request
            SocialHttpRequest request = new SocialHttpRequest {
                Method = SocialHttpMethod.Post,
                Url = "https://accounts.google.com/o/oauth2/token",
                PostData = postData
            };

            // Make a call to the server
            SocialHttpResponse response = request.GetResponse();

            // Parse the JSON response
            return GoogleTokenResponse.ParseResponse(response);

        }

        /// <summary>
        /// Gets information about the authenticated user.
        /// </summary>
        public SocialHttpResponse GetUserInfo() {
            return DoHttpGetRequest("https://www.googleapis.com/oauth2/v2/userinfo");
        }

        protected override void PrepareHttpRequest(SocialHttpRequest request) {

            // Append the access token or server if specified
            if (!String.IsNullOrWhiteSpace(AccessToken)) {
                // TODO: Specify access token in HTTP header instead
                request.QueryString.Set("access_token", AccessToken);
            } else if (!String.IsNullOrWhiteSpace(ServerKey)) {
                request.QueryString.Set("key", ServerKey);
            }

        }

        #endregion

    }

}