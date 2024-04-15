namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Command(ProtocolName.Worker.DisconnectFromWorker)]
	[SupportedBy("iOS")]
	public class DisconnectFromWorkerCommand: ICommand<DisconnectFromWorkerCommandResponse>
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		public long WorkerId { get; set; }
	}
}
