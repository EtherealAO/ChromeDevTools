namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Mirrors `DOMNodeInserted` event.
	/// </summary>
	[Event(ProtocolName.DOM.ChildNodeInserted)]
	[SupportedBy("Chrome")]
	public class ChildNodeInsertedEvent
	{
		/// <summary>
		/// Gets or sets Id of the node that has changed.
		/// </summary>
		public long ParentNodeId { get; set; }
		/// <summary>
		/// Gets or sets Id of the previous sibling.
		/// </summary>
		public long PreviousNodeId { get; set; }
		/// <summary>
		/// Gets or sets Inserted node data.
		/// </summary>
		public Node Node { get; set; }
	}
}
