namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	[Command(ProtocolName.Profiler.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
