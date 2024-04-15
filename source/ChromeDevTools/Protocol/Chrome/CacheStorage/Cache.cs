namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Cache identifier.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Cache
	{
		/// <summary>
		/// Gets or sets An opaque unique id of the cache.
		/// </summary>
		public string CacheId { get; set; }
		/// <summary>
		/// Gets or sets Security origin of the cache.
		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets Storage key of the cache.
		/// </summary>
		public string StorageKey { get; set; }
		/// <summary>
		/// Gets or sets The name of the cache.
		/// </summary>
		public string CacheName { get; set; }
	}
}
