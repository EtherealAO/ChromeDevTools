using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Sets entry with `key` and `value` for a given origin's shared storage.
	/// </summary>
	[Command(ProtocolName.Storage.SetSharedStorageEntry)]
	[SupportedBy("Chrome")]
	public class SetSharedStorageEntryCommand: ICommand<SetSharedStorageEntryCommandResponse>
	{
		/// <summary>
		/// Gets or sets OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
		/// <summary>
		/// Gets or sets Key
		/// </summary>
		public string Key { get; set; }
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or sets If `ignoreIfPresent` is included and true, then only sets the entry if
		/// `key` doesn't already exist.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IgnoreIfPresent { get; set; }
	}
}
