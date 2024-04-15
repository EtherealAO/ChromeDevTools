namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Sets entry with `key` and `value` for a given origin's shared storage.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.SetSharedStorageEntry)]
	[SupportedBy("Chrome")]
	public class SetSharedStorageEntryCommandResponse
	{
	}
}
