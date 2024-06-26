using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Requests database names for given security origin.
	/// </summary>
	[Command(ProtocolName.IndexedDB.RequestDatabaseNames)]
	[SupportedBy("Chrome")]
	public class RequestDatabaseNamesCommand: ICommand<RequestDatabaseNamesCommandResponse>
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
