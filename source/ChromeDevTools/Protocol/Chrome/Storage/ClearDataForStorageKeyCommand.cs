namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Clears storage for storage key.
	/// </summary>
	[Command(ProtocolName.Storage.ClearDataForStorageKey)]
	[SupportedBy("Chrome")]
	public class ClearDataForStorageKeyCommand: ICommand<ClearDataForStorageKeyCommandResponse>
	{
		/// <summary>
		/// Gets or sets Storage key.
		/// </summary>
		public string StorageKey { get; set; }
		/// <summary>
		/// Gets or sets Comma separated list of StorageType to clear.
		/// </summary>
		public string StorageTypes { get; set; }
	}
}
