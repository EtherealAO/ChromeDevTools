using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Overrides the values of device screen dimensions (window.screen.width, window.screen.height,
	/// window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media
	/// query results).
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Page.SetDeviceMetricsOverride)]
	[SupportedBy("Chrome")]
	public class SetDeviceMetricsOverrideCommandResponse
	{
	}
}
