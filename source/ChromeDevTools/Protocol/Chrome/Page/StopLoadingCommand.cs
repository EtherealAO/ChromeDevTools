namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Force the page stop all navigations and pending resource fetches.
	/// </summary>
	[Command(ProtocolName.Page.StopLoading)]
	[SupportedBy("Chrome")]
	public class StopLoadingCommand: ICommand<StopLoadingCommandResponse>
	{
	}
}
