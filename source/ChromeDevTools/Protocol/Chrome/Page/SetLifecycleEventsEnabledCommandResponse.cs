namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Controls whether page will emit lifecycle events.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetLifecycleEventsEnabled)]
	[SupportedBy("Chrome")]
	public class SetLifecycleEventsEnabledCommandResponse
	{
	}
}
