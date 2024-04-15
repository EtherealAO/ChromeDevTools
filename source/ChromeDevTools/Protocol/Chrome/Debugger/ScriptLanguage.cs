using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger{
	/// <summary>
	/// Enum of possible script languages.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ScriptLanguage
	{
			JavaScript,
			WebAssembly,
	}
}
