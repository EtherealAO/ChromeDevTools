using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Returns all browser cookies.
	/// </summary>
	[Command(ProtocolName.Storage.GetCookies)]
	[SupportedBy("Chrome")]
	public class GetCookiesCommand: ICommand<GetCookiesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Browser context to use when called on the browser endpoint.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
