namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Activates / deactivates all breakpoints on the page.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetBreakpointsActive)]
	[SupportedBy("iOS")]
	public class SetBreakpointsActiveCommandResponse
	{
	}
}
