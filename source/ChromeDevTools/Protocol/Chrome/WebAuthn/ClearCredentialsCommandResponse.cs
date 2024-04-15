namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Clears all the credentials from the specified device.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.ClearCredentials)]
	[SupportedBy("Chrome")]
	public class ClearCredentialsCommandResponse
	{
	}
}
