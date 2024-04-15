namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Unregisters origin from receiving notifications for cache storage.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.UntrackCacheStorageForOrigin)]
	[SupportedBy("Chrome")]
	public class UntrackCacheStorageForOriginCommandResponse
	{
	}
}
