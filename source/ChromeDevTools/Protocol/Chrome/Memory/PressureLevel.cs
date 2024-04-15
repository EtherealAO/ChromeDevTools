using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory{
	/// <summary>
	/// Memory pressure level.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PressureLevel
	{
			Moderate,
			Critical,
	}
}
