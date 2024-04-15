using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RuleSetErrorType
	{
			SourceIsNotJsonObject,
			InvalidRulesSkipped,
	}
}
