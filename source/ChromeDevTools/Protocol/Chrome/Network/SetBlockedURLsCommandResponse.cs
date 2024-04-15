namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Blocks URLs from loading.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetBlockedURLs)]
	[SupportedBy("Chrome")]
	public class SetBlockedURLsCommandResponse
	{
	}
}
