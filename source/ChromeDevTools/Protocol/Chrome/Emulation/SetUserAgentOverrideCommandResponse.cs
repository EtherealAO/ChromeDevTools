namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Allows overriding user agent with the given string.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetUserAgentOverride)]
	[SupportedBy("Chrome")]
	public class SetUserAgentOverrideCommandResponse
	{
	}
}
