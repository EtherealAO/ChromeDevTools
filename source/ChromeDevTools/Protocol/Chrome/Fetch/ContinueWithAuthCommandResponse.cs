namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Continues a request supplying authChallengeResponse following authRequired event.
	/// </summary>
	[CommandResponse(ProtocolName.Fetch.ContinueWithAuth)]
	[SupportedBy("Chrome")]
	public class ContinueWithAuthCommandResponse
	{
	}
}
