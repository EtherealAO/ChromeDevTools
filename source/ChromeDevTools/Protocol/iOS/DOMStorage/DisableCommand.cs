namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMStorage
{
	/// <summary>
	/// Disables storage tracking, prevents storage events from being sent to the client.
	/// </summary>
	[Command(ProtocolName.DOMStorage.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
