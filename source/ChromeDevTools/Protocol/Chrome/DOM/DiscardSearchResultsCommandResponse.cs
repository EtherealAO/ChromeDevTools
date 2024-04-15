namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Discards search results from the session with the given id. `getSearchResults` should no longer
	/// be called for that search.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.DiscardSearchResults)]
	[SupportedBy("Chrome")]
	public class DiscardSearchResultsCommandResponse
	{
	}
}
