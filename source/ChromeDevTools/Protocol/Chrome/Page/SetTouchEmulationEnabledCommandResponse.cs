using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Toggles mouse event-based touch event emulation.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Page.SetTouchEmulationEnabled)]
	[SupportedBy("Chrome")]
	public class SetTouchEmulationEnabledCommandResponse
	{
	}
}
