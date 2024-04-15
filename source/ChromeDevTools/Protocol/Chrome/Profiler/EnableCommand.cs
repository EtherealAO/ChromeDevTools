namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	[Command(ProtocolName.Profiler.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
