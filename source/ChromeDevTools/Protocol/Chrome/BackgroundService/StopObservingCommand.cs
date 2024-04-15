namespace MasterDevs.ChromeDevTools.Protocol.Chrome.BackgroundService
{
	/// <summary>
	/// Disables event updates for the service.
	/// </summary>
	[Command(ProtocolName.BackgroundService.StopObserving)]
	[SupportedBy("Chrome")]
	public class StopObservingCommand: ICommand<StopObservingCommandResponse>
	{
		/// <summary>
		/// Gets or sets Service
		/// </summary>
		public string Service { get; set; }
	}
}
