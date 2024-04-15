using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CookieWarningReason
	{
			WarnSameSiteUnspecifiedCrossSiteContext,
			WarnSameSiteNoneInsecure,
			WarnSameSiteUnspecifiedLaxAllowUnsafe,
			WarnSameSiteStrictLaxDowngradeStrict,
			WarnSameSiteStrictCrossDowngradeStrict,
			WarnSameSiteStrictCrossDowngradeLax,
			WarnSameSiteLaxCrossDowngradeStrict,
			WarnSameSiteLaxCrossDowngradeLax,
			WarnAttributeValueExceedsMaxSize,
			WarnDomainNonASCII,
	}
}
