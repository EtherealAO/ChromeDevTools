namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Highlights given rectangle. Coordinates are absolute with respect to the main frame viewport.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.HighlightRect)]
	[SupportedBy("iOS")]
	public class HighlightRectCommandResponse
	{
	}
}
