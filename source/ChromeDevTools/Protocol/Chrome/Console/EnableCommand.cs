namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Console
{
	/// <summary>
	/// Enables console domain, sends the messages collected so far to the client by means of the
	/// `messageAdded` notification.
	/// </summary>
	[Command(ProtocolName.Console.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
