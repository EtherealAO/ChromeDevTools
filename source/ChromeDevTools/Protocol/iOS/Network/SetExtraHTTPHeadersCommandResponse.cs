namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Specifies whether to always send extra HTTP headers with the requests from this page.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetExtraHTTPHeaders)]
	[SupportedBy("iOS")]
	public class SetExtraHTTPHeadersCommandResponse
	{
	}
}
