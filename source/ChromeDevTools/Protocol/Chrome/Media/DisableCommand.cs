namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Media
{
	/// <summary>
	/// Disables the Media domain.
	/// </summary>
	[Command(ProtocolName.Media.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
