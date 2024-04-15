namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Steps out of the function call.
	/// </summary>
	[Command(ProtocolName.Debugger.StepOut)]
	[SupportedBy("Chrome")]
	public class StepOutCommand: ICommand<StepOutCommandResponse>
	{
	}
}
