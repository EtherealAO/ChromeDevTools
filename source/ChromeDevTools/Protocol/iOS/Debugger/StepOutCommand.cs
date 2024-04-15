namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Steps out of the function call.
	/// </summary>
	[Command(ProtocolName.Debugger.StepOut)]
	[SupportedBy("iOS")]
	public class StepOutCommand: ICommand<StepOutCommandResponse>
	{
	}
}
