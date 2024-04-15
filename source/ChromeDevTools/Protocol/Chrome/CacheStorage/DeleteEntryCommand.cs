namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Deletes a cache entry.
	/// </summary>
	[Command(ProtocolName.CacheStorage.DeleteEntry)]
	[SupportedBy("Chrome")]
	public class DeleteEntryCommand: ICommand<DeleteEntryCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of cache where the entry will be deleted.
		/// </summary>
		public string CacheId { get; set; }
		/// <summary>
		/// Gets or sets URL spec of the request.
		/// </summary>
		public string Request { get; set; }
	}
}
