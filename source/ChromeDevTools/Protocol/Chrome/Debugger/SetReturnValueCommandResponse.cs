namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Changes return value in top frame. Available only at return break position.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetReturnValue)]
	[SupportedBy("Chrome")]
	public class SetReturnValueCommandResponse
	{
	}
}
