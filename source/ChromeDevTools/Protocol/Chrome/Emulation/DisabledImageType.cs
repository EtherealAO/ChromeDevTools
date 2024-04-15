using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation{
	/// <summary>
	/// Enum of image types that can be disabled.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DisabledImageType
	{
			Avif,
			Webp,
	}
}
