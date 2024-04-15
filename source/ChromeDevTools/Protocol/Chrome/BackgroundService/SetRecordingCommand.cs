namespace MasterDevs.ChromeDevTools.Protocol.Chrome.BackgroundService
{
	/// <summary>
	/// Set the recording state for the service.
	/// </summary>
	[Command(ProtocolName.BackgroundService.SetRecording)]
	[SupportedBy("Chrome")]
	public class SetRecordingCommand: ICommand<SetRecordingCommandResponse>
	{
		/// <summary>
		/// Gets or sets ShouldRecord
		/// </summary>
		public bool ShouldRecord { get; set; }
		/// <summary>
		/// Gets or sets Service
		/// </summary>
		public string Service { get; set; }
	}
}
