namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Triggered when a credential is used in a webauthn assertion.
	/// </summary>
	[Event(ProtocolName.WebAuthn.CredentialAsserted)]
	[SupportedBy("Chrome")]
	public class CredentialAssertedEvent
	{
		/// <summary>
		/// Gets or sets AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
		/// <summary>
		/// Gets or sets Credential
		/// </summary>
		public Credential Credential { get; set; }
	}
}
