using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security{
	/// <summary>
	/// The action to take when a certificate error occurs. continue will continue processing the
	/// request and cancel will cancel the request.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CertificateErrorAction
	{
			Continue,
			Cancel,
	}
}
