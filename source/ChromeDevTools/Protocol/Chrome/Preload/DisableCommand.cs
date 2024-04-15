namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	[Command(ProtocolName.Preload.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
