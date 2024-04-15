namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	[Command(ProtocolName.DOMStorage.GetDOMStorageItems)]
	[SupportedBy("Chrome")]
	public class GetDOMStorageItemsCommand: ICommand<GetDOMStorageItemsCommandResponse>
	{
		/// <summary>
		/// Gets or sets StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
