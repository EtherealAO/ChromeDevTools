using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Ad advertising element inside an interest group.
	/// </summary>
	[SupportedBy("Chrome")]
	public class InterestGroupAd
	{
		/// <summary>
		/// Gets or sets RenderUrl
		/// </summary>
		public string RenderUrl { get; set; }
		/// <summary>
		/// Gets or sets Metadata
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Metadata { get; set; }
	}
}
