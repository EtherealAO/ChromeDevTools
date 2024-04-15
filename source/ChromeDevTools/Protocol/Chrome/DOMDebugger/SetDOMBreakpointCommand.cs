namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular operation with DOM.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetDOMBreakpoint)]
	[SupportedBy("Chrome")]
	public class SetDOMBreakpointCommand: ICommand<SetDOMBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the node to set breakpoint on.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Type of the operation to stop upon.
		/// </summary>
		public string Type { get; set; }
	}
}
