using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// The referring-policy used for the navigation.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ReferrerPolicy
	{
			NoReferrer,
			NoReferrerWhenDowngrade,
			Origin,
			OriginWhenCrossOrigin,
			SameOrigin,
			StrictOrigin,
			StrictOriginWhenCrossOrigin,
			UnsafeUrl,
	}
}
