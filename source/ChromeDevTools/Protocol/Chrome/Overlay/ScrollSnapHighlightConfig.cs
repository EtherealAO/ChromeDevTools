namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[SupportedBy("Chrome")]
	public class ScrollSnapHighlightConfig
	{
		/// <summary>
		/// Gets or sets A descriptor for the highlight appearance of scroll snap containers.
		/// </summary>
		public ScrollSnapContainerHighlightConfig ScrollSnapContainerHighlightConfig { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the node to highlight.
		/// </summary>
		public long NodeId { get; set; }
	}
}
