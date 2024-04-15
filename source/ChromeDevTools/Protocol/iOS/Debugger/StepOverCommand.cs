namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Steps over the statement.
	/// </summary>
	[Command(ProtocolName.Debugger.StepOver)]
	[SupportedBy("iOS")]
	public class StepOverCommand: ICommand<StepOverCommandResponse>
	{
	}
}
