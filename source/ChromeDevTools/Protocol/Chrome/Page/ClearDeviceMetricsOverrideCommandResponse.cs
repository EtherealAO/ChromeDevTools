using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Clears the overridden device metrics.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Page.ClearDeviceMetricsOverride)]
	[SupportedBy("Chrome")]
	public class ClearDeviceMetricsOverrideCommandResponse
	{
	}
}
