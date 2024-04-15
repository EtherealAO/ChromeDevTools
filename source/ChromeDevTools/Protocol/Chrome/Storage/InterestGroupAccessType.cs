using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage{
	/// <summary>
	/// Enum of interest group access types.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InterestGroupAccessType
	{
			Join,
			Leave,
			Update,
			Loaded,
			Bid,
			Win,
	}
}
