using System;
using Skybrud.Social.Google.Analytics.Endpoints;
using Skybrud.Social.Google.Calendar.Endpoints;
using Skybrud.Social.Google.Common.OAuth;
using Skybrud.Social.Google.Common.Responses;
using Skybrud.Social.Google.Common.Responses.Authentication;
using Skybrud.Social.Google.Drive.Endpoints;
using Skybrud.Social.Google.Geocoding.Endpoints;
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
        /// Gets the endpoint for the Geocoding API.
        /// </summary>
        public GeocodingEndpoint Geocoding { get; private set; }

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
            Geocoding = new GeocodingEndpoint(this);
            Places = new PlacesEndpoint(this);
            YouTube = new YouTubeEndpoint(this);
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets information about the authenticated user.
        /// </summary>
        /// <returns>An instance of <see cref="GoogleGetUserInfoResponse"/> representing the response.</returns>
        public GoogleGetUserInfoResponse GetUserInfo() {
            return GoogleGetUserInfoResponse.ParseResponse(Client.GetUserInfo());
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Initializes a new instance based on the specified OAuth <paramref name="client"/>.
        /// </summary>
        /// <param name="client">The OAuth client.</param>
        /// <returns>An instance of <see cref="GoogleService"/>.</returns>
        public static GoogleService CreateFromOAuthClient(GoogleOAuthClient client) {

            // Validate the OAuth client
            if (client == null) throw new ArgumentNullException("client");

            // Initialize a new service
            return new GoogleService(client);
        
        }

        /// <summary>
        /// Initializes a new instance based on an access token. Calling this method will not make any calls to the
        /// Google Accounts API.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <returns>An instance of <see cref="GoogleService"/>.</returns>
        public static GoogleService CreateFromAccessToken(string accessToken) {

            // Validate the server key
            if (String.IsNullOrWhiteSpace(accessToken)) throw new ArgumentNullException("accessToken");

            // Initialize a new OAuth client
            GoogleOAuthClient client = new GoogleOAuthClient {
                AccessToken = accessToken
            };

            // Initialize a new service
            return new GoogleService(client);
        
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="serverKey"/>. The server key is tied to
        /// your app, whereas an access token or refresh token is tied the a specific user of your app. Calling this
        /// method will not make any calls to the Google Accounts API.
        /// </summary>
        /// <param name="serverKey">The server key of your app.</param>
        /// <returns>An instance of <see cref="GoogleService"/>.</returns>
        public static GoogleService CreateFromServerKey(string serverKey) {

            // Validate the server key
            if (String.IsNullOrWhiteSpace(serverKey)) throw new ArgumentNullException("serverKey");

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
            if (String.IsNullOrWhiteSpace(clientId)) throw new ArgumentNullException("clientId");
            if (String.IsNullOrWhiteSpace(clientSecret)) throw new ArgumentNullException("clientSecret");
            if (String.IsNullOrWhiteSpace(refreshToken)) throw new ArgumentNullException("refreshToken");

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