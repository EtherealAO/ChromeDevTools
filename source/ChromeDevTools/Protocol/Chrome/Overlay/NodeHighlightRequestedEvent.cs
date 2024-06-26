namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Fired when the node should be highlighted. This happens after call to `setInspectMode`.
	/// </summary>
	[Event(ProtocolName.Overlay.NodeHighlightRequested)]
	[SupportedBy("Chrome")]
	public class NodeHighlightRequestedEvent
	{
		/// <summary>
		/// Gets or sets NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
