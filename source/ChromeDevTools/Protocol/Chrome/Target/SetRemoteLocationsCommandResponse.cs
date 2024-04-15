namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Enables target discovery for the specified locations, when `setDiscoverTargets` was set to
	/// `true`.
	/// </summary>
	[CommandResponse(ProtocolName.Target.SetRemoteLocations)]
	[SupportedBy("Chrome")]
	public class SetRemoteLocationsCommandResponse
	{
	}
}
