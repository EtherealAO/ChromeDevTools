namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Registers storage key to be notified when an update occurs to its IndexedDB.
	/// </summary>
	[Command(ProtocolName.Storage.TrackIndexedDBForStorageKey)]
	[SupportedBy("Chrome")]
	public class TrackIndexedDBForStorageKeyCommand: ICommand<TrackIndexedDBForStorageKeyCommandResponse>
	{
		/// <summary>
		/// Gets or sets Storage key.
		/// </summary>
		public string StorageKey { get; set; }
	}
}
