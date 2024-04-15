using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Javascript dialog type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DialogType
	{
			Alert,
			Confirm,
			Prompt,
			Beforeunload,
	}
}
