using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AttributionReportingIssueType
	{
			PermissionPolicyDisabled,
			UntrustworthyReportingOrigin,
			InsecureContext,
			InvalidHeader,
			InvalidRegisterTriggerHeader,
			InvalidEligibleHeader,
			TooManyConcurrentRequests,
			SourceAndTriggerHeaders,
			SourceIgnored,
			TriggerIgnored,
			OsSourceIgnored,
			OsTriggerIgnored,
			InvalidRegisterOsSourceHeader,
			InvalidRegisterOsTriggerHeader,
			WebAndOsHeaders,
	}
}
