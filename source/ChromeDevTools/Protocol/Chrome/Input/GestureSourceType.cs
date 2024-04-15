using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GestureSourceType
	{
			Default,
			Touch,
			Mouse,
	}
}
