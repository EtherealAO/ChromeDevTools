namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Force the page stop all navigations and pending resource fetches.
	/// </summary>
	[CommandResponse(ProtocolName.Page.StopLoading)]
	[SupportedBy("Chrome")]
	public class StopLoadingCommandResponse
	{
	}
}
