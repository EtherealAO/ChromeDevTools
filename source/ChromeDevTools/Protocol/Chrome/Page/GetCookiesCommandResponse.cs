using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns all browser cookies for the page and all of its subframes. Depending
	/// on the backend support, will return detailed cookie information in the
	/// `cookies` field.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Page.GetCookies)]
	[SupportedBy("Chrome")]
	public class GetCookiesCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of cookie objects.
		/// </summary>
		public Network.Cookie[] Cookies { get; set; }
	}
}
