namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Stops on the next JavaScript statement.
	/// </summary>
	[Command(ProtocolName.Debugger.Pause)]
	[SupportedBy("Chrome")]
	public class PauseCommand: ICommand<PauseCommandResponse>
	{
	}
}
