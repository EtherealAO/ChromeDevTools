namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.InspectWorker)]
	[SupportedBy("Chrome")]
	public class InspectWorkerCommand: ICommand<InspectWorkerCommandResponse>
	{
		/// <summary>
		/// Gets or sets VersionId
		/// </summary>
		public string VersionId { get; set; }
	}
}
