using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser{
	/// <summary>
	/// The state of the browser window.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum WindowState
	{
			Normal,
			Minimized,
			Maximized,
			Fullscreen,
	}
}
