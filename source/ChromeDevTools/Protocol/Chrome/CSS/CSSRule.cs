using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// CSS rule representation.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSRule
	{
		/// <summary>
		/// Gets or sets The css style sheet identifier (absent for user agent stylesheet and user-specified
		/// stylesheet rules) this rule came from.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Rule selector data.
		/// </summary>
		public SelectorList SelectorList { get; set; }
		/// <summary>
		/// Gets or sets Array of selectors from ancestor style rules, sorted by distance from the current rule.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] NestingSelectors { get; set; }
		/// <summary>
		/// Gets or sets Parent stylesheet's origin.
		/// </summary>
		public StyleSheetOrigin Origin { get; set; }
		/// <summary>
		/// Gets or sets Associated style declaration.
		/// </summary>
		public CSSStyle Style { get; set; }
		/// <summary>
		/// Gets or sets Media list array (for rules involving media queries). The array enumerates media queries
		/// starting with the innermost one, going outwards.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSMedia[] Media { get; set; }
		/// <summary>
		/// Gets or sets Container query list array (for rules involving container queries).
		/// The array enumerates container queries starting with the innermost one, going outwards.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSContainerQuery[] ContainerQueries { get; set; }
		/// <summary>
		/// Gets or sets @supports CSS at-rule array.
		/// The array enumerates @supports at-rules starting with the innermost one, going outwards.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSSupports[] Supports { get; set; }
		/// <summary>
		/// Gets or sets Cascade layer array. Contains the layer hierarchy that this rule belongs to starting
		/// with the innermost layer and going outwards.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSLayer[] Layers { get; set; }
		/// <summary>
		/// Gets or sets @scope CSS at-rule array.
		/// The array enumerates @scope at-rules starting with the innermost one, going outwards.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSScope[] Scopes { get; set; }
	}
}
