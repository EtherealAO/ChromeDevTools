namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular operation with DOM.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetDOMBreakpoint)]
	[SupportedBy("iOS")]
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
