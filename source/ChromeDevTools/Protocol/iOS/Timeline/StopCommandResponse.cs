namespace MasterDevs.ChromeDevTools.Protocol.iOS.Timeline
{
	/// <summary>
	/// Stops capturing instrumentation events.
	/// </summary>
	[CommandResponse(ProtocolName.Timeline.Stop)]
	[SupportedBy("iOS")]
	public class StopCommandResponse
	{
	}
}
