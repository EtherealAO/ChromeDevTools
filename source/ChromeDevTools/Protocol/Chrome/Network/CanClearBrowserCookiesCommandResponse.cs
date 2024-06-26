using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Tells whether clearing browser cookies is supported.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Network.CanClearBrowserCookies)]
	[SupportedBy("Chrome")]
	public class CanClearBrowserCookiesCommandResponse
	{
		/// <summary>
		/// Gets or sets True if browser cookies can be cleared.
		/// </summary>
		public bool Result { get; set; }
	}
}
