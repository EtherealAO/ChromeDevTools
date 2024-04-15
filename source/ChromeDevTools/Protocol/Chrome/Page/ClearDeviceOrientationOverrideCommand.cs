using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Clears the overridden Device Orientation.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Page.ClearDeviceOrientationOverride)]
	[SupportedBy("Chrome")]
	public class ClearDeviceOrientationOverrideCommand: ICommand<ClearDeviceOrientationOverrideCommandResponse>
	{
	}
}
