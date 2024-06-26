namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Clears seeded compilation cache.
	/// </summary>
	[Command(ProtocolName.Page.ClearCompilationCache)]
	[SupportedBy("Chrome")]
	public class ClearCompilationCacheCommand: ICommand<ClearCompilationCacheCommandResponse>
	{
	}
}
