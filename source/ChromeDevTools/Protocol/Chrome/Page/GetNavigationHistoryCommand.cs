namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns navigation history for the current page.
	/// </summary>
	[Command(ProtocolName.Page.GetNavigationHistory)]
	[SupportedBy("Chrome")]
	public class GetNavigationHistoryCommand: ICommand<GetNavigationHistoryCommandResponse>
	{
	}
}
