namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DeviceAccess
{
	/// <summary>
	/// Disable events in this domain.
	/// </summary>
	[Command(ProtocolName.DeviceAccess.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
