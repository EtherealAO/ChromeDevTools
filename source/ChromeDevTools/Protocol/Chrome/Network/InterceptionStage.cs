using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// Stages of the interception to begin intercepting. Request will intercept before the request is
	/// sent. Response will intercept after the response is received.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InterceptionStage
	{
			Request,
			HeadersReceived,
	}
}
