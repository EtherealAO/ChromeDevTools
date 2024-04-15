namespace MasterDevs.ChromeDevTools.Protocol.Chrome.BackgroundService
{
	/// <summary>
	/// Clears all stored data for the service.
	/// </summary>
	[CommandResponse(ProtocolName.BackgroundService.ClearEvents)]
	[SupportedBy("Chrome")]
	public class ClearEventsCommandResponse
	{
	}
}
