namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Struct for a single key-value pair in an origin's shared storage.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SharedStorageEntry
	{
		/// <summary>
		/// Gets or sets Key
		/// </summary>
		public string Key { get; set; }
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		public string Value { get; set; }
	}
}
