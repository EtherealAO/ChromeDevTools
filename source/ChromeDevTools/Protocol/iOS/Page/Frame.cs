using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Information about the Frame on the page.
	/// </summary>
	[SupportedBy("iOS")]
	public class Frame
	{
		/// <summary>
		/// Gets or sets Frame unique identifier.
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Parent frame identifier.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ParentId { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the loader associated with this frame.
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets Frame's name as specified in the tag.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Frame document's URL.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Frame document's security origin.
		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets Frame document's mimeType as determined by the browser.
		/// </summary>
		public string MimeType { get; set; }
	}
}
