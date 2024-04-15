namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Inspector
{
	/// <summary>
	/// Disables inspector domain notifications.
	/// </summary>
	[Command(ProtocolName.Inspector.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
