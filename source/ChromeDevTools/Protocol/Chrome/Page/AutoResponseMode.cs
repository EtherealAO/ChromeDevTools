using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Enum of possible auto-reponse for permisison / prompt dialogs.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutoResponseMode
	{
			None,
			AutoAccept,
			AutoReject,
			AutoOptOut,
	}
}
