namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Mirrors `DOMNodeRemoved` event.
	/// </summary>
	[Event(ProtocolName.DOM.ChildNodeRemoved)]
	[SupportedBy("Chrome")]
	public class ChildNodeRemovedEvent
	{
		/// <summary>
		/// Gets or sets Parent id.
		/// </summary>
		public long ParentNodeId { get; set; }
		/// <summary>
		/// Gets or sets Id of the node that has been removed.
		/// </summary>
		public long NodeId { get; set; }
	}
}
