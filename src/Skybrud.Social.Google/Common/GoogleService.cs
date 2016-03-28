using System;
using Skybrud.Social.Google.Analytics.Endpoints;
using Skybrud.Social.Google.Calendar.Endpoints;
using Skybrud.Social.Google.Common.OAuth;
using Skybrud.Social.Google.Common.Responses;
using Skybrud.Social.Google.Common.Responses.Authentication;
using Skybrud.Social.Google.Drive.Endpoints;
using Skybrud.Social.Google.Places.Endpoints;
using Skybrud.Social.Google.YouTube.Endpoints;

namespace Skybrud.Social.Google.Common {

    /// <summary>
    /// Class working as an entry point to the Google APIs supported by Skybrud.Social.
    /// </summary>
    public class GoogleService {

        #region Properties

        /// <summary>
        /// Gets a reference to the internal OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; private set; }

        /// <summary>
        /// Gets the endpoint for the Analytics API.
        /// </summary>
        public AnalyticsEndpoint Analytics { get; private set; }

        /// <summary>
        /// Gets the endpoint for the Calendar API.
        /// </summary>
        public CalendarEndpoint Calendar { get; private set; }

        /// <summary>
        /// Gets the endpoint for the Drive API.
        /// </summary>
        public DriveEndpoint Drive { get; private set; }

        /// <summary>
        /// Gets the endpoint for the Google Places API.
        /// </summary>
        public PlacesEndpoint Places { get; private set; }

        /// <summary>
        /// Gets the endpoint for the YouTube API.
        /// </summary>
        public YouTubeEndpoint YouTube { get; private set; }

        #endregion

        #region Constructors

        private GoogleService(GoogleOAuthClient client) {
            Client = client;
            Analytics = new AnalyticsEndpoint(this);
            Calendar = new CalendarEndpoint(this);
            Drive = new DriveEndpoint(this);
            Places = new PlacesEndpoint(this);
            YouTube = new YouTubeEndpoint(this);
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets information about the authenticated user.
        /// </summary>
        /// <returns>Returns an instance of <code>GoogleGetUserInfoResponse</code> representing the response.</returns>
        public GoogleGetUserInfoResponse GetUserInfo() {
            return GoogleGetUserInfoResponse.ParseResponse(Client.GetUserInfo());
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Initializes a new instance based on the specified OAuth client. The OAuth client must either have an access
        /// token or a server key. Calling this method will not make any calls to the Google Accounts API.
        /// </summary>
        /// <param name="client">The OAuth client.</param>
        public static GoogleService CreateFromOAuthClient(GoogleOAuthClient client) {
            if (String.IsNullOrWhiteSpace(client.AccessToken)) throw new ArgumentException("An access token must be present in the OAuth Client");
            return new GoogleService(client);
        }

        /// <summary>
        /// Initializes a new instance based on an access token. Calling this
        /// method will not make any calls to the Google Accounts API.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        public static GoogleService CreateFromAccessToken(string accessToken) {

            // Initialize a new OAuth client
            GoogleOAuthClient client = new GoogleOAuthClient {
                AccessToken = accessToken
            };

            // Initialize a new service
            return new GoogleService(client);
        
        }

        /// <summary>
        /// Initializes a new instance based on the specified <code>serverKey</code>. The server key is tied to your
        /// app, whereas an access token or refresh token is tied the a specific user of your app. Calling this method
        /// will not make any calls to the Google Accounts API.
        /// </summary>
        /// <param name="serverKey">The server key of your app.</param>
        public static GoogleService CreateFromServerKey(string serverKey) {

            // Initialize a new OAuth client
            GoogleOAuthClient client = new GoogleOAuthClient {
                ServerKey = serverKey
            };

            // Initialize a new service
            return new GoogleService(client);
        
        }

        /// <summary>
        /// Initializes a new instance based on the specified refresh token. The refresh token is used for making a
        /// call to the Google Accounts API to get a new access token. Access tokens typically expire after an hour
        /// (3600 seconds).
        /// </summary>
        /// <param name="clientId">The client ID.</param>
        /// <param name="clientSecret">The client secret.</param>
        /// <param name="refreshToken">The refresh token of the user.</param>
        public static GoogleService CreateFromRefreshToken(string clientId, string clientSecret, string refreshToken) {
            
            // Validation
            if (String.IsNullOrWhiteSpace(clientId)) throw new ArgumentException("Parameter \"clientId\" cannot be NULL or empty", "clientId");
            if (String.IsNullOrWhiteSpace(clientSecret)) throw new ArgumentException("Parameter \"clientSecret\" cannot be NULL or empty", "clientSecret");
            if (String.IsNullOrWhiteSpace(refreshToken)) throw new ArgumentException("Parameter \"refreshToken\" cannot be NULL or empty", "refreshToken");

            // Initialize a new OAuth client with the specified client id and client secret
            GoogleOAuthClient client = new GoogleOAuthClient {
                ClientId = clientId,
                ClientSecret = clientSecret
            };

            // Get a new access token from the specified request token
            GoogleTokenResponse response = client.GetAccessTokenFromRefreshToken(refreshToken);

            // Initialize a new GoogleService instance based on the received access token
            return CreateFromAccessToken(response.Body.AccessToken);

        }

        #endregion

    }

}