namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Highlights given rectangle.
	/// </summary>
	[Command(ProtocolName.DOM.HighlightRect)]
	[SupportedBy("Chrome")]
	public class HighlightRectCommand: ICommand<HighlightRectCommandResponse>
	{
	}
}
