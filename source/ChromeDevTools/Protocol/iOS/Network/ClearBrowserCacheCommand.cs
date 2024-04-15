namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Clears browser cache.
	/// </summary>
	[Command(ProtocolName.Network.ClearBrowserCache)]
	[SupportedBy("iOS")]
	public class ClearBrowserCacheCommand: ICommand<ClearBrowserCacheCommandResponse>
	{
	}
}
