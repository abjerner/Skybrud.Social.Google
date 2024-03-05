using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Skybrud.Social.Google.Attributes;

namespace Skybrud.Social.Google.Scopes;

/// <summary>
/// Class representing a group of scopes. A group could for instance contain all scopes relevant to the Analytics
/// APIs, while another group could contain all scopes relevant to the YouTube APIs.
/// </summary>
public class GoogleScopeGroup {

    #region Properties

    /// <summary>
    /// Gets the name of the group.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; }

    /// <summary>
    /// Gets an array with the scopes of the group.
    /// </summary>
    [JsonProperty("scopes")]
    public GoogleScope[] Scopes { get; }

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new group with the specified <paramref name="name"/> and <paramref name="scopes"/>.
    /// </summary>
    /// <param name="name">The name of the group.</param>
    /// <param name="scopes">An array with the scopes that should make up the group.</param>
    public GoogleScopeGroup(string name, GoogleScope[] scopes) {
        Name = name;
        Scopes = scopes;
    }

    #endregion

    #region Static methods

#if I_CAN_HAS_APP_DOMAIN

    /// <summary>
    /// Gets an array of all known Google scopes.
    /// </summary>
    /// <returns>An array of <see cref="GoogleScopeGroup"/>.</returns>
    public static GoogleScopeGroup[] GetAll() {

        var types = (
            from a in AppDomain.CurrentDomain.GetAssemblies()
            from t in a.GetTypes()
            let attributes = t.GetCustomAttributes(typeof(GoogleScopesAttribute), false)
            where attributes is { Length: > 0 }
            select new { Type = t, Attribute = attributes.Cast<GoogleScopesAttribute>().First() }
        ).OrderBy(x => x.Attribute.Weight).ThenBy(x => x.Attribute.Name);

        List<GoogleScopeGroup> groups = new();

        foreach (var type in types) {

            FieldInfo? field = type.Type.GetField("All", BindingFlags.Static | BindingFlags.Public);
            if (field == null) continue;

            GoogleScope[] value = (GoogleScope[]) field.GetValue(null);

            groups.Add(new GoogleScopeGroup(type.Attribute.Name, value));

        }

        return groups.ToArray();

    }

#endif

    #endregion

}