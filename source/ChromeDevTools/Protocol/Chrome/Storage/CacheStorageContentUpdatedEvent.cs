namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// A cache's contents have been modified.
	/// </summary>
	[Event(ProtocolName.Storage.CacheStorageContentUpdated)]
	[SupportedBy("Chrome")]
	public class CacheStorageContentUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Origin to update.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets Storage key to update.
		/// </summary>
		public string StorageKey { get; set; }
		/// <summary>
		/// Gets or sets Name of cache in origin.
		/// </summary>
		public string CacheName { get; set; }
	}
}
