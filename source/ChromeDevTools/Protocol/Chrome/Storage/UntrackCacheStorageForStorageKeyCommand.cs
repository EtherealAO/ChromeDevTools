namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Unregisters storage key from receiving notifications for cache storage.
	/// </summary>
	[Command(ProtocolName.Storage.UntrackCacheStorageForStorageKey)]
	[SupportedBy("Chrome")]
	public class UntrackCacheStorageForStorageKeyCommand: ICommand<UntrackCacheStorageForStorageKeyCommandResponse>
	{
		/// <summary>
		/// Gets or sets Storage key.
		/// </summary>
		public string StorageKey { get; set; }
	}
}
