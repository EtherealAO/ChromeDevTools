namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Executes `querySelector` on a given node.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.QuerySelector)]
	[SupportedBy("Chrome")]
	public class QuerySelectorCommandResponse
	{
		/// <summary>
		/// Gets or sets Query selector result.
		/// </summary>
		public long NodeId { get; set; }
	}
}
