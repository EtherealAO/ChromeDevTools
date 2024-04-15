namespace MasterDevs.ChromeDevTools.Protocol.iOS.Console
{
	/// <summary>
	/// Clears console messages collected in the browser.
	/// </summary>
	[Command(ProtocolName.Console.ClearMessages)]
	[SupportedBy("iOS")]
	public class ClearMessagesCommand: ICommand<ClearMessagesCommandResponse>
	{
	}
}
