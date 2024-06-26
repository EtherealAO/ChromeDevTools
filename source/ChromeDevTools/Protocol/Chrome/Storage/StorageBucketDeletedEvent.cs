namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[Event(ProtocolName.Storage.StorageBucketDeleted)]
	[SupportedBy("Chrome")]
	public class StorageBucketDeletedEvent
	{
		/// <summary>
		/// Gets or sets BucketId
		/// </summary>
		public string BucketId { get; set; }
	}
}
