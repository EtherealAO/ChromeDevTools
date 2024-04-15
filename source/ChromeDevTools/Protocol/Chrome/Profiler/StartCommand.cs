namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	[Command(ProtocolName.Profiler.Start)]
	[SupportedBy("Chrome")]
	public class StartCommand: ICommand<StartCommandResponse>
	{
	}
}
