using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// This struct holds a list of optional fields with additional information
	/// specific to the kind of issue. When adding a new issue code, please also
	/// add a new optional field to this type.
	/// </summary>
	[SupportedBy("Chrome")]
	public class InspectorIssueDetails
	{
		/// <summary>
		/// Gets or sets CookieIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CookieIssueDetails CookieIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets MixedContentIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public MixedContentIssueDetails MixedContentIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets BlockedByResponseIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BlockedByResponseIssueDetails BlockedByResponseIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets HeavyAdIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public HeavyAdIssueDetails HeavyAdIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets ContentSecurityPolicyIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ContentSecurityPolicyIssueDetails ContentSecurityPolicyIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets SharedArrayBufferIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SharedArrayBufferIssueDetails SharedArrayBufferIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets TwaQualityEnforcementDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public TrustedWebActivityIssueDetails TwaQualityEnforcementDetails { get; set; }
		/// <summary>
		/// Gets or sets LowTextContrastIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LowTextContrastIssueDetails LowTextContrastIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets CorsIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CorsIssueDetails CorsIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets AttributionReportingIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AttributionReportingIssueDetails AttributionReportingIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets QuirksModeIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public QuirksModeIssueDetails QuirksModeIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets NavigatorUserAgentIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public NavigatorUserAgentIssueDetails NavigatorUserAgentIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets GenericIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public GenericIssueDetails GenericIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets DeprecationIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DeprecationIssueDetails DeprecationIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets ClientHintIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ClientHintIssueDetails ClientHintIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets FederatedAuthRequestIssueDetails
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FederatedAuthRequestIssueDetails FederatedAuthRequestIssueDetails { get; set; }
	}
}
