namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Enables the CSS agent for the given page. Clients should not assume that the CSS agent has been
	/// enabled until the result of this command is received.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
