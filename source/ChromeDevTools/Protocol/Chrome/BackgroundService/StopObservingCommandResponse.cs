namespace MasterDevs.ChromeDevTools.Protocol.Chrome.BackgroundService
{
	/// <summary>
	/// Disables event updates for the service.
	/// </summary>
	[CommandResponse(ProtocolName.BackgroundService.StopObserving)]
	[SupportedBy("Chrome")]
	public class StopObservingCommandResponse
	{
	}
}
