namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[Event(ProtocolName.Storage.StorageBucketCreatedOrUpdated)]
	[SupportedBy("Chrome")]
	public class StorageBucketCreatedOrUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Bucket
		/// </summary>
		public StorageBucketInfo Bucket { get; set; }
	}
}
