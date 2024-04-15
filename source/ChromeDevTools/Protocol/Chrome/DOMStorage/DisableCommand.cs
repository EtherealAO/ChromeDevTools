namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	/// <summary>
	/// Disables storage tracking, prevents storage events from being sent to the client.
	/// </summary>
	[Command(ProtocolName.DOMStorage.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
