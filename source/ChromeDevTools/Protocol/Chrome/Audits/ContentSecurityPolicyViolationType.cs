using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContentSecurityPolicyViolationType
	{
			KInlineViolation,
			KEvalViolation,
			KURLViolation,
			KTrustedTypesSinkViolation,
			KTrustedTypesPolicyViolation,
			KWasmEvalViolation,
	}
}
