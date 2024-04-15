namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Enable/disable suppressing memory pressure notifications in all processes.
	/// </summary>
	[CommandResponse(ProtocolName.Memory.SetPressureNotificationsSuppressed)]
	[SupportedBy("Chrome")]
	public class SetPressureNotificationsSuppressedCommandResponse
	{
	}
}
