using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Resets parameters isBogusSignature, isBadUV, isBadUP to false if they are not present.
	/// </summary>
	[Command(ProtocolName.WebAuthn.SetResponseOverrideBits)]
	[SupportedBy("Chrome")]
	public class SetResponseOverrideBitsCommand: ICommand<SetResponseOverrideBitsCommandResponse>
	{
		/// <summary>
		/// Gets or sets AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
		/// <summary>
		/// Gets or sets If isBogusSignature is set, overrides the signature in the authenticator response to be zero.
		/// Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsBogusSignature { get; set; }
		/// <summary>
		/// Gets or sets If isBadUV is set, overrides the UV bit in the flags in the authenticator response to
		/// be zero. Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsBadUV { get; set; }
		/// <summary>
		/// Gets or sets If isBadUP is set, overrides the UP bit in the flags in the authenticator response to
		/// be zero. Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsBadUP { get; set; }
	}
}
