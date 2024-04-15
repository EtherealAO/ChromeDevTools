namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Console
{
	/// <summary>
	/// Does nothing.
	/// </summary>
	[Command(ProtocolName.Console.ClearMessages)]
	[SupportedBy("Chrome")]
	public class ClearMessagesCommand: ICommand<ClearMessagesCommandResponse>
	{
	}
}
