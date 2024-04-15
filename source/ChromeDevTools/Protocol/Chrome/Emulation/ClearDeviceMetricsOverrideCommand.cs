namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Clears the overridden device metrics.
	/// </summary>
	[Command(ProtocolName.Emulation.ClearDeviceMetricsOverride)]
	[SupportedBy("Chrome")]
	public class ClearDeviceMetricsOverrideCommand: ICommand<ClearDeviceMetricsOverrideCommandResponse>
	{
	}
}
