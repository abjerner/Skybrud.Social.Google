using System;
using System.Collections.Generic;
using Skybrud.Social.Google.OAuth;
using Skybrud.Social.Google.Responses;
using Skybrud.Social.Google.Responses.Authentication;

namespace Skybrud.Social.Google;

/// <summary>
/// Class working as an entry point to the Google APIs.
/// </summary>
public class GoogleHttpService {

    private readonly Dictionary<Type, GoogleHttpServiceBase> _services = new();

    #region Properties

    /// <summary>
    /// Gets a reference to the internal OAuth client.
    /// </summary>
    public GoogleOAuthClient Client { get; }

    #endregion

    #region Constructors

    private GoogleHttpService(GoogleOAuthClient client) {
        Client = client;
    }

    #endregion

    #region Member methods

    /// <summary>
    /// Gets information about the authenticated user.
    /// </summary>
    /// <returns>An instance of <see cref="GoogleUserInfoResponse"/> representing the response.</returns>
    public GoogleUserInfoResponse GetUserInfo() {
        return new(Client.GetUserInfo());
    }

    #endregion

    #region Static methods

    /// <summary>
    /// Initializes a new instance based on the specified OAuth <paramref name="client"/>.
    /// </summary>
    /// <param name="client">The OAuth client.</param>
    /// <returns>An instance of <see cref="GoogleHttpService"/>.</returns>
    public static GoogleHttpService CreateFromOAuthClient(GoogleOAuthClient client) {

        // Validate the OAuth client
        if (client == null) throw new ArgumentNullException(nameof(client));

        // Initialize a new service
        return new GoogleHttpService(client);

    }

    /// <summary>
    /// Initializes a new instance based on an access token. Calling this method will not make any calls to the
    /// Google Accounts API.
    /// </summary>
    /// <param name="accessToken">The access token.</param>
    /// <returns>An instance of <see cref="GoogleHttpService"/>.</returns>
    public static GoogleHttpService CreateFromAccessToken(string accessToken) {

        // Validate the server key
        if (string.IsNullOrWhiteSpace(accessToken)) throw new ArgumentNullException(nameof(accessToken));

        // Initialize a new OAuth client
        GoogleOAuthClient client = new() {
            AccessToken = accessToken
        };

        // Initialize a new service
        return new GoogleHttpService(client);

    }

    /// <summary>
    /// Initializes a new instance based on the specified <paramref name="apiKey"/>. The API key is tied to
    /// your app, whereas an access token or refresh token is tied the a specific user of your app. Calling this
    /// method will not make any calls to the Google Accounts API.
    /// </summary>
    /// <param name="apiKey">The API key of your app.</param>
    /// <returns>An instance of <see cref="GoogleHttpService"/>.</returns>
    public static GoogleHttpService CreateFromApiKey(string apiKey) {

        // Validate the server key
        if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException(nameof(apiKey));

        // Initialize a new OAuth client
        GoogleOAuthClient client = new() {
            ApiKey = apiKey
        };

        // Initialize a new service
        return new GoogleHttpService(client);

    }

    /// <summary>
    /// Initializes a new instance based on the specified refresh token. The refresh token is used for making a
    /// call to the Google Accounts API to get a new access token. Access tokens typically expire after an hour
    /// (3600 seconds).
    /// </summary>
    /// <param name="clientId">The client ID.</param>
    /// <param name="clientSecret">The client secret.</param>
    /// <param name="refreshToken">The refresh token of the user.</param>
    public static GoogleHttpService CreateFromRefreshToken(string clientId, string clientSecret, string refreshToken) {

        // Validation
        if (string.IsNullOrWhiteSpace(clientId)) throw new ArgumentNullException(nameof(clientId));
        if (string.IsNullOrWhiteSpace(clientSecret)) throw new ArgumentNullException(nameof(clientSecret));
        if (string.IsNullOrWhiteSpace(refreshToken)) throw new ArgumentNullException(nameof(refreshToken));

        // Initialize a new OAuth client with the specified client id and client secret
        GoogleOAuthClient client = new() {
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
    public T GetHttpService<T>(Func<T> callback) where T : GoogleHttpServiceBase {
        Type type = typeof(T);
        if (_services.TryGetValue(type, out GoogleHttpServiceBase endpoint)) return (T) endpoint;
        T e = callback();
        _services.Add(type, e);
        return e;
    }

    #endregion

}