namespace MasterDevs.ChromeDevTools.Protocol.Chrome.PerformanceTimeline
{
	/// <summary>
	/// Previously buffered events would be reported before method returns.
	/// See also: timelineEventAdded
	/// </summary>
	[CommandResponse(ProtocolName.PerformanceTimeline.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
