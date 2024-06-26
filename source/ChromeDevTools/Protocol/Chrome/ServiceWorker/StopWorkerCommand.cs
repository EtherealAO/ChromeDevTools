namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.StopWorker)]
	[SupportedBy("Chrome")]
	public class StopWorkerCommand: ICommand<StopWorkerCommandResponse>
	{
		/// <summary>
		/// Gets or sets VersionId
		/// </summary>
		public string VersionId { get; set; }
	}
}
