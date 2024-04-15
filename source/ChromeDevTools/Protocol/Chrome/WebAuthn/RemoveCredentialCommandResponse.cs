namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Removes a credential from the authenticator.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.RemoveCredential)]
	[SupportedBy("Chrome")]
	public class RemoveCredentialCommandResponse
	{
	}
}
