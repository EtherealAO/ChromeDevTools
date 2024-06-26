namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Disables network tracking, prevents network events from being sent to the client.
	/// </summary>
	[Command(ProtocolName.Network.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
