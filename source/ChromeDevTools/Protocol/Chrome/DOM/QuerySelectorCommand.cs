namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Executes `querySelector` on a given node.
	/// </summary>
	[Command(ProtocolName.DOM.QuerySelector)]
	[SupportedBy("Chrome")]
	public class QuerySelectorCommand: ICommand<QuerySelectorCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to query upon.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Selector string.
		/// </summary>
		public string Selector { get; set; }
	}
}
