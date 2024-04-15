namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Stops sending each frame in the `screencastFrame`.
	/// </summary>
	[CommandResponse(ProtocolName.Page.StopScreencast)]
	[SupportedBy("Chrome")]
	public class StopScreencastCommandResponse
	{
	}
}
