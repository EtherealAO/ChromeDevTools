namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Command(ProtocolName.Worker.ConnectToWorker)]
	[SupportedBy("iOS")]
	public class ConnectToWorkerCommand: ICommand<ConnectToWorkerCommandResponse>
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		public long WorkerId { get; set; }
	}
}
