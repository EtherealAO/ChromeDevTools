namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Activates / deactivates all breakpoints on the page.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetBreakpointsActive)]
	[SupportedBy("Chrome")]
	public class SetBreakpointsActiveCommandResponse
	{
	}
}
