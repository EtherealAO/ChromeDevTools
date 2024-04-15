namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular DOM event.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.RemoveEventListenerBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveEventListenerBreakpointCommandResponse
	{
	}
}
