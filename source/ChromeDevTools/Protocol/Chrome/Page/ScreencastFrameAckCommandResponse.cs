namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Acknowledges that a screencast frame has been received by the frontend.
	/// </summary>
	[CommandResponse(ProtocolName.Page.ScreencastFrameAck)]
	[SupportedBy("Chrome")]
	public class ScreencastFrameAckCommandResponse
	{
	}
}
