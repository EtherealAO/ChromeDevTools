using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AuthenticatorTransport
	{
			Usb,
			Nfc,
			Ble,
			Cable,
			Internal,
	}
}
