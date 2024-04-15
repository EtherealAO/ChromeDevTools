namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DeviceOrientation
{
	/// <summary>
	/// Clears the overridden Device Orientation.
	/// </summary>
	[Command(ProtocolName.DeviceOrientation.ClearDeviceOrientationOverride)]
	[SupportedBy("Chrome")]
	public class ClearDeviceOrientationOverrideCommand: ICommand<ClearDeviceOrientationOverrideCommandResponse>
	{
	}
}
