namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Sets if stack traces should be captured for Nodes. See `Node.getNodeStackTraces`. Default is disabled.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetNodeStackTracesEnabled)]
	[SupportedBy("Chrome")]
	public class SetNodeStackTracesEnabledCommandResponse
	{
	}
}
