namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Database
{
	/// <summary>
	/// Disables database tracking, prevents database events from being sent to the client.
	/// </summary>
	[CommandResponse(ProtocolName.Database.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
