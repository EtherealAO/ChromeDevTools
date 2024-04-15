namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Clears browser cache.
	/// </summary>
	[Command(ProtocolName.Network.ClearBrowserCache)]
	[SupportedBy("Chrome")]
	public class ClearBrowserCacheCommand: ICommand<ClearBrowserCacheCommandResponse>
	{
	}
}
