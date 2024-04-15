namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Clears seeded compilation cache.
	/// </summary>
	[CommandResponse(ProtocolName.Page.ClearCompilationCache)]
	[SupportedBy("Chrome")]
	public class ClearCompilationCacheCommandResponse
	{
	}
}
