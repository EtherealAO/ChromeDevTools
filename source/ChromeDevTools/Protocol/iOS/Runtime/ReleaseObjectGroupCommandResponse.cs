namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Releases all remote objects that belong to a given group.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.ReleaseObjectGroup)]
	[SupportedBy("iOS")]
	public class ReleaseObjectGroupCommandResponse
	{
	}
}
