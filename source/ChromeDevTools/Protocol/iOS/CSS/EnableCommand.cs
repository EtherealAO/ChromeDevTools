namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Enables the CSS agent for the given page. Clients should not assume that the CSS agent has been enabled until the result of this command is received.
	/// </summary>
	[Command(ProtocolName.CSS.Enable)]
	[SupportedBy("iOS")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
