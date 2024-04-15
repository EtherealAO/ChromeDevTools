namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Retrieve native memory allocations profile collected since last
	/// `startSampling` call.
	/// </summary>
	[Command(ProtocolName.Memory.GetSamplingProfile)]
	[SupportedBy("Chrome")]
	public class GetSamplingProfileCommand: ICommand<GetSamplingProfileCommandResponse>
	{
	}
}
