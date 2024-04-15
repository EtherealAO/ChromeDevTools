namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Gets the entries in an given origin's shared storage.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.GetSharedStorageEntries)]
	[SupportedBy("Chrome")]
	public class GetSharedStorageEntriesCommandResponse
	{
		/// <summary>
		/// Gets or sets Entries
		/// </summary>
		public SharedStorageEntry[] Entries { get; set; }
	}
}
