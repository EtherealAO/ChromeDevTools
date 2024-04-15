using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InspectMode
	{
			SearchForNode,
			SearchForUAShadowDOM,
			CaptureAreaScreenshot,
			ShowDistances,
			None,
	}
}
