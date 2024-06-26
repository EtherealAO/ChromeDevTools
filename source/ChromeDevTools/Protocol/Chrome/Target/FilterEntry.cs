using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// A filter used by target query/discovery/auto-attach operations.
	/// </summary>
	[SupportedBy("Chrome")]
	public class FilterEntry
	{
		/// <summary>
		/// Gets or sets If set, causes exclusion of mathcing targets from the list.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Exclude { get; set; }
		/// <summary>
		/// Gets or sets If not present, matches any type.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Type { get; set; }
	}
}
