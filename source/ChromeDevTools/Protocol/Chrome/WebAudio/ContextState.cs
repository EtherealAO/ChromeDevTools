using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio{
	/// <summary>
	/// Enum of AudioContextState from the spec
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContextState
	{
			Suspended,
			Running,
			Closed,
	}
}
