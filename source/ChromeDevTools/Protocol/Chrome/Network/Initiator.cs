using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Information about the request initiator.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Initiator
	{
		/// <summary>
		/// Gets or sets Type of this initiator.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Initiator JavaScript stack trace, set for Script only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTrace Stack { get; set; }
		/// <summary>
		/// Gets or sets Initiator URL, set for Parser type or for Script type (when script is importing module) or for SignedExchange type.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Initiator line number, set for Parser type or for Script type (when script is importing
		/// module) (0-based).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double LineNumber { get; set; }
		/// <summary>
		/// Gets or sets Initiator column number, set for Parser type or for Script type (when script is importing
		/// module) (0-based).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ColumnNumber { get; set; }
		/// <summary>
		/// Gets or sets Set if another request triggered this request (e.g. preflight).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RequestId { get; set; }
	}
}
