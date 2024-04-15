namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Enables network tracking, network events will now be delivered to the client.
	/// </summary>
	[Command(ProtocolName.Network.Enable)]
	[SupportedBy("iOS")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
