namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Deletes entry for `key` (if it exists) for a given origin's shared storage.
	/// </summary>
	[Command(ProtocolName.Storage.DeleteSharedStorageEntry)]
	[SupportedBy("Chrome")]
	public class DeleteSharedStorageEntryCommand: ICommand<DeleteSharedStorageEntryCommandResponse>
	{
		/// <summary>
		/// Gets or sets OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
		/// <summary>
		/// Gets or sets Key
		/// </summary>
		public string Key { get; set; }
	}
}
