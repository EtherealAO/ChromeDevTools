namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Deletes a cache.
	/// </summary>
	[Command(ProtocolName.CacheStorage.DeleteCache)]
	[SupportedBy("Chrome")]
	public class DeleteCacheCommand: ICommand<DeleteCacheCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of cache for deletion.
		/// </summary>
		public string CacheId { get; set; }
	}
}
