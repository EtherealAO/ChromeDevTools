using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// Returns the response body and size if it were re-encoded with the specified settings. Only
	/// applies to images.
	/// </summary>
	[CommandResponse(ProtocolName.Audits.GetEncodedResponse)]
	[SupportedBy("Chrome")]
	public class GetEncodedResponseCommandResponse
	{
		/// <summary>
		/// Gets or sets The encoded body as a base64 string. Omitted if sizeOnly is true. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Body { get; set; }
		/// <summary>
		/// Gets or sets Size before re-encoding.
		/// </summary>
		public long OriginalSize { get; set; }
		/// <summary>
		/// Gets or sets Size after re-encoding.
		/// </summary>
		public long EncodedSize { get; set; }
	}
}
