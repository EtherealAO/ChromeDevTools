namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// A cache has been added/deleted.
	/// </summary>
	[Event(ProtocolName.Storage.CacheStorageListUpdated)]
	[SupportedBy("Chrome")]
	public class CacheStorageListUpdatedEvent
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
