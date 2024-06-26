namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	/// Disables log domain, prevents further log entries from being reported to the client.
	/// </summary>
	[CommandResponse(ProtocolName.Log.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
