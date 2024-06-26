using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	[Command(ProtocolName.FedCm.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
		/// <summary>
		/// Gets or sets Allows callers to disable the promise rejection delay that would
		/// normally happen, if this is unimportant to what's being tested.
		/// (step 4 of https://fedidcg.github.io/FedCM/#browser-api-rp-sign-in)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? DisableRejectionDelay { get; set; }
	}
}
