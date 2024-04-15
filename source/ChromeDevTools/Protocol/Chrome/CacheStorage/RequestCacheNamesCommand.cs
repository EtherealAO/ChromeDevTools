using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Requests cache names.
	/// </summary>
	[Command(ProtocolName.CacheStorage.RequestCacheNames)]
	[SupportedBy("Chrome")]
	public class RequestCacheNamesCommand: ICommand<RequestCacheNamesCommandResponse>
	{
		/// <summary>
		/// Gets or sets At least and at most one of securityOrigin, storageKey must be specified.
		/// Security origin.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets Storage key.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StorageKey { get; set; }
	}
}
