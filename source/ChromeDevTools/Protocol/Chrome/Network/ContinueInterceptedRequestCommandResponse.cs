using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Response to Network.requestIntercepted which either modifies the request to continue with any
	/// modifications, or blocks it, or completes it with the provided response bytes. If a network
	/// fetch occurs as a result which encounters a redirect an additional Network.requestIntercepted
	/// event will be sent with the same InterceptionId.
	/// Deprecated, use Fetch.continueRequest, Fetch.fulfillRequest and Fetch.failRequest instead.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Network.ContinueInterceptedRequest)]
	[SupportedBy("Chrome")]
	public class ContinueInterceptedRequestCommandResponse
	{
	}
}
