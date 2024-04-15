namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	/// Enables DOM snapshot agent for the given page.
	/// </summary>
	[Command(ProtocolName.DOMSnapshot.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
