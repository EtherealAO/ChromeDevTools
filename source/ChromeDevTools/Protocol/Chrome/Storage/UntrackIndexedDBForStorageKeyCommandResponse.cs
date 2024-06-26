namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Unregisters storage key from receiving notifications for IndexedDB.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.UntrackIndexedDBForStorageKey)]
	[SupportedBy("Chrome")]
	public class UntrackIndexedDBForStorageKeyCommandResponse
	{
	}
}
