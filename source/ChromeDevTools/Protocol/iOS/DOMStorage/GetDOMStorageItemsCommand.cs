namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMStorage
{
	[Command(ProtocolName.DOMStorage.GetDOMStorageItems)]
	[SupportedBy("iOS")]
	public class GetDOMStorageItemsCommand: ICommand<GetDOMStorageItemsCommandResponse>
	{
		/// <summary>
		/// Gets or sets StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
