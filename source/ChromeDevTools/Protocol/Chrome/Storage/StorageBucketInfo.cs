namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[SupportedBy("Chrome")]
	public class StorageBucketInfo
	{
		/// <summary>
		/// Gets or sets StorageKey
		/// </summary>
		public string StorageKey { get; set; }
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets IsDefault
		/// </summary>
		public bool IsDefault { get; set; }
		/// <summary>
		/// Gets or sets Expiration
		/// </summary>
		public double Expiration { get; set; }
		/// <summary>
		/// Gets or sets Storage quota (bytes).
		/// </summary>
		public double Quota { get; set; }
		/// <summary>
		/// Gets or sets Persistent
		/// </summary>
		public bool Persistent { get; set; }
		/// <summary>
		/// Gets or sets Durability
		/// </summary>
		public StorageBucketsDurability Durability { get; set; }
	}
}
