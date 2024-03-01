---
order: -8
---

# Authentication

When authenticating with Google, you must send a number of parameters to the authentication page. Some of these parameters are required, while some are just optional:

### State

The state is a somewhat random and/or auto-generated value that identifies the user at your site. A good state will only be valid for a short amount of time, and unable to be used multiple times.

### Scope

The scope specifies which privileges your app will have to any users who authenticate your app. You can read more about scopes <a href="./scope/">here</a>.

### Access Type
*Optional.* It is possible to specify an `access type`, which can be set to either `online` (default) or `offline`.

When requesting online access, the OAuth authentication will only return an access token that expires after about an hour. This is typically used when you need to do something only when users does something on your site. If the access token expires, the user must re-authenticate.

On the other hand, if you have to do something in the background on a regular basis and the user is present in the browser (at your site), you can request offline access. If the user hasn't already authorized your app, a successful authentication will give you an access token as before that expires after about an hour - but now also a refresh token that won't expire unless the user deauthorizes your app. A refresh token can then be used to acquire new access tokens. However depending on the parameters send to the OAuth dialog, you might now get a refresh token if the user already has authorized your app - therefore see the text about `Approval Prompt` below.

### Approval Prompt
*Optional.* By default the Google OAuth dialog will only prompt the user with scopes that the user hasn't already approved. By setting the approval prompt parameter to `force` rather than the default `auto`, the user will always be prompted to authorize your app even if he/she has done so before.

When setting the access type to `offline` and the approval prompt to `auto` the authentication will not return a refresh token if the user already has authorized your app. On the other hand, when setting approval prompt to `force`, the authorization will return an new refresh token while any previously valid refresh tokens are valid as well. Deauthorizing your app will however invalidate all refresh tokens for the user.

### Read more

While I have tried to cover the basics on this page, it is recommended to have a look at Google's own documentation:

<ul>
  <li>
    <a href="https://developers.google.com/identity/protocols/OAuth2" target="_blank">Using OAuth 2.0 to Access Google APIs</a>
    <ul>
      <li>
        <a href="https://developers.google.com/identity/protocols/OAuth2#expiration" target="_blank">Token expiration</a>
      </li>
    </ul>
  </li>
</ul>




## Setting up an authentication page

The first step in order to set up an authentication page is to register a new project with Google through the <a href="https://console.developers.google.com/" target="_blank">Google Developer Console</a> (or simply use an existing project).

Once you have created or found your project, go to *Credentials*, click the *Create credentials* dropdown, and then select *OAuth client ID*.

![image](https://cloud.githubusercontent.com/assets/3634580/17412732/89c2af02-5a7e-11e6-8628-16d09bb6d71d.png)

You will then be asked to specify the type of your application, which for this example is *Web application*. Once the type is selected, you will be given the option to specify a name for the credentials - you could name it something like *OAuth Login with Skybrud.Social*.

![image](https://cloud.githubusercontent.com/assets/3634580/17413046/fcf7ec70-5a7f-11e6-9940-ef5bf83e701e.png)

When using OAuth 2.0, we also need to specify a redirect URI (which is the URI the user is redirected back to after a successful or failed login). In my case, the login page is located at `http://localhost:63510/login/`, so I have added this under *Authorized redirect URIs*. Since our login is server based, we don't need to specify anything for *Authorized JavaScript origins*.

Once you click the **Create** button, your OAuth credentials will be created, and you will be prompted with your **client ID** and **client secret**, which we need in our code.



### Getting started with the code
When the project/app is correctly configured, we can start setting up the actual authentication page. Here, the first step is to create a new instance of the `GoogleOAuthClient` class and populate the properties we need for the authentication:

```csharp
// Initialize a new instance of the OAuth client
GoogleOAuthClient oauth = new GoogleOAuthClient {
    ClientId = "The client ID of your project",
    ClientSecret = "The client secret of your project",
    RedirectUri = "The return URI (where users should be redirected after the login)"
};
```

We can then generate the authorization URL (the URL of Google's authentication including the properties identifying your project):

```csharp
// Construct the authorization URL
string authorizationUrl = oauth.GetAuthorizationUrl(state, GoogleScopes.Email, GoogleAccessType.Offline);
```

For the `GetAuthorizationUrl` method, the first parameter is a state, which is specified for security purposes, and should be something that uniquely identities the user on your site.

The second parameter is one or more scopes (permissions) the user will be requested to grant your app. In the example above, I have specified `GoogleScopes.Email`, which lets us retrieve the email of the authenticated user. To specify multiple scopes, simply do like this:

```csharp
// Construct the authorization URL
string authorizationUrl = oauth.GetAuthorizationUrl(state, GoogleScopes.Email + GoogleScopes.Profile, GoogleAccessType.Offline);
```

This time, we'll also request the user to grant us access to basic profile information. You can more about scopes <a href="./scope/">**here**</a>.

The third parameter is the access type explained earlier on this page, which specifies whether we want the user to authenticate for *offline* or *online* access. For this example, we will just focus on *offline* access.

Optionally we can also specify a fourth parameter to indicate whether we should force the user to re-approve our app when already logged in with his/her Google account.

If we wanted both *online* access and force the user to re-approve the next time he/she logs into our page, the code could look like:

```csharp
// Construct the authorization URL
string authorizationUrl = oauth.GetAuthorizationUrl(state, GoogleScopes.Email, GoogleAccessType.Online, GoogleApprovalPrompt.Force);
```

### Handling the callback
Following a successful (or failed) authentication with the Google API, the user is redirected back to our login page (equal to the value of the `RedirectUri` property we specified for our `GoogleOAuthClient` instance earlier).

If the authentication was successful, a `code` parameter will be specified in the query string containing the authorization code. We can then exchange this authorization code for an access token:

```csharp
// Exchange the authorization code for an access token
string code = Request.QueryString["code"];

// Make the request to the Google API
GoogleAccessTokenResponse response = oauth.GetAccessTokenFromAuthorizationCode(code);

// Get the access token from the response body
string accessToken = response.AccessToken;
```

You can then store the access token in a session for the user or something similar. Just keep in mind to store it securely, since it gives access to information about the user (how much depends on the scope the user granted).

If the authentication fails while the user is at Google's authentication page, the user is also redirected back to our login page, but instead with an `error` parameter in the query string. This parameter will then contain a semi-readable error code - eg. `access_denied` if the user cancels the authentication.



### Making calls to the API using the access token
If you have setup an authentication page like in this example for letting users log into your site, you most likely also wish to get some information about each user. For this we need to create a new instance of the `GoogleHttpService` class based on the access token of each user who logs in:

```csharp
// Initialize a new instance of the GoogleHttpService class so we can make calls to the API
GoogleHttpService service = GoogleHttpService.CreateFromAccessToken(accessToken);
```

We can then get basic information about the authenticated user like:

```cshtml
// Make a call to the API to get information about the authenticated user
GoogleUserInfo user = service.GetUserInfo();

<div class="alert alert-info">
    <strong>ID:</strong> @user.Id<br />
    <strong>Name:</strong> @user.Name<br />
    <strong>Email:</strong> @user.Email
</div>
```





### Full example

To summarize the steps described above, here is a full example (implemented in a partial Razor view):

```cshtml
@using Skybrud.Social.Google
@using Skybrud.Social.Google.OAuth
@inherits WebViewPage
              
@{

    // Initialize a new instance of the OAuth client
    GoogleOAuthClient oauth = new GoogleOAuthClient {
        ClientId = "The client ID of your project",
        ClientSecret = "The client secret of your project",
        RedirectUri = "The return URI (where users should be redirected after the login)"
    };

    // Read some input from the query string
    string code = Request.QueryString["code"];
    string action = Request.QueryString["do"];
    string error = Request.QueryString["error"];


    // Handle the state when the user clicks our login button
    if (action == "login") {

        // Get the redirect URI (if present)
        string redirect = (Request.QueryString["redirect"] ?? "/");

        // Set the state (a unique/random value)
        string state = Guid.NewGuid().ToString();
        Session["Google_" + state] = redirect;

        // Construct the authorization URL
        string authorizationUrl = oauth.GetAuthorizationUrl(state, GoogleScopes.Email + GoogleScopes.Profile, GoogleAccessType.Online, GoogleApprovalPrompt.Force);

        // Redirect the user to the OAuth dialog
        Response.Redirect(authorizationUrl);
        return;

    }

    // Handle if an error occurs during the Google authentication (eg. if the user cancels the login)
    if (!String.IsNullOrWhiteSpace(error)) {
        <div class="alert alert-danger">
            <strong>Login failed</strong><br />
            Error received from Google: @error
        </div>
        return;
    }

    // Handle the state when the user is redirected back to our page after a successful login with the Google API
    if (!String.IsNullOrWhiteSpace(code)) {

        // Get the state from the query string
        string state = Request.QueryString["state"];

        // Validate state - Step 1
        if (state == null) {
            <div class="alert alert-danger">No <strong>state</strong> specified in the query string.</div>
            return;
        }

        // Validate state - Step 2
        string session = Session["Google_" + state] as string;
        if (session == null) {
            <div class="alert alert-danger">Session expired?</div>
            return;
        }

        // Remove the state from the session
        Session.Remove("Google_" + state);

        // Exchange the authorization code for an access token
        GoogleAccessTokenResponse response = oauth.GetAccessTokenFromAuthorizationCode(code);
        string accessToken = response.AccessToken;
        
        // Print out the access token to the user (we really shouldn't do this in a live environment)
        <div class="alert alert-info">
            <strong>Access token:</strong> @accessToken
        </div>

        // Initialize a new instance of the GoogleService class so we can make calls to the API
        GoogleService service = GoogleService.CreateFromAccessToken(accessToken);

        // Make a call to the API to get information about the authenticated user
        GoogleUserInfo user = service.GetUserInfo();

        <div class="alert alert-info">
            <strong>ID:</strong> @user.Id<br />
            <strong>Name:</strong> @user.Name<br />
            <strong>Email:</strong> @user.Email
        </div>

        return;

    }

    <a href="?do=login" class="btn btn-primary">Login with Google</a>
    
}
```