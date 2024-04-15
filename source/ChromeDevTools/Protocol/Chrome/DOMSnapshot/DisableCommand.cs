namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	/// Disables DOM snapshot agent for the given page.
	/// </summary>
	[Command(ProtocolName.DOMSnapshot.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
