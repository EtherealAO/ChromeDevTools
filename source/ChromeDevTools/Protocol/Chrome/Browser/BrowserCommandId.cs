using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser{
	/// <summary>
	/// Browser command ids used by executeBrowserCommand.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BrowserCommandId
	{
			OpenTabSearch,
			CloseTabSearch,
	}
}
