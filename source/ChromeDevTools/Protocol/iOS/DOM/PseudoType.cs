using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM{
	/// <summary>
	/// Pseudo element type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PseudoType
	{
			Before,
			After,
	}
}
