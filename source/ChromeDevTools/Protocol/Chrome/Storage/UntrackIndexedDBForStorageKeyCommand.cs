namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Unregisters storage key from receiving notifications for IndexedDB.
	/// </summary>
	[Command(ProtocolName.Storage.UntrackIndexedDBForStorageKey)]
	[SupportedBy("Chrome")]
	public class UntrackIndexedDBForStorageKeyCommand: ICommand<UntrackIndexedDBForStorageKeyCommandResponse>
	{
		/// <summary>
		/// Gets or sets Storage key.
		/// </summary>
		public string StorageKey { get; set; }
	}
}
