namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Clears browser cookies.
	/// </summary>
	[Command(ProtocolName.Network.ClearBrowserCookies)]
	[SupportedBy("Chrome")]
	public class ClearBrowserCookiesCommand: ICommand<ClearBrowserCookiesCommandResponse>
	{
	}
}
