namespace MasterDevs.ChromeDevTools.Protocol.iOS.Inspector
{
	/// <summary>
	/// Fired when debugging target has crashed
	/// </summary>
	[Event(ProtocolName.Inspector.TargetCrashed)]
	[SupportedBy("iOS")]
	public class TargetCrashedEvent
	{
	}
}
