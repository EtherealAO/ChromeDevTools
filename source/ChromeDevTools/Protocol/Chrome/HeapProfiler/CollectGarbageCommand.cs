namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.CollectGarbage)]
	[SupportedBy("Chrome")]
	public class CollectGarbageCommand: ICommand<CollectGarbageCommandResponse>
	{
	}
}
