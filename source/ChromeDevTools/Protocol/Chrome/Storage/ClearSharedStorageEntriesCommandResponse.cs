namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Clears all entries for a given origin's shared storage.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.ClearSharedStorageEntries)]
	[SupportedBy("Chrome")]
	public class ClearSharedStorageEntriesCommandResponse
	{
	}
}
