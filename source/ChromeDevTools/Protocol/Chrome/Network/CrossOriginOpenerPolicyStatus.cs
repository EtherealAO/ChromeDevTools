using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	[SupportedBy("Chrome")]
	public class CrossOriginOpenerPolicyStatus
	{
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		public CrossOriginOpenerPolicyValue Value { get; set; }
		/// <summary>
		/// Gets or sets ReportOnlyValue
		/// </summary>
		public CrossOriginOpenerPolicyValue ReportOnlyValue { get; set; }
		/// <summary>
		/// Gets or sets ReportingEndpoint
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ReportingEndpoint { get; set; }
		/// <summary>
		/// Gets or sets ReportOnlyReportingEndpoint
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ReportOnlyReportingEndpoint { get; set; }
	}
}
