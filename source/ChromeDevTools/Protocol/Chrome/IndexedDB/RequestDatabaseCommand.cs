using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Requests database with given name in given frame.
	/// </summary>
	[Command(ProtocolName.IndexedDB.RequestDatabase)]
	[SupportedBy("Chrome")]
	public class RequestDatabaseCommand: ICommand<RequestDatabaseCommandResponse>
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
		/// <summary>
		/// Gets or sets Database name.
		/// </summary>
		public string DatabaseName { get; set; }
	}
}
