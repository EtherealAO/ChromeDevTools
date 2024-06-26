namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// The origin's IndexedDB database list has been modified.
	/// </summary>
	[Event(ProtocolName.Storage.IndexedDBListUpdated)]
	[SupportedBy("Chrome")]
	public class IndexedDBListUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Origin to update.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets Storage key to update.
		/// </summary>
		public string StorageKey { get; set; }
	}
}
