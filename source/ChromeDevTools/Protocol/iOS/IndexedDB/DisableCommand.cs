namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	/// Disables events from backend.
	/// </summary>
	[Command(ProtocolName.IndexedDB.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
