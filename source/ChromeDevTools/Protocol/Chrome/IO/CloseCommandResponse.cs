namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IO
{
	/// <summary>
	/// Close the stream, discard any temporary backing storage.
	/// </summary>
	[CommandResponse(ProtocolName.IO.Close)]
	[SupportedBy("Chrome")]
	public class CloseCommandResponse
	{
	}
}
