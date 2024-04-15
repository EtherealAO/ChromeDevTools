namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Removes DOM breakpoint that was set using `setDOMBreakpoint`.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.RemoveDOMBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveDOMBreakpointCommandResponse
	{
	}
}
