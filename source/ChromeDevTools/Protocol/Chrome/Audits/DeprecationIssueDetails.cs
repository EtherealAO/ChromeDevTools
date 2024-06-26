using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// This issue tracks information needed to print a deprecation message.
	/// https://source.chromium.org/chromium/chromium/src/+/main:third_party/blink/renderer/core/frame/third_party/blink/renderer/core/frame/deprecation/README.md
	/// </summary>
	[SupportedBy("Chrome")]
	public class DeprecationIssueDetails
	{
		/// <summary>
		/// Gets or sets AffectedFrame
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AffectedFrame AffectedFrame { get; set; }
		/// <summary>
		/// Gets or sets SourceCodeLocation
		/// </summary>
		public SourceCodeLocation SourceCodeLocation { get; set; }
		/// <summary>
		/// Gets or sets One of the deprecation names from third_party/blink/renderer/core/frame/deprecation/deprecation.json5
		/// </summary>
		public string Type { get; set; }
	}
}
