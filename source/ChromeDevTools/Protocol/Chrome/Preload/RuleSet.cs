using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	/// Corresponds to SpeculationRuleSet
	/// </summary>
	[SupportedBy("Chrome")]
	public class RuleSet
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Identifies a document which the rule set is associated with.
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets Source text of JSON representing the rule set. If it comes from
		/// <script> tag, it is the textContent of the node. Note that it is
		/// a JSON for valid case.
		/// 
		/// See also:
		/// - https://wicg.github.io/nav-speculation/speculation-rules.html
		/// - https://github.com/WICG/nav-speculation/blob/main/triggers.md
		/// </summary>
		public string SourceText { get; set; }
		/// <summary>
		/// Gets or sets Error information
		/// `errorMessage` is null iff `errorType` is null.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RuleSetErrorType ErrorType { get; set; }
		/// <summary>
		/// Gets or sets TODO(https://crbug.com/1425354): Replace this property with structured error.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ErrorMessage { get; set; }
	}
}
