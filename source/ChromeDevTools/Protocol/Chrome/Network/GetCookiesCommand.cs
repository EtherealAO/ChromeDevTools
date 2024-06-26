using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Returns all browser cookies for the current URL. Depending on the backend support, will return
	/// detailed cookie information in the `cookies` field.
	/// </summary>
	[Command(ProtocolName.Network.GetCookies)]
	[SupportedBy("Chrome")]
	public class GetCookiesCommand: ICommand<GetCookiesCommandResponse>
	{
		/// <summary>
		/// Gets or sets The list of URLs for which applicable cookies will be fetched.
		/// If not specified, it's assumed to be set to the list containing
		/// the URLs of the page and all of its subframes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Urls { get; set; }
	}
}
