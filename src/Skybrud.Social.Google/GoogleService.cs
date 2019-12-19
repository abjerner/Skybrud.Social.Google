using System;
using System.Collections.Generic;
using Skybrud.Social.Google.OAuth;
using Skybrud.Social.Google.Responses;
using Skybrud.Social.Google.Responses.Authentication;

namespace Skybrud.Social.Google {

    /// <summary>
    /// Class working as an entry point to the Google APIs.
    /// </summary>
    public class GoogleService {

        private readonly Dictionary<Type, GoogleApiServiceBase> _services = new Dictionary<Type, GoogleApiServiceBase>();

        #region Properties

        /// <summary>
        /// Gets a reference to the internal OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; }

        #endregion

        #region Constructors

        private GoogleService(GoogleOAuthClient client) {
            Client = client;
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
            if (client == null) throw new ArgumentNullException(nameof(client));

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
            if (string.IsNullOrWhiteSpace(accessToken)) throw new ArgumentNullException(nameof(accessToken));

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
            if (string.IsNullOrWhiteSpace(serverKey)) throw new ArgumentNullException(nameof(serverKey));

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
            if (string.IsNullOrWhiteSpace(clientId)) throw new ArgumentNullException(nameof(clientId));
            if (string.IsNullOrWhiteSpace(clientSecret)) throw new ArgumentNullException(nameof(clientSecret));
            if (string.IsNullOrWhiteSpace(refreshToken)) throw new ArgumentNullException(nameof(refreshToken));

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

        /// <summary>
        /// Returns the API implementation of type <typeparamref name="T"/>.
        ///
        /// If an implementation of type <typeparamref name="T"/> hasn't yet been registered,
        /// <paramref name="callback"/> will be used to initialize and register an implementation.
        /// </summary>
        /// <typeparam name="T">The type of the API implementation.</typeparam>
        /// <param name="callback"></param>
        /// <returns>An instance of <typeparamref name="T"/>.</returns>
        public T GetApiService<T>(Func<T> callback) where T : GoogleApiServiceBase {
            Type type = typeof(T);
            if (_services.TryGetValue(type, out GoogleApiServiceBase endpoint)) return (T) endpoint;
            T e = callback();
            _services.Add(type, e);
            return e;
        }

        #endregion

    }

}