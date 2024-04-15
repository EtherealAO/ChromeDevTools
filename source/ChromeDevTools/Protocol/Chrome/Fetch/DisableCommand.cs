namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Disables the fetch domain.
	/// </summary>
	[Command(ProtocolName.Fetch.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
