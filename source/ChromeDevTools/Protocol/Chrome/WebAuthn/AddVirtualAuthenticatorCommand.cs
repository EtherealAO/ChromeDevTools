namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Creates and adds a virtual authenticator.
	/// </summary>
	[Command(ProtocolName.WebAuthn.AddVirtualAuthenticator)]
	[SupportedBy("Chrome")]
	public class AddVirtualAuthenticatorCommand: ICommand<AddVirtualAuthenticatorCommandResponse>
	{
		/// <summary>
		/// Gets or sets Options
		/// </summary>
		public VirtualAuthenticatorOptions Options { get; set; }
	}
}
