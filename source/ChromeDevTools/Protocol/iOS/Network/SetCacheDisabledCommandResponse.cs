namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Toggles ignoring cache for each request. If <code>true</code>, cache will not be used.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetCacheDisabled)]
	[SupportedBy("iOS")]
	public class SetCacheDisabledCommandResponse
	{
	}
}
