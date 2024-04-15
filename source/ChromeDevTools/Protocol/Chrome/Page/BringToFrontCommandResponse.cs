namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Brings page to front (activates tab).
	/// </summary>
	[CommandResponse(ProtocolName.Page.BringToFront)]
	[SupportedBy("Chrome")]
	public class BringToFrontCommandResponse
	{
	}
}
