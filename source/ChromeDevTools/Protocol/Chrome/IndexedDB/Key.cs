using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Key.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Key
	{
		/// <summary>
		/// Gets or sets Key type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Number value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Number { get; set; }
		/// <summary>
		/// Gets or sets String value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string String { get; set; }
		/// <summary>
		/// Gets or sets Date value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Date { get; set; }
		/// <summary>
		/// Gets or sets Array value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Key[] Array { get; set; }
	}
}
