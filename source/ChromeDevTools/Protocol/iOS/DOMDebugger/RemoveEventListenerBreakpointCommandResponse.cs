namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular DOM event.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.RemoveEventListenerBreakpoint)]
	[SupportedBy("iOS")]
	public class RemoveEventListenerBreakpointCommandResponse
	{
	}
}
