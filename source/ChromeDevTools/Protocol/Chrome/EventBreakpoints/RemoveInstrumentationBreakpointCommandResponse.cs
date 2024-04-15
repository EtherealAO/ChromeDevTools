namespace MasterDevs.ChromeDevTools.Protocol.Chrome.EventBreakpoints
{
	/// <summary>
	/// Removes breakpoint on particular native event.
	/// </summary>
	[CommandResponse(ProtocolName.EventBreakpoints.RemoveInstrumentationBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveInstrumentationBreakpointCommandResponse
	{
	}
}
