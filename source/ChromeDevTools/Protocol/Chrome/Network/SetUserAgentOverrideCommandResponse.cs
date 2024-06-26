namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Allows overriding user agent with the given string.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetUserAgentOverride)]
	[SupportedBy("Chrome")]
	public class SetUserAgentOverrideCommandResponse
	{
	}
}
