namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Returns all browser contexts created with `Target.createBrowserContext` method.
	/// </summary>
	[Command(ProtocolName.Target.GetBrowserContexts)]
	[SupportedBy("Chrome")]
	public class GetBrowserContextsCommand: ICommand<GetBrowserContextsCommandResponse>
	{
	}
}
