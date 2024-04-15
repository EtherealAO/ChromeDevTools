namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint from XMLHttpRequest.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.RemoveXHRBreakpoint)]
	[SupportedBy("iOS")]
	public class RemoveXHRBreakpointCommand: ICommand<RemoveXHRBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or sets Resource URL substring.
		/// </summary>
		public string Url { get; set; }
	}
}
