namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Executes <code>querySelector</code> on a given node.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.QuerySelector)]
	[SupportedBy("iOS")]
	public class QuerySelectorCommandResponse
	{
		/// <summary>
		/// Gets or sets Query selector result.
		/// </summary>
		public long NodeId { get; set; }
	}
}
