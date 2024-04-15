namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Releases remote object with given id.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.ReleaseObject)]
	[SupportedBy("Chrome")]
	public class ReleaseObjectCommandResponse
	{
	}
}
