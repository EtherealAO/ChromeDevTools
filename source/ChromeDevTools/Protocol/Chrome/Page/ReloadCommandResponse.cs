namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Reloads given page optionally ignoring the cache.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Reload)]
	[SupportedBy("Chrome")]
	public class ReloadCommandResponse
	{
	}
}
