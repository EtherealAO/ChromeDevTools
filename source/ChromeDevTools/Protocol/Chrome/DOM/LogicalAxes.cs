using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM{
	/// <summary>
	/// ContainerSelector logical axes
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LogicalAxes
	{
			Inline,
			Block,
			Both,
	}
}
