namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows layout shift regions
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowLayoutShiftRegions)]
	[SupportedBy("Chrome")]
	public class SetShowLayoutShiftRegionsCommandResponse
	{
	}
}
