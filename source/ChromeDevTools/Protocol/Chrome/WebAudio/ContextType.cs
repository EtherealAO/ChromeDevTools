using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio{
	/// <summary>
	/// Enum of BaseAudioContext types
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContextType
	{
			Realtime,
			Offline,
	}
}
