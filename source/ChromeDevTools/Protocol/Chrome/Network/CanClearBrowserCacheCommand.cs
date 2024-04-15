using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Tells whether clearing browser cache is supported.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Network.CanClearBrowserCache)]
	[SupportedBy("Chrome")]
	public class CanClearBrowserCacheCommand: ICommand<CanClearBrowserCacheCommandResponse>
	{
	}
}
