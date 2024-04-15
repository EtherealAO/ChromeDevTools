namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Stop collecting native memory profile.
	/// </summary>
	[CommandResponse(ProtocolName.Memory.StopSampling)]
	[SupportedBy("Chrome")]
	public class StopSamplingCommandResponse
	{
	}
}
