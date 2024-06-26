using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// Types of reasons why a cookie may not be stored from a response.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SetCookieBlockedReason
	{
			SecureOnly,
			SameSiteStrict,
			SameSiteLax,
			SameSiteUnspecifiedTreatedAsLax,
			SameSiteNoneInsecure,
			UserPreferences,
			ThirdPartyBlockedInFirstPartySet,
			SyntaxError,
			SchemeNotSupported,
			OverwriteSecure,
			InvalidDomain,
			InvalidPrefix,
			UnknownError,
			SchemefulSameSiteStrict,
			SchemefulSameSiteLax,
			SchemefulSameSiteUnspecifiedTreatedAsLax,
			SamePartyFromCrossPartyContext,
			SamePartyConflictsWithOtherAttributes,
			NameValuePairExceedsMaxSize,
	}
}
