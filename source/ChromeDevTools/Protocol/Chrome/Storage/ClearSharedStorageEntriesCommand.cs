namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Clears all entries for a given origin's shared storage.
	/// </summary>
	[Command(ProtocolName.Storage.ClearSharedStorageEntries)]
	[SupportedBy("Chrome")]
	public class ClearSharedStorageEntriesCommand: ICommand<ClearSharedStorageEntriesCommandResponse>
	{
		/// <summary>
		/// Gets or sets OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
	}
}
