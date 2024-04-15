namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Sets whether User Verification succeeds or fails for an authenticator.
	/// The default is true.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.SetUserVerified)]
	[SupportedBy("Chrome")]
	public class SetUserVerifiedCommandResponse
	{
	}
}
