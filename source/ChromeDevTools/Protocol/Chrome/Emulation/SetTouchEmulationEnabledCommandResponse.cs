namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Enables touch on platforms which do not support them.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetTouchEmulationEnabled)]
	[SupportedBy("Chrome")]
	public class SetTouchEmulationEnabledCommandResponse
	{
	}
}
