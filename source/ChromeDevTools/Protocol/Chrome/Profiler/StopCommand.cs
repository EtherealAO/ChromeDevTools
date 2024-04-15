namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	[Command(ProtocolName.Profiler.Stop)]
	[SupportedBy("Chrome")]
	public class StopCommand: ICommand<StopCommandResponse>
	{
	}
}
