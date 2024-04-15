namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Sets instrumentation breakpoint.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetInstrumentationBreakpoint)]
	[SupportedBy("Chrome")]
	public class SetInstrumentationBreakpointCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the created breakpoint for further reference.
		/// </summary>
		public string BreakpointId { get; set; }
	}
}
