namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Gets metadata for an origin's shared storage.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.GetSharedStorageMetadata)]
	[SupportedBy("Chrome")]
	public class GetSharedStorageMetadataCommandResponse
	{
		/// <summary>
		/// Gets or sets Metadata
		/// </summary>
		public SharedStorageMetadata Metadata { get; set; }
	}
}
