namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Disable the WebAuthn domain.
	/// </summary>
	[Command(ProtocolName.WebAuthn.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
