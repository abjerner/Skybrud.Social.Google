
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Models;

/// <summary>
/// Class representing a Google account/user. Not all properties may be present since it both
/// depends on the scope of the application as well as what information the user has specified
/// and is sharing.
/// </summary>
public class GoogleUserInfo : GoogleObject {

    #region Properties

    /// <summary>
    /// Gets the ID of the user.
    /// </summary>
    public string Id { get; }

    /// <summary>
    /// Gets the full name of the user.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the given name (first name) of the user.
    /// </summary>
    public string GivenName { get; }

    /// <summary>
    /// Gets the family name (last name) of the user.
    /// </summary>
    public string FamilyName { get; }

    /// <summary>
    /// Gets the URL to the Google+ profile of the user, or <c>null</c> if the user doesn't have a Google+
    /// profile.
    /// </summary>
    public string? Profile { get; }

    /// <summary>
    /// Gets the URL to the profile picture of the user, or <c>null</c> if the user doesn't have a profile
    /// picture.
    /// </summary>
    public string Picture { get; }

    /// <summary>
    /// Gets the email address of the user. The underlying <c>email</c> property is only part of the response
    /// if the <c>email</c> scope has been granted by the user.
    /// </summary>
    public string Email { get; }

    /// <summary>
    /// Gets whether the email address of the user has been verified. The underlying <c>email_verified</c>
    /// property is only part of the response if the <c>email</c> scope has been granted by the user.
    /// </summary>
    public bool IsEmailVerified { get; }

    /// <summary>
    /// Gets the gender of the user.
    /// </summary>
    public string? Gender { get; }

    /// <summary>
    /// Gets the birth date of the user.
    /// </summary>
    public string? Birthdate { get; }

    /// <summary>
    /// Gets the locale of the user.
    /// </summary>
    public string? Locale { get; }

    /// <summary>
    /// Gets the hosted Google Apps domain of the user, or <c>null</c> if the user is not a part of a hosted
    /// domain.
    /// </summary>
    public string? HostedDomain { get; }

    /// <summary>
    /// Gets whether the user is part of a hosted Google Apps domain. The underlying <c>hd</c> property is
    /// only part of the response if the <c>email</c> scope has been granted by the user.
    /// </summary>
    public bool HasHostedDomain => !string.IsNullOrWhiteSpace(HostedDomain);

    /// <summary>
    /// Gets whether the email of the user was part of the properties returned in the response.
    /// </summary>
    public bool HasEmail => !string.IsNullOrWhiteSpace(Email);

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance from the specified <paramref name="json"/> object.
    /// </summary>
    /// <param name="json">The instance of <see cref="JObject"/> representing the object.</param>
    protected GoogleUserInfo(JObject json) : base(json) {
        Id = json.GetString("id")!;
        Name = json.GetString("name")!;
        GivenName = json.GetString("given_name")!;
        FamilyName = json.GetString("family_name")!;
        Profile = json.GetString("profile");
        Picture = json.GetString("picture")!;
        Email = json.GetString("email")!;
        IsEmailVerified = json.GetBoolean("email_verified");
        Gender = json.GetString("gender");
        Birthdate = json.GetString("birthdate");
        Locale = json.GetString("locale");
        HostedDomain = json.GetString("hd");
    }

    #endregion

    #region Static methods

    /// <summary>
    /// Gets a user from the specified <paramref name="json"/> object.
    /// </summary>
    /// <param name="json">The instance of <see cref="JObject"/> to parse.</param>
    /// <returns>An instance of <see cref="GoogleUserInfo"/> representing the user.</returns>
    [return: NotNullIfNotNull("json")]
    public static GoogleUserInfo? Parse(JObject? json) {
        return json == null ? null : new GoogleUserInfo(json);
    }

    #endregion

}