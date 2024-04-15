namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows paint rectangles
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowPaintRects)]
	[SupportedBy("Chrome")]
	public class SetShowPaintRectsCommandResponse
	{
	}
}
