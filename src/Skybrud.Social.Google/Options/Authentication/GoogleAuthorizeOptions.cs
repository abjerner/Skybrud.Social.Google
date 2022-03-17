using System;
using System.Linq;
using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Strings;
using Skybrud.Social.Google.OAuth;
using Skybrud.Social.Google.Scopes;

namespace Skybrud.Social.Google.Options.Authentication {

    /// <summary>
    /// Options for authorizing using the OAuth server-side web app flow.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/identity/protocols/OAuth2WebServer</cref>
    /// </see>
    public class GoogleAuthorizeOptions {

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public GoogleAuthorizeOptions() { }

        /// <summary>
        /// Initializes a new instance with the specified options.
        /// </summary>
        /// <param name="state">The state of the application.</param>
        /// <param name="scope">The scope of the application.</param>
        public GoogleAuthorizeOptions(string state, string scope) {
            State = state;
            Scope = new GoogleScope(scope);
        }

        /// <summary>
        /// Initializes a new instance with the specified options.
        /// </summary>
        /// <param name="state">The state of the application.</param>
        /// <param name="scope">The scope of the application.</param>
        /// <param name="accessType">Whether the application should be enabled for offline access.</param>
        public GoogleAuthorizeOptions(string state, string scope, GoogleAccessType accessType) {
            State = state;
            Scope = new GoogleScope(scope);
            AccessType = accessType;
        }

        /// <summary>
        /// Initializes a new instance with the specified options.
        /// </summary>
        /// <param name="state">The state of the application.</param>
        /// <param name="scope">The scope of the application.</param>
        /// <param name="accessType">Whether the application should be enabled for offline access.</param>
        /// <param name="prompt">A list of prompts to present the user. If <see cref="GooglePromptOption.None"/>, the user will be prompted only the first time your app requests access.</param>
        public GoogleAuthorizeOptions(string state, string scope, GoogleAccessType accessType, GooglePromptOption prompt) {
            State = state;
            Scope = new GoogleScope(scope);
            AccessType = accessType;
            Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance with the specified options.
        /// </summary>
        /// <param name="state">The state of the application.</param>
        /// <param name="scope">The scope of the application.</param>
        public GoogleAuthorizeOptions(string state, GoogleScopeList scope) {
            State = state;
            Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance with the specified options.
        /// </summary>
        /// <param name="state">The state of the application.</param>
        /// <param name="scope">The scope of the application.</param>
        /// <param name="accessType">Whether the application should be enabled for offline access.</param>
        public GoogleAuthorizeOptions(string state, GoogleScopeList scope, GoogleAccessType accessType) {
            State = state;
            Scope = scope;
            AccessType = accessType;
        }

        /// <summary>
        /// Initializes a new instance with the specified options.
        /// </summary>
        /// <param name="state">The state of the application.</param>
        /// <param name="scope">The scope of the application.</param>
        /// <param name="accessType">Whether the application should be enabled for offline access.</param>
        /// <param name="prompt">A list of prompts to present the user. If <see cref="GooglePromptOption.None"/>, the user will be prompted only the first time your app requests access.</param>
        public GoogleAuthorizeOptions(string state, GoogleScopeList scope, GoogleAccessType accessType, GooglePromptOption prompt) {
            State = state;
            Scope = scope;
            AccessType = accessType;
            Prompt = prompt;
        }

        #region Properties

        /// <summary>
        /// A list of scopes that identify the resources that your application could access on the user's behalf. These
        /// values inform the consent screen that Google displays to the user.
        /// 
        /// Scopes enable your application to only request access to the resources that it needs while also enabling
        /// users to control the amount of access that they grant to your application.Thus, there is an inverse
        /// relationship between the number of scopes requested and the likelihood of obtaining user consent.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/identity/protocols/googlescopes</cref>
        /// </see>
        public GoogleScopeList Scope { get; set; }

        /// <summary>
        /// Indicates whether your application can refresh access tokens when the user is not present at the browser.
        /// Valid parameter values are <see cref="GoogleAccessType.Online"/>, which is the default value, and
        /// <see cref="GoogleAccessType.Offline"/>.
        ///
        /// Set the value to <see cref="GoogleAccessType.Offline"/> if your application needs to refresh access tokens
        /// when the user is not present at the browser. This value instructs the Google authorization server to return
        /// a refresh token and an access token the first time that your application exchanges an authorization code
        /// for tokens.
        /// </summary>
        public GoogleAccessType AccessType { get; set; }

        /// <summary>
        /// Specifies any string value that your application uses to maintain state between your authorization request
        /// and the authorization server's response.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Enables applications to use incremental authorization to request access to additional scopes in context. If
        /// you set this parameter's value to <c>true</c> and the authorization request is granted, then the new access
        /// token will also cover any scopes to which the user previously granted the application access.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/identity/protocols/OAuth2WebServer#incrementalAuth</cref>
        /// </see>
        public bool IncludeGrantedScopes { get; set; }

        /// <summary>
        /// If your application knows which user is trying to authenticate, it can use this parameter to provide a hint
        /// to the Google Authentication Server. The server uses the hint to simplify the login flow either by
        /// prefilling the email field in the sign-in form or by selecting the appropriate multi-login session.
        ///
        /// Set the parameter value to an email address or sub identifier, which is equivalent to the user's Google ID.
        /// </summary>
        public string LoginHint { get; set; }

        /// <summary>
        /// A list of prompts to present the user. If you don't specify this parameter, the user will be prompted only
        /// the first time your app requests access.
        /// </summary>
        public GooglePromptOption Prompt { get; set; }

        #endregion

        #region Member methods

        internal IHttpQueryString GetQueryString(GoogleOAuthClient client) {

            // Validate the required parameters and properties
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrWhiteSpace(State)) throw new PropertyNotSetException(nameof(State));
            if (string.IsNullOrWhiteSpace(client.ClientId)) throw new PropertyNotSetException(nameof(client.ClientId));
            if (string.IsNullOrWhiteSpace(client.RedirectUri)) throw new PropertyNotSetException(nameof(client.RedirectUri));

            // Generate the query string
            IHttpQueryString query = new HttpQueryString();

            query.Add("response_type", "code");
            query.Add("client_id", client.ClientId);
            query.Add("access_type", StringUtils.ToUnderscore(AccessType));
            query.Add("prompt", ToString(Prompt));
            query.Add("scope", Scope + string.Empty);
            query.Add("redirect_uri", client.RedirectUri);
            query.Add("state", State);

            return query;

        }

        private string ToString(GooglePromptOption prompt) {
            return string.Join(",", prompt.ToString().Split(',').Select(StringUtils.ToUnderscore));
        }

        #endregion

    }

}