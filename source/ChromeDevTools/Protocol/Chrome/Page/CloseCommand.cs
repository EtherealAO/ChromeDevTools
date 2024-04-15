namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Tries to close page, running its beforeunload hooks, if any.
	/// </summary>
	[Command(ProtocolName.Page.Close)]
	[SupportedBy("Chrome")]
	public class CloseCommand: ICommand<CloseCommandResponse>
	{
	}
}
