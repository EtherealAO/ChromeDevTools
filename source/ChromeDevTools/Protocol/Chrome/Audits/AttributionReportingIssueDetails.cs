using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// Details for issues around "Attribution Reporting API" usage.
	/// Explainer: https://github.com/WICG/attribution-reporting-api
	/// </summary>
	[SupportedBy("Chrome")]
	public class AttributionReportingIssueDetails
	{
		/// <summary>
		/// Gets or sets ViolationType
		/// </summary>
		public AttributionReportingIssueType ViolationType { get; set; }
		/// <summary>
		/// Gets or sets Request
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AffectedRequest Request { get; set; }
		/// <summary>
		/// Gets or sets ViolatingNodeId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ViolatingNodeId { get; set; }
		/// <summary>
		/// Gets or sets InvalidParameter
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string InvalidParameter { get; set; }
	}
}
