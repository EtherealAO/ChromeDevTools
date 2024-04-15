using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Ctap2Version
	{
			Ctap2_0,
			Ctap2_1,
	}
}
