namespace MasterDevs.ChromeDevTools.Protocol.Chrome.BackgroundService
{
	/// <summary>
	/// Enables event updates for the service.
	/// </summary>
	[CommandResponse(ProtocolName.BackgroundService.StartObserving)]
	[SupportedBy("Chrome")]
	public class StartObservingCommandResponse
	{
	}
}
