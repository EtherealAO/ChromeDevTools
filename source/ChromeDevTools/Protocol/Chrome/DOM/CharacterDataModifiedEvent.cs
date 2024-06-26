namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Mirrors `DOMCharacterDataModified` event.
	/// </summary>
	[Event(ProtocolName.DOM.CharacterDataModified)]
	[SupportedBy("Chrome")]
	public class CharacterDataModifiedEvent
	{
		/// <summary>
		/// Gets or sets Id of the node that has changed.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets New text value.
		/// </summary>
		public string CharacterData { get; set; }
	}
}
