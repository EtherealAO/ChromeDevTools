namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Retrieve native memory allocations profile collected since last
	/// `startSampling` call.
	/// </summary>
	[CommandResponse(ProtocolName.Memory.GetSamplingProfile)]
	[SupportedBy("Chrome")]
	public class GetSamplingProfileCommandResponse
	{
		/// <summary>
		/// Gets or sets Profile
		/// </summary>
		public SamplingProfile Profile { get; set; }
	}
}
