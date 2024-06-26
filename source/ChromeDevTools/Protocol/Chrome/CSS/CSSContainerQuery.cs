using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// CSS container query rule descriptor.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSContainerQuery
	{
		/// <summary>
		/// Gets or sets Container query text.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets The associated rule header range in the enclosing stylesheet (if
		/// available).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the stylesheet containing this object (if exists).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Optional name for the container.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Optional physical axes queried for the container.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.PhysicalAxes PhysicalAxes { get; set; }
		/// <summary>
		/// Gets or sets Optional logical axes queried for the container.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.LogicalAxes LogicalAxes { get; set; }
	}
}
