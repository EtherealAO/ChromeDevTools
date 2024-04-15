namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
