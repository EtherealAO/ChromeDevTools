using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Clears the overridden Device Orientation.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Page.ClearDeviceOrientationOverride)]
	[SupportedBy("Chrome")]
	public class ClearDeviceOrientationOverrideCommandResponse
	{
	}
}
