namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	/// Disables log domain, prevents further log entries from being reported to the client.
	/// </summary>
	[Command(ProtocolName.Log.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
