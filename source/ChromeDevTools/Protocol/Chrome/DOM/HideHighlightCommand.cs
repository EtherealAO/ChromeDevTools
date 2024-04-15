namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Hides any highlight.
	/// </summary>
	[Command(ProtocolName.DOM.HideHighlight)]
	[SupportedBy("Chrome")]
	public class HideHighlightCommand: ICommand<HideHighlightCommandResponse>
	{
	}
}
