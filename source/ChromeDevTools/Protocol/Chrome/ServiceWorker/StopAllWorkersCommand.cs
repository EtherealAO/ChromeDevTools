namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.StopAllWorkers)]
	[SupportedBy("Chrome")]
	public class StopAllWorkersCommand: ICommand<StopAllWorkersCommandResponse>
	{
	}
}
