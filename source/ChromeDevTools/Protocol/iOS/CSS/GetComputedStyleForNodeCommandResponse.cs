namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Returns the computed style for a DOM node identified by <code>nodeId</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetComputedStyleForNode)]
	[SupportedBy("iOS")]
	public class GetComputedStyleForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Computed style for the specified DOM node.
		/// </summary>
		public CSSComputedStyleProperty[] ComputedStyle { get; set; }
	}
}
