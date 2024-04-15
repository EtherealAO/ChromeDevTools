namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// Disables the accessibility domain.
	/// </summary>
	[Command(ProtocolName.Accessibility.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
