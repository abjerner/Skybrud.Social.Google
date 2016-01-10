using System;
using System.Collections.Specialized;
using Skybrud.Social.Exceptions;
using Skybrud.Social.Google.Analytics.Endpoints.Raw;
using Skybrud.Social.Google.Calendar.Endpoints.Raw;
using Skybrud.Social.Google.Drive.Endpoints.Raw;
using Skybrud.Social.Google.OAuth.Enums;
using Skybrud.Social.Google.OAuth.Responses;
using Skybrud.Social.Google.Scopes;
using Skybrud.Social.Google.YouTube.Endpoints.Raw;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces;

namespace Skybrud.Social.Google.OAuth {
    
    /// <summary>
    /// A client for handling the communication with the Google APIs using OAuth 2.0. The client is also responsible
    /// for the raw communication with the various Google APIs.
    /// </summary>
    public class GoogleOAuthClient {

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

        /// <summary>
        /// Gets a reference to the raw Analytics endpoint.
        /// </summary>
        public AnalyticsRawEndpoint Analytics { get; private set; }

        /// <summary>
        /// Gets a reference to the raw Calendar endpoint.
        /// </summary>
        public CalendarRawEndpoint Calendar { get; private set; }

        /// <summary>
        /// Gets a reference to the raw Drive endpoint.
        /// </summary>
        public DriveRawEndpoint Drive { get; private set; }

        /// <summary>
        /// Gets a reference to the raw YouTube endpoint.
        /// </summary>
        public YouTubeRawEndpoint YouTube { get; private set; }

        #endregion

        #region Constructors

        public GoogleOAuthClient() {
            Analytics = new AnalyticsRawEndpoint(this);
            Calendar = new CalendarRawEndpoint(this);
            Drive = new DriveRawEndpoint(this);
            YouTube = new YouTubeRawEndpoint(this);
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
            if (String.IsNullOrWhiteSpace(ClientId)) throw new PropertyNotSetException("ClientId");

            // Construct the authorization URL
            return GenerateUrl("https://accounts.google.com/o/oauth2/auth", new NameValueCollection {
                {"response_type", "code"},
                {"client_id", ClientId},
                {"access_type", accessType.ToString().ToLower()},
                {"approval_prompt", approvalPrompt.ToString().ToLower()},
                {"scope", scope + ""},
                {"redirect_uri", RedirectUri},
                {"state", state}
            });
        
        }

        public string GenerateUrl(string url, NameValueCollection query) {
            return url + (query.Count == 0 ? "" : "?" + SocialUtils.NameValueCollectionToQueryString(query));
        }

        public GoogleAccessTokenResponse GetAccessTokenFromAuthorizationCode(string code) {

            // Validate the required properties
            if (String.IsNullOrWhiteSpace(ClientId)) throw new PropertyNotSetException("ClientId");

            // Declare the POST data
            NameValueCollection postData = new NameValueCollection {
                {"code", code},
                {"client_id", ClientId},
                {"client_secret", ClientSecret},
                {"redirect_uri", RedirectUri},
                {"grant_type", "authorization_code"}
            };

            // Initialize the request
            SocialHttpRequest request = new SocialHttpRequest {
                Method = "POST",
                Url = "https://accounts.google.com/o/oauth2/token",
                PostData = postData
            };

            // Make a call to the server
            SocialHttpResponse response = request.GetResponse();

            // Parse the JSON response
            return GoogleAccessTokenResponse.ParseResponse(response);

        }

        public GoogleAccessTokenResponse GetAccessTokenFromRefreshToken(string refreshToken) {

            // Validate the required properties
            if (String.IsNullOrWhiteSpace(ClientId)) throw new PropertyNotSetException("ClientId");
            if (String.IsNullOrWhiteSpace(ClientSecret)) throw new PropertyNotSetException("ClientSecret");

            // Declare the POST data
            NameValueCollection postData = new NameValueCollection {
                {"client_id", ClientId},
                {"client_secret", ClientSecret},
                {"refresh_token", refreshToken},
                {"grant_type", "refresh_token"}
            };

            // Initialize the request
            SocialHttpRequest request = new SocialHttpRequest {
                Method = "POST",
                Url = "https://accounts.google.com/o/oauth2/token",
                PostData = postData
            };

            // Make a call to the server
            SocialHttpResponse response = request.GetResponse();

            // Parse the JSON response
            return GoogleAccessTokenResponse.ParseResponse(response);

        }

        /// <summary>
        /// Gets information about the authenticated user.
        /// </summary>
        public SocialHttpResponse GetUserInfo() {
            return DoAuthenticatedGetRequest("https://www.googleapis.com/oauth2/v2/userinfo");
        }

        /// <summary>
        /// Makes an authenticated GET request to the specified URL. The access token is
        /// automatically appended to the query string.
        /// </summary>
        /// <param name="url">The URL to call.</param>
        public SocialHttpResponse DoAuthenticatedGetRequest(string url) {
            return DoAuthenticatedGetRequest(url, default(NameValueCollection));
        }

        /// <summary>
        /// Makes an authenticated GET request to the specified URL. The access token is
        /// automatically appended to the query string.
        /// </summary>
        /// <param name="url">The URL to call.</param>
        /// <param name="query">The query string for the call.</param>
        public SocialHttpResponse DoAuthenticatedGetRequest(string url, NameValueCollection query) {

            // Initialize a new NameValueCollection if NULL
            if (query == null) query = new NameValueCollection();

            // Append the access token or server if specified
            if (!String.IsNullOrWhiteSpace(AccessToken)) {
                // TODO: Specify access token in HTTP header instead
                query.Set("access_token", AccessToken);
            } else if (!String.IsNullOrWhiteSpace(ServerKey)) {
                query.Set("key", ServerKey);
            }

            // Make a call to the API
            return SocialHttpResponse.GetFromWebResponse(SocialUtils.DoHttpGetRequest(url, query));

        }

        /// <summary>
        /// Makes an authenticated GET request to the specified URL. The access token is
        /// automatically appended to the query string.
        /// </summary>
        /// <param name="url">The URL to call.</param>
        /// <param name="options">The options for the call to the API.</param>
        public SocialHttpResponse DoAuthenticatedGetRequest(string url, IGetOptions options) {

            // Generate a NameValueCollection for the query string
            NameValueCollection query = options.GetQueryString().NameValueCollection;

            // Append the access token or server if specified
            if (!String.IsNullOrWhiteSpace(AccessToken)) {
                // TODO: Specify access token in HTTP header instead
                query.Set("access_token", AccessToken);
            } else if (!String.IsNullOrWhiteSpace(ServerKey)) {
                query.Set("key", ServerKey);
            }

            // Make a call to the API
            return SocialHttpResponse.GetFromWebResponse(SocialUtils.DoHttpGetRequest(url, query));

        }

        #endregion

    }

}
