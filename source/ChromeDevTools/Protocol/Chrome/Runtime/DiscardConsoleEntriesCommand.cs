namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Discards collected exceptions and console API calls.
	/// </summary>
	[Command(ProtocolName.Runtime.DiscardConsoleEntries)]
	[SupportedBy("Chrome")]
	public class DiscardConsoleEntriesCommand: ICommand<DiscardConsoleEntriesCommandResponse>
	{
	}
}
