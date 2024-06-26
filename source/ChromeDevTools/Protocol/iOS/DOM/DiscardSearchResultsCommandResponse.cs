namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Discards search results from the session with the given id. <code>getSearchResults</code> should no longer be called for that search.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.DiscardSearchResults)]
	[SupportedBy("iOS")]
	public class DiscardSearchResultsCommandResponse
	{
	}
}
