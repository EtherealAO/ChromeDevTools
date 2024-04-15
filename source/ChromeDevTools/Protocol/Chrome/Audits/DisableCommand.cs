namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// Disables issues domain, prevents further issues from being reported to the client.
	/// </summary>
	[Command(ProtocolName.Audits.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
