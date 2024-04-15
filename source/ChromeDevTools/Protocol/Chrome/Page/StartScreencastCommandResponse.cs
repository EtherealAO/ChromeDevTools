namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Starts sending each frame using the `screencastFrame` event.
	/// </summary>
	[CommandResponse(ProtocolName.Page.StartScreencast)]
	[SupportedBy("Chrome")]
	public class StartScreencastCommandResponse
	{
	}
}
