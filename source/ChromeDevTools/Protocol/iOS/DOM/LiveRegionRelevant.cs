using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM{
	/// <summary>
	/// Token values of @aria-relevant attribute.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LiveRegionRelevant
	{
			Additions,
			Removals,
			Text,
	}
}
