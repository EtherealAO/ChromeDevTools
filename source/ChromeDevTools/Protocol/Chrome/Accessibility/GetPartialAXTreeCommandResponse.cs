namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// Fetches the accessibility node and partial accessibility tree for this DOM node, if it exists.
	/// </summary>
	[CommandResponse(ProtocolName.Accessibility.GetPartialAXTree)]
	[SupportedBy("Chrome")]
	public class GetPartialAXTreeCommandResponse
	{
		/// <summary>
		/// Gets or sets The `Accessibility.AXNode` for this DOM node, if it exists, plus its ancestors, siblings and
		/// children, if requested.
		/// </summary>
		public AXNode[] Nodes { get; set; }
	}
}
