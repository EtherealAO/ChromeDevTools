namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Enable the WebAuthn domain and start intercepting credential storage and
	/// retrieval with a virtual authenticator.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
