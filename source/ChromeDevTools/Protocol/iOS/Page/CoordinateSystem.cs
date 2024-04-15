using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page{
	/// <summary>
	/// Coordinate system used by supplied coordinates.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CoordinateSystem
	{
			Viewport,
			Page,
	}
}
