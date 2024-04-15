namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Start collecting native memory profile.
	/// </summary>
	[CommandResponse(ProtocolName.Memory.StartSampling)]
	[SupportedBy("Chrome")]
	public class StartSamplingCommandResponse
	{
	}
}
