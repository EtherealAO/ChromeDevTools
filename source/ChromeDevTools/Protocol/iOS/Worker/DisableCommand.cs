namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Command(ProtocolName.Worker.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
