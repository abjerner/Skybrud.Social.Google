using System;
using System.Collections.Specialized;
using Skybrud.Essentials.Common;
using Skybrud.Social.Google.Analytics.Endpoints.Raw;
using Skybrud.Social.Google.Calendar.Endpoints.Raw;
using Skybrud.Social.Google.Common.Enums;
using Skybrud.Social.Google.Common.Responses.Authentication;
using Skybrud.Social.Google.Common.Scopes;
using Skybrud.Social.Google.Drive.Endpoints.Raw;
using Skybrud.Social.Google.Geocoding.Endpoints.Raw;
using Skybrud.Social.Google.Places.Endpoints.Raw;
using Skybrud.Social.Google.YouTube.Endpoints.Raw;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Common.OAuth {
    
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

        /// <summary>
        /// Gets a reference to the raw Analytics endpoint.
        /// </summary>
        public AnalyticsRawEndpoint Analytics { get; private set; }

        /// <summary>
        /// Gets a reference to the raw Google Calendar endpoint.
        /// </summary>
        public CalendarRawEndpoint Calendar { get; private set; }

        /// <summary>
        /// Gets a reference to the raw Google Drive endpoint.
        /// </summary>
        public DriveRawEndpoint Drive { get; private set; }

        /// <summary>
        /// Gets a reference to the raw Geocoding endpoint.
        /// </summary>
        public GeocodingRawEndpoint Geocoding { get; private set; }

        /// <summary>
        /// Gets a reference to the raw Google Places endpoint.
        /// </summary>
        public PlacesRawEndpoint Places { get; private set; }

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
            Geocoding = new GeocodingRawEndpoint(this);
            Places = new PlacesRawEndpoint(this);
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
            return url + (query.Count == 0 ? "" : "?" + SocialUtils.Misc.NameValueCollectionToQueryString(query));
        }

        public GoogleTokenResponse GetAccessTokenFromAuthorizationCode(string code) {

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
                Method = SocialHttpMethod.Post,
                Url = "https://accounts.google.com/o/oauth2/token",
                PostData = new SocialHttpPostData(postData)
            };

            // Make a call to the server
            SocialHttpResponse response = request.GetResponse();

            // Parse the JSON response
            return GoogleTokenResponse.ParseResponse(response);

        }

        public GoogleTokenResponse GetAccessTokenFromRefreshToken(string refreshToken) {

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
                Method = SocialHttpMethod.Post,
                Url = "https://accounts.google.com/o/oauth2/token",
                PostData = new SocialHttpPostData(postData)
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