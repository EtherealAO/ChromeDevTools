namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.StopSampling)]
	[SupportedBy("Chrome")]
	public class StopSamplingCommand: ICommand<StopSamplingCommandResponse>
	{
	}
}
