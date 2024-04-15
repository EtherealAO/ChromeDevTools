namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Disables network tracking, prevents network events from being sent to the client.
	/// </summary>
	[CommandResponse(ProtocolName.Network.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
