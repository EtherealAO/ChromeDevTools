namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular native event.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetInstrumentationBreakpoint)]
	[SupportedBy("Chrome")]
	public class SetInstrumentationBreakpointCommand: ICommand<SetInstrumentationBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or sets Instrumentation name to stop on.
		/// </summary>
		public string EventName { get; set; }
	}
}
