namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Requests that page scale factor is reset to initial values.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.ResetPageScaleFactor)]
	[SupportedBy("Chrome")]
	public class ResetPageScaleFactorCommandResponse
	{
	}
}
