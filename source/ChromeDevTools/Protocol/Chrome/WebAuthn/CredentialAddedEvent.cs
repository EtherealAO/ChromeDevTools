namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Triggered when a credential is added to an authenticator.
	/// </summary>
	[Event(ProtocolName.WebAuthn.CredentialAdded)]
	[SupportedBy("Chrome")]
	public class CredentialAddedEvent
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
