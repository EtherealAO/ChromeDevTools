using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits{
	/// <summary>
	/// A unique identifier for the type of issue. Each type may use one of the
	/// optional fields in InspectorIssueDetails to convey more specific
	/// information about the kind of issue.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InspectorIssueCode
	{
			CookieIssue,
			MixedContentIssue,
			BlockedByResponseIssue,
			HeavyAdIssue,
			ContentSecurityPolicyIssue,
			SharedArrayBufferIssue,
			TrustedWebActivityIssue,
			LowTextContrastIssue,
			CorsIssue,
			AttributionReportingIssue,
			QuirksModeIssue,
			NavigatorUserAgentIssue,
			GenericIssue,
			DeprecationIssue,
			ClientHintIssue,
			FederatedAuthRequestIssue,
	}
}
