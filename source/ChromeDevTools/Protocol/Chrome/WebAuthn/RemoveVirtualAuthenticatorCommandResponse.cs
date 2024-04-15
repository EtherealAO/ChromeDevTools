namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Removes the given authenticator.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.RemoveVirtualAuthenticator)]
	[SupportedBy("Chrome")]
	public class RemoveVirtualAuthenticatorCommandResponse
	{
	}
}
