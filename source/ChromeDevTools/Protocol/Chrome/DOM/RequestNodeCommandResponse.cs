namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given the JavaScript node object reference. All
	/// nodes that form the path from the node to the root are also sent to the client as a series of
	/// `setChildNodes` notifications.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.RequestNode)]
	[SupportedBy("Chrome")]
	public class RequestNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Node id for given object.
		/// </summary>
		public long NodeId { get; set; }
	}
}
