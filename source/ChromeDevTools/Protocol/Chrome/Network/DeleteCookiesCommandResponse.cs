namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Deletes browser cookies with matching name and url or domain/path pair.
	/// </summary>
	[CommandResponse(ProtocolName.Network.DeleteCookies)]
	[SupportedBy("Chrome")]
	public class DeleteCookiesCommandResponse
	{
	}
}
