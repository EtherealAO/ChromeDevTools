namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Request that backend shows an overlay with web vital metrics.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowWebVitals)]
	[SupportedBy("Chrome")]
	public class SetShowWebVitalsCommandResponse
	{
	}
}
