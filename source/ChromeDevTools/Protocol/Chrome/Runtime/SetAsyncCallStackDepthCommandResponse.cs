namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Enables or disables async call stacks tracking.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.SetAsyncCallStackDepth)]
	[SupportedBy("Chrome")]
	public class SetAsyncCallStackDepthCommandResponse
	{
	}
}
