using System;
using System.Collections.Generic;
using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Client;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Social.Google.Http;
using Skybrud.Social.Google.Options.Authentication;
using Skybrud.Social.Google.Responses.Authentication;
using Skybrud.Social.Google.Scopes;

namespace Skybrud.Social.Google.OAuth;

/// <summary>
/// A client for handling the communication with the Google APIs using OAuth 2.0. The client is also responsible
/// for the raw communication with the various Google APIs.
/// </summary>
public class GoogleOAuthClient : HttpClient {

    private readonly Dictionary<Type, GoogleHttpClientBase> _apis = new();

    #region Properties

    /// <summary>
    /// Gets or sets the ID of the client/application.
    /// </summary>
    public string? ClientId { get; set; }

    /// <summary>
    /// Gets or sets the the secret of the client/application. Guard this with your life!
    /// </summary>
    public string? ClientSecret { get; set; }

    /// <summary>
    /// Gets or sets the redirect URL. Must be specified in Google's APIs console.
    /// </summary>
    public string? RedirectUri { get; set; }

    /// <summary>
    /// Gets or sets the access token.
    /// </summary>
    public string? AccessToken { get; set; }

    /// <summary>
    /// Gets or sets the API key.
    /// </summary>
    public string? ApiKey { get; set; }

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
    public string GetAuthorizationUrl(string state, string scope) {
        return GetAuthorizationUrl(new GoogleAuthorizeOptions(state, scope));
    }


    /// <summary>
    /// Gets the authorization URL at accounts.google.com for your application.
    /// </summary>
    /// <param name="state">The state of the application.</param>
    /// <param name="scope">The scope of the application.</param>
    /// <param name="offline">Whether the application should be enabled for offline access.</param>
    public string GetAuthorizationUrl(string state, string scope, bool offline) {
        return GetAuthorizationUrl(new GoogleAuthorizeOptions(state, scope, offline ? GoogleAccessType.Offline : GoogleAccessType.Online));
    }

    /// <summary>
    /// Gets the authorization URL at accounts.google.com for your application.
    /// </summary>
    /// <param name="state">The state of the application.</param>
    /// <param name="scope">The scope of the application.</param>
    public string GetAuthorizationUrl(string state, GoogleScopeList scope) {
        return GetAuthorizationUrl(new GoogleAuthorizeOptions(state, scope));
    }

    /// <summary>
    /// Gets the authorization URL at accounts.google.com for your application.
    /// </summary>
    /// <param name="state">The state of the application.</param>
    /// <param name="scope">The scope of the application.</param>
    /// <param name="offline">Whether the application should be enabled for offline access.</param>
    public string GetAuthorizationUrl(string state, GoogleScopeList scope, bool offline) {
        return GetAuthorizationUrl(new GoogleAuthorizeOptions(state, scope, offline ? GoogleAccessType.Offline : GoogleAccessType.Online));
    }

    /// <summary>
    /// Gets the authorization URL at accounts.google.com for your application.
    /// </summary>
    /// <param name="state">The state of the application.</param>
    /// <param name="scope">The scope of the application.</param>
    /// <param name="accessType">Whether the application should be enabled for offline access.</param>
    /// <param name="prompt">A list of prompts to present the user. If <see cref="GooglePromptOption.None"/>, the user will be prompted only the first time your app requests access.</param>
    public string GetAuthorizationUrl(string state, string scope, GoogleAccessType accessType, GooglePromptOption prompt) {
        return GetAuthorizationUrl(new GoogleAuthorizeOptions(state, scope, accessType, prompt));
    }

    /// <summary>
    /// Gets the authorization URL at accounts.google.com for your application.
    /// </summary>
    /// <param name="state">The state of the application.</param>
    /// <param name="scope">The scope of the application.</param>
    /// <param name="accessType">Whether the application should be enabled for offline access.</param>
    /// <param name="prompt">A list of prompts to present the user. If <see cref="GooglePromptOption.None"/>, the user will be prompted only the first time your app requests access.</param>
    public string GetAuthorizationUrl(string state, GoogleScopeList scope, GoogleAccessType accessType, GooglePromptOption prompt) {
        return GetAuthorizationUrl(new GoogleAuthorizeOptions(state, scope, accessType, prompt));
    }

    /// <summary>
    /// Gets the authorization URL at accounts.google.com for your application.
    /// </summary>
    /// <param name="options">The options for generating an authorization URL.</param>
    public string GetAuthorizationUrl(GoogleAuthorizeOptions options) {
        if (options == null) throw new ArgumentNullException(nameof(options));
        return "https://accounts.google.com/o/oauth2/auth?" + options.GetQueryString(this);
    }

    /// <summary>
    /// Returns an instance of <see cref="GoogleTokenResponse"/> with information about an access token exchanged
    /// from the specified authorization <paramref name="code"/>.
    /// </summary>
    /// <param name="code">The authorization code.</param>
    /// <returns>An instance of  <see cref="GoogleTokenResponse"/>.</returns>
    public GoogleTokenResponse GetAccessTokenFromAuthorizationCode(string code) {

        // Validate the required parameters and properties
        if (string.IsNullOrWhiteSpace(code)) throw new ArgumentNullException(nameof(code));
        if (string.IsNullOrWhiteSpace(ClientId)) throw new PropertyNotSetException(nameof(ClientId));
        if (string.IsNullOrWhiteSpace(ClientSecret)) throw new PropertyNotSetException(nameof(ClientSecret));
        if (string.IsNullOrWhiteSpace(RedirectUri)) throw new PropertyNotSetException(nameof(RedirectUri));

        // Declare the POST data
        IHttpPostData postData = new HttpPostData();
        postData.Add("code", code);
        postData.Add("client_id", ClientId!);
        postData.Add("client_secret", ClientSecret!);
        postData.Add("redirect_uri", RedirectUri!);
        postData.Add("grant_type", "authorization_code");

        // Initialize the request
        HttpRequest request = HttpRequest.Post("https://accounts.google.com/o/oauth2/token", postData);

        // Make the request to the server
        IHttpResponse response = request.GetResponse();

        // Parse the JSON response
        return new GoogleTokenResponse(response);

    }

    /// <summary>
    /// Returns an instance of <see cref="GoogleTokenResponse"/> with information about an access token exchanged
    /// from the specified <paramref name="refreshToken"/>.
    /// </summary>
    /// <param name="refreshToken">The refresh token to exchange for a new access token.</param>
    /// <returns>An instance of  <see cref="GoogleTokenResponse"/>.</returns>
    public GoogleTokenResponse GetAccessTokenFromRefreshToken(string refreshToken) {

        // Validate the required parameters and properties
        if (string.IsNullOrWhiteSpace(refreshToken)) throw new ArgumentNullException(nameof(refreshToken));
        if (string.IsNullOrWhiteSpace(ClientId)) throw new PropertyNotSetException(nameof(ClientId));
        if (string.IsNullOrWhiteSpace(ClientSecret)) throw new PropertyNotSetException(nameof(ClientSecret));

        // Declare the POST data
        IHttpPostData postData = new HttpPostData();
        postData.Add("client_id", ClientId!);
        postData.Add("client_secret", ClientSecret!);
        postData.Add("refresh_token", refreshToken);
        postData.Add("grant_type", "refresh_token");

        // Initialize the request
        HttpRequest request = HttpRequest.Post("https://accounts.google.com/o/oauth2/token", postData);

        // Make the request to the server
        IHttpResponse response = request.GetResponse();

        // Parse the JSON response
        return new GoogleTokenResponse(response);

    }

    /// <summary>
    /// Gets information about the authenticated user.
    /// </summary>
    public IHttpResponse GetUserInfo() {
        return Get("https://www.googleapis.com/oauth2/v2/userinfo");
    }

    /// <summary>
    /// Returns the raw API implementation of type <typeparamref name="T"/>.
    ///
    /// If an implementation of type <typeparamref name="T"/> hasn't yet been registered,
    /// <paramref name="callback"/> will be used to initialize and register an implementation.
    /// </summary>
    /// <typeparam name="T">The type of the raw API implementation.</typeparam>
    /// <param name="callback"></param>
    /// <returns>An instance of <typeparamref name="T"/>.</returns>
    public T GetHttpClient<T>(Func<T> callback) where T : GoogleHttpClientBase {
        Type type = typeof(T);
        if (_apis.TryGetValue(type, out GoogleHttpClientBase api)) return (T) api;
        T e = callback();
        _apis.Add(type, e);
        return e;
    }

    /// <summary>
    /// Virtual method that can be used for configuring a request.
    /// </summary>
    /// <param name="request">The instance of <see cref="IHttpRequest"/> representing the request.</param>
    protected override void PrepareHttpRequest(IHttpRequest request) {

        // Append the access token or server if specified
        if (!string.IsNullOrWhiteSpace(AccessToken)) {
            // TODO: Specify access token in HTTP header instead
            request.QueryString.Set("access_token", AccessToken!);
        } else if (!string.IsNullOrWhiteSpace(ApiKey)) {
            request.QueryString.Set("key", ApiKey!);
        }

        // Prepend scheme and host name if not already specified
        if (request.Url.StartsWith("/")) request.Url = $"https://www.googleapis.com{request.Url}";

    }

    internal void PrepareHttpRequestInternal(IHttpRequest request) {

        // As the "PrepareHttpRequest" method is protected, we need an internal "shortcut" method in order to call
        // it from the "GoogleHttpClientBase" class

        PrepareHttpRequest(request);

    }

    #endregion

}