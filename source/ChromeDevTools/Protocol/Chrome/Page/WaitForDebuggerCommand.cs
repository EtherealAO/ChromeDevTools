namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Pauses page execution. Can be resumed using generic Runtime.runIfWaitingForDebugger.
	/// </summary>
	[Command(ProtocolName.Page.WaitForDebugger)]
	[SupportedBy("Chrome")]
	public class WaitForDebuggerCommand: ICommand<WaitForDebuggerCommandResponse>
	{
	}
}
