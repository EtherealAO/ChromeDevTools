namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted.
	/// Backend then generates 'inspectNodeRequested' event upon element selection.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetInspectMode)]
	[SupportedBy("Chrome")]
	public class SetInspectModeCommandResponse
	{
	}
}
