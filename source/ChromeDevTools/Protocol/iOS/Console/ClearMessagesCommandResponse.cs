namespace MasterDevs.ChromeDevTools.Protocol.iOS.Console
{
	/// <summary>
	/// Clears console messages collected in the browser.
	/// </summary>
	[CommandResponse(ProtocolName.Console.ClearMessages)]
	[SupportedBy("iOS")]
	public class ClearMessagesCommandResponse
	{
	}
}
