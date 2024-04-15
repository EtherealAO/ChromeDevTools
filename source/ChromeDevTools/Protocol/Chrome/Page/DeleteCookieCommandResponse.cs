using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Deletes browser cookie with given name, domain and path.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Page.DeleteCookie)]
	[SupportedBy("Chrome")]
	public class DeleteCookieCommandResponse
	{
	}
}
