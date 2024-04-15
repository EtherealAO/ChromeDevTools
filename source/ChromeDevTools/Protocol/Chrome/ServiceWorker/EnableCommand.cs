namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
