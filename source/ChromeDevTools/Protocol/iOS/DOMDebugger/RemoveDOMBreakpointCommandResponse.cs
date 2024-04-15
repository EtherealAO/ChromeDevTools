namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMDebugger
{
	/// <summary>
	/// Removes DOM breakpoint that was set using <code>setDOMBreakpoint</code>.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.RemoveDOMBreakpoint)]
	[SupportedBy("iOS")]
	public class RemoveDOMBreakpointCommandResponse
	{
	}
}
