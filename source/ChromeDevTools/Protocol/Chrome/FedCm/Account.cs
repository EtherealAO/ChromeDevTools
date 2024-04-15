using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	/// <summary>
	/// Corresponds to IdentityRequestAccount
	/// </summary>
	[SupportedBy("Chrome")]
	public class Account
	{
		/// <summary>
		/// Gets or sets AccountId
		/// </summary>
		public string AccountId { get; set; }
		/// <summary>
		/// Gets or sets Email
		/// </summary>
		public string Email { get; set; }
		/// <summary>
		/// Gets or sets Name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets GivenName
		/// </summary>
		public string GivenName { get; set; }
		/// <summary>
		/// Gets or sets PictureUrl
		/// </summary>
		public string PictureUrl { get; set; }
		/// <summary>
		/// Gets or sets IdpConfigUrl
		/// </summary>
		public string IdpConfigUrl { get; set; }
		/// <summary>
		/// Gets or sets IdpSigninUrl
		/// </summary>
		public string IdpSigninUrl { get; set; }
		/// <summary>
		/// Gets or sets LoginState
		/// </summary>
		public LoginState LoginState { get; set; }
		/// <summary>
		/// Gets or sets These two are only set if the loginState is signUp
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TermsOfServiceUrl { get; set; }
		/// <summary>
		/// Gets or sets PrivacyPolicyUrl
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PrivacyPolicyUrl { get; set; }
	}
}
