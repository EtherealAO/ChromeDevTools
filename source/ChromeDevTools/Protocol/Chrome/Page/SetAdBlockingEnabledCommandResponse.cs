namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Enable Chrome's experimental ad filter on all sites.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetAdBlockingEnabled)]
	[SupportedBy("Chrome")]
	public class SetAdBlockingEnabledCommandResponse
	{
	}
}
