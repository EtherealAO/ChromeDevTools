using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Tells whether clearing browser cookies is supported.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Network.CanClearBrowserCookies)]
	[SupportedBy("Chrome")]
	public class CanClearBrowserCookiesCommand: ICommand<CanClearBrowserCookiesCommandResponse>
	{
	}
}
