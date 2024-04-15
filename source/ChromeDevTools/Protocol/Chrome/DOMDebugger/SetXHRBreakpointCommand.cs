namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on XMLHttpRequest.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetXHRBreakpoint)]
	[SupportedBy("Chrome")]
	public class SetXHRBreakpointCommand: ICommand<SetXHRBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or sets Resource URL substring. All XHRs having this substring in the URL will get stopped upon.
		/// </summary>
		public string Url { get; set; }
	}
}
