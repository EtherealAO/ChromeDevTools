namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Tells whether clearing browser cookies is supported.
	/// </summary>
	[Command(ProtocolName.Network.CanClearBrowserCookies)]
	[SupportedBy("iOS")]
	public class CanClearBrowserCookiesCommand: ICommand<CanClearBrowserCookiesCommandResponse>
	{
	}
}
