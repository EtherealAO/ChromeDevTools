namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows the FPS counter
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowFPSCounter)]
	[SupportedBy("Chrome")]
	public class SetShowFPSCounterCommandResponse
	{
	}
}
