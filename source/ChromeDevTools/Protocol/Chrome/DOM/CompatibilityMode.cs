using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM{
	/// <summary>
	/// Document compatibility mode.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CompatibilityMode
	{
			QuirksMode,
			LimitedQuirksMode,
			NoQuirksMode,
	}
}
