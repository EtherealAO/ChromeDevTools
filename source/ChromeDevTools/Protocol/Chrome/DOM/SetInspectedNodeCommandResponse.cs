namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Enables console to refer to the node with given id via $x (see Command Line API for more details
	/// $x functions).
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetInspectedNode)]
	[SupportedBy("Chrome")]
	public class SetInspectedNodeCommandResponse
	{
	}
}
