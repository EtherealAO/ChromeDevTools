namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns the root DOM node (and optionally the subtree) to the caller.
	/// Implicitly enables the DOM domain events for the current target.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetDocument)]
	[SupportedBy("Chrome")]
	public class GetDocumentCommandResponse
	{
		/// <summary>
		/// Gets or sets Resulting node.
		/// </summary>
		public Node Root { get; set; }
	}
}
