namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Fired when `Element`'s attribute is removed.
	/// </summary>
	[Event(ProtocolName.DOM.AttributeRemoved)]
	[SupportedBy("Chrome")]
	public class AttributeRemovedEvent
	{
		/// <summary>
		/// Gets or sets Id of the node that has changed.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets A ttribute name.
		/// </summary>
		public string Name { get; set; }
	}
}
