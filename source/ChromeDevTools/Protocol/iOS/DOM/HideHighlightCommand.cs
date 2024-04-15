namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Hides DOM node highlight.
	/// </summary>
	[Command(ProtocolName.DOM.HideHighlight)]
	[SupportedBy("iOS")]
	public class HideHighlightCommand: ICommand<HideHighlightCommandResponse>
	{
	}
}
