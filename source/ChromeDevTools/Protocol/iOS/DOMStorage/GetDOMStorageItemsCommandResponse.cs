namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMStorage
{
	[CommandResponse(ProtocolName.DOMStorage.GetDOMStorageItems)]
	[SupportedBy("iOS")]
	public class GetDOMStorageItemsCommandResponse
	{
		/// <summary>
		/// Gets or sets Entries
		/// </summary>
		public string[][] Entries { get; set; }
	}
}
