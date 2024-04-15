namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	[Command(ProtocolName.Memory.GetDOMCounters)]
	[SupportedBy("Chrome")]
	public class GetDOMCountersCommand: ICommand<GetDOMCountersCommandResponse>
	{
	}
}
