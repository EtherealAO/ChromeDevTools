namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Controls whether to discover available targets and notify via
	/// `targetCreated/targetInfoChanged/targetDestroyed` events.
	/// </summary>
	[CommandResponse(ProtocolName.Target.SetDiscoverTargets)]
	[SupportedBy("Chrome")]
	public class SetDiscoverTargetsCommandResponse
	{
	}
}
