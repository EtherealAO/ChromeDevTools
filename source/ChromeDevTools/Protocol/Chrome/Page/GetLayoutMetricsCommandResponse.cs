namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns metrics relating to the layouting of the page, such as viewport bounds/scale.
	/// </summary>
	[CommandResponse(ProtocolName.Page.GetLayoutMetrics)]
	[SupportedBy("Chrome")]
	public class GetLayoutMetricsCommandResponse
	{
		/// <summary>
		/// Gets or sets Deprecated metrics relating to the layout viewport. Is in device pixels. Use `cssLayoutViewport` instead.
		/// </summary>
		public LayoutViewport LayoutViewport { get; set; }
		/// <summary>
		/// Gets or sets Deprecated metrics relating to the visual viewport. Is in device pixels. Use `cssVisualViewport` instead.
		/// </summary>
		public VisualViewport VisualViewport { get; set; }
		/// <summary>
		/// Gets or sets Deprecated size of scrollable area. Is in DP. Use `cssContentSize` instead.
		/// </summary>
		public DOM.Rect ContentSize { get; set; }
		/// <summary>
		/// Gets or sets Metrics relating to the layout viewport in CSS pixels.
		/// </summary>
		public LayoutViewport CssLayoutViewport { get; set; }
		/// <summary>
		/// Gets or sets Metrics relating to the visual viewport in CSS pixels.
		/// </summary>
		public VisualViewport CssVisualViewport { get; set; }
		/// <summary>
		/// Gets or sets Size of scrollable area in CSS pixels.
		/// </summary>
		public DOM.Rect CssContentSize { get; set; }
	}
}
