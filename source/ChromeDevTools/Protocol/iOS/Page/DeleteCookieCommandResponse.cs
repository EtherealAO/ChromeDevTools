namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Deletes browser cookie with given name, domain and path.
	/// </summary>
	[CommandResponse(ProtocolName.Page.DeleteCookie)]
	[SupportedBy("iOS")]
	public class DeleteCookieCommandResponse
	{
	}
}
