namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Hides any highlight.
	/// </summary>
	[Command(ProtocolName.Overlay.HideHighlight)]
	[SupportedBy("Chrome")]
	public class HideHighlightCommand: ICommand<HideHighlightCommandResponse>
	{
	}
}
