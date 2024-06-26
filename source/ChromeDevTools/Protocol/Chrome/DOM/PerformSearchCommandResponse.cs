namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Searches for a given string in the DOM tree. Use `getSearchResults` to access search results or
	/// `cancelSearch` to end this search session.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.PerformSearch)]
	[SupportedBy("Chrome")]
	public class PerformSearchCommandResponse
	{
		/// <summary>
		/// Gets or sets Unique search session identifier.
		/// </summary>
		public string SearchId { get; set; }
		/// <summary>
		/// Gets or sets Number of search results.
		/// </summary>
		public long ResultCount { get; set; }
	}
}
