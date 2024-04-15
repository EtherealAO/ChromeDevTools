namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.GetSamplingProfile)]
	[SupportedBy("Chrome")]
	public class GetSamplingProfileCommand: ICommand<GetSamplingProfileCommandResponse>
	{
	}
}
