namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Deletes the Storage Bucket with the given storage key and bucket name.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.DeleteStorageBucket)]
	[SupportedBy("Chrome")]
	public class DeleteStorageBucketCommandResponse
	{
	}
}
