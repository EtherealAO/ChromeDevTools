namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Gets metadata for an origin's shared storage.
	/// </summary>
	[Command(ProtocolName.Storage.GetSharedStorageMetadata)]
	[SupportedBy("Chrome")]
	public class GetSharedStorageMetadataCommand: ICommand<GetSharedStorageMetadataCommandResponse>
	{
		/// <summary>
		/// Gets or sets OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
	}
}
