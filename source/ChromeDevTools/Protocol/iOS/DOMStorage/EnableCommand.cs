namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMStorage
{
	/// <summary>
	/// Enables storage tracking, storage events will now be delivered to the client.
	/// </summary>
	[Command(ProtocolName.DOMStorage.Enable)]
	[SupportedBy("iOS")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
