namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Command(ProtocolName.Worker.Enable)]
	[SupportedBy("iOS")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
