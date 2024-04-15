namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Detaches session with given id.
	/// </summary>
	[CommandResponse(ProtocolName.Target.DetachFromTarget)]
	[SupportedBy("Chrome")]
	public class DetachFromTargetCommandResponse
	{
	}
}
