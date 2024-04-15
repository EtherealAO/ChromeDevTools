namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Enables CPU throttling to emulate slow CPUs.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetCPUThrottlingRate)]
	[SupportedBy("Chrome")]
	public class SetCPUThrottlingRateCommandResponse
	{
	}
}
