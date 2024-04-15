using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Clears the overridden device metrics.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Page.ClearDeviceMetricsOverride)]
	[SupportedBy("Chrome")]
	public class ClearDeviceMetricsOverrideCommand: ICommand<ClearDeviceMetricsOverrideCommandResponse>
	{
	}
}
