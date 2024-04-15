namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// Stops the active Cast session on the sink.
	/// </summary>
	[CommandResponse(ProtocolName.Cast.StopCasting)]
	[SupportedBy("Chrome")]
	public class StopCastingCommandResponse
	{
	}
}
