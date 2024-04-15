namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	/// Clears the log.
	/// </summary>
	[Command(ProtocolName.Log.Clear)]
	[SupportedBy("Chrome")]
	public class ClearCommand: ICommand<ClearCommandResponse>
	{
	}
}
