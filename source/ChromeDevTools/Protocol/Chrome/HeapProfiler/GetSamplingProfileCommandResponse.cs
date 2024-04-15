namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.GetSamplingProfile)]
	[SupportedBy("Chrome")]
	public class GetSamplingProfileCommandResponse
	{
		/// <summary>
		/// Gets or sets Return the sampling profile being collected.
		/// </summary>
		public SamplingHeapProfile Profile { get; set; }
	}
}
